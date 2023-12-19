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
internal class EntrepotDAO : AbstractDao<EntrepotDTO, int> {
    protected override AbstractContext Context { get; }

    public EntrepotDAO(AbstractContext context) {
        this.Context = context;
    }

    public override List<EntrepotDTO> GetAll() {
        return this.Context.GetDbSet<EntrepotDTO>()
            .Include(wh => wh.Address)
            .ToList();
    }

    public override EntrepotDTO? GetById(int identifier) {
        return this.Context.GetDbSet<EntrepotDTO>()
            .Include(wh => wh.Address)
            .Where(wh => wh.Id == identifier)
            .SingleOrDefault();
    }

    public List<EntrepotDTO> SearchEntrepots(string filter) {
        return this.Context.GetDbSet<EntrepotDTO>()
            .Include(wh => wh.Address)
            .Where(wh => wh.Id.ToString().StartsWith(filter) || wh.NomEntrepot.StartsWith(filter))
            .ToList();
    }
}
