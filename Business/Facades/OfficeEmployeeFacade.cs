using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class OfficeEmployeeFacade : AbstractFacade {
    private OfficeWorkerMainMenu MainMenu { get; set; }

    public OfficeEmployeeFacade(AbstractApplication parentApp, AbstractLoginService loginService) : base(parentApp, loginService) {
        this.MainMenu = new OfficeWorkerMainMenu(this);
    }

    public override void Shutdown() {
        throw new NotImplementedException();
    }

    public override void Start() {
        Application.Run(this.MainMenu);
    }
}
