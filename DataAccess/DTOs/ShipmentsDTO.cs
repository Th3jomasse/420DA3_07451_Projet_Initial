using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ShipmentsDTO : AbstractDTO<int> {
    public ShippingCompanyEnum ShippingCompany { get; set; }

    public int ShipOrderId { get; set; }
    public long TrackingNumber { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateDelivered { get; set; }  
    public DateTime? DateShipped { get; set; }
    public DateTime? DateUpdated { get; set; }
  
    public DateTime? DateDeleted { get; set; }
    public Byte[]? RowVersion { get; set; }

    public ShipOrdersDTO ShipOrders {get; set;} = null!;
    public ShipmentsDTO() { }

    public ShipmentsDTO(ShippingCompanyEnum shippingCompany, int shipOrderId) {
        this.ShippingCompany = shippingCompany;
        this.ShipOrderId = shipOrderId;
    }
    protected ShipmentsDTO(ShippingCompanyEnum shippingCompany, int shipOrderId, long trackingNumber, DateTime? dateCreated, DateTime? dateUpdated, 
        DateTime? dateCompleted, DateTime? dateShipped, DateTime? dateDeleted) : this(shippingCompany, shipOrderId) {
        this.ShippingCompany = shippingCompany;
        this.ShipOrderId = shipOrderId;
        this.TrackingNumber = trackingNumber;
        this.DateCreated = dateCreated;
        this.DateUpdated = dateUpdated;
        this.DateDelivered = dateCompleted;
        this.DateShipped = dateShipped;
        this.DateDeleted = dateDeleted;
    }

    public override string ToString() {
        return this.Id.ToString() + "-" + this.ShippingCompany.ToString() + "-" + this.DateShipped.ToString();

    }
}
