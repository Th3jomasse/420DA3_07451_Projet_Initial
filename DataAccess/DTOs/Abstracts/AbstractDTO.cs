namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;

/// <summary>
/// Classe abstraite générique pour les entités.
/// </summary>
/// <remarks>
/// Contient la propriété Id dont héritent les classes-enfants.<br/>
/// Recoit le type de la propriété d'identifiant (Id) dans <typeparamref name="DtoIdType"/> ce qui permet
/// de théoriquement créer des DTOs avec autre chose qu'un <see cref="int"/> comme identifiant.<br/>
/// Implémente <see cref="IDto{DtoIdType}"/>.
/// </remarks>
/// <typeparam name="DtoIdType">Le type de la propriété d'identifiant de l'entité</typeparam>
public abstract class AbstractDTO<DtoIdType> : IDto<DtoIdType> where DtoIdType : struct, IEquatable<DtoIdType> {

    public DtoIdType Id { get; set; }

    protected AbstractDTO() { }

    /// <summary>
    /// Méthode retournant la valeur de l'identifiant.
    /// </summary>
    /// <remarks>
    /// Utilisé par <see cref="DAOs.Abstracts.AbstractDao{DtoType, DtoIdType}.GetById(DtoIdType)"/>.
    /// </remarks>
    /// <returns></returns>
    public DtoIdType? GetId() {
        return this.Id;
    }
}
