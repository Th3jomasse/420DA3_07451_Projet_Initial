using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ShipOrdersDAO: AbstractDao <ShipOrdersDTO,int> {
    protected override AbstractContext Context { get; }

    public ShipOrdersDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override ShipOrdersDTO Update(ShipOrdersDTO instance) {

        instance.DateUpdated = DateTime.Now;
        return base.Update(instance);
    }

    public override ShipOrdersDTO Delete(ShipOrdersDTO instance) {

        instance.DateDeleted = DateTime.Now;
        return base.Delete(instance);
    }
}
