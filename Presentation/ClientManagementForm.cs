using _420DA3_07451_Projet_Initial.Business.Abstracts;
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
internal partial class ClientManagementForm : Form, IDtoManagementView<ClientDTO> {
    private AbstractFacade ParentFacade { get; set; }
    private ClientDTO workingInstance = null!;
    private ViewIntentEnum viewIntent;

    public ClientManagementForm(AbstractFacade facade) {
        this.ParentFacade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(ClientDTO blankInstance) {
        this.workingInstance = blankInstance;
        this.viewIntent = ViewIntentEnum.Creation;
        this.actionButton.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForDeletion(ClientDTO instance) {
        this.workingInstance = instance;
        this.viewIntent = ViewIntentEnum.Deletion;
        this.actionButton.Text = "Supprimer!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(ClientDTO instance) {
        this.workingInstance = instance;
        this.viewIntent = ViewIntentEnum.Edition;
        this.actionButton.Text = "Sauvegarder!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(ClientDTO instance) {
        this.workingInstance = instance;
        this.viewIntent = ViewIntentEnum.Visualization;
        this.actionButton.Text = "OK";
        return this.OpenFor(instance);
    }

    private DialogResult OpenFor(ClientDTO instance) {
        this.LoadDataInControls(instance);
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
                throw new NotImplementedException("View Intent is not supported.");
        }
        return this.ShowDialog();
    }

    private void ActivateControls() {
        this.nomClientTextBox.Enabled = true;
        this.addressSelector.Enabled = true;
        this.warehouseSelector.Enabled = true;
        this.contactNameTextBox.Enabled = true;
        this.prenomContactTextBox.Enabled = true;
        this.telephoneContactTextBox.Enabled = true;
        this.courrielContactTextBox.Enabled = true;
    }

    private void DeactivateControls() {
        this.nomClientTextBox.Enabled = false;
        this.addressSelector.Enabled = false;
        this.warehouseSelector.Enabled = false;
        this.contactNameTextBox.Enabled = false;
        this.prenomContactTextBox.Enabled = false;
        this.telephoneContactTextBox.Enabled = false;
        this.courrielContactTextBox.Enabled = false;
    }

    private void LoadDataInControls(ClientDTO instance) {
        this.idNumUpDown.Value = instance.Id;
        this.nomClientTextBox.Text = instance.NomClient;
        this.addressSelector.SelectedItem = instance.ClientAddress;
        this.warehouseSelector.SelectedItem = instance.AssignedWarehouse;
        this.contactNameTextBox.Text = instance.NomPersonneContact;
        this.prenomContactTextBox.Text = instance.PrenomPersonneContact;
        this.telephoneContactTextBox.Text = instance.TelephonePersonneContact;
        this.courrielContactTextBox.Text = instance.CourrielPersonneContact;
    }

    private void SaveControlsDataInInstance() {
        this.workingInstance.NomClient = this.nomClientTextBox.Text;
        this.workingInstance.ClientAddress = (AddressDTO) this.addressSelector.SelectedItem;
        this.workingInstance.AssignedWarehouse = (EntrepotDTO) this.warehouseSelector.SelectedItem;
        this.workingInstance.NomPersonneContact = this.contactNameTextBox.Text;
        this.workingInstance.PrenomPersonneContact = this.prenomContactTextBox.Text;
        this.workingInstance.TelephonePersonneContact = this.telephoneContactTextBox.Text;
        this.workingInstance.CourrielPersonneContact = this.courrielContactTextBox.Text;
    }

    private bool ValidateFieldsData() {
        try {
            if (this.nomClientTextBox.Text.IsNullOrEmpty()) {
                throw new Exception("Nom de client vide.");
            }
            _ = ClientDTO.ValidateNomClient(this.nomClientTextBox.Text, true);

            if (this.addressSelector.SelectedItem is null) {
                throw new Exception("Pas d'adresse sélectionnée.");
            }
            if (this.warehouseSelector.SelectedItem is null) {
                throw new Exception("Pas d'entrepôt sélectionné.");
            }

            if (this.contactNameTextBox.Text.IsNullOrEmpty()) {
                throw new Exception("Nom de contact vide.");
            }
            _ = ClientDTO.ValidateNomContact(this.contactNameTextBox.Text, true);
            if (this.prenomContactTextBox.Text.IsNullOrEmpty()) {
                throw new Exception("Prénom de contact vide.");
            }
            _ = ClientDTO.ValidatePrenomContact(this.prenomContactTextBox.Text, true);
            if (this.telephoneContactTextBox.Text.IsNullOrEmpty()) {
                throw new Exception("Téléphone de contact vide.");
            }
            _ = ClientDTO.ValidateTelephoneContact(this.telephoneContactTextBox.Text, true);
            if (this.courrielContactTextBox.Text.IsNullOrEmpty()) {
                throw new Exception("Courriel de contact vide.");
            }
            _ = ClientDTO.ValidateCourrielContact(this.courrielContactTextBox.Text, true);
            return true;
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        if (this.ValidateFieldsData()) {
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
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void TelephoneContactTextBox_Leave(object sender, EventArgs e) {
        this.telephoneContactTextBox.Text = ClientDTO.SanitizeTelephoneString(this.telephoneContactTextBox.Text);
    }
}
