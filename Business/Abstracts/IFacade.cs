namespace _420DA3_07451_Projet_Initial.Business.Abstracts;

/// <summary>
/// Interface généralisant les facades. Oblige les facades concrètes à avoir une méthode d'ajout
/// à un registre des objets dépendents stoppables (comme les services).
/// </summary>
/// <remarks>
/// Hérite de <see cref="IStoppable"/> et de <see cref="IStartable"/> ce qui oblige les facades 
/// à avoir une méthode de démarrage et une de terminaison.
/// </remarks>
public interface IFacade : IStartable, IStoppable {

    public void RegisterDependent(IStoppable dependent);

}
