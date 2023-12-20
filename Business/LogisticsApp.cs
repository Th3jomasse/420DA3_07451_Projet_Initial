using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business;
internal class LogisticsApp : AbstractApplication {
    public const string STANDARD_DATETIME_FORMAT = "yyyy-MM-dd HH:mm:ss";
    private LoginFacade LoginFacade { get; set; }
    private AbstractFacade? MainFacade { get; set; }
    

    public LogisticsApp() {
        // fake login service requis pour la facade parce que j'ai foiré un peu dans ma logique
        // d'abstraction au niveau des facades - Prof
#pragma warning disable CS0618 // Type or member is obsolete
        this.LoginFacade = new LoginFacade(this, new LoginService());
#pragma warning restore CS0618 // Type or member is obsolete


    }



    public override void Start() {
        // obtient le rôle de l'utilisateur connecté. S'il n'y a pas d'utilisateur connecté, force
        // un utilisateur à se connecter. Si celui-ci possède plusieurs rôles, déclenche un form
        // de sélection de rôle.
        this.StartMainFacade(this.LoginFacade.GetService<LoginService>().GetLoggedInUserRole());


    }

    private void StartMainFacade(RoleDTO role) {

        switch (role.Id) {
            case RoleDTO.ADMINISTRATOR_ROLE_ID:
                this.MainFacade = new AdminFacade(this, this.LoginFacade.LoginService);
                break;
            case RoleDTO.WAREHOUSE_EMPLOYEE_ROLE_ID:
                this.MainFacade = new WhEmployeeFacade(this, this.LoginFacade.LoginService);
                break;
            case RoleDTO.OFFICE_EMPLOYEE_ROLE_ID:
                this.MainFacade = new OfficeEmployeeFacade(this, this.LoginFacade.LoginService);
                break;
            default:
                throw new Exception($"Le Rôle [{role.RoleName}] n'est pas supporté.");
        }

        this.MainFacade.Start();
    }

    public override void Shutdown() {
        base.Shutdown();
        Application.Exit();
    }
}
