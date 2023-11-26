using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class RoleManagementForm : Form, IDtoManagementView<RoleDTO> {
    private readonly AbstractFacade facade;
    private RoleDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public RoleManagementForm() {
        this.facade = facade;
        // création d'une instance de DTO vide juste pour garantir qu'il y aura quelque chose
        // dans le champ associé et éviter de devoir dealer avec un type nullable.
        this.workingDtoInstance = new RoleDTO("", null);
        InitializeComponent();
    }

    public DialogResult OpenForCreation(RoleDTO blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(RoleDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(RoleDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(RoleDTO instance) {
        throw new NotImplementedException();
    }
}
