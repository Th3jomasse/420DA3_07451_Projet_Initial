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
    private RestockOrderDTO workingInstance = null!;
    private ViewIntentEnum viewIntent;


    public ShipOrdersManagementForm(AbstractFacade facade) {
        this.facade = facade;
        InitializeComponent();
    }
}
