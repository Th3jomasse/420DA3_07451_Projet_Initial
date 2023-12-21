using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class ShipOrdersService : AbstractDtoService<ShipOrdersDTO, int> {
    private AbstractFacade facade;
    protected override ShipOrdersDAO Dao { get; }

    protected override ShipOrdersManagementForm DtoManagementWindow { get; }

    public ShipOrdersService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ShipOrdersDAO(context);
        this.DtoManagementWindow = new ShipOrdersManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

   
    public ShipOrdersDTO? GetShipOrdersById(int id) {
        return this.Dao.GetById(id);
    }

    public List<ShipOrdersDTO> GetShipOrdersByWarehouse(int Id) { 
        return this.Dao.GetByWarehouseId(Id);
    }

    public List<ShipOrdersDTO> GetByStatus(int warehouseId, ShipOrderEnum status){ 
    return this.Dao.GetOrdersByStatus(warehouseId, status);
    }

    public void ChangeStatus(int id, ShipOrderEnum status) {
        this.Dao.ChangeStatus(id, status);
    }

}
