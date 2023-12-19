using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
internal class ClientDAO : AbstractDao<ClientDTO, int> {
    protected override AbstractContext Context { get; }

    public ClientDAO(AbstractContext context) {
        this.Context = context;
    }

    public override List<ClientDTO> GetAll() {
        return this.Context.GetDbSet<ClientDTO>()
            .Include(client => client.ClientAddress)
            .Include(client => client.AssignedWarehouse)
            .ToList();
    }

    public override ClientDTO? GetById(int identifier) {
        return this.Context.GetDbSet<ClientDTO>()
            .Include(client => client.ClientAddress)
            .Include(client => client.AssignedWarehouse)
            .Where(client => client.Id == identifier)
            .SingleOrDefault();
    }

    public List<ClientDTO> SearchClients(string filter) {
        return this.Context.GetDbSet<ClientDTO>()
            .Include(client => client.ClientAddress)
            .Include(client => client.AssignedWarehouse)
            .Where(client => client.Id.ToString().StartsWith(filter) || client.NomClient.StartsWith(filter))
            .ToList();
    }

    public List<ClientDTO> SearchClientsById(string idString) {
        return this.Context.GetDbSet<ClientDTO>()
            .Include(client => client.ClientAddress)
            .Include(client => client.AssignedWarehouse)
            .Where(client => client.Id.ToString().StartsWith(idString))
            .ToList();
    }

    public List<ClientDTO> SearchClientsByClientName(string nameString) {
        return this.Context.GetDbSet<ClientDTO>()
            .Include(client => client.ClientAddress)
            .Include(client => client.AssignedWarehouse)
            .Where(client => client.NomClient.StartsWith(nameString))
            .ToList();
    }

}
