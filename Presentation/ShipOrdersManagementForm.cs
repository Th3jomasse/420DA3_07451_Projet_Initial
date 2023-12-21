using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Enums;
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
public partial class ShipOrdersManagementForm : Form, IDtoManagementView<ShipOrdersDTO> {
    private readonly AbstractFacade facade;
    private ShipOrdersDTO workingInstance = null!;
    private ViewIntentEnum viewIntent;


    public ShipOrdersManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.workingInstance = new ShipOrdersDTO();
        InitializeComponent();
    }

    DialogResult IDtoManagementView<ShipOrdersDTO>.OpenForCreation(ShipOrdersDTO blankInstance) {
        this.workingInstance=blankInstance;
        this.viewIntent = ViewIntentEnum.Creation;
     return this.ShowDialog();
    }
    DialogResult IDtoManagementView<ShipOrdersDTO>.OpenForDeletion(ShipOrdersDTO instance) {
        _ = MessageBox.Show("Cette action n'est pas autorisée.");
        return DialogResult.Cancel;
    }

    DialogResult IDtoManagementView<ShipOrdersDTO>.OpenForEdition(ShipOrdersDTO instance) {

        return this.ShowDialog();
    }

    DialogResult IDtoManagementView<ShipOrdersDTO>.OpenForVisualization(ShipOrdersDTO instance) {
        this.viewIntent = ViewIntentEnum.Visualization;

        return this.ShowDialog();
    }

}