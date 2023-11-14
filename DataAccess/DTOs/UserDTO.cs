using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class UserDTO : AbstractDTO<int> {

    public int UserId { get; set; }
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public RoleDTO RoleId { get; set; }
    public DateTime? DateCreation { get; set; }
    public DateTime? DateUpdate { get; set; }
    public DateTime? DateDelete { get; set; }

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;

}
