using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class ProduitsDAO : AbstractDao<ProduitsDTO, int> {
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
    private IEnumerable<ProduitsDTO> GetAll() {
        return base.GetAll().Where(x => x.DateDeleted == null);
    }

    public override ProduitsDTO GetById(int id)
    {
        return base.GetById(id);
    }
    
    public ProduitsDTO? GetByNom(string nom) {
        return this.GetAll().FirstOrDefault(x => x.NomProduit == nom);
    }

    public ProduitsDTO? GetByUpc(int upc) {
        return this.GetAll().FirstOrDefault(x => x.ProduitUpc == upc);
    }

    public ProduitsDTO? GetByFournisseurId(int fournisseurId) {
        return this.GetAll().FirstOrDefault(x => x.FournisseurId == fournisseurId);
    }

    public ProduitsDTO? GetByCodeFournisseur(int codeFournisseur) {
        return this.GetAll().FirstOrDefault(x => x.CodeFournisseur == codeFournisseur);
    }
}
