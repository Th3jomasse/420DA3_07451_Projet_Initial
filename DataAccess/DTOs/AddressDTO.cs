using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class AddressDTO : AbstractDTO<int> {
    private const string POSTALCODE_REGEX_PATTERN = @"^[a-zA-Z]{1}[\d]{1}[a-zA-Z]{1}[\s]*[\d]{1}[a-zA-Z]{1}[\d]{1}$";
    public const int STREET_MAX_LENGTH = 128;
    public const int CITY_MAX_LENGTH = 85; // Fun fact, the place with the longest name in the world (85 chars) is a hill in northern New Zealand.
    public const int PROVINCE_MAX_LENGTH = 64;
    public const int COUNTRY_MAX_LENGTH = 64;
    public const int POSTALCODE_MAX_LENGTH = 15;


    // Data Properties
    public int CivicNumber { get; set; }
    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Province { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public byte[] Rowversion { get; set; } = null!;

    // Navigation Properties
    public FournisseursDTO? FournisseurAssocie { get; set; }
    public EntrepotDTO? WarehouseAssociee { get; set; }
    public ClientDTO? ClientAssocie { get; set; }


    #region Constructors

    public AddressDTO() { }

    public AddressDTO(int civicNumber, string street, string city, string province, 
        string country, string postalCode) {
        this.CivicNumber = civicNumber;
        this.Street = street;
        this.City = city;
        this.Province = province;
        this.Country = country;
        this.PostalCode = postalCode;
    }


    public AddressDTO(int id, int civicNumber, string street, string city, string province, 
        string country, string postalCode, byte[] rowversion) {
        this.Id = id;
        this.CivicNumber = civicNumber;
        this.Street = street;
        this.City = city;
        this.Province = province;
        this.Country = country;
        this.PostalCode = postalCode;
        this.Rowversion = rowversion;
    }

    #endregion


    #region Validation Methods

    public static bool ValidateCivicNumber(int civicNumber, bool optThrowExceptions = false) {
        try {
            return civicNumber < 1 ? throw new Exception("Civic number value cannot be 0 or less.") : true;
        } catch (Exception ex) {
            return optThrowExceptions 
                ? throw new Exception("Invalid civic integer.", ex) 
                : false;
        }
    }

    public static bool ValidateStreet(string street, bool optThrowExceptions = false) {
        try {
            return street.Length > STREET_MAX_LENGTH
                ? throw new Exception($"Street string length is over {STREET_MAX_LENGTH} characters.")
                : true;
        } catch (Exception ex) {
            return optThrowExceptions
                ? throw new Exception("Invalid street string.", ex)
                : false;
        }
    }

    public static bool ValidateCity(string city, bool optThrowExceptions = false) {
        try {
            return city.Length > CITY_MAX_LENGTH ? throw new Exception($"City string length is over {CITY_MAX_LENGTH} characters.") : true;
        } catch (Exception ex) {
            return optThrowExceptions
                ? throw new Exception("Invalid city string.", ex)
                : false;
        }
    }

    public static bool ValidateProvince(string province, bool optThrowExceptions = false) {
        try {
            return province.Length > PROVINCE_MAX_LENGTH
                ? throw new Exception($"Province string length is over {PROVINCE_MAX_LENGTH} characters.")
                : true;
        } catch (Exception ex) {
            return optThrowExceptions
                ? throw new Exception("Invalid province string.", ex)
                : false;
        }
    }

    public static bool ValidateCountry(string country, bool optThrowExceptions = false) {
        try {
            return country.Length > COUNTRY_MAX_LENGTH
                ? throw new Exception($"Country string length is over {COUNTRY_MAX_LENGTH} characters.")
                : true;
        } catch (Exception ex) {
            return optThrowExceptions
                ? throw new Exception("Invalid country string.", ex)
                : false;
        }
    }

    public static bool ValidatePostalCode(string postalCode, bool optThrowExceptions = false) {
        RegexStringValidator postalCodeValidator = new RegexStringValidator(POSTALCODE_REGEX_PATTERN);
        try {
            if (postalCode.Length > POSTALCODE_MAX_LENGTH) {
                throw new Exception($"Postal code string length is over {POSTALCODE_MAX_LENGTH} characters.");
            }
            try {
                postalCodeValidator.Validate(postalCode);
                return true;
            } catch (ArgumentException argEx) {
                throw new Exception("Invalid postal code does not match pattern [A#A #A#].", argEx);
            }
        } catch (Exception ex) {
            return optThrowExceptions ? throw new Exception("Invalid postal code.", ex) : false;
        }
    }

    #endregion


    public override string ToString() {
        return this.CivicNumber.ToString() 
            + " " + this.Street 
            + ", " + this.City 
            + ", " + this.Province 
            + ", " + this.Country 
            + ", " + this.PostalCode;
    }
}
