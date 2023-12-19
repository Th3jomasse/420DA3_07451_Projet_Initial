using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class ClientDTO : AbstractDTO<int> {
    public const int CLIENT_NAME_MAX_LENGTH = 128;
    public const int CONTACT_NOM_MAX_LENGTH = 32;
    public const int CONTACT_PRENOM_MAX_LENGTH = 32;
    public const int CONTACT_COURRIEL_MAX_LENGTH = 128;
    public const int CONTACT_TELEPHONE_MAX_LENGTH = 15; 
    public const string COURRIEL_REGEX_PATTERN = @"^[a-zA-Z0-9\._]+@[a-zA-Z0-9_]+\.[a-zA-Z]+$";
    public const string TELEPHONE_SANITIZATION_REGEX_PATTERN = @"[^\d]+";
    public const string SANITIZED_TELEPHONE_REGEX_PATTERN = @"^[\d]{7,15}$";

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

    public static bool ValidateNomClient(string nomClient, bool optThrowExceptions = false) {
        return nomClient.Length <= CLIENT_NAME_MAX_LENGTH
            || (optThrowExceptions 
                ? throw new Exception($"Nom de client trop long: maximum {CLIENT_NAME_MAX_LENGTH} caractères.") 
                : false);
    }

    public static bool ValidateNomContact(string nomContact, bool optThrowExceptions = false) {
        return nomContact.Length <= CONTACT_NOM_MAX_LENGTH
            || (optThrowExceptions
                ? throw new Exception($"Nom de contact trop long: maximum {CONTACT_NOM_MAX_LENGTH} caractères.")
                : false);
    }

    public static bool ValidatePrenomContact(string prenomContact, bool optThrowExceptions = false) {
        return prenomContact.Length <= CONTACT_PRENOM_MAX_LENGTH
            || (optThrowExceptions
                ? throw new Exception($"Prénom de contact trop long: maximum {CONTACT_PRENOM_MAX_LENGTH} caractères.")
                : false);
    }

    public static bool ValidateCourrielContact(string courrielContact, bool optThrowExceptions = false) {
        bool isValid = true;
        if (courrielContact.Length <= CONTACT_COURRIEL_MAX_LENGTH) {
            if (optThrowExceptions) {
                throw new Exception($"Courriel de contact trop long: maximum {CONTACT_COURRIEL_MAX_LENGTH} caractères.");
            }
            isValid = false;
        }
        if (!Regex.IsMatch(courrielContact, COURRIEL_REGEX_PATTERN, RegexOptions.IgnoreCase)) {
            if (optThrowExceptions) {
                throw new Exception($"Le courriel de contact est invalide: format requis: xxx@xxx.xxx .");
            }
            isValid = false;
        }
        return isValid;
    }

    public static bool ValidateTelephoneContact(string telephoneContact, bool optThrowExceptions = false) {
        bool isValid = true;
        if (telephoneContact.Length <= CONTACT_TELEPHONE_MAX_LENGTH) {
            if (optThrowExceptions) {
                throw new Exception($"Telephone de contact trop long: maximum {CONTACT_TELEPHONE_MAX_LENGTH} caractères.");
            }
            isValid = false;
        }
        if (!Regex.IsMatch(telephoneContact, SANITIZED_TELEPHONE_REGEX_PATTERN, RegexOptions.IgnoreCase)) {
            if (optThrowExceptions) {
                throw new Exception($"Le telephone de contact est invalide: seuls des chiffres sont acceptés.");
            }
            isValid = false;
        }
        return isValid;
    }

    public static string SanitizeTelephoneString(string rawTelephoneString) {
        return Regex.Replace(rawTelephoneString, TELEPHONE_SANITIZATION_REGEX_PATTERN, "");
    }

    public override string ToString() {
        return this.Id + " - " + this.NomClient;
    }
}
