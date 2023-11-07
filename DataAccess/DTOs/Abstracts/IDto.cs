namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;


/// <summary>
/// Interface standard généralisant les entités.
/// </summary>
public interface IDto {

}

/// <summary>
/// Interface générique généralisant les entités.
/// </summary>
/// <remarks>
/// Hérite de <see cref="IDto"/>
/// </remarks>
/// <typeparam name="DtoIdType">Le type de la propriété d'identifiant de l'entité</typeparam>
public interface IDto<DtoIdType> : IDto where DtoIdType : struct, IEquatable<DtoIdType> {

    public DtoIdType? GetId();

}
