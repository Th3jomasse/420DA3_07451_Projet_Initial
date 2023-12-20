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
public partial class RestockOrderManagementForm : Form, IDtoManagementView<RestockOrderDTO> {
    private readonly AbstractFacade facade;
    private RestockOrderDTO workingInstance = null!;
    private ViewIntentEnum viewIntent;

    public RestockOrderManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.InitializeComponent();
        this.LoadWarehousesCombobox();
        this.LoadStatusesCombobox();
    }

    public DialogResult OpenForCreation(RestockOrderDTO blankInstance) {
        this.viewIntent = ViewIntentEnum.Creation;
        this.actionButton.Text = "Créer!";
        return this.OpenFor(blankInstance);

    }

    public DialogResult OpenForDeletion(RestockOrderDTO instance) {
        _ = MessageBox.Show("Cette action n'est pas autorisée.");
        return DialogResult.Cancel;
    }

    public DialogResult OpenForEdition(RestockOrderDTO instance) {
        _ = MessageBox.Show("Cette action n'est pas autorisée.");
        return DialogResult.Cancel;
    }

    public DialogResult OpenForVisualization(RestockOrderDTO instance) {
        this.viewIntent = ViewIntentEnum.Visualization;
        this.actionButton.Text = "OK";
        return this.OpenFor(instance);
    }

    private DialogResult OpenFor(RestockOrderDTO instance) {
        this.workingInstance = instance;
        this.LoadInstanceDataInControls(instance);
        switch (this.viewIntent) {
            case ViewIntentEnum.Creation:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Visualization:
                this.DeactivateControls();
                break;
            default:
                throw new NotImplementedException("View intent is not supported.");
        }
        return this.ShowDialog();
    }

    private void ActivateControls() {
        this.idNumUpDown.Enabled = false;
        this.productSearchFilter.Enabled = true;
        this.productSearchListBox.Enabled = true;
        this.statusSelector.Enabled = true;
        this.entrepotSelector.Enabled = false;
        this.quantityNumUpDown.Enabled = true;
    }

    private void DeactivateControls() {
        this.idNumUpDown.Enabled = false;
        this.productSearchFilter.Enabled = false;
        this.productSearchListBox.Enabled = false;
        this.statusSelector.Enabled = false;
        this.entrepotSelector.Enabled = false;
        this.quantityNumUpDown.Enabled = false;
    }

    private void LoadInstanceDataInControls(RestockOrderDTO instance) {
        this.idNumUpDown.Value = instance.Id;
        if (!this.productSearchListBox.Items.Contains(instance.Produit)) {
            _ = this.productSearchListBox.Items.Add(instance.Produit);
        }
        this.quantityNumUpDown.Value = instance.Quantity;
        this.productSearchListBox.SelectedItem = instance.Produit;
        this.statusSelector.SelectedItem = instance.Status;
        this.entrepotSelector.SelectedItem = instance.DestinationWarehouse;
    }

    private void StoreControlsDataInInstance() {
        this.workingInstance.Produit = (ProduitsDTO) this.productSearchListBox.SelectedItem;
        this.workingInstance.Status = (RestockOrderStatusEnum) this.statusSelector.SelectedItem;
        this.workingInstance.DestinationWarehouse = (EntrepotDTO) this.entrepotSelector.SelectedItem;
        this.workingInstance.Quantity = (int) this.quantityNumUpDown.Value;
    }

    private void LoadWarehousesCombobox() {
        this.entrepotSelector.DataSource = this.facade.GetService<EntrepotService>().GetAllEntrepots();
    }

    private void LoadStatusesCombobox() {
        this.statusSelector.Items.Clear();
        foreach (RestockOrderStatusEnum enumValue in Enum.GetValues(typeof(RestockOrderStatusEnum))) {
            _ = this.statusSelector.Items.Add(enumValue);
        }
    }

    private void ProductSearchFilter_TextChanged(object sender, EventArgs e) {
        this.productSearchListBox.Items.Clear();
        this.productSearchListBox.Items.AddRange(
            this.facade.GetService<ProduitsService>().SearchProducts(this.productSearchFilter.Text).ToArray()
            );
    }

    private void ProductSearchListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.productSearchListBox.SelectedItem is not null) {
            ProduitsDTO produitSelectionne = (ProduitsDTO) this.productSearchListBox.SelectedItem;
            this.entrepotSelector.SelectedItem = produitSelectionne.ClientProprietaireProduit.AssignedWarehouse;
        }
    }

    private bool ValidateControlsData() {
        return this.productSearchListBox.SelectedItem is null
            ? throw new Exception("Pas de produit sélectionné.")
            : this.quantityNumUpDown.Value <= 0
                ? throw new Exception("La quantité ne peut être 0 ou moins.")
                : this.statusSelector.SelectedItem is null
                    ? throw new Exception("Pas de statut sélectionné.")
                    : this.entrepotSelector.SelectedItem is null 
                        ? throw new Exception("Pas d'entrepôt sélectionné.") 
                        : true;
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        if (this.ValidateControlsData()) {
            switch (this.viewIntent) {
                case ViewIntentEnum.Creation:
                    this.StoreControlsDataInInstance();
                    break;
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
