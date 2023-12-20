using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;
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
    public int FournisseurId { get; set; }
    public int CodeFournisseur { get; set; }
    public int UnitesEnStock { get; set; }
    public int NiveauDeReappro { get; set; }
    public decimal PoidsKilo { get; set; }
    public byte[] RowVersion { get; set; } = null!;
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public int ClientId { get; set; }

    public const int UPC_MIN_LENGTH = 3;
    public const int UPC_MAX_LENGTH = 50;
    public const int NOM_MIN_LENGTH = 3;
    public const int NOM_MAX_LENGTH = 50;
    public const int DESCRIPTION_MIN_LENGTH = 3;
    public const int DESCRIPTION_MAX_LENGTH = 50;

    public ProduitsDTO() { }

    // Ajouté propriété de navigation manquantes
    public ClientDTO ClientProprietaireProduit {  get; set; }
    public FournisseursDTO FournisseurProduit { get; set; }


    public List<ShipmentsDTO> Shipments { get; set; } = null!;
    public List<ShipOrdersDTO> ShipOrders { get; set; } = null!;
    public List<RestockOrderDTO> RestockOrders { get; set; } = null!;
    public List<ShippingOrderProducts> ShippingOrderProducts { get; set; } = new List<ShippingOrderProducts>();

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
    
}
