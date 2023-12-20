using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ShipOrdersDTO: AbstractDTO<int> {

    public int WarehouseId { get; set; }
    public int ShipmentId { get; set; }
    public string DestName { get; set; }
    public string DestFirstName { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public int CustomerId { get; set; }
    public DateTime ShipOrderDate { get; set; }
    public ShipOrderEnum Status { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateCompleted { get; set; }
    public Byte RowVersion { get; set; }


    public ProduitsDTO Produit { get; set; }
    public ShipmentsDTO Shipment { get; set; }
    public ClientDTO Client { get; set; } 
    public WarehouseDTO Warehouse { get; set; }

    public ShipOrdersDTO() { }

    public ShipOrdersDTO(int warehouseid, int shipmentId, string destName, string destFirstName, string address,
    string postalCode, int customerId, DateTime shipOrderDate   ) { 
        this.WarehouseId = warehouseid;
        this.ShipmentId = shipmentId;
        this.DestName = destName;
        this.DestFirstName = destFirstName;
        this.Address = address;
        this.PostalCode = postalCode;
        this.CustomerId = customerId;
        this.ShipOrderDate = shipOrderDate;
        this.Status = ShipOrderEnum.NEW;

    public List<ShippingOrderProducts> ShippingOrderProducts { get; set; } = new List<ShippingOrderProducts>();

}
    }

    protected ShipOrdersDTO(int warehouseid, int shipmentId, string destName, string destFirstName, string address,
    string postalCode, int customerId, ShipOrderEnum status, DateTime shipOrderDate, DateTime dateCreated, DateTime dateUpdated, 
    DateTime dateCompleted, Byte rowversion, DateTime? dateDeleted) : this(warehouseid, shipmentId, destName, destFirstName, address, postalCode, customerId,
     shipOrderDate) {
        this.WarehouseId = warehouseid;
        this.ShipmentId = shipmentId;
        this.DestName = destName;
        this.DestFirstName = destFirstName;
        this.Address = address;
        this.PostalCode = postalCode;
        this.CustomerId = customerId;
        this.ShipOrderDate = shipOrderDate;
        this.Status = status;
        this.DateCreated = dateCreated;
        this.DateUpdated = dateUpdated;
        this.DateCompleted = dateCompleted;
        this.RowVersion = rowversion;
        this.DateDeleted = dateDeleted;
    }
}

