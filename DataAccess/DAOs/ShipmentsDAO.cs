using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ShipmentsDAO: AbstractDao <ShipmentsDTO, int> {

    protected override AbstractContext Context { get; }

    public ShipmentsDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override ShipmentsDTO Update(ShipmentsDTO instance) {
        instance.DateUpdated = DateTime.Now;
        return base.Update(instance);
    }

    public override ShipmentsDTO Delete(ShipmentsDTO instance) {
        instance.DateDeleted = DateTime.Now;
        return base.Delete(instance);
    }
}
