using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ProduitsDTO : AbstractDTO<int> {
    
    public int ProduitUpc { get; set; }
    public string NomProduit { get; set; } = null!;
    public string? Description { get; set; }
    public int UserId { get; set; }
    public int FournisseurId { get; set; }
    public int CodeFournisseur { get; set; }
    public int UnitesEnStock { get; set; }
    public int NiveauDeReappro { get; set; }
    public decimal PoidsKilo { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }

    public const int UPC_MIN_LENGTH = 3;
    public const int UPC_MAX_LENGTH = 50;
    public const int NOM_MIN_LENGTH = 3;
    public const int NOM_MAX_LENGTH = 50;
    public const int DESCRIPTION_MIN_LENGTH = 3;
    public const int DESCRIPTION_MAX_LENGTH = 50;

    public ProduitsDTO(string nom, string description, int upc)
    {
        this.NomProduit = nom;
        this.Description = description;
        this.ProduitUpc = upc;
    }
    protected ProduitsDTO(int id, int upc, string nom, string description, int unitesEnStock, int niveauDeReappro, decimal poids, DateTime? dateCreated,
        DateTime? dateUpdated, DateTime? dateDeleted, byte[] rowVersion) 
        : this(nom, description, upc){
        this.Id = id;
        this.UnitesEnStock = unitesEnStock;
        this.NiveauDeReappro = niveauDeReappro;
        this.PoidsKilo = poids;
        this.DateCreated = dateCreated;
        this.DateUpdated = dateUpdated;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
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
    public override string ToString() {
        return this.Id.ToString() + " - " + this.NomProduit;
    }

    public override string ToInsert()
    {
        return $"INSERT INTO Produits (ProduitUpc, NomProduit, Description, ClientId, FournisseurId, CodeFournisseur, UnitesEnStock, NiveauDeReappro, PoidsKilo, RowVersion, DateCreated, DateUpdated, DateDeleted) " +
            $"VALUES ({this.ProduitUpc}, '{this.NomProduit}', '{this.Description}', {this.ClientId}, {this.FournisseurId}, {this.CodeFournisseur}, {this.UnitesEnStock}, {this.NiveauDeReappro}, {this.PoidsKilo}, {this.RowVersion}, {this.DateCreated}, {this.DateUpdated}, {this.DateDeleted})";
    }

    public override string ToUpdate() {
        return $"UPDATE Produits SET ProduitUpc = {this.ProduitUpc}, NomProduit = '{this.NomProduit}', Description = '{this.Description}', ClientId = {this.ClientId}, FournisseurId = {this.FournisseurId}, CodeFournisseur = {this.CodeFournisseur}, UnitesEnStock = {this.UnitesEnStock}, NiveauDeReappro = {this.NiveauDeReappro}, PoidsKilo = {this.PoidsKilo}, RowVersion = {this.RowVersion}, DateCreated = {this.DateCreated}, DateUpdated = {this.DateUpdated}, DateDeleted = {this.DateDeleted} " +
            $"WHERE ProduitId = {this.Id}";
    }

    public override string ToDelete() {
        return $"DELETE FROM Produits WHERE ProduitId = {this.Id}";
    }

    public override string ToSelect() {
        return $"SELECT * FROM Produits WHERE ProduitId = {this.Id}";
    }

    public override string ToSelectAll() {
        return $"SELECT * FROM Produits";
    }

    public override string ToSelectLast() {
        return $"SELECT TOP 1 * FROM Produits ORDER BY ProduitId DESC";
    }

    public override string ToSelectByForeignKey() {
        return $"SELECT * FROM Produits WHERE FournisseurId = {this.FournisseurId}";
    }

    public override string ToSelectByForeignKey2() {
        return $"SELECT * FROM Produits WHERE ClientId = {this.ClientId}";
    }

    public override string ToSelectByForeignKey3() {
        return $"SELECT * FROM Produits WHERE CodeFournisseur = {this.CodeFournisseur}";
    }

}
