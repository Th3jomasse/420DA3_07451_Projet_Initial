using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class UserDTO : AbstractDTO<int> {

    public string UserName { get; set; } = null!;
    public string Password { get; set; }
    public byte[]? RowVersion { get; set; } = null;
    public DateTime? DateCreation { get; set; }
    public int? Warehouse { get; set; }
    public WarehouseDTO WarehouseId { get; set; }
    public List<RoleDTO> Roles { get; set; } = null!;
    public WarehouseDTO? WarehouseWork { get; set; } = null!;

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 64;

    public UserDTO(string username, string passwordHash, int? warehouseWork)
        : this(username, passwordHash) {
        this.WarehouseWork = warehouseWork;
    }
    protected UserDTO(int id, string username, string passwordHash, int? warehouseId, DateTime dateCreation, byte[] rowVersion)
        : this(username, passwordHash, warehouseId) {
        this.Id = id;
        this.DateCreation = dateCreation;
        this.RowVersion = rowVersion;
    }
    public UserDTO() : base() { }

    public UserDTO(string username, string passwordHash) : base() {
        this.UserName = username;
        this.Password = passwordHash;
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
        return this.Id.ToString() + " - " + this.UserName;
    }
}
