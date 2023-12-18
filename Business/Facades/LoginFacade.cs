using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class LoginFacade : AbstractFacade {
    private AppDbContext Context { get; set; }
    public UserService UserService { get; set; }


    public LoginFacade(AbstractApplication parentApp, AbstractLoginService loginService) : base(parentApp, loginService) {
        // remplacement de fake login service recu par le constructeur par une vrai associé à la facade.
        // Note que la propriété this.LoginService est héritée de AbstractFacade
        this.LoginService = new LoginService(this);
        this.Context = new AppDbContext();
        this.UserService = new UserService(this, this.Context);

    }

    public override void Shutdown() {
        throw new NotImplementedException();
    }

    public override void Start() {
        throw new NotImplementedException();
    }
}
