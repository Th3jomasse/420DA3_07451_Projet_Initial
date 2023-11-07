using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;

/// <summary>
/// Exemple de DAO
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDao{DtoType, DtoIdType}"/> et donc hérite des méthodes suivantes:
/// <list type="bullet">
/// <item><see cref="AbstractDao{DtoType, DtoIdType}.GetAll"/></item>
/// <item><see cref="AbstractDao{DtoType, DtoIdType}.GetById(DtoIdType)"/></item>
/// <item><see cref="AbstractDao{DtoType, DtoIdType}.Create(DtoType)"/></item>
/// <item><see cref="AbstractDao{DtoType, DtoIdType}.Update(DtoType)"/></item>
/// <item><see cref="AbstractDao{DtoType, DtoIdType}.Delete(DtoType)"/></item>
/// </list>
/// Notez que je redéfini (override) deux de ces méthodes pour leur ajouter une fonctionnalité.
/// </remarks>
public class ExampleDAO : AbstractDao<ExampleDTO, int> {
    protected override ExampleContext Context { get; }

    public ExampleDAO(ExampleContext context) : base() { 
        this.Context = context;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <remarks>
    /// Voir <see cref="AbstractDao{DtoType, DtoIdType}.Update(DtoType)"/>.
    /// </remarks>
    public override ExampleDTO Update(ExampleDTO instance) {
        // ajout d'une valeur de date de mise à jour pour la date de modification lors de l'update
        instance.DateUpdated = DateTime.Now;
        // appel de la méthode Update de la classe parente (base, ici AbstractDao) et retour de sa valeur retournée
        return base.Update(instance);
    }

    public override ExampleDTO Delete(ExampleDTO instance) {
        // ajout d'une valeur de date de suppression pour la date de modification lors de l'update
        instance.DateDeleted = DateTime.Now;
        // appel de la méthode Delete de la classe parente (base, ici AbstractDao) et retour de sa valeur retournée
        return base.Delete(instance);
    }
}
