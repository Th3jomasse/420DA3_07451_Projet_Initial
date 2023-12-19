using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts;
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
internal class EntrepotService : AbstractDtoService<EntrepotDTO, int> {
    private AbstractFacade ParentFacade { get; set; }
    protected override EntrepotDAO Dao { get; }

    protected override EntrepotManagementForm DtoManagementWindow { get; }

    public EntrepotService(AbstractFacade facade, AppDbContext context) {
        facade.RegisterDependent(this);
        this.ParentFacade = facade;
        this.Dao = new EntrepotDAO(context);
        this.DtoManagementWindow = new EntrepotManagementForm(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }

    public List<EntrepotDTO> GetAllEntrepots() {
        return this.Dao.GetAll();
    }

    public List<EntrepotDTO> SearchEntrepots(string filter) {
        return this.Dao.SearchEntrepots(filter);
    }

}
