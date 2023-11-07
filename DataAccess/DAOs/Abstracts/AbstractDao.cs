using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;

/// <summary>
/// Classe abstraite générique permettant de généraliser les opérations de base pour les DAOs.<br/>
/// Fournit automatiquement les méthodes suivantes:
/// <list type="bullet">
/// <item><see cref="GetAll"/></item>
/// <item><see cref="GetById(DtoIdType)"/></item>
/// <item><see cref="Create(DtoType)"/></item>
/// <item><see cref="Update(DtoType)"/></item>
/// <item><see cref="Delete(DtoType)"/></item>
/// </list>
/// Notez que ces méthodes sont virtuelles et peuvent être redéfinies (override) si nécessaire.
/// </summary>
/// <remarks>
/// Recoit le type de l'entitée gérée par la classe de DAO concrète qui hérite de celle-ci dans <typeparamref name="DtoType"/>.<br/>
/// Recoit le type de la propriété d'identifiant (Id) de l'entitée gérée par la classe de DAO concrète qui hérite 
/// de celle-ci dans <typeparamref name="DtoIdType"/>.<br/>
/// Implémente <see cref="IDao{DtoType, DtoIdType}"/>.
/// </remarks>
/// <typeparam name="DtoType">La classe de l'entité gérée.</typeparam>
/// <typeparam name="DtoIdType">Le type de la propriété d'identifiant de la classe de l'entité gérée.</typeparam>
public abstract class AbstractDao<DtoType, DtoIdType> : IDao<DtoType, DtoIdType>
    where DtoType : class, IDto<DtoIdType>
    where DtoIdType : struct, IEquatable<DtoIdType> {

    protected abstract AbstractContext Context { get; }

    protected AbstractDao() { }

    /// <summary>
    /// Retourne la <see cref="List{T}">liste</see> de toutes les instances de <typeparamref name="DtoType"/> 
    /// enregistrées dans la base de données.
    /// </summary>
    /// <returns>La <see cref="List{T}"/> de toutes les instances de l'entité.</returns>
    /// <remarks>
    /// Définition/Implémentation de <see cref="IDao{DtoType, DtoIdType}.GetAll"/>,
    /// </remarks>
    /// <exception cref="Exception">Si la classe de contexte concrène de possède pas de propriété <see cref="DbSet{TEntity}"/> pour <typeparamref name="DtoType"/>.</exception>
    public virtual List<DtoType> GetAll() {
        return this.Context.GetDbSet<DtoType>()?.ToList() ?? throw new Exception($"Context does not contain a DbSet property for type {typeof(DtoType)}.");
    }

    /// <summary>
    /// Obtient l'instance de <typeparamref name="DtoType"/> dont l'identifiant correspond à la valeur passée à <paramref name="identifier"/>.<br/>
    /// Si aucune instance ne correspond à la valeur passée, retourne <see langword="null"/>.
    /// </summary>
    /// <param name="identifier">L'identifiant de l'instance de l'entité à obtenir.</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> trouvée, ou <see langword="null"/> si aucune ne correspond.</returns>
    /// <remarks>
    /// Définition/Implémentation de <see cref="IDao{DtoType, DtoIdType}.GetById(DtoIdType)"/>,
    /// </remarks>
    /// <exception cref="Exception">Si la classe de contexte concrète de possède pas de propriété <see cref="DbSet{TEntity}"/> pour <typeparamref name="DtoType"/>.</exception>
    public virtual DtoType? GetById(DtoIdType identifier) {
        DbSet<DtoType> dbSet = this.Context.GetDbSet<DtoType>() ?? throw new Exception($"Context does not contain a DbSet property for type {typeof(DtoType)}.");
        return dbSet.Where(dto => dto.GetId().Equals(identifier)).SingleOrDefault();
    }

    /// <summary>
    /// Insère l'instance de <typeparamref name="DtoType"/> passée dans <paramref name="instance"/> dans la base de données.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="DtoType"/> à insérer.</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> insérée.</returns>
    /// <remarks>
    /// Définition/Implémentation de <see cref="IDao{DtoType, DtoIdType}.Create(DtoType)"/>,
    /// </remarks>
    /// <exception cref="Exception">Si la classe de contexte concrète de possède pas de propriété <see cref="DbSet{TEntity}"/> pour <typeparamref name="DtoType"/>.</exception>
    public virtual DtoType Create(DtoType instance) {
        DbSet<DtoType> dbSet = this.Context.GetDbSet<DtoType>() ?? throw new Exception($"Context does not contain a DbSet property for type {typeof(DtoType)}.");
        _ = dbSet.Add(instance);
        _ = this.Context.SaveChanges();
        return instance;
    }

    /// <summary>
    /// Enregistre les modifications apportés à l'instance de <typeparamref name="DtoType"/> passée dans 
    /// <paramref name="instance"/> dans la base de données.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="DtoType"/> modifiée à sauvegarder.</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> sauvegardée.</returns>
    /// <remarks>
    /// Définition/Implémentation de <see cref="IDao{DtoType, DtoIdType}.Update(DtoType)"/>,
    /// </remarks>
    /// <exception cref="Exception">Si la classe de contexte concrète de possède pas de propriété <see cref="DbSet{TEntity}"/> pour <typeparamref name="DtoType"/>.</exception>
    public virtual DtoType Update(DtoType instance) {
        DbSet<DtoType> dbSet = this.Context.GetDbSet<DtoType>() ?? throw new Exception($"Context does not contain a DbSet property for type {typeof(DtoType)}.");
        _ = dbSet.Update(instance);
        _ = this.Context.SaveChanges();
        return instance;
    }

    /// <summary>
    /// Supprime l'instance de <typeparamref name="DtoType"/> passée dans 
    /// <paramref name="instance"/> de la base de données.
    /// </summary>
    /// <param name="instance">L'instance de <typeparamref name="DtoType"/> à supprimer.</param>
    /// <returns>L'instance de <typeparamref name="DtoType"/> supprimée.</returns>
    /// <remarks>
    /// Définition/Implémentation de <see cref="IDao{DtoType, DtoIdType}.Delete(DtoType)"/>.
    /// <inheritdoc/>
    /// </remarks>
    /// <exception cref="Exception">Si la classe de contexte concrète de possède pas de propriété <see cref="DbSet{TEntity}"/> pour <typeparamref name="DtoType"/>.</exception>
    public virtual DtoType Delete(DtoType instance) {
        DbSet<DtoType> dbSet = this.Context.GetDbSet<DtoType>() ?? throw new Exception($"Context does not contain a DbSet property for type {typeof(DtoType)}.");
        _ = dbSet.Remove(instance);
        _ = this.Context.SaveChanges();
        return instance;
    }
}
