using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class UserDTO : AbstractDTO<int> {

    public string UserName { get; set; } = null!;
    public string Password { get; set; }
    public byte[]? RowVersion { get; set; } = null;
    public DateTime? DateCreation { get; set; }
    public WarehouseDTO Warehouse { get; set; }
    public WarehouseDTO Id { get; set; }

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 64;

    public UserDTO(string username, string passwordHash, int? warehouseId)
        : this(username, passwordHash) {
        this.Id = warehouseId;
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
        return this.UserId.ToString() + " - " + this.UserName;
    }
}
