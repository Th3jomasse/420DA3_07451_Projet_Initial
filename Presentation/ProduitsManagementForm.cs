using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
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
using _420DA3_07451_Projet_Initial.Presentation.Enums;

namespace _420DA3_07451_Projet_Initial.Presentation;

public partial class ProduitsManagementForm : Form, IDtoManagementView<ProduitsDTO> {
    private readonly ProduitsService service;
    private readonly FournisseursService fournisseursService;
    private readonly AbstractFacade ParentFacade;
    private ProduitsDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public ProduitsManagementForm(AbstractFacade parentFacade) {
        this.ParentFacade = parentFacade;
        this.InitializeComponent();
        this.RefreshList();
    }

    private void RefreshList() {
        var productItems = this.listBoxProduits.SelectedItems.Cast<ProduitsDTO>().ToList();
        var fournisseurItems = this.listBoxFournisseurs.SelectedItems.Cast<FournisseursDTO>().ToList();
        this.listBoxProduits.DataSource = this.service.GetAllProduits();
        this.listBoxFournisseurs.DataSource = this.fournisseursService.FindAllFournisseurs();
        this.listBoxProduits.ClearSelected();
        this.listBoxFournisseurs.ClearSelected();
        foreach (var productItem in productItems) {
            var index = this.listBoxProduits.Items.IndexOf(productItem);
            if (index >= 0) {
                this.listBoxProduits.SetSelected(index, true);
            }
        }

        foreach (var fournisseurItem in fournisseurItems) {
            var index = this.listBoxFournisseurs.Items.IndexOf(fournisseurItem);
            if (index >= 0) {
                this.listBoxFournisseurs.SetSelected(index, true);
            }
        }
    }

    private void buttonNew_Click(object sender, EventArgs e) {
        ProduitsDTO? createdInstance = this.service.CreateNewDtoInstance();
        if (createdInstance is not null) {
            _ = this.service.DisplayDtoInstance(createdInstance);
            this.RefreshList();
        }

    }

    private void buttonSearch_Click(object sender, EventArgs e) {
        string searchTermId = this.textBoxProdId.Text.Trim();
        string searchTermNom = this.textBoxProdCodeFour.Text.Trim();

        if (!string.IsNullOrEmpty(searchTermId)) {
            // Search by ID
            if (int.TryParse(searchTermId, out int productId)) {
                ProduitsDTO? filteredProducts = this.service.FindProduitById(productId);
                this.listBoxProduits.DataSource = null;
                this.listBoxProduits.DataSource = filteredProducts;
            } else {
                MessageBox.Show("Invalid ID format. Please enter a valid numeric ID.");
            }
        } else if (!string.IsNullOrEmpty(searchTermNom)) {
            // Search by name
            ProduitsDTO? filteredProducts = this.service.SearchProduct(searchTermNom);
            this.listBoxProduits.DataSource = null;
            this.listBoxProduits.DataSource = filteredProducts;
        } else {
            // Both textboxes are empty, display all products
            this.RefreshList();
        }
    }


    private void buttonDelete_Click(object sender, EventArgs e) {
        if (this.listBoxProduits.SelectedItems.Count > 0) {
            ProduitsDTO? deletedInstance = this.listBoxProduits.SelectedItem as ProduitsDTO;
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
        if (this.listBoxProduits.SelectedItems.Count > 0) {
            ProduitsDTO? editedInstance = this.listBoxProduits.SelectedItem as ProduitsDTO;
            if (editedInstance is not null) {
                _ = this.service.UpdateDtoInstance(editedInstance);
                _ = this.service.DisplayDtoInstance(editedInstance);
                this.RefreshList();
            }
        }
    }


    private void buttonView_Click(object sender, EventArgs e) {
        if (this.listBoxProduits.SelectedItems.Count > 0) {
            ProduitsDTO? displayInstance = this.listBoxProduits.SelectedItem as ProduitsDTO;
            if (displayInstance is not null) {
                _ = this.service.DisplayDtoInstance(displayInstance);
                this.RefreshList();
            }
        }
    }


    private void buttonExit_Click(object sender, EventArgs e) {
        this.Hide();
    }
   
    public DialogResult OpenForCreation(ProduitsDTO blankInstance) {
        // Set the working instance and intent
        this.workingDtoInstance = blankInstance;
        this.workingViewIntent = ViewIntentEnum.Creation;

        // Customize the form for creation
       this.SetFields(blankInstance);

        // Show the form modally
        DialogResult result = this.ShowDialog();

        // Check the result and perform actions if needed
        if (result == DialogResult.OK) {
            // The user clicked OK, you might want to perform additional actions
            this.RefreshList(); // Refresh the list after creation
        }

        return result;
    }

    public DialogResult OpenForDeletion(ProduitsDTO instance) {
        // Set the working instance and intent
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Deletion;

        // Customize the form for deletion
        
        this.SetFields(instance); // Display details for confirmation

        // Show the form modally
        DialogResult result = this.ShowDialog();

        // Check the result and perform actions if needed
        if (result == DialogResult.OK) {
            // The user confirmed deletion, you might want to perform additional actions
            this.RefreshList(); // Refresh the list after deletion
        }

        return result;
    }


    public DialogResult OpenForEdition(ProduitsDTO instance) {
        // Set the working instance and intent
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Edition;
        this.SetFields(instance);

        // Show the form modally
        DialogResult result = this.ShowDialog();

        // Check the result and perform actions if needed
        if (result == DialogResult.OK) {
            // The user clicked OK, you might want to perform additional actions
            this.RefreshList(); // Refresh the list after edition
        }

        return result;
    }


    public DialogResult OpenForVisualization(ProduitsDTO instance) {
        // Set the working instance and intent
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Visualization;
        this.SetFields(instance);

        // Show the form modally
        return this.ShowDialog();
    }
    private void SetFields(ProduitsDTO dto) {
        this.textBoxProdId.Text = dto.Id.ToString() ?? "";
        this.textBoxProdCodeFour.Text = dto.NomProduit ?? "";
        this.textBoxProdUnitStock.Text = dto.ProduitUpc.ToString() ?? "";
        this.textBoxProdKg.Text = dto.Description ?? "";
        this.textBoxProdDesc.Text = dto.UnitesEnStock.ToString() ?? "";
        this.textBoxProdMinUnit.Text = dto.PoidsKilo.ToString() ?? "";
        this.textBoxProdUpc.Text = dto.NiveauDeReappro.ToString() ?? "";

        // Assuming comboBoxFournisseurs is a ComboBox and dto.FournisseurId is an int
        // You need to find the corresponding index for the item in the ComboBox
        int fournisseurId = dto.FournisseurId;
        int index = comboBoxProdFourId.FindStringExact(fournisseurId.ToString());
        comboBoxProdFourId.SelectedIndex = index;
    }

}