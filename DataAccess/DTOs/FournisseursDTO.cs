using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class FournisseursDTO : AbstractDTO<int> {
    public int FournisseurId { get; set; }
    public string NomFournisseur { get; set; }
    public string AdresseId { get; set; }
    public string NomResponsable { get; set; }
    public string PrenomResponsable { get; set; }
    public string TelephoneResponsable { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }


    public FournisseursDTO(string nomFournisseur, string nomResponsable, string prenomResponsable) {
        this.NomFournisseur = nomFournisseur;
        this.NomResponsable = nomResponsable;
        this.PrenomResponsable = prenomResponsable;
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


}

