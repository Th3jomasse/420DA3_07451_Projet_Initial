using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
internal class ShipmentsService : AbstractDtoService<ShipmentsDTO, int> {
    private AbstractFacade facade;
    protected override ShipmentsDAO Dao { get; }

    protected override ShipmentsManagementForm DtoManagementWindow { get; }

    public ShipmentsService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ShipmentsDAO(context);
        this.DtoManagementWindow = new ShipmentsManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    public ShipmentsDTO? GetShipmentsById(int id) {
        return this.Dao.GetById(id);
    }

    public List<ShipmentsDTO> GetShipmentsByShippingCompany(int id, ShippingCompanyEnum company) {
        return this.Dao.GetOrdersByShippingCompany(id, company);
    }


  

}