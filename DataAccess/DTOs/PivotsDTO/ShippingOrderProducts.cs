using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
public class ShippingOrderProducts {
    public int ShippingOrderId { get; set; }
    public ShipOrdersDTO ShippingOrder { get; set; } = null!;
    public int ProduitId { get; set; }
    public ProduitsDTO Produit { get; set; } = null!;

}
