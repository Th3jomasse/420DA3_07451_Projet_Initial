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
        this.DtoManagementWindow = new ClientManagementForm(facade);
    }

    public List<ClientDTO> GetAllClients() {
        throw new NotImplementedException();
    }

    public List<ClientDTO> SearchClients(string filter) {
        return this.Dao.SearchClients(filter);
    }

    public List<ClientDTO> SearchClientsByName(string clientName) {
        return this.Dao.SearchClientsByClientName(clientName);
    }

    public List<ClientDTO> SearchClientsByIdString(string idString) {
        return this.Dao.SearchClientsById(idString);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
}
