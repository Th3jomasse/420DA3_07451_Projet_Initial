using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class FournisseursDTO : AbstractDTO<int> {
    public string NomFournisseur { get; set; } = null!;
    public int AddresseId { get; set; }
    public string? NomResponsable { get; set; }
    public string? PrenomResponsable { get; set; }
    public string? CourrielResponsable { get; set; }
    public string TelephoneResponsable { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }


    public List<ProduitsDTO> Produits { get; set; }

    public const int NOMFOURNISSEUR_MIN_LENGTH = 3;
    public const int NOMFOURNISSEUR_MAX_LENGTH = 50;
    public const int NOMRESPONSABLE_MIN_LENGTH = 3;
    public const int NOMRESPONSABLE_MAX_LENGTH = 50;
    public const int PRENOMRESPONSABLE_MIN_LENGTH = 3;
    public const int PRENOMRESPONSABLE_MAX_LENGTH = 50;
    public const int COURRIELRESPONSABLE_MIN_LENGTH = 3;

    public FournisseursDTO(){ }

    public FournisseursDTO(string nomFournisseur, string nomResponsable, string prenomResponsable, string courrielResponsable, string telephoneResponsable) {
        this.NomFournisseur = nomFournisseur;
        this.NomResponsable = nomResponsable;
        this.PrenomResponsable = prenomResponsable;
        this.CourrielResponsable = courrielResponsable;
        this.TelephoneResponsable = telephoneResponsable;
    }

    protected FournisseursDTO(int id, string nomFournisseur,int addresseId, string nomResponsable, string prenomResponsable,
        string courrielResponsable, string telephoneResponsable, DateTime? dateCreated,
        DateTime? dateUpdated, DateTime? dateDeleted, byte[] rowVersion)
        : this(nomFournisseur, nomResponsable, prenomResponsable, courrielResponsable, telephoneResponsable)
    {
        this.Id = id;
        this.AddresseId = addresseId;
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
        return this.Id.ToString() + " - " + this.NomFournisseur + " " + this.NomResponsable + ", " + this.PrenomResponsable + " - " + this.CourrielResponsable + " - " + this.TelephoneResponsable;
    }

}

