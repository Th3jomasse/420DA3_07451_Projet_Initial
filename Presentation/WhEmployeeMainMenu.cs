﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
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
public partial class WhEmployeeMainMenu : Form {
    private AbstractFacade ParentFacade { get; set; }

    public WhEmployeeMainMenu(AbstractFacade parentFacade) {
        this.ParentFacade = parentFacade;
        this.InitializeComponent();
    }
}
