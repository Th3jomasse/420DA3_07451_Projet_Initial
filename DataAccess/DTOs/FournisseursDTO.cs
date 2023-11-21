using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class FournisseursDTO : AbstractDTO<int> {
    public int FournisseurId { get; set; }
    public string NomFournisseur { get; set; } = null!;
    public int AdresseId { get; set; }
    public string? NomResponsable { get; set; }
    public string? PrenomResponsable { get; set; }
    public string? CourrielResponsable { get; set; }
    public string? TelephoneResponsable { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }

    public const int NOMFOURNISSEUR_MIN_LENGTH = 3;
    public const int NOMFOURNISSEUR_MAX_LENGTH = 50;
    public const int NOMRESPONSABLE_MIN_LENGTH = 3;
    public const int NOMRESPONSABLE_MAX_LENGTH = 50;
    public const int PRENOMRESPONSABLE_MIN_LENGTH = 3;
    public const int PRENOMRESPONSABLE_MAX_LENGTH = 50;

    public FournisseursDTO(){ }

    public FournisseursDTO(string nomFournisseur, string nomResponsable, string prenomResponsable, string courrielResponsable, string telephoneResponsable) {
        this.NomFournisseur = nomFournisseur;
        this.NomResponsable = nomResponsable;
        this.PrenomResponsable = prenomResponsable;
        this.CourrielResponsable = courrielResponsable;
        this.TelephoneResponsable = telephoneResponsable;
    }

    protected FournisseursDTO(int id, string nomFournisseur,int adresseId, string nomResponsable, string prenomResponsable,
        string courrielResponsable, string telephoneResponsable, DateTime? dateCreated,
        DateTime? dateUpdated, DateTime? dateDeleted, byte[] rowVersion)
        : this(nomFournisseur, nomResponsable, prenomResponsable, courrielResponsable, telephoneResponsable)
    {
        this.FournisseurId = id;
        this.AdresseId = adresseId;
        this.DateCreated = dateCreated;
        this.DateUpdated = dateUpdated;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    public static bool ValidateNomFournisseur(string nomFournisseur) {
        return nomFournisseur.Length >= NOMFOURNISSEUR_MIN_LENGTH && nomFournisseur.Length <= NOMFOURNISSEUR_MAX_LENGTH;
    }
    public static bool ValidateNomResponsable(string nomResponsable) {
        return nomResponsable.Length >= NOMRESPONSABLE_MIN_LENGTH && nomResponsable.Length <= NOMRESPONSABLE_MAX_LENGTH;
    }
    public static bool ValidatePrenomResponsable(string prenomResponsable) {
        return prenomResponsable.Length >= PRENOMRESPONSABLE_MIN_LENGTH && prenomResponsable.Length <= PRENOMRESPONSABLE_MAX_LENGTH;
    }
    public override string ToString() {
        return this.Id.ToString() + " - " + this.NomFournisseur;
    }
    public override string ToInsert()
    {
        return $"INSERT INTO Fournisseurs (NomFournisseur, NomResponsable, PrenomResponsable, CourrielResponsable, TelephoneResponsable) " +
               $"VALUES ('{this.NomFournisseur}', '{this.NomResponsable}', '{this.PrenomResponsable}', '{this.CourrielResponsable}', '{this.TelephoneResponsable}')";
    }           


}

