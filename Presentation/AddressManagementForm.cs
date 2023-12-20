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
public partial class AddressManagementForm : Form, IDtoManagementView<AddressDTO> {
    private AbstractFacade facade;
    private AddressDTO workingInstance = null!;
    private ViewIntentEnum viewIntent;


    public AddressManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(AddressDTO blankInstance) {
        this.workingInstance = blankInstance;
        this.viewIntent = ViewIntentEnum.Creation;
        this.buttonAction.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForDeletion(AddressDTO instance) {
        this.workingInstance = instance;
        this.viewIntent = ViewIntentEnum.Deletion;
        this.buttonAction.Text = "Supprimer!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(AddressDTO instance) {
        this.workingInstance = instance;
        this.viewIntent = ViewIntentEnum.Edition;
        this.buttonAction.Text = "Sauvegarder!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(AddressDTO instance) {
        this.workingInstance = instance;
        this.viewIntent = ViewIntentEnum.Visualization;
        this.buttonAction.Text = "OK";
        return this.OpenFor(instance);
    }

    private DialogResult OpenFor(AddressDTO instance) {
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
        this.civicNumNumUpDown.Enabled = true;
        this.streetTextBox.Enabled = true;
        this.cityTextBox.Enabled = true;
        this.provinceTextBox.Enabled = true;
        this.countryTextBox.Enabled = true;
        this.postalCodeTextBox.Enabled = true;
    }

    private void DeactivateControls() {
        this.civicNumNumUpDown.Enabled = false;
        this.streetTextBox.Enabled = false;
        this.cityTextBox.Enabled = false;
        this.provinceTextBox.Enabled = false;
        this.countryTextBox.Enabled = false;
        this.postalCodeTextBox.Enabled = false;
    }

    private void LoadDataInControls(AddressDTO instance) {
        this.idNumUpDown.Value = instance.Id;
        this.civicNumNumUpDown.Value = instance.CivicNumber;
        this.streetTextBox.Text = instance.Street;
        this.cityTextBox.Text = instance.City;
        this.provinceTextBox.Text = instance.Province;
        this.countryTextBox.Text = instance.Country;
        this.postalCodeTextBox.Text = instance.PostalCode;
    }

    private void SaveControlsDataInInstance() {
        this.workingInstance.CivicNumber = (int) this.civicNumNumUpDown.Value;
        this.workingInstance.Street = this.streetTextBox.Text;
        this.workingInstance.City = this.cityTextBox.Text;
        this.workingInstance.Province = this.provinceTextBox.Text;
        this.workingInstance.Country = this.countryTextBox.Text;
        this.workingInstance.PostalCode = this.postalCodeTextBox.Text;
    }


    private bool ValidateFieldsData() {
        try {
            _ = AddressDTO.ValidateCivicNumber(((int) this.civicNumNumUpDown.Value), true);
            _ = AddressDTO.ValidateStreet(this.streetTextBox.Text, true);
            _ = AddressDTO.ValidateCity(this.cityTextBox.Text, true);
            _ = AddressDTO.ValidateProvince(this.provinceTextBox.Text, true);
            _ = AddressDTO.ValidateCountry(this.countryTextBox.Text, true);
            _ = AddressDTO.ValidatePostalCode(this.postalCodeTextBox.Text, true);
            return true;
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    private void ButtonAction_Click(object sender, EventArgs e) {
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

    private void ButtonCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
