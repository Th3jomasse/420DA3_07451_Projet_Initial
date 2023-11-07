using _420DA3_07451_Projet_Initial.Business.Abstracts;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;

/// <summary>
/// Fausse classe de login. Je n'ai pas eu le choix de la créer pour pouvoir fournir
/// une classe de service de login concrète à mon exemple de facade.
/// </summary>
public class FakeLoginService : AbstractLoginService {

    public FakeLoginService(AbstractApplication parentApp) {
        parentApp.RegisterDependent(this);
    }

    public override User GetLoggedInUser() {
        throw new NotImplementedException();
    }

    public override void Shutdown() {
        // rien à faire dans ce service
    }
}
