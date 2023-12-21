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
public partial class ShipmentsManagementForm : Form, IDtoManagementView<ShipmentsDTO> {
    private readonly AbstractFacade facade;
    private ShipmentsDTO workingInstance = null!;
    private ViewIntentEnum viewIntent;


    public ShipmentsManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.workingInstance = new ShipmentsDTO();
        InitializeComponent();
    }

    DialogResult IDtoManagementView<ShipmentsDTO>.OpenForCreation(ShipmentsDTO blankInstance) {
        this.workingInstance = blankInstance;
        this.viewIntent = ViewIntentEnum.Creation;
        return this.ShowDialog();
    }
    DialogResult IDtoManagementView<ShipmentsDTO>.OpenForDeletion(ShipmentsDTO instance) {
        return DialogResult.Cancel;
    }

    DialogResult IDtoManagementView<ShipmentsDTO>.OpenForEdition(ShipmentsDTO instance) {

        return this.ShowDialog();
    }

    DialogResult IDtoManagementView<ShipmentsDTO>.OpenForVisualization(ShipmentsDTO instance) {
        this.viewIntent = ViewIntentEnum.Visualization;

        return this.ShowDialog();
    }
}
