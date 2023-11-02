namespace _420DA3_07451_Projet_Initial.Business.Abstracts;
public abstract class AbstractApplication {
    protected List<IService> Services { get; private set; }

    protected AbstractApplication() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        this.Services = new List<IService>();
    }

    public void RegisterService(IService service) {
        this.Services.Add(service);
    }

    abstract public void Start();

    abstract public void Shutdown();

}
