namespace _420DA3_07451_Projet_Initial.Business.Exceptions;

/// <summary>
/// Classe d'erreur/exception à lancer lorsque l'utilisateur n'est pas trouvé dans la base de données
/// lors de l'authentification (login).
/// </summary>
public class UserNotFoundException : Exception {
    public UserNotFoundException(string username) : base($"User [{username}] not found.") { }
}
