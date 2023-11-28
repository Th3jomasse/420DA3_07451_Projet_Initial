using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public override UserDTO Create(UserDTO instance) {

        instance.DateCreation = DateTime.Now;
        return base.Create(instance);
    }
    public override UserDTO? GetById(int identifier) {
        return this.Context.GetDbSet<UserDTO>()
            .Where(user => user.Id == identifier)
            .Include(user => user.Warehouse)
            .Include(user => user.Roles)
            .SingleOrDefault();
    }
    public override List<UserDTO> GetAll() {
        return this.Context.GetDbSet<UserDTO>()
            .Include(user => user)
            .ToList();
    }
    public UserDTO? GetByUsername(string username) {
        return this.Context.GetDbSet<UserDTO>()
            .Where(user => user.UserName == username)
            .Include(user => user.Roles)
            .Include(user => user.Warehouse)
            .SingleOrDefault();
    }
}
