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

public class FournisseursService : AbstractDtoService<FournisseursDTO, int> {

    private AbstractFacade facade;
    protected override FournisseursDAO Dao { get; }

    protected override FournisseursManagementForm DtoManagementWindow { get; }

    public FournisseursService(AbstractFacade facade, AbstractContext context) : base() {
        this.facade = facade;
        facade.RegisterDependent(this);
        this.Dao = new FournisseursDAO(context);
        this.DtoManagementWindow = new FournisseursManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    public List<FournisseursDTO> FindAllFournisseurs() {
        return this.Dao.GetAll();
    }

    public FournisseursDTO? FindFournisseurById(int id) {
        return this.Dao.GetById(id);
    }

    public FournisseursDTO? FindFournisseurByNom(string nom) {
        return this.Dao.GetByNom(nom);
    }

    public List<FournisseursDTO> FindFournisseurByTel(string telephone) {
        return this.Dao.GetByTelephone(telephone);
    }

    public List<FournisseursDTO> FindFournisseurByAddresse(int addresseId) {
        return this.Dao.GetByAddresse(addresseId.ToString());
    }
}