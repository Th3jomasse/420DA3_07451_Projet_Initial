using _420DA3_07451_Projet_Initial.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Facades;
internal class AdminFacade : AbstractFacade {
    public AdminFacade(AbstractApplication parentApp, AbstractLoginService loginService) : base(parentApp, loginService) {
    }

    public override void Shutdown() {
        throw new NotImplementedException();
    }

    public override void Start() {
        throw new NotImplementedException();
    }
}
