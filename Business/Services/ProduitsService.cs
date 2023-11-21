using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class ProduitsService : AbstractDtoService<ProduitsDTO, int> {

    protected override ProduitsDAO Dao { get; }

    protected override ExampleDtoWindow DtoManagementWindow { get; }

    public ProduitsService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new ProduitsDAO(context);
        this.DtoManagementWindow = new ExampleDtoWindow(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
    protected override IDtoManagementView<ProduitsDTO> DtoManagementWindow {
        get { throw new NotImplementedException(); }
    }
}
