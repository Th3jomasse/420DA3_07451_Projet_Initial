using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;

namespace _420DA3_07451_Projet_Initial.Business.Services;

/// <summary>
/// Exemple de classe de service de gestion d'une entitée spécifique, ici <see cref="ExampleDTO"/>.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractDtoService{DtoType, DtoIdType}"/> ce qui lui fournit des méthodes
/// d'opérations de base automatiquement.
/// </remarks>
public class ExampleService : AbstractDtoService<ExampleDTO, int> {

    protected override ExampleDAO Dao { get; }

    protected override ExampleDtoWindow DtoManagementWindow { get; }

    public ExampleService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ExampleDAO(context);
        this.DtoManagementWindow = new ExampleDtoWindow(facade);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    /*
     * NOTEZ QUE CE SERVICE DE GESTION N'A AUCUNE MÉTHODE D'OPÉRATIONS DE BASE DÉFINIES DEDANS
     * 
     * IL HÉRITE DES MÉTHODES DE LA CLASSE ABSTRAITE GÉNÉRIQUES AbstractDtoService<ExampleDTO, int>
     * QUI LUI FOURNIT LES MÉTHODES POUR CES MÊMES OPÉRATIONS DE BASE.
     * 
     * NOUS N'AVONS QU'À CRÉER LES MÉTHODES POUR DES CAS D'OPÉRATIONS PARTICULIÈRES NE
     * POUVANT PAS ÊTRE GÉNÉRALISÉES.
     */

    /// <summary>
    /// Retourne la liste de tous les examples existant.
    /// </summary>
    /// <returns>La liste de tous les examples existants.</returns>
    public List<ExampleDTO> GetAllExamples() {
        // Notez l'utilisation de GetAll() sur l'instance de ExampleDAO qui hérite de cette
        // méthode définie dans AbstractDao
        return this.Dao.GetAll();
    }
}
