using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
internal class RestockOrderDTO : AbstractDTO<int> 
{
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public WarehouseDTO Warehouse { get; set; }
    public int Quantity { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime CompletionDate { get; set; }
}
