using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class UserService : AbstractDtoService<UserDTO, int> {

    protected override UserDAO Dao { get; }

    protected override UserManagementForm DtoManagementWindow { get; }

    public UserService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new UserDAO(context);
        this.DtoManagementWindow = new UserManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
    protected override IDtoManagementView<UserDTO> DtoManagementWindow {
        get { throw new NotImplementedException(); }
    }

    public UserDTO? FindUserByUsername(string username) { 
        return this.Dao.GetByUsername(username);
    }
}
