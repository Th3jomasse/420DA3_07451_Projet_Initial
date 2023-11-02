using _420DA3_07451_Projet_Initial.Business.Abstracts;
using System.Security.Cryptography;

namespace _420DA3_07451_Projet_Initial.Business;
internal class CryptographyService : IService {
    // Paramètres de hashage.
    private const int SALT_SIZE = 16; // sel cryptographique de 128 bits
    private const int KEY_SIZE = 32; // clé cryptographique de 256 bits
    private const int CRYPT_ITERATIONS = 100000; // itérations de l'étirement de clé
    private const char SEGMENT_DELIMITER = ':'; // séparateur des sections générées - NE PAS CHANGER (sinon hashs existants invalidables)
    private static readonly HashAlgorithmName CRYPT_ALGORITHM = HashAlgorithmName.SHA256; // algorithme de base


    public CryptographyService(AbstractApplication app) {
        app.RegisterService(this);
    }

    public void Shutdown() {
        // rien à faire dans ce service
    }

    public static string? HashPassword(string? clearPassword) {
        if (clearPassword == null) {
            return null;
        }
        byte[] salt = RandomNumberGenerator.GetBytes(SALT_SIZE);
        byte[] key = Rfc2898DeriveBytes.Pbkdf2(
            clearPassword,
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


    public static bool VerifyPassword(string unencryptedPassword, string hashedPassword) {
        string[] segments = hashedPassword.Split(SEGMENT_DELIMITER);
        byte[] key = Convert.FromHexString(segments[0]);
        byte[] salt = Convert.FromHexString(segments[1]);
        int iterations = int.Parse(segments[2]);
        HashAlgorithmName algorithm = new HashAlgorithmName(segments[3]);
        byte[] inputSecretKey = Rfc2898DeriveBytes.Pbkdf2(
            unencryptedPassword,
            salt,
            iterations,
            algorithm,
            key.Length
        );
        return key.SequenceEqual(inputSecretKey);
    }

}
