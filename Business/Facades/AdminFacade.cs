﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
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

    private ClientService ClientService { get; set; }
    private EntrepotService EntrepotService { get; set; }
    private AddressService AddressService { get; set; }
    private RestockOrderService RestockOrderService { get; set; }


    public AdminFacade(AbstractApplication parentApp, AbstractLoginService loginService) : base(parentApp, loginService) {
        this.Context = new AppDbContext();
        this.ClientService = new ClientService(this, this.Context);
        this.EntrepotService = new EntrepotService(this, this.Context);
        this.AddressService = new AddressService(this, this.Context);
        this.RestockOrderService = new RestockOrderService(this, this.Context);
        this.MainMenu = new AdminMainMenu(this);
    }

    public override void Shutdown() {
        throw new NotImplementedException();
    }

    public override void Start() {
        Application.Run(this.MainMenu);
    }
}
