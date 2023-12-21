using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using Microsoft.IdentityModel.Tokens;
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
internal partial class EntrepotManagementForm : Form, IDtoManagementView<EntrepotDTO> {
    private AbstractFacade ParentFacade { get; set; }
    private EntrepotDTO workingInstance = null!;
    private ViewIntentEnum viewIntent;

    public EntrepotManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(EntrepotDTO blankInstance) {
        this.viewIntent = ViewIntentEnum.Creation;
        this.actionButton.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForDeletion(EntrepotDTO instance) {
        this.viewIntent = ViewIntentEnum.Deletion;
        this.actionButton.Text = "Supprimer!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(EntrepotDTO instance) {
        this.viewIntent = ViewIntentEnum.Edition;
        this.actionButton.Text = "Sauvegarder!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(EntrepotDTO instance) {
        this.viewIntent = ViewIntentEnum.Visualization;
        this.actionButton.Text = "OK";
        return this.OpenFor(instance);
    }

    private void LoadAddressCombobox() {
        this.addressSelector.Items.Clear();
        this.addressSelector.Items.AddRange(this.ParentFacade.GetService<AddressService>().GetAllAddresses().ToArray());
    }

    private void ActivateControls() {
        this.idNumUpDown.Enabled = false;
        this.nomTextBox.Enabled = true;
        this.addressSelector.Enabled = true;
    }

    private void DeactivateControls() {
        this.idNumUpDown.Enabled = false;
        this.nomTextBox.Enabled = false;
        this.addressSelector.Enabled = false;
    }

    private DialogResult OpenFor(EntrepotDTO instance) {
        this.workingInstance = instance;
        this.LoadAddressCombobox();
        this.LoadInstanceDataInControls(instance);
        switch (this.viewIntent) {
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
                this.DeactivateControls();
                break;
            default:
                throw new NotImplementedException("View intent is not supported.");
        }
        return this.ShowDialog();
    }

    private void LoadInstanceDataInControls(EntrepotDTO instance) {
        this.idNumUpDown.Value = instance.Id;
        this.nomTextBox.Text = instance.NomEntrepot;
        this.addressSelector.SelectedValue = instance.Address;
    }

    private void SaveControlsDataInInstance() {
        this.workingInstance.NomEntrepot = this.nomTextBox.Text;
        this.workingInstance.Address = (AddressDTO) this.addressSelector.SelectedValue;
    }

    private bool ValidateControlsData() {
        return this.addressSelector.SelectedItem is null
            ? throw new Exception("Pas d'adresse sélectionnée.")
            : this.nomTextBox.Text.IsNullOrEmpty() 
                ? throw new Exception("Nom d'entrepôt vide.") 
                : true;
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {
            if (this.ValidateControlsData()) {
                switch (this.viewIntent) {
                    case ViewIntentEnum.Creation:
                    case ViewIntentEnum.Edition:
                        this.SaveControlsDataInInstance();
                        break;
                    case ViewIntentEnum.Visualization:
                    case ViewIntentEnum.Deletion:
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CreateAddressButton_Click(object sender, EventArgs e) {
        AddressDTO? newAddress = this.ParentFacade.GetService<AddressService>().CreateNewDtoInstance();
        if (newAddress is not null) {
            _ = this.addressSelector.Items.Add(newAddress);
            this.addressSelector.SelectedItem = newAddress;
        }
    }
}
