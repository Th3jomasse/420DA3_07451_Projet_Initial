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

public partial class FournisseursManagementForm : Form, IDtoManagementView<FournisseursDTO> {
    private readonly ProduitsService service;
    private readonly FournisseursService fournisseursService;
    private readonly AbstractFacade ParentFacade;
    private FournisseursDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public FournisseursManagementForm(AbstractFacade parentFacade) {
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
        FournisseursDTO? createdInstance = this.fournisseursService.CreateNewDtoInstance();
        if (createdInstance is not null) {
            _ = this.fournisseursService.DisplayDtoInstance(createdInstance);
            this.RefreshList();
        }

    }

    private void buttonSearch_Click(object sender, EventArgs e) {
        string searchTermId = this.textBoxFourId.Text.Trim();
        string searchTermNom = this.textBoxFourNomComp.Text.Trim();

        if (!string.IsNullOrEmpty(searchTermId)) {
            // Search by ID
            if (int.TryParse(searchTermId, out int productId)) {
                FournisseursDTO? filteredProducts = this.fournisseursService.FindFournisseurById(productId);
                this.listBoxProduits.DataSource = null;
                this.listBoxProduits.DataSource = filteredProducts;
            } else {
                MessageBox.Show("Invalid ID format. Please enter a valid numeric ID.");
            }
        } else if (!string.IsNullOrEmpty(searchTermNom)) {
            // Search by name
            FournisseursDTO? filteredProducts = this.fournisseursService.SearchFournisseur(searchTermNom);
            this.listBoxProduits.DataSource = null;
            this.listBoxProduits.DataSource = filteredProducts;
        } else {
            // Both textboxes are empty, display all products
            this.RefreshList();
        }
    }


    private void buttonDelete_Click(object sender, EventArgs e) {
        if (this.listBoxProduits.SelectedItems.Count > 0) {
            FournisseursDTO? deletedInstance = this.listBoxProduits.SelectedItem as FournisseursDTO;
            if (deletedInstance is not null) {
                _ = this.fournisseursService.DeleteDtoInstance(deletedInstance);
                _ = this.fournisseursService.DisplayDtoInstance(deletedInstance);
                this.RefreshList();
            }
        }
    }
    

    private void FournisseursManagementForm_Load(object sender, EventArgs e) {
        RefreshList();
    }

    private void buttonEdit_Click(object sender, EventArgs e) {
        if (this.listBoxProduits.SelectedItems.Count > 0) {
            FournisseursDTO? editedInstance = this.listBoxProduits.SelectedItem as FournisseursDTO;
            if (editedInstance is not null) {
                _ = this.fournisseursService.UpdateDtoInstance(editedInstance);
                _ = this.fournisseursService.DisplayDtoInstance(editedInstance);
                this.RefreshList();
            }
        }
    }


    private void buttonView_Click(object sender, EventArgs e) {
        if (this.listBoxProduits.SelectedItems.Count > 0) {
            FournisseursDTO? displayInstance = this.listBoxProduits.SelectedItem as FournisseursDTO;
            if (displayInstance is not null) {
                _ = this.fournisseursService.DisplayDtoInstance(displayInstance);
                this.RefreshList();
            }
        }
    }


    private void buttonExit_Click(object sender, EventArgs e) {
        this.Hide();
    }

    public DialogResult OpenForCreation(FournisseursDTO blankInstance) {
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

    public DialogResult OpenForDeletion(FournisseursDTO instance) {
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


    public DialogResult OpenForEdition(FournisseursDTO instance) {
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


    public DialogResult OpenForVisualization(FournisseursDTO instance) {
        // Set the working instance and intent
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Visualization;
        this.SetFields(instance);

        // Show the form modally
        return this.ShowDialog();
    }
    private void SetFields(FournisseursDTO dto) {
        this.textBoxFourId.Text = dto.Id.ToString();
        this.textBoxFourNomComp.Text = dto.NomFournisseur;
        this.textBoxFourNom.Text = dto.NomResponsable;
        this.textBoxFourPrenom.Text = dto.PrenomResponsable;
        this.textBoxFourTelephone.Text = dto.TelephoneResponsable;

        // Assuming AddressId is the ID of the associated address
        int addressId = dto.AddresseId;

        // Fetch the AddressDTO using the addressId, assuming you have a service method for this
        AddressDTO address = GetAddressById(addressId);

        if (address != null) {
            this.textBoxFourCivic.Text = address.CivicNumber.ToString();
            this.textBoxFourVille.Text = address.City ?? "";
            this.textBoxFourRue.Text = address.Street ?? "";
            this.textBoxFourPostalCode.Text = address.PostalCode ?? "";

            // Assuming you have a ComboBox named comboBoxFourProvince
            int index = this.comboBoxFourProvince.FindStringExact(address.Province);
            if (index >= 0) {
                this.comboBoxFourProvince.SelectedIndex = index;
            }
        }
    }

    // Example method to fetch AddressDTO by ID (replace this with your actual method)
    private AddressDTO GetAddressById(int addressId) {
        // Implement logic to fetch AddressDTO by ID from your data source
        // Example: return addressService.GetAddressById(addressId);
        return null; // Replace with actual implementation
    }






}