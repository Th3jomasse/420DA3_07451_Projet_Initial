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
    public string Password { get; set; }
    public byte[]? RowVersion { get; set; } = null;
    public RoleDTO RoleId { get; set; }
    public DateTime? DateCreation { get; set; }
    public WarehouseDTO Warehouse { get; set; }
    public WarehouseDTO Id { get; set; }

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 64;

    public UserDTO(string nameUser, string passwordUser, int userId, WarehouseDTO warehouse, WarehouseDTO id) {
        this.UserName = nameUser;
        this.Password = passwordUser;
        this.UserId = userId;
        this.Warehouse = warehouse;
        this.Id = id;
    }
    protected UserDTO(int userId, string userName, string passWord, byte[] rowVersion)
        : this(userName, passWord, userId) {
        this.UserId = userId;
        this.RowVersion = rowVersion;
    }
    public UserDTO() : base() { }

    public UserDTO(string userName, string passWord, int userId) {
        this.UserName = userName;
        this.Password = passWord;
        this.UserId = userId;
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
        return this.UserId.ToString() + " - " + this.UserName;
    }
}
