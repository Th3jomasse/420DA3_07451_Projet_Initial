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

    public override FournisseursDTO Update(FournisseursDTO instance) {
        instance.DateUpdated = DateTime.Now;
        return base.Update(instance);
    }

    public override FournisseursDTO Delete(FournisseursDTO instance) {
        instance.DateDeleted = DateTime.Now;
        return base.Delete(instance);
    }
}
