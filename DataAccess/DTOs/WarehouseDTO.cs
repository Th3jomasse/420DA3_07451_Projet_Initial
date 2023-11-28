using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class WarehouseDTO : AbstractDTO<int> {
    public int Id { get; set; }
    public string Name { get; set; }


    // Désolé d'avoir ajouté ça, mais il fallait que je fasse avancer quelques trucs
    // pour pouvoir compléter ma partie du DbContext
    public List<RestockOrderDTO> RestockOrders { get; set; } = new List<RestockOrderDTO>();
}
