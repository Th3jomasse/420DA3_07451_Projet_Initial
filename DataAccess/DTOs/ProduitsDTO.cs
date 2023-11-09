using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ProduitsDTO : AbstractDTO<int> {
    public int ProduitId { get; set; }
    public int ProduitUpc { get; set; }
    public string Nom { get; set; }
    public string Description { get; set; }
    public int ClientId { get; set; }
    public int FournisseurId { get; set; }
    public int CategorieId { get; set; }
    public int UnitesEnStock { get; set; }
    public int UnitesCommandees { get; set; }
    public int NiveauDeReappro { get; set; }
    public decimal PoidsKilo { get; set; }
    public bool Suspendu { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime DateDeleted { get; set; }

    public ProduitsDTO(string nom, string description, int upc) {
        this.Nom = nom;
        this.Description = description;
        this.ProduitUpc = upc;
    }
    public static bool ValidateUpc(int upc) {
        return upc >= UPC_MIN_LENGTH && upc <= UPC_MAX_LENGTH;
    }
    public static bool ValidateNom(string nom) {
        return nom.Length >= NOM_MIN_LENGTH && nom.Length <= NOM_MAX_LENGTH;
    }
    public static bool ValidateDescription(string description) {
        return description.Length >= DESCRIPTION_MIN_LENGTH && description.Length <= DESCRIPTION_MAX_LENGTH;
    }
   

}
