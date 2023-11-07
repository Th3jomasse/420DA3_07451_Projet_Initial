using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;

/// <summary>
/// Exemple de classe de facade.
/// </summary>
/// <remarks>
/// Hérite de <see cref="AbstractFacade"/>.
/// </remarks>
public class ExempleFacade : AbstractFacade {
    public ExampleService ExampleService { get; protected set; }
    private readonly ExampleMainMenu mainMenu;

    public ExempleFacade(AbstractApplication parentApp, AbstractContext dbContext, AbstractLoginService loginService) : base(parentApp, loginService) {
        // Ajout de la facade en cours de création comme dépendent de l'application.
        // Elle sera donc automatiquement terminée lorsque l'application elle-même terminera via Shutdown()
        parentApp.RegisterDependent(this);
        this.ParentApplication = parentApp;

        // Création des services requis pour les tâches de la facade (donc selon le rôle de l'utilisateur)
        this.ExampleService = new ExampleService(this, dbContext);
        this.mainMenu = new ExampleMainMenu(this);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public override void Start() {
        // Démarrage de la façade (menu principal supposément pour un utilisateur ayant un role spécifique)
        Application.Run(this.mainMenu);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public override void Shutdown() {
        // arrêt de tous les dépendents associés
        foreach (IStoppable dependent in this.Dependents) {
            dependent.Shutdown();
        }
        // destruction et clean-up mémoire de la fenêtre associée
        if (!this.mainMenu.IsDisposed) {
            this.mainMenu.Dispose();
        }
    }
}
