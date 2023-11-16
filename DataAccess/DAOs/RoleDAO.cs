using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
internal class RoleDAO : AbstractDao<RoleDTO, int> {
    protected override AbstractContext Context { get; }

    public RoleDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override RoleDTO Update(RoleDTO instance) {

        instance.DateUpdate = DateTime.Now;
        return base.Update(instance);
    }

    public override RoleDTO Delete(RoleDTO instance) {

        instance.DateDelete = DateTime.Now;
        return base.Delete(instance);
    }
    public override RoleDTO Create(RoleDTO instance) {

        instance.DateCreate = DateTime.Now;
        return base.Create(instance);
    }
}
