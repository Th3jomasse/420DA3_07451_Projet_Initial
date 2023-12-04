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
    public List<RoleDTO> Roles { get; set; } = new List<RoleDTO>();
    public WarehouseDTO? WarehouseWork { get; set; } = null!;

    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int PASSWORD_MIN_LENGTH = 8;
    public const int PASSWORD_MAX_LENGTH = 64;

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="UserDTO"/> avec le nom d'utilisateur, le mot de passe et l'entrepôt de travail.
    /// </summary>
    /// <param name="username">Le nom d'utilisateur.</param>
    /// <param name="passwordHash">Le mot de passe de l'utilisateur.</param>
    /// <param name="warehouseWork">L'entrepôt de travail associé.</param>
    public UserDTO(string username, string passwordHash, int? warehouseWork)
    : this(username, passwordHash) {
        this.WarehouseWork = warehouseWork.HasValue ? new WarehouseDTO { Id = warehouseWork.Value } : null;
    }

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="UserDTO"/> avec l'identifiant, le nom d'utilisateur, le mot de passe, l'identifiant de l'entrepôt, la date de création et la version de ligne.
    /// </summary>
    /// <param name="id">L'identifiant de l'utilisateur.</param>
    /// <param name="username">Le nom d'utilisateur.</param>
    /// <param name="passwordHash">Le mot de passe de l'utilisateur.</param>
    /// <param name="warehouseId">L'identifiant de l'entrepôt associé.</param>
    /// <param name="dateCreation">La date de création de l'utilisateur.</param>
    /// <param name="rowVersion">La version de ligne (optimistic concurrency control).</param>
    protected UserDTO(int id, string username, string passwordHash, int? warehouseId, DateTime dateCreation, byte[] rowVersion)
        : this(username, passwordHash, warehouseId) {
        this.Id = id;
        this.DateCreation = dateCreation;
        this.RowVersion = rowVersion;
    }
    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="UserDTO"/>.
    /// </summary>
    public UserDTO() : base() { }

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="UserDTO"/> avec le nom d'utilisateur et le mot de passe.
    /// </summary>
    /// <param name="username">Le nom d'utilisateur.</param>
    /// <param name="passwordHash">Le mot de passe de l'utilisateur.</param>
    public UserDTO(string username, string passwordHash) : base() {
        this.UserName = username;
        this.Password = passwordHash;
    }

    /// <summary>
    /// Valide la longueur du nom d'utilisateur.
    /// </summary>
    /// <param name="nameUser">Le nom d'utilisateur à valider.</param>
    /// <returns>True si la longueur est valide, sinon False.</returns>
    public static bool ValidateNameUser(string nameUser) {
        return nameUser.Length >= NAME_MIN_LENGTH && nameUser.Length <= NAME_MAX_LENGTH;
    }
    /// <summary>
    /// Valide la longueur du mot de passe de l'utilisateur.
    /// </summary>
    /// <param name="passwordUser">Le mot de passe de l'utilisateur à valider.</param>
    /// <returns>True si la longueur est valide, sinon False.</returns>
    public static bool ValidatePasswordUser(string passwordUser) {
        return passwordUser.Length >= NAME_MIN_LENGTH && passwordUser.Length <= NAME_MAX_LENGTH;
    }

    public static implicit operator UserDTO(string v) {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Retourne une représentation textuelle de l'objet utilisateur, 
    /// sous la forme de son identifiant suivi de son nom d'utilisateur.
    /// </summary>
    public override string ToString() {
        return this.Id.ToString() + " - " + this.UserName;
    }
}
