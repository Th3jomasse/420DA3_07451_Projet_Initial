using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
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
internal partial class EntrepotManagementForm : Form, IDtoManagementView<EntrepotDTO> {
    private AbstractFacade ParentFacade { get; set; }

    public EntrepotManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(EntrepotDTO blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(EntrepotDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(EntrepotDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(EntrepotDTO instance) {
        throw new NotImplementedException();
    }
}
