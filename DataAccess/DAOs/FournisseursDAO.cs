using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Facades;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;

public class FournisseursDAO : AbstractDao<FournisseursDTO, int> {
    private AbstractFacade context;

    protected override AbstractContext Context { get; }

    public FournisseursDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override FournisseursDTO Create(FournisseursDTO instance) {
        instance.DateCreated = DateTime.Now;
        return base.Create(instance);
    }

    public override FournisseursDTO Update(FournisseursDTO instance) {
        instance.DateUpdated = DateTime.Now;
        return base.Update(instance);
    }

    public override FournisseursDTO Delete(FournisseursDTO instance) {
        instance.DateDeleted = DateTime.Now;
        return base.Delete(instance);
    }

    private IEnumerable<FournisseursDTO> GetAll() {
        return base.GetAll().Where(x => x.DateDeleted == null);
    }


    public override FournisseursDTO GetById(int id) {
        return base.GetById(id);
    }

    public FournisseursDTO? GetByNom(string nom) {
        return this.GetAll().FirstOrDefault(x => x.NomFournisseur == nom);
    }

    public List<FournisseursDTO> GetByTelephone(string telephone) {
        return this.Context.GetDbSet<FournisseursDTO>()
            .Where(tel =>
                tel.TelephoneResponsable.Contains(telephone)
            ).ToList();
    }

    public List<FournisseursDTO> GetByAddresse(string userInput) {
        List<AddressDTO> addresses = AddressService.SearchAddresses(userInput);
        List<FournisseursDTO> fournisseurs = new List<FournisseursDTO>();
        FournisseursService FournisseursService = new FournisseursService(this.context);
        foreach (AddressDTO addresse in addresses) {
            FournisseursDTO? fournisseur = FournisseursService.FindFournisseurByAddresse(addresse.Id);
            if (fournisseur != null) {
                fournisseurs.Add(fournisseur);
            }
        }
        return fournisseurs;
    }
}



