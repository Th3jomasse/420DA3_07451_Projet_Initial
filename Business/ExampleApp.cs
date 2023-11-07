using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business;
public class ExampleApp : AbstractApplication {

    /*
     * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE-APPLICATION.
     */

    private IFacade? facade;
    private readonly FakeLoginService loginService;
    private readonly ExampleContext dbContext;

    public ExampleApp() : base() {

        /*
         * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE-APPLICATION.
         */

        this.loginService = new FakeLoginService(this);
        this.dbContext = new ExampleContext();
    }

    public override void Start() {
        /*
         * NORMALEMENT IL Y AURAIT LE CODE POUR L'AUTHENTIFICATION (LOGIN) ICI.
         * SELON LE ROLE DE L'UTILISATEUR, ON CRÉERAIT LA FACADE CORRESPONDANTE
         * PUIS ON LA DÉMARERAIT.
         * 
         * JE N'AI QU'UNE FACADE ET PAS IMPLÉMENTÉ DE LOGIN DANS L'EXEMPLE ALORS JE SKIPPE CELÀ
         * ET NE FAIT QUE DÉMARRER MA FACADE-DÉMO
         */
        this.facade = new ExempleFacade(this, this.dbContext, this.loginService);
        this.facade.Start();
    }


    public override void Shutdown() {
        base.Shutdown();
        this.dbContext.Dispose();
        Application.Exit();
    }

    /*
     * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE-APPLICATION.
     */
}
