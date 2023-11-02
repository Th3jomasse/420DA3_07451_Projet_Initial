using _420DA3_07451_Projet_Initial.DataAccess.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;

[NotMapped]
public class ExampleDTO : IDto<int> {
    public const int NAME_MIN_LENGTH = 4;
    public const int NAME_MAX_LENGTH = 64;
    public const int DESCRIPTION_MAX_LENGTH = 256;

    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;



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

    public int GetId() {
        return this.Id;
    }

    public static bool ValidateName(string name) {
        return name.Length >= NAME_MIN_LENGTH && name.Length <= NAME_MAX_LENGTH;
    }

    public static bool ValidateDescription(string? description) {
        return description is null || description.Length <= DESCRIPTION_MAX_LENGTH;
    }

    public override string ToString() {
        return this.Id.ToString() + " " + this.Name;
    }
}
