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
internal partial class ClientManagementForm : Form, IDtoManagementView<ClientDTO> {
    private AbstractFacade ParentFacade { get; set; }

    public ClientManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(ClientDTO blankInstance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(ClientDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(ClientDTO instance) {
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(ClientDTO instance) {
        throw new NotImplementedException();
    }
}
