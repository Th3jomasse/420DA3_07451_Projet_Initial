using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class UserDAO: AbstractDao<UserDTO, int> {
    protected override AbstractContext Context { get; }

    public UserDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override UserDTO Update(UserDTO instance) {

        instance.DateUpdate = DateTime.Now;
        return base.Update(instance);
    }

    public override UserDTO Delete(UserDTO instance) {

        instance.DateDelete = DateTime.Now;
        return base.Delete(instance);
    }
}
