using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

/// <summary>
/// Exemple d'entité
/// </summary>
public class ExampleDTO : AbstractDTO<int> {
    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int DESCRIPTION_MAX_LENGTH = 256;

    // NOTEZ LA PROPRIÉTÉ Id MANQUANTE:
    // ELLE EST DÉFINIE DANS LA CLASSE-PARENT AbstractDTO
    // ET EST HÉRITÉE PAR ExampleDTO

    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    public ExampleDTO() { }

    public ExampleDTO(string name, string? description) {
        this.Name = name;
        this.Description = description;
    }

    protected ExampleDTO(int id, string name, string? description, DateTime? dateCreated,
        DateTime? dateUpdated, DateTime? dateDeleted, byte[] rowVersion)
        : this(name, description) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateUpdated = dateUpdated;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Méthode de validation de données.
    /// </summary>
    /// <param name="name">Valeur pour la propriété <see cref="ExampleDTO.Name"/> de l'entité à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateName(string name) {
        return name.Length >= NAME_MIN_LENGTH && name.Length <= NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Méthode de validation de données.
    /// </summary>
    /// <param name="description">Valeur pour la propriété <see cref="ExampleDTO.Description"/> de l'entité à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateDescription(string? description) {
        return description is null || description.Length <= DESCRIPTION_MAX_LENGTH;
    }

    /// <summary>
    /// Méthode de génération de string représentant l'instance.
    /// </summary>
    /// <remarks>
    /// Cette méthode est notamment utilisée par le controle graphique <see cref="ListBox"/> pour afficher
    /// le texte des items dans le contrôle.
    /// </remarks>
    /// <returns>L'identifiant et le nom de l'instance dans un <see cref="string"/>.</returns>
    public override string ToString() {
        return this.Id.ToString() + " - " + this.Name;
    }
}
