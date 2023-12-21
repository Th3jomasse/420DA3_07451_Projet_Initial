using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic.ApplicationServices;
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

    public override ShipOrdersDTO Create(ShipOrdersDTO instance) {
        instance.DateCreated = DateTime.Now;
        return base.Create(instance);
    }
    public override ShipOrdersDTO Update(ShipOrdersDTO instance) {

        instance.DateUpdated = DateTime.Now;
        return base.Update(instance);
    }

    public override ShipOrdersDTO Delete(ShipOrdersDTO instance) {

        instance.DateDeleted = DateTime.Now;
        return base.Delete(instance);
    }

    public override List<ShipOrdersDTO> GetAll() {
        return this.Context.GetDbSet<ShipOrdersDTO>().ToList();
    }


    public override ShipOrdersDTO? GetById(int id) {
        return this.Context.GetDbSet<ShipOrdersDTO>()
            .Where(so => so.Id == id)
            .Include(so => so.WarehouseId)
            .Include(so => so.Status)
            .Include(so => so.ShipOrderDate)
            .FirstOrDefault();
    }

    public List<ShipOrdersDTO> GetByWarehouseId(int id) {
        return this.Context.GetDbSet<ShipOrdersDTO>()
            .Where(so => so.WarehouseId == id)
            .Include(so => so.Status)
            .Include(so=>so.ShipOrderDate)
            .ToList();

    }

    public List<ShipOrdersDTO> GetOrdersByStatus(int warehouseId, ShipOrderEnum status) {
        return this.Context.GetDbSet<ShipOrdersDTO>()
            .Where(so => so.WarehouseId == warehouseId
                && so.Status == status
            )
            .Include(so=>so.Id)
            .Include(so => so.ShipOrderDate)
            .ToList();
    }

    /// <summary>
    /// Change le status de l'ordre d'expédition
    /// </summary>
    /// <param name="id">identificateur de l'ordre d'expédition</param>
    /// <param name="status">Variable de l'enumérateur ShipOrderEnum</param>
    public void ChangeStatus(int id, ShipOrderEnum status) {

        _ = this.Context.GetDbSet<ShipOrdersDTO>()
       .Where(so => so.Id == id)
       .ExecuteUpdate(so => so.SetProperty(so => so.Status, status));

    }
}
