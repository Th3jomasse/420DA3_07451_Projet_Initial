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

        string searchTerm = this.textBoxSearch.Text.Trim();
        List<ProduitsDTO> filteredProducts = this.service.SearchProduits(searchTerm);
        object selected = this.dataGridViewProduits.SelectedRows;
        this.dataGridViewProduits.Rows.Clear();
        this.dataGridViewProduits.Rows.AddRange(filteredProducts.ToArray());
        this.dataGridViewProduits.SelectedRows = (DataGridViewSelectedRowCollection) selected;
        this.dataGridViewProduits.Refresh();
    }

    private void buttonDelete_Click(object sender, EventArgs e) {
        if (this.dataGridViewProduits.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = this.dataGridViewProduits.SelectedRows[0];
            ProduitsDTO? deletedInstance = selectedRow.DataBoundItem as ProduitsDTO;
            if (deletedInstance is not null) {
                _ = this.service.DeleteDtoInstance(deletedInstance);
                _ = this.service.DisplayDtoInstance(deletedInstance);
                this.RefreshList();
            }
        }
    }

    private void dataGridViewFournisseurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void dataGridViewProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void ProduitsManagementForm_Load(object sender, EventArgs e) {
        RefreshList();
    }

    private void buttonEdit_Click(object sender, EventArgs e) {

        if (this.dataGridViewProduits.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = this.dataGridViewProduits.SelectedRows[0];
            ProduitsDTO? editedInstance = selectedRow.DataBoundItem as ProduitsDTO;
            if (editedInstance is not null) {
                _ = this.service.UpdateDtoInstance(editedInstance);
                _ = this.service.DisplayDtoInstance(editedInstance);
                this.RefreshList();
            }
        }
    }

    private void buttonView_Click(object sender, EventArgs e) {
        if (this.dataGridViewProduits.SelectedRows.Count > 0) {
            DataGridViewRow selectedRow = this.dataGridViewProduits.SelectedRows[0];
            ProduitsDTO? displayInstance = selectedRow.DataBoundItem as ProduitsDTO;
            if (displayInstance is not null) {
                _ = this.service.DisplayDtoInstance(displayInstance);
                this.RefreshList();
            }
        }
    }

    private void buttonExit_Click(object sender, EventArgs e) {
        this.Hide();
    }

    private void textBoxProduitId_TextChanged(object sender, EventArgs e) {

    }

    private void comboBoxFournisseurs_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void textBoxFournisseurId_TextChanged(object sender, EventArgs e) {

    }

    private void textBoxProduitUpc_TextChanged(object sender, EventArgs e) {

    }

    private void textBoxProduitNom_TextChanged(object sender, EventArgs e) {

    }

    private void textBoxProduitDesc_TextChanged(object sender, EventArgs e) {

    }

    private void textBoxProduitUnitStock_TextChanged(object sender, EventArgs e) {

    }

    private void textBoxProduitPoids_TextChanged(object sender, EventArgs e) {

    }

    private void textBoxProduitMinStock_TextChanged(object sender, EventArgs e) {

    }

    private void dataGridViewFournisseurs_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void dataGridViewProduits_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }
    public DialogResult OpenForCreation(ProduitsDTO blankInstance) {
        // TODO:  Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForDeletion(ProduitsDTO instance) {
        // TODO:  Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForEdition(ProduitsDTO instance) {
        // TODO: Complete form code
        throw new NotImplementedException();
    }

    public DialogResult OpenForVisualization(ProduitsDTO instance) {
        // TODO:  Complete form code
        throw new NotImplementedException();
    }
}