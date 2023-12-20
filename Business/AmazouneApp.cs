using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business;
internal class AmazouneApp : AbstractApplication {
    private LoginFacade LoginFacade { get; set; }
    private AbstractFacade? MainFacade { get; set; }


    public AmazouneApp() {
        this.LoginFacade = new LoginFacade(this, new LoginService());
    }



    public override void Start() {
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