using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class AddressDAO : AbstractDao<AddressDTO, int> {
    protected override AbstractContext Context { get; }

    public AddressDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public List<AddressDTO> Search(string userInput) {
        // split user input in words
        List<string> words = userInput.Split(' ').ToList();
        List<AddressDTO> results = new List<AddressDTO>();

        // for each word
        foreach (string word in words) {
            int numericValue;
            // try to parse it as an int
            if (int.TryParse(word, out numericValue)) {
                // if parse is successful (word is numeric):
                // try to get the address with that number as an id and add to the results
                AddressDTO? adressIdFound = this.GetById(numericValue);
                if (adressIdFound != null) {
                    results.Add(adressIdFound);
                }
                // search addresses by civic number with that number and add to the results
                results = results.Union(this.SearchByCivicNumber(numericValue)).ToList();
            } else {
                // parse failed (word is non numeric)
                // search addesses by street name with that word and add to the results
                results = results.Union(this.SearchByStreet(word)).ToList();

            }
        }
        return results;
    }

    public List<AddressDTO> QuickSearch(string filter) {
        return this.Context.GetDbSet<AddressDTO>()
            .Where(addr =>
                addr.CivicNumber.ToString().StartsWith(filter)
                || addr.Id.ToString().StartsWith(filter)
                || addr.Street.StartsWith(filter)
                || addr.City.StartsWith(filter)
                || addr.Province.StartsWith(filter)
                || addr.Country.StartsWith(filter)
            ).ToList();
    }

    public List<AddressDTO> SearchByCivicNumber(int civicNumber) {
        return this.Context.GetDbSet<AddressDTO>()
            .Where(addr => 
                addr.CivicNumber.ToString().StartsWith(civicNumber.ToString())
            ).ToList();
    }

    public List<AddressDTO> SearchByStreet(string streetName) {
        return this.Context.GetDbSet<AddressDTO>()
            .Where(addr =>
                addr.Street.Contains(streetName)
            ).ToList();
    }
}
