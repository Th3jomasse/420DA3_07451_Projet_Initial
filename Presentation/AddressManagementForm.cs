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
public partial class AddressManagementForm : Form, IDtoManagementView<AddressDTO> {
    private AbstractFacade facade;

    public AddressManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(AddressDTO blankInstance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(AddressDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(AddressDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(AddressDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }
}
