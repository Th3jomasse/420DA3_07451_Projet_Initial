using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class AdminFacade : AbstractFacade {
    private AdminMainMenu MainMenu { get; set; }
    private AppDbContext Context { get; set; }

    public ClientService ClientService { get; set; }
    public EntrepotService EntrepotService { get; set; }
    public AddressService AddressService { get; set; }
    public RestockOrderService RestockOrderService { get; set; }
    public ShipOrdersService ShipOrdersService { get; set; }
    public ShipmentsService ShipmentsService { get; set; }

    // TODO: ajoutez des propriétés pour vos services ici


    public AdminFacade(AbstractApplication parentApp, AbstractLoginService loginService) : base(parentApp, loginService) {
        this.Context = new AppDbContext();
        this.ClientService = new ClientService(this, this.Context);
        this.EntrepotService = new EntrepotService(this, this.Context);
        this.AddressService = new AddressService(this, this.Context);
        this.RestockOrderService = new RestockOrderService(this, this.Context);
        this.ShipOrdersService= new ShipOrdersService(this, this.Context);
        this.ShipmentsService=new ShipmentsService(this, this.Context);

        // TODO: initialisez vos propriétés de services ici

        this.MainMenu = new AdminMainMenu(this);
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
