using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;

namespace _420DA3_07451_Projet_Initial.Business.Services;

public class FournisseursService : AbstractDtoService<FournisseursDTO, int>
{
    protected override FournisseursDAO Dao { get; }

    protected override ExampleDtoWindow DtoManagementWindow { get; }

    public FournisseursService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new FournisseursDAO(context);
        this.DtoManagementWindow = new ExampleDtoWindow(facade);
    }

    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
    protected override IDtoManagementView<FournisseursDTO> DtoManagementWindow
    {
        get { throw new NotImplementedException(); }
    }
    
}

