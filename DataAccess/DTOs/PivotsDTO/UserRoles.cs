using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
public class UserRoles {

    public int UserId { get; set; }
    public UserDTO User { get; set; } = null!;
    public int RoleId { get; set; }
    public RoleDTO Role { get; set; } = null!;
}
