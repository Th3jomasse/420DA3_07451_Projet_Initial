using System.Reflection;

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
    public AbstractLoginService LoginService { get; protected set; }

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
    /// Méthode pour obtenir, à partir d'un <see cref="AbstractFacade"/>, un <see cref="IService"/> quelconque 
    /// existant dans une facade concrète.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Recoit le type (classe) du service à obtenir dans <typeparamref name="ServiceType"/>.<br/>
    /// Lance des exceptions si aucune propriété ou champ du type requis est définie dans la facade concrète
    /// ou si cette propriété/champ n'est pas initialisée avec un objet du type requis.
    /// </para>
    /// <para>
    /// Le type <see cref="AbstractFacade"/> ne défini pas de propriétés de service en lui-même.
    /// Ce sont les facades concrètes qui possèdent des propriétés de services selon les tâches
    /// du rôle représenté par la facade. Cependant, pour que les services et fenêtres graphiques
    /// puissent utiliser les divers services tout en restant compatible avec diverses facades concrètes,
    /// elles doivent recevoir un objet du type abstrait. Cette méthode permet de tenter d'obtenir un 
    /// service spécifique directement à partir de <see cref="AbstractFacade"/>.
    /// </para>
    /// </remarks>
    /// <typeparam name="ServiceType">Le type (classe) du service requis.</typeparam>
    /// <returns></returns>
    /// <exception cref="Exception">Si aucune propriété initialisée du type requis existe dans la facade concrète.</exception>
    public ServiceType GetService<ServiceType>() where ServiceType : IService {
        List<PropertyInfo> properties = this.GetType().GetProperties().ToList();
        foreach (PropertyInfo property in properties) {
            if (property.PropertyType == typeof(ServiceType)) {
                return (ServiceType) (property.GetValue(this) 
                    ?? throw new Exception($"Property of type [{typeof(ServiceType).Name}] is empty (not initialized)."));
            }
        }
        List<FieldInfo> fields = this.GetType().GetFields().ToList();
        foreach (FieldInfo field in fields) {
            if (field.FieldType == typeof(ServiceType)) {
                return (ServiceType) (field.GetValue(this)
                    ?? throw new Exception($"Field of type [{typeof(ServiceType).Name}] is empty (not initialized)."));
            }
        }
        throw new Exception($"Facade does not posess a property or field of type [{typeof(ServiceType).Name}].");
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
