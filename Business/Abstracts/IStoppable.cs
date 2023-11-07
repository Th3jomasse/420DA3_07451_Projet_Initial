namespace _420DA3_07451_Projet_Initial.Business.Abstracts;

/// <summary>
/// Interface obligeant les classes l'implémentant (qui en héritent)
/// de définir la méthode de terminaison <see cref="Shutdown"/>.
/// </summary>
public interface IStoppable {

    /// <summary>
    /// Méthode de terminaison (shutdown)
    /// </summary>
    public void Shutdown();

}
