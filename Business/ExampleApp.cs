using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business;
public class ExampleApp : AbstractApplication {

    /*
     * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE-APPLICATION.
     */

    private readonly ExampleContext dbContext;
    private readonly ExampleService exampleService;
    private readonly ExampleMainMenu mainMenu;

    public ExampleApp() : base() {

        /*
         * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE-APPLICATION.
         */

        this.dbContext = new ExampleContext();
        this.exampleService = new ExampleService(this, this.dbContext);
        this.mainMenu = new ExampleMainMenu(this, this.exampleService, this.exampleService.GetAllExamples());
    }

    public override void Start() {
        Application.Run(this.mainMenu);
    }


    public override void Shutdown() {
        foreach (IService service in this.Services) {
            service.Shutdown();
        }
        this.mainMenu.Dispose();
        this.dbContext.Dispose();
        Application.Exit();
    }

    /*
     * N'UTILISEZ PAS CETTE CLASSE. FAITES VOTRE PROPRE CLASSE-APPLICATION.
     */
}
