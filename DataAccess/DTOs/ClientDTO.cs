using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ClientDTO : AbstractDTO<int> {
    public const int CLIENT_NAME_MAX_LENGTH = 128;
    public const int CONTACT_NOM_MAX_LENGTH = 32;
    public const int CONTACT_PRENOM_MAX_LENGTH = 32;
    public const int CONTACT_COURRIEL_MAX_LENGTH = 128;
    public const int CONTACT_TELEPHONE_MAX_LENGTH = 15;

    public string NomClient {  get; set; }
    public int AddressId { get; set; }
    public int WarehouseId { get; set; }
    public string NomPersonneContact { get; set; }
    public string PrenomPersonneContact { get; set; }
    public string CourrielPersonneContact { get; set; }
    public string TelephonePersonneContact { get; set; }
    public byte[] Version { get; set; }


    public AddressDTO ClientAddress { get; set; } = null!;

    public EntrepotDTO AssignedWarehouse { get; set; } = null!;

    public List<ProduitsDTO> ProduitsDuClient { get; set; } = new List<ProduitsDTO>();


    public ClientDTO() : base() { }


    public ClientDTO(string nomClient, int addressId, int warehouseId, string nomPersonneContact,
        string prenomPersonneContact, string courrielPersonneContact, string telephonePersonneContact) 
        : base() {
        this.NomClient = nomClient;
        this.AddressId = addressId;
        this.WarehouseId = warehouseId;
        this.NomPersonneContact = nomPersonneContact;
        this.PrenomPersonneContact = prenomPersonneContact;
        this.CourrielPersonneContact = courrielPersonneContact;
        this.TelephonePersonneContact = telephonePersonneContact;
    }


    protected ClientDTO(int id, string nomClient, int addressId, int warehouseId, string nomPersonneContact,
        string prenomPersonneContact, string courrielPersonneContact, string telephonePersonneContact,
        byte[] version) : base() {
        this.Id = id;
        this.NomClient = nomClient;
        this.AddressId = addressId;
        this.WarehouseId = warehouseId;
        this.NomPersonneContact = nomPersonneContact;
        this.PrenomPersonneContact = prenomPersonneContact;
        this.CourrielPersonneContact = courrielPersonneContact;
        this.TelephonePersonneContact = telephonePersonneContact;
        this.Version = version;
    }
}
