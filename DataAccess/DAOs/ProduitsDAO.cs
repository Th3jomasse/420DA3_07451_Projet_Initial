using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ProduitsDAO : AbstractDao<ProduitsDTO, int> {
    private AbstractFacade context;
    protected override AbstractContext Context { get; }

    public ProduitsDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override ProduitsDTO Create(ProduitsDTO instance)
    {
        instance.DateCreated = DateTime.Now;
        return base.Create(instance);
    }

    public override ProduitsDTO Update(ProduitsDTO instance) {
        instance.DateUpdated = DateTime.Now;
        return base.Update(instance);
    }

    public override ProduitsDTO Delete(ProduitsDTO instance) {
        instance.DateDeleted = DateTime.Now;
        return base.Delete(instance);
    }
    public override List<ProduitsDTO> GetAll() {
        return this.Context.GetDbSet<ProduitsDTO>()
            .ToList();
    }

    public override ProduitsDTO GetById(int id)
    {
        return this.GetAll().FirstOrDefault(x => x.Id == id);
    }
    
    public ProduitsDTO? GetByNom(string nom) {
        return this.GetAll().FirstOrDefault(x => x.NomProduit == nom);
    }

    public ProduitsDTO? GetByUpc(int upc) {
        return this.GetAll().FirstOrDefault(x => x.ProduitUpc == upc);
    }

    public List<ProduitsDTO> GetByFournisseurId(int fournisseurId) {
        return this.GetAll().Where(x => x.FournisseurId == fournisseurId).ToList();
    }

    public List<ProduitsDTO> GetByCodeFournisseur(int codeFournisseur) {
        return this.GetAll().Where(x => x.CodeFournisseur == codeFournisseur).ToList();
    }

    public List<ProduitsDTO> SearchProducts(string filter) {
        return this.Context.GetDbSet<ProduitsDTO>()
            .Include(produit => produit.ClientProprietaireProduit)
                .ThenInclude(client => client.AssignedWarehouse)
            .Include(produit => produit.FournisseurProduit)
            .Where(produit => 
                produit.Id.ToString().StartsWith(filter)
                || produit.NomProduit.StartsWith(filter) 
                || produit.ProduitUpc.ToString().StartsWith(filter) 
                || produit.CodeFournisseur.ToString().StartsWith(filter))
            .ToList();
    }
}
