using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business;
public class AmazouneApp : AbstractApplication {

    private IFacade? facade;
    private readonly FakeLoginService loginService;
    private readonly AppDbContext dbContext;

    public AmazouneApp() : base() {
       
        ApplicationConfiguration.Initialize();
        this.loginService = new FakeLoginService(this);
        this.dbContext = new AppDbContext();
    }

    public override void Start() {
        this.facade = new AmazouneFacade(this, this.dbContext, this.loginService);
        this.facade.Start();
    }
    public override void Shutdown() {
        base.Shutdown();
        this.dbContext.Dispose();
        Application.Exit();
    }
    
}