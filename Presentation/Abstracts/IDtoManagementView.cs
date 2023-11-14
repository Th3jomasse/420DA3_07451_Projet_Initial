using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;

namespace _420DA3_07451_Projet_Initial.Presentation.Abstracts;

/// <summary>
/// Interface générique généralisant les fenêtres de gestion d'une entité spécifique.
/// </summary>
/// <remarks>
/// recoit le type de l'entité spécifique dans <typeparamref name="DtoType"/>.
/// </remarks>
/// <typeparam name="DtoType">Le type de l'entité spécifique gérée par la classe de fenêtre de gestion d'entité</typeparam>
public interface IDtoManagementView<DtoType> : IDisposable
    where DtoType : IDto {

    /// <summary>
    /// Ouvre la fenêtre avec l'intention de créer une nouvelle instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Retourne <see cref="DialogResult.OK"/> si l'utilisateur confirme la création à faire, ou <see cref="DialogResult.Cancel"/>
    /// si l'utilisateur annule l'opération.
    /// </remarks>
    /// <param name="blankInstance">Une instance vide de <typeparamref name="DtoType"/>.</param>
    /// <returns>Une valeur de <see cref="DialogResult"/></returns>
    public DialogResult OpenForCreation(DtoType blankInstance);

    /// <summary>
    /// Ouvre la fenêtre avec l'intention d'afficher instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Retourne <see cref="DialogResult.OK"/> ou <see cref="DialogResult.Cancel"/>. Il n'y a pas d'opérations
    /// à faire subséquemment pour la visualisation.
    /// </remarks>
    /// <param name="instance">Une instance de <typeparamref name="DtoType"/>.</param>
    /// <returns>Une valeur de <see cref="DialogResult"/></returns>
    public DialogResult OpenForVisualization(DtoType instance);

    /// <summary>
    /// Ouvre la fenêtre avec l'intention de modifier une instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Retourne <see cref="DialogResult.OK"/> si l'utilisateur confirme les modifications, ou <see cref="DialogResult.Cancel"/>
    /// si l'utilisateur annule l'opération.
    /// </remarks>
    /// <param name="instance">Une instance de <typeparamref name="DtoType"/>.</param>
    /// <returns>Une valeur de <see cref="DialogResult"/></returns>
    public DialogResult OpenForEdition(DtoType instance);

    /// <summary>
    /// Ouvre la fenêtre avec l'intention de supprimer une instance de <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Retourne <see cref="DialogResult.OK"/> si l'utilisateur confirme la suppression, ou <see cref="DialogResult.Cancel"/>
    /// si l'utilisateur annule l'opération.
    /// </remarks>
    /// <param name="instance">Une instance de <typeparamref name="DtoType"/>.</param>
    /// <returns>Une valeur de <see cref="DialogResult"/></returns>
    public DialogResult OpenForDeletion(DtoType instance);

}
