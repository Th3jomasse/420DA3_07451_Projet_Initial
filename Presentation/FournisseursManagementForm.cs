using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
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
public partial class FournisseursManagementForm : Form, IDtoManagementView<FournisseursDTO> {
    
    private readonly FournisseursService service;
    private readonly AbstractFacade facade;

    public FournisseursManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(FournisseursDTO blankInstance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(FournisseursDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(FournisseursDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(FournisseursDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }
}