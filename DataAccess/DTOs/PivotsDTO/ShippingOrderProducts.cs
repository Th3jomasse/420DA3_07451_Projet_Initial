using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.Pivots;
public class ShippingOrderProducts {
    public int ProductId { get; set; }
    public int ShipOrderId { get; set; }
    public int Qty { get; set; }

    public ProduitsDTO Produits { get; set; }
    public ShipOrdersDTO ShipOrders { get; set; }
}
