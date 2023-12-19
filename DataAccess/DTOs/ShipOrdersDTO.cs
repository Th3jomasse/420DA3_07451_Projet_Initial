using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ShipOrdersDTO: AbstractDTO<int> {

    public int WarehouseId { get; set; }
    public int ShipmentId { get; set; }
    public string Destname { get; set; }
    public string DestFirstName { get; set; }
    public string Adress { get; set; }
    public string PostalCode { get; set; }
    public int CustomerId { get; set; }
    public DateTime ShipOrderDate { get; set; }
    public string ShipOrderStatus { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }

    public List<ShippingOrderProducts> ShippingOrderProducts { get; set; } = new List<ShippingOrderProducts>();

}
