using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class AddressService : AbstractDtoService<AddressDTO, int> {
    private AbstractFacade facade;
    protected override AddressDAO Dao { get; }
    protected override AddressManagementForm DtoManagementWindow { get; }



    public AddressService(AbstractFacade facade, AbstractContext context) : base() {
        this.facade = facade;
        facade.RegisterDependent(this);
        this.Dao = new AddressDAO(context);
        this.DtoManagementWindow = new AddressManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    public List<AddressDTO> SearchAddresses(string userInput) {
        return this.Dao.Search(userInput);
    }

    public List<AddressDTO> SearchAddressesByCivicNumber(int civicNumber) {
        return this.Dao.SearchByCivicNumber(civicNumber);
    }

    public List<AddressDTO> SearchAddressesByStreetName(string streetName) {
        return this.Dao.SearchByStreet(streetName);
    }

    public AddressDTO? GetAddressById(int id) { 
        return this.Dao.GetById(id);
    }
}
