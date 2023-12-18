using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
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
internal class ClientService : AbstractDtoService<ClientDTO, int> {
    private AbstractFacade ParentFacade { get; set; }
    protected override ClientDAO Dao { get; }

    protected override ClientManagementForm DtoManagementWindow { get; }

    public ClientService(AbstractFacade facade, AppDbContext context) {
        facade.RegisterDependent(this);
        this.ParentFacade = facade;
        this.Dao = new ClientDAO(context);
    }

    public List<ClientDTO> GetAllClients() {
        throw new NotImplementedException();
    }

    public List<ClientDTO> SearchClientsByName(string clientName) {
        throw new NotImplementedException();
    }

    public List<ClientDTO> SearchClientsByIdString(string idString) {
        throw new NotImplementedException();
    }

    public override void Shutdown() {
        throw new NotImplementedException();
    }
}
