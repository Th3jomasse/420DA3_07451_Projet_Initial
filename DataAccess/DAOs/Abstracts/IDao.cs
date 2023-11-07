using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
public interface IDao<DtoType, DtoIdType>
    where DtoType : class, IDto<DtoIdType>
    where DtoIdType : struct, IEquatable<DtoIdType> {

    /// <summary>
    /// Déclaration de méthode généralisée de requête globale pour <typeparamref name="DtoType"/>.
    /// </summary>
    /// <returns>La <see cref="List{T}">liste</see> des instances de <typeparamref name="DtoType"/> existantes</returns>
    public List<DtoType> GetAll();

    /// <summary>
    /// Déclaration de méthode généralisée de requête par identifiant pour <typeparamref name="DtoType"/>.
    /// </summary>
    /// <param name="identifier">L'identifiant de l'instance à obtenir</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> obtenue ou <see langword="null"/> si aucune ne correspond</returns>
    public DtoType? GetById(DtoIdType identifier);

    /// <summary>
    /// Déclaration de méthode généralisée d'insertion pour <typeparamref name="DtoType"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="DtoType"/> à insérer</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> insérée</returns>
    public DtoType Create(DtoType instance);

    /// <summary>
    /// Déclaration de méthode généralisée de mise à jour pour <typeparamref name="DtoType"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="DtoType"/> à mettre à jour</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> mise à jour</returns>
    public DtoType Update(DtoType instance);

    /// <summary>
    /// Déclaration de méthode généralisée de suppression pour <typeparamref name="DtoType"/>.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="DtoType"/> à supprimer</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> supprimée</returns>
    public DtoType Delete(DtoType instance);

}
