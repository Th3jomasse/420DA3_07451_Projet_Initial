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
public partial class ProduitsManagementForm : Form, IDtoManagementView<ProduitsDTO> {
    private readonly ProduitsService service;
    private readonly AbstractFacade facade;
    public ProduitsManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.service = facade.GetService<ProduitsService>();
        this.InitializeComponent();
        this.RefreshList();
    }

    private void RefreshList() {
        object selected = this.dataGridViewProduits.SelectedRows;
        this.dataGridViewProduits.Rows.Clear();
        this.dataGridViewProduits.Rows.AddRange(this.service.GetAllProduits().ToArray());
        this.dataGridViewProduits.SelectedRows = (DataGridViewSelectedRowCollection) selected;
        this.dataGridViewProduits.Refresh();
    }

    private void buttonNew_Click(object sender, EventArgs e) {
        ProduitsDTO? createdInstance = this.service.CreateNewDtoInstance();
        if (createdInstance is not null) {
            _ = this.service.DisplayDtoInstance(createdInstance);
            this.RefreshList();
        }

    }

    private void buttonSearch_Click(object sender, EventArgs e) {


    }

    private void buttonDelete_Click(object sender, EventArgs e) {
        ProduitsDTO? deletedInstance = this.service.DeleteDtoInstance((ProduitsDTO) this.dataGridViewProduits.SelectedRows[0]);
        if (deletedInstance is not null) {
            _ = this.service.DisplayDtoInstance(deletedInstance);
            this.RefreshList();
        }
    }

    private void dataGridViewFournisseurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void dataGridViewProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void ProduitsManagementForm_Load(object sender, EventArgs e) {

    }

    private void buttonEdit_Click(object sender, EventArgs e) {
        ProduitsDTO? editedInstance = this.service.EditDtoInstance((ProduitsDTO) this.dataGridViewProduits.SelectedRows[0]);
        if (editedInstance is not null) {
            _ = this.service.DisplayDtoInstance(editedInstance);
            this.RefreshList();
        }
    }

    private void buttonView_Click(object sender, EventArgs e) {
        _ = this.service.DisplayDtoInstance((ProduitsDTO) this.dataGridViewProduits.SelectedRows[0]);
    }

    private void buttonExit_Click(object sender, EventArgs e) {
        this.Hide();
    }
    public DialogResult OpenForCreation(ProduitsDTO blankInstance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(ProduitsDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(ProduitsDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(ProduitsDTO instance) {
        // TODO: (Prof) Complete form code
        throw new NotImplementedException();
    }
