using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PIvots;
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

    /// <summary>
    /// Identifiant des roles Employé d'entrepôt.
    /// </summary>
    public const int ADMINISTRATOR_ROLE_ID = 1;
    public const int OFFICE_EMPLOYEE_ROLE_ID = 2;
    public const int WAREHOUSE_EMPLOYEE_ROLE_ID = 3;

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="RoleDTO"/> avec le nom du rôle.
    /// </summary>
    /// <param name="roleName">Le nom du rôle.</param>
    public RoleDTO(string roleName) : this() {
        this.RoleName = roleName;
    }

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="RoleDTO"/> avec le nom et la description du rôle.
    /// </summary>
    /// <param name="roleName">Le nom du rôle.</param>
    /// <param name="roleDescription">La description du rôle.</param>
    public RoleDTO(string roleName, string? roleDescription = null)
        : this(roleName) {
        this.RoleDescription = roleDescription;
    }

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="RoleDTO"/> avec l'identifiant, le nom, la description et la version de ligne du rôle.
    /// </summary>
    /// <param name="roleId">L'identifiant du rôle.</param>
    /// <param name="roleName">Le nom du rôle.</param>
    /// <param name="roleDescription">La description du rôle.</param>
    /// <param name="rowVersion">La version de ligne du rôle.</param>
    protected RoleDTO(int roleid, string roleName, string? roleDescription, byte[] rowVersion)
        : this(roleName, roleDescription) {
        this.Id = roleid;
        this.RowVersion = rowVersion;
    }
    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="RoleDTO"/>.
    /// </summary>
    public RoleDTO() : base() { }

    public List<UserRoles> UserRoles { get; set; } = new List<UserRoles>();

    /// <summary>
    /// Valide la longueur du nom du rôle.
    /// </summary>
    /// <param name="nameRole">Le nom du rôle à valider.</param>
    public static bool ValidateNameRole(string nameRole) {
        return nameRole.Length >= NAME_MIN_LENGTH && nameRole.Length <= NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Valide la longueur de la description du rôle.
    /// </summary>
    /// <param name="descriptionRole">La description du rôle à valider.</param>
    public static bool ValidateDescriptionRole(string descriptionRole) {
        return descriptionRole.Length >= ROLEDESCRIPTION_MAX_LENGTH;
    }


    public static implicit operator RoleDTO(string v) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retourne une représentation textuelle de l'objet role, 
    /// sous la forme de son identifiant suivi de son nom de role.
    /// </summary>
    public override string ToString() {
        return this.Id.ToString() + " - " + this.RoleName;
    }
    // Propriété de navigation vers les utilisateurs possédant ce rôle
    public List<UserDTO> UtilisateursPossedantRoles { get; set; } = new List<UserDTO>();
}
