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


public class AmazouneFacade : AbstractFacade {
    public UserService userService { get; protected set; }
    private readonly LoginForm loginForm;

    public AmazouneFacade(AbstractApplication parentApp, AbstractContext dbContext, AbstractLoginService loginService) : base(parentApp, loginService) {
        parentApp.RegisterDependent(this);
        this.ParentApplication = parentApp;
        
        this.userService = new UserService(this, dbContext);
        this.loginForm = new LoginForm(this);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public override void Start() {
        // Démarrage de la façade (menu principal supposément pour un utilisateur ayant un role spécifique)
        Application.Run(this.loginForm);
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
        if (!this.loginForm.IsDisposed) {
            this.loginForm.Dispose();
        }
    }
}
