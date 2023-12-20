using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class RoleService : AbstractDtoService<RoleDTO, int>{
    protected override RoleDAO Dao { get; }

    protected override RoleManagementForm DtoManagementWindow { get; }

    public RoleService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new RoleDAO(context);
        this.DtoManagementWindow = new RoleManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
    //protected override IDtoManagementView<RoleDTO> DtoManagementWindows { get; }

    public List<RoleDTO> GetRoles() {
        return this.Dao.GetAll();
    }
    public List<RoleDTO>SearchRole(string userInput) {
        return this.Dao.SearchRole(userInput);
    }
}
