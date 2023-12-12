﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
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
public class ProduitsService : AbstractDtoService<ProduitsDTO, int> {

    private AbstractFacade facade;
    protected override ProduitsDAO Dao { get; }

    protected override ProduitsManagementForm DtoManagementWindow { get; }

    public ProduitsService(AbstractFacade facade, AbstractContext context) {
        this.facade = facade;
        facade.RegisterDependent(this);
        this.Dao = new ProduitsDAO(context);
        this.DtoManagementWindow = new ProduitsManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    public ProduitsDTO FindProduitById(int id) {
        return this.Dao.GetById(id);
    }

    public ProduitsDTO FindProduitByCode(int code) {
        return this.Dao.GetByCode(code);
    }

    public ProduitsDTO FindProduitByNom(string nom) {
        return this.Dao.GetByNom(nom);
    }

    public ProduitsDTO FindProduitByUpc(int upc) {
        return this.Dao.GetByUpc(upc);
    }

    public List<ProduitsDTO> FindProduitByClientId(int clientId) {
        return this.Dao.GetByClientId(clientId);
    }

    public List<ProduitsDTO> FindProduitByFournisseurId(int fournisseurId) {
        return this.Dao.GetByFournisseurId(fournisseurId);
    }

    public List<ProduitsDTO> FindProduitByCodeFournisseur(int codeFournisseur) {
        return this.Dao.GetByCodeFournisseur(codeFournisseur);
    }
    public List<ProduitsDTO> GetAllProduits(int id) {
        return this.Dao.GetAllProduits();
    }

}
