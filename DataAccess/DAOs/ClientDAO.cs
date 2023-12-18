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


}
