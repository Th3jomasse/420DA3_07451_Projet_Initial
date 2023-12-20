using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class OfficeEmployeeFacade : AbstractFacade {
    private OfficeWorkerMainMenu MainMenu { get; set; }
    private AppDbContext Context { get; set; }

    // TODO: ajoutez des propriétés pour les services appropriés ici

    public OfficeEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService) : base(parentApp, loginService) {
        this.Context = new AppDbContext();

        // TODO: initialisez les propriétés des services ici

        this.MainMenu = new OfficeWorkerMainMenu(this);
    }

    public override void Shutdown() {
        foreach (IStoppable dependant in this.Dependents) {
            dependant.Shutdown();
        }
        if (!this.MainMenu.IsDisposed) {
            this.MainMenu.Dispose();
        }
    }

    public override void Start() {
        Application.Run(this.MainMenu);
    }
}
