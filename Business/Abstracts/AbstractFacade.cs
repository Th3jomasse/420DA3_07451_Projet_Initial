namespace _420DA3_07451_Projet_Initial.Business.Abstracts;

/// <summary>
/// Classe abstraite fournissant des services de terminaison (shutdown) pour les
/// classes-facade qui en héritent.
/// </summary>
/// <remarks>
/// Implémente <see cref="IFacade"/>.
/// </remarks>
public abstract class AbstractFacade : IFacade {
    protected AbstractApplication ParentApplication { get; set; }
    protected List<IStoppable> Dependents { get; set; }
    public AbstractLoginService LoginService { get; private set; }

    protected AbstractFacade(AbstractApplication parentApp, AbstractLoginService loginService) {
        parentApp.RegisterDependent(this);
        this.ParentApplication = parentApp;
        this.Dependents = new List<IStoppable>();
        this.LoginService = loginService;
    }


    /// <summary>
    /// Ajoute un objet <see cref="IStoppable"/> au registre d'objets dépendants pouvant êtres terminés/stoppés.
    /// Ces objets sont automatiquement terminés/stoppés lorsque l'application l'est elle-même.
    /// </summary>
    /// <param name="dependent">L'objet dépendent à ajouter au registre.</param>
    public void RegisterDependent(IStoppable dependent) {
        this.Dependents.Add(dependent);
    }


    /// <summary>
    /// Démarrage de la facade
    /// </summary>
    public abstract void Start();


    /// <summary>
    /// Terminaison (shutdown) de la facade
    /// </summary>
    public abstract void Shutdown();


    /// <summary>
    /// Méthode de relai du signal de terminaison entre la fenêtre principale
    /// et la méthode de base dans la classe-application (la fenêtre principale n'a pas
    /// accès à l'application elle-même, juste à sa façade).
    /// </summary>
    public void ShutdownParentApplication() {
        this.ParentApplication.Shutdown();
    }
}
