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
    public byte[] RowVersion { get; set; } = null;
    public RoleDTO RoleId { get; set; }
    public DateTime? DateCreation { get; set; }
    public DateTime? DateUpdate { get; set; }
    public DateTime? DateDelete { get; set; }

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 64;

    public UserDTO(string nameUser, string passwordUser, string roleId, byte[] rowVersion) {
        this.UserName = nameUser;
        this.Password = passwordUser;
        this.RoleId = roleId;
        this.RowVersion = rowVersion;
    }

    public static bool ValidateNameUser(string nameUser) {
        return nameUser.Length >= NAME_MIN_LENGTH && nameUser.Length <= NAME_MAX_LENGTH;
    }
    public static bool ValidatePasswordUser(string passwordUser) {
        return passwordUser.Length >= NAME_MIN_LENGTH && passwordUser.Length <= NAME_MAX_LENGTH;
    }

    public static implicit operator UserDTO(string v) {
        throw new NotImplementedException();
    }
    public override string ToString() {
        return this.UserId.ToString() + " - " + this.UserName + " = " + this.Password + " = " + this.RoleId + " = " + this.DateCreation + " = " + this.DateUpdate + " = " + this.DateDelete;
    }
}
