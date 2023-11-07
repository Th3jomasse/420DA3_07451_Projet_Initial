namespace _420DA3_07451_Projet_Initial.Business.Abstracts;

/// <summary>
/// Classe abstraite fournissant des services de terminaison (shutdown) pour les
/// classes-application qui en héritent.
/// </summary>
/// <remarks>
/// Implémente <see cref="IStartable"/> et <see cref="IStoppable"/>.
/// </remarks>
public abstract class AbstractApplication : IStartable, IStoppable {
    protected List<IStoppable> Dependents { get; private set; }


    protected AbstractApplication() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        this.Dependents = new List<IStoppable>();
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
    /// Démarrage de l'application
    /// </summary>
    public abstract void Start();

    /// <summary>
    /// Terminaison de l'application
    /// </summary>
    public virtual void Shutdown() {
        foreach (IStoppable stoppable in this.Dependents) {
            stoppable.Shutdown();
        }
    }

}