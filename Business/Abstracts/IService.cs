namespace _420DA3_07451_Projet_Initial.Business.Abstracts;

/// <summary>
/// Interface généralisant les services.
/// </summary>
/// <remarks>
/// Hérite de <see cref="IStoppable"/> ce qui oblige les services à avoir une méthode de terminaison.
/// </remarks>
public interface IService : IStoppable {

}
