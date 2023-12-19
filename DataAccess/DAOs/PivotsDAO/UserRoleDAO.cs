using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.PivotsDTO;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs.PivotsDAO;
    public class UserRoleDAO {

        private readonly AppDbContext context;

        public UserRoleDAO(AppDbContext context) {
            this.context = context;
        }

        public UserRoles? GetUserRoleById(int userId, int roleId) {
            return this.context.UserRoles
                .Where(ur => ur.UserId == userId && ur.RoleId == roleId)
                .SingleOrDefault();
        }

        public UserRoles CreateUserRoles(UserRoles userRoles) {
            this.context.UserRoles.Add(userRoles);
            this.context.SaveChanges();
            return userRoles;
        }

        public UserRoles UpdateUserRoles(UserRoles userRoles) {
            this.context.UserRoles.Update(userRoles);
            this.context.SaveChanges();
            return userRoles;
        }

        public UserRoles DeleteUserRoles(UserRoles userRoles) {
            this.context.UserRoles.Remove(userRoles);
            this.context.SaveChanges();
            return userRoles;
        }
    }

