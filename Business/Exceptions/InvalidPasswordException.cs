namespace _420DA3_07451_Projet_Initial.Business.Exceptions;

/// <summary>
/// Classe d'erreur/exception à lancer lorsque la validation du mot de passe de l'utilisateur
/// échoue lors de l'authentification (login).
/// </summary>
public class InvalidPasswordException : Exception {
    public InvalidPasswordException() : base("Mot de passe invalide.") { }

}
