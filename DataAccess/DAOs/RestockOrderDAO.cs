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
public class RestockOrderDAO : AbstractDao<RestockOrderDTO, int> {
    protected override AbstractContext Context { get; }

    public RestockOrderDAO(AbstractContext context) {
        this.Context = context;
    }

    public override List<RestockOrderDTO> GetAll() {
        return this.Context.GetDbSet<RestockOrderDTO>()
            .Include(ro => ro.DestinationWarehouse)
            .Include(ro => ro.Produit)
            .ToList();
    }

    public override RestockOrderDTO? GetById(int identifier) {
        return this.Context.GetDbSet<RestockOrderDTO>()
            .Include(ro => ro.DestinationWarehouse)
            .Include(ro => ro.Produit)
            .FirstOrDefault();
    }

    public List<RestockOrderDTO> GetAllIncompleteForWarehouse(WarehouseDTO warehouse) {
        return this.GetAllIncompleteForWarehouse(warehouse.Id);
    }

    public List<RestockOrderDTO> GetAllIncompleteForWarehouse(int warehouseId) {
        return this.Context.GetDbSet<RestockOrderDTO>()
            .Where(ro => 
                ro.DestinationWarehouseId == warehouseId 
                && ro.Status == DTOs.Enums.RestockOrderStatusEnum.PENDING
            )
            .Include(ro => ro.DestinationWarehouse)
            .Include(ro => ro.Produit)
            .ToList();
    }
}
