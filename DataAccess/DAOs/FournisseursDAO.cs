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
    protected override AbstractContext Context { get; }

    public FournisseursDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override FournisseursDTO Create(FournisseursDTO instance)
    {
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

    public override IEnumerable<FournisseursDTO> GetAll()
    {
        return base.GetAll().Where(x => x.DateDeleted == null);
    }

    public override FournisseursDTO GetById(int id)
    {
        return base.GetById(id);
    }

    public FournisseursDTO? GetByCode(int code) {
        return this.GetAll().FirstOrDefault(x => x.CodeFournisseur == code);
    }
    public FournisseursDTO? GetByNom(string nom) {
        return this.GetAll().FirstOrDefault(x => x.NomFournisseur == nom);
    }

    public FournisseursDTO? GetByTelephone(string telephone) {
        return this.GetAll().FirstOrDefault(x => x.Telephone == telephone);
    }

    public FournisseursDTO? GetByAdresse(string adresse) {
        return this.GetAll().FirstOrDefault(x => x.Adresse == adresse);
    }
}
