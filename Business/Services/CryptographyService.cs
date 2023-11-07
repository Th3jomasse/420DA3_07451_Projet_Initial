using _420DA3_07451_Projet_Initial.Business.Abstracts;
using System.Security.Cryptography;

namespace _420DA3_07451_Projet_Initial.Business.Services;

/// <summary>
/// Service cryptographique pour le hashage et la validation de mots de passe.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractService"/>.
/// </remarks>
internal class CryptographyService : AbstractService {
    // Paramètres de hashage.
    private const int SALT_SIZE = 16; // sel cryptographique de 128 bits
    private const int KEY_SIZE = 32; // clé cryptographique de 256 bits
    private const int CRYPT_ITERATIONS = 100000; // itérations de l'étirement de clé
    private const char SEGMENT_DELIMITER = ':'; // séparateur des sections générées - NE PAS CHANGER (sinon hashs existants invalidables)
    private static readonly HashAlgorithmName CRYPT_ALGORITHM = HashAlgorithmName.SHA256; // algorithme de base


    public CryptographyService(AbstractApplication app) {
        app.RegisterDependent(this);
    }

    public override void Shutdown() {
        // rien à faire dans ce service
    }

    /// <summary>
    /// Fonction de hachage de mot de passe.
    /// </summary>
    /// <remarks>
    /// Recoit le mot de passe en clair, non-encrypté, dans <paramref name="motDePasseNonEncrypte"/>.
    /// Retourne le mot de passe hashé sous forme de <see cref="string"/>.
    /// </remarks>
    /// <param name="motDePasseNonEncrypte">Le mot de passe en clair, non-encrypté.</param>
    /// <returns></returns>
    public static string HashPassword(string motDePasseNonEncrypte) {
        byte[] salt = RandomNumberGenerator.GetBytes(SALT_SIZE);
        byte[] key = Rfc2898DeriveBytes.Pbkdf2(
            motDePasseNonEncrypte,
            salt,
            CRYPT_ITERATIONS,
            CRYPT_ALGORITHM,
            KEY_SIZE
        );
        return string.Join(
            SEGMENT_DELIMITER,
            Convert.ToHexString(key),
            Convert.ToHexString(salt),
            CRYPT_ITERATIONS,
            CRYPT_ALGORITHM
        );
    }

    /// <summary>
    /// Fonction de validation de mots de passe.
    /// </summary>
    /// <remarks>
    /// Recoit le mot de passe en clair, non-encrypté, dans <paramref name="motDePasseNonEncrypte"/> tel qu'entré
    /// dans la fenêtre d'authentification (login) par l'utilisateur.<br/>
    /// Recoit le hash du mot de passe de l'utilisateur dans <paramref name="motDePasseNonEncrypte"/> tel que 
    /// trouvé pour l'utilisateur correspondant dans la base de données.<br/>
    /// Retourne <see langword="true"/> si le mot de passe en clair concorde (est valide), <see langword="false"/> sinon.
    /// </remarks>
    /// <param name="motDePasseNonEncrypte"></param>
    /// <param name="hashDuMotDePasseDansLaBdD"></param>
    /// <returns>True si le mot de passe est valide.</returns>
    public static bool VerifyPassword(string motDePasseNonEncrypte, string hashDuMotDePasseDansLaBdD) {
        string[] segments = hashDuMotDePasseDansLaBdD.Split(SEGMENT_DELIMITER);
        byte[] key = Convert.FromHexString(segments[0]);
        byte[] salt = Convert.FromHexString(segments[1]);
        int iterations = int.Parse(segments[2]);
        HashAlgorithmName algorithm = new HashAlgorithmName(segments[3]);
        byte[] inputSecretKey = Rfc2898DeriveBytes.Pbkdf2(
            motDePasseNonEncrypte,
            salt,
            iterations,
            algorithm,
            key.Length
        );
        return key.SequenceEqual(inputSecretKey);
    }

}
