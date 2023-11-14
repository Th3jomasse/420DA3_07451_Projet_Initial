using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class RoleDTO : AbstractDTO<int> {

    public int RoleId { get; set; }
    public string RoleName { get; set; } = null!;
    public string RoleDescription { get; set; } = null!;
    public UserDTO UserId { get; set; }
    public DateTime? DateCreate { get; set; }
    public DateTime? DateUpdate { get; set; }
    public DateTime? DateDelete { get; set; }

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int ROLEDESCRIPTION_MAX_LENGTH = 256;

}
