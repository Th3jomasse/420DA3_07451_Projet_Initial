using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
using Microsoft.EntityFrameworkCore;
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
    public override ShipmentsDTO Create(ShipmentsDTO instance) {
        instance.DateCreated = DateTime.Now;
        return base.Create(instance);
    }
    public override ShipmentsDTO Update(ShipmentsDTO instance) {
        instance.DateUpdated = DateTime.Now;
        return base.Update(instance);
    }

    public override ShipmentsDTO Delete(ShipmentsDTO instance) {
        instance.DateDeleted = DateTime.Now;
        return base.Delete(instance);
    }
    public override List<ShipmentsDTO> GetAll() {
        return this.Context.GetDbSet<ShipmentsDTO>().ToList();
    }


    public override ShipmentsDTO? GetById(int id) {
        return this.Context.GetDbSet<ShipmentsDTO>()
            .Where(sh => sh.Id == id)
            .Include(sh => sh.ShippingCompany)
            .Include(sh => sh.ShipOrders.Status)
            .Include(sh => sh.ShipOrders.ShipOrderDate)
            .FirstOrDefault();
    }

    public List<ShipmentsDTO> GetOrdersByShippingCompany(int id,ShippingCompanyEnum company) {
        return this.Context.GetDbSet<ShipmentsDTO>()
            .Where(sh => sh.ShippingCompany == company)
            .Where(sh=>sh.ShipOrders.WarehouseId == id)
            .Include(sh=>sh.ShipOrderId)
            .Include(sh => sh.ShipOrders.Status)
            .Include(sh => sh.ShipOrders.ShipOrderDate)
            .ToList();
    }

    public long GenerateTrackingNumber() {
        Random random = new Random();
        return random.NextInt64(10000000000000, 99999999999999);
    }
}

