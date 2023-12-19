using _420DA3_07451_Projet_Initial.Business;
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

    public List<RestockOrderDTO> SearchRestockOrdersByProduct(ProduitsDTO produit) {
        return this.Context.GetDbSet<RestockOrderDTO>()
            .Include(ro => ro.DestinationWarehouse)
            .Include(ro => ro.Produit)
            .Where(ro =>
                ro.Produit.Id == produit.Id
            )
            .ToList();
    }

    public List<RestockOrderDTO> SearchRestockOrders(string filter) {
        return this.Context.GetDbSet<RestockOrderDTO>()
            .Include(ro => ro.DestinationWarehouse)
            .Include(ro => ro.Produit)
            .Where(ro =>
                ro.Produit.NomProduit.StartsWith(filter)
                || ro.CreationDate.ToString(LogisticsApp.STANDARD_DATETIME_FORMAT).Contains(filter)
                || (ro.CompletionDate != null && ((DateTime)ro.CompletionDate).ToString(LogisticsApp.STANDARD_DATETIME_FORMAT).Contains(filter))
            )
            .ToList();
    }

    public List<RestockOrderDTO> GetAllIncompleteForWarehouse(EntrepotDTO warehouse) {
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
