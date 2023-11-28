using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;

namespace _420DA3_07451_Projet_Initial.Business.Abstracts;

/// <summary>
/// Classe abstraite pour représenter un service stoppable (<see cref="IStoppable"/>)
/// de l'application.
/// </summary>
/// <remarks>
/// Implémente <see cref="IService"/>.
/// </remarks>
public abstract class AbstractService : IService {

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public abstract void Shutdown();

}

/// <summary>
/// Classe générique abstraite pour représenter un service de gestion d'un type d'entité particulier.<br/>
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractService"/>.<br/>
/// Reçoit la classe du type d'entité gérée dans <typeparamref name="DtoType"/> et le type de la propriété
/// d'identifiant de <typeparamref name="DtoType"/> dans <see cref="DtoIdType"/>.
/// </remarks>
/// <typeparam name="DtoType">La classe du type d'entité géré</typeparam>
/// <typeparam name="DtoIdType">Le type de la propriété d'identifiant (Id) du type d'entité géré</typeparam>
public abstract class AbstractDtoService<DtoType, DtoIdType> : AbstractService
    where DtoType : class, IDto<DtoIdType>, new()
    where DtoIdType : struct, IEquatable<DtoIdType> {

    protected abstract AbstractDao<DtoType, DtoIdType> Dao { get; }
    protected abstract IDtoManagementView<DtoType> DtoManagementWindow { get; }


    /// <summary>
    /// Méthode de création d'une nouvelle instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Crée une instance de <see cref="DtoType"/> vide, la passe à <see cref="IDtoManagementView{DtoType}.OpenForCreation(DtoType)"/>
    /// pour que des valeurs puissent être données aux propriétés de l'entité via l'interface graphique et ensuite sauvegarde le tout
    /// dans la source de données via <see cref="AbstractDao{DtoType, DtoIdType}.Create(DtoType)"/>.
    /// </remarks>
    /// <returns>L'instance de l'entité créée, remplie en valeurs et sauvegardée ou <see langword="null"/> 
    /// si l'utilisateur a annulé l'opération dans l'interface graphique.</returns>
    public virtual DtoType? CreateNewDtoInstance() {
        DtoType dto = new DtoType();
        if (this.DtoManagementWindow.OpenForCreation(dto) == DialogResult.OK) {
            _ = this.Dao.Create(dto);
            return dto;
        }
        return null;
    }


    /// <summary>
    /// Méthode de modification d'une instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Reçoit une instance de <see cref="DtoType"/> à modifier, la passe à 
    /// <see cref="IDtoManagementView{DtoType}.OpenForEdition(DtoType)"/>
    /// pour que l'utilisateur puisse modifier ses valeurs via l'interface graphique et ensuite sauvegarde le tout
    /// dans la source de données via <see cref="AbstractDao{DtoType, DtoIdType}.Update(DtoType)"/>.
    /// </remarks>
    /// <returns>L'instance de l'entité modifiée par l'utilisateur et sauvegardée.</returns>
    public virtual DtoType UpdateDtoInstance(DtoType dto) {
        if (this.DtoManagementWindow.OpenForEdition(dto) == DialogResult.OK) {
            _ = this.Dao.Update(dto);
        }
        return dto;
    }


    /// <summary>
    /// Méthode de visualisation d'une instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Reçoit une instance de <see cref="DtoType"/> à afficher et la passe à 
    /// <see cref="IDtoManagementView{DtoType}.OpenForVisualization(DtoType)"/>
    /// pour que l'utilisateur puisse voir ses données.
    /// </remarks>
    /// <returns>L'instance de l'entité modifiée par l'utilisateur et sauvegardée.</returns>
    public virtual DtoType DisplayDtoInstance(DtoType dto) {
        _ = this.DtoManagementWindow.OpenForVisualization(dto);
        return dto;
    }


    /// <summary>
    /// Méthode de suppression/destruction d'une instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Reçoit une instance de <see cref="DtoType"/> à supprimer, la passe à 
    /// <see cref="IDtoManagementView{DtoType}.OpenForDeletion(DtoType)"/>
    /// pour que l'utilisateur puisse confirmer la suppression et ensuite sauvegarde le tout
    /// dans la source de données via <see cref="AbstractDao{DtoType, DtoIdType}.Delete(DtoType)"/>.
    /// </remarks>
    /// <returns>L'instance de l'entité supprimée.</returns>
    public virtual DtoType DeleteDtoInstance(DtoType dto) {
        if (this.DtoManagementWindow.OpenForDeletion(dto) == DialogResult.OK) {
            _ = this.Dao.Delete(dto);
        }
        return dto;
    }

}
