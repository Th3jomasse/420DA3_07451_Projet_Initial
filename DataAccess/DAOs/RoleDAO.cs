using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class RoleDAO : AbstractDao<RoleDTO, int> {
    protected override AbstractContext Context { get; }

    public RoleDAO(AbstractContext context) : base() {
        this.Context = context;
    }

    public override RoleDTO? GetById(int identifier) {
        return this.Context.GetDbSet<RoleDTO>()
            .Where(role => role.Id == identifier)
            .SingleOrDefault();
    }
    public override List<RoleDTO> GetAll() {
        return this.Context.GetDbSet<RoleDTO>()
            .ToList();
    }
    public RoleDTO? GetByRoleName(string nameRole) {
        return this.Context.GetDbSet<RoleDTO>()
            .Where(role => role.RoleName == nameRole)
            .SingleOrDefault();
    }
    public RoleDTO GetAdminRole() {
        return this.GetById(RoleDTO.ADMINISTRATOR_ROLE_ID) ?? throw new Exception("Le Role d'administrateur n'existe pas.");
    }

    public RoleDTO GetOfficeEmployeeRole() {
        return this.GetById(RoleDTO.OFFICE_EMPLOYEE_ROLE_ID) ?? throw new Exception("Le Role d'employé de bureau n'existe pas.");
    }

    public RoleDTO GetWarehouseEmployeeRole() {
        return this.GetById(RoleDTO.WAREHOUSE_EMPLOYEE_ROLE_ID) ?? throw new Exception("Le Role d'employe d'entrepôt n'existe pas.");
    }

    public List<RoleDTO> SearchRole(string userInput) {
        return this.Context.GetDbSet<RoleDTO>().Where(
                role => role.RoleName.StartsWith(userInput)
                || (role.RoleDescription != null && role.RoleDescription.StartsWith(userInput))
            ).ToList();
    }
}
