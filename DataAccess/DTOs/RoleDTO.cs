using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class RoleDTO : AbstractDTO<int> {

    public string RoleName { get; set; } = null!;
    public string RoleDescription { get; set; } = null!;
    public byte[]? RowVersion { get; set; } = null;
    public List<UserDTO> UtilisateursPossedantRole { get; set; } = null!;

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int ROLEDESCRIPTION_MAX_LENGTH = 256;

    public const int ADMINISTRATOR_ROLE_ID = 1;
    public const int OFFICE_EMPLOYEE_ROLE_ID = 2;
    public const int WAREHOUSE_EMPLOYEE_ROLE_ID = 3;

    public RoleDTO(string roleName) : this() {
        this.RoleName = roleName;
    }
    public RoleDTO(string roleName, string? roleDescription = null)
        : this(roleName) {
        this.RoleDescription = roleDescription;
    }
    protected RoleDTO(int roleid, string roleName, string? roleDescription, byte[] rowVersion)
        : this(roleName, roleDescription) {
        this.Id = roleid;
        this.RowVersion = rowVersion;
    }
    public RoleDTO() : base() { }

    public static bool ValidateNameRole(string nameRole) {
        return nameRole.Length >= NAME_MIN_LENGTH && nameRole.Length <= NAME_MAX_LENGTH;
    }

    public static bool ValidateDescriptionRole(string descriptionRole) {
        return descriptionRole.Length >= ROLEDESCRIPTION_MAX_LENGTH;
    }

    public static implicit operator RoleDTO(string v) {
        throw new NotImplementedException();
    }
    public override string ToString() {
        return this.RoleId.ToString() + " - " + this.RoleName;
    }
}
