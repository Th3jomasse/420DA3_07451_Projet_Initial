namespace _420DA3_07451_Projet_Initial.Business.Exceptions;


/// <summary>
/// Classe d'erreur/exception à lancer lorsque l'utilisateur connecté tente d'accéder à une fonctionnalité
/// réservé pour un rôle qu'il ne possède pas.
/// </summary>
public class UnauthorisedException : Exception {
    public UnauthorisedException(string message, Exception previous) : base(message, previous) { }
    public UnauthorisedException(string message) : base(message) { }
    public UnauthorisedException() : base() { }

}
