using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
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
public partial class AdminMainMenu : Form {
    private AbstractFacade ParentFacade { get; set; }

    public AdminMainMenu(AbstractFacade parentFacade) {
        this.ParentFacade = parentFacade;
        this.InitializeComponent();
    }



    #region Gestion des Adresses


    private void AddressSearchTextBox_TextChanged(object sender, EventArgs e) {
        this.filteredAddresses.DataSource =
            this.ParentFacade.GetService<AddressService>().SearchAddresses(this.addressSearchTextBox.Text);
    }

    private void ActivateAddressButtons() {
        this.editAddressButton.Enabled = true;
        this.viewAddressButton.Enabled = true;
        this.deleteAddressButton.Enabled = true;
    }

    private void DeactivateAddressButtons() {
        this.editAddressButton.Enabled = false;
        this.viewAddressButton.Enabled = false;
        this.deleteAddressButton.Enabled = false;
    }

    private void CreateAddressButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<AddressService>().CreateNewDtoInstance();
    }

    private void ViewAddressButton_Click(object sender, EventArgs e) {
        if (this.filteredAddresses.SelectedItem == null) {
            _ = MessageBox.Show("Pas d'adresse sélectionnée.");
        } else {
            _ = this.ParentFacade.GetService<AddressService>().DisplayDtoInstance((AddressDTO) this.filteredAddresses.SelectedItem);
        }
    }

    private void EditAddressButton_Click(object sender, EventArgs e) {
        if (this.filteredAddresses.SelectedItem == null) {
            _ = MessageBox.Show("Pas d'adresse sélectionnée.");
        } else {
            _ = this.ParentFacade.GetService<AddressService>().UpdateDtoInstance((AddressDTO) this.filteredAddresses.SelectedItem);
        }

    }

    private void DeleteAddressButton_Click(object sender, EventArgs e) {
        if (this.filteredAddresses.SelectedItem == null) {
            _ = MessageBox.Show("Pas d'adresse sélectionnée.");
        } else {
            _ = this.ParentFacade.GetService<AddressService>().DeleteDtoInstance((AddressDTO) this.filteredAddresses.SelectedItem);
        }

    }

    private void FilteredAddresses_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.filteredAddresses.SelectedItem != null) {
            this.ActivateAddressButtons();
        } else {
            this.DeactivateAddressButtons();
        }
    }

    #endregion


    #region Gestion des Clients

    private void ClientCreateButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ClientService>().CreateNewDtoInstance();
    }

    private void ClientFilteringBox_TextChanged(object sender, EventArgs e) {
        this.filteredClients.DataSource =
            this.ParentFacade.GetService<ClientService>().SearchClientsByName(this.clientFilteringBox.Text);
    }

    private void ActivateClientsButtons() {
        this.clientEditButton.Enabled = true;
        this.clientViewButton.Enabled = true;
        this.clientDeleteButton.Enabled = true;
    }

    private void DeactivateClientsButtons() {
        this.clientEditButton.Enabled = false;
        this.clientViewButton.Enabled = false;
        this.clientDeleteButton.Enabled = false;
    }

    private void ClientViewButton_Click(object sender, EventArgs e) {
        if (this.filteredClients.SelectedItem == null) {
            _ = MessageBox.Show("Pas de client sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<ClientService>().DisplayDtoInstance((ClientDTO) this.filteredClients.SelectedItem);
        }
    }

    private void ClientEditButton_Click(object sender, EventArgs e) {
        if (this.filteredClients.SelectedItem == null) {
            _ = MessageBox.Show("Pas de client sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<ClientService>().UpdateDtoInstance((ClientDTO) this.filteredClients.SelectedItem);
        }
    }

    private void ClientDeleteButton_Click(object sender, EventArgs e) {
        if (this.filteredClients.SelectedItem == null) {
            _ = MessageBox.Show("Pas de client sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<ClientService>().DeleteDtoInstance((ClientDTO) this.filteredClients.SelectedItem);
        }
    }

    private void FilteredClients_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.filteredAddresses.SelectedItem is not null) {
            this.ActivateClientsButtons();
        } else {
            this.DeactivateClientsButtons();
        }
    }

    #endregion

    #region Gestion des Utilisateurs
    private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.UserComboBox.SelectedItem != null) {
            this.ActivateUserButtons();
        } else {
            this.DeactivateUserButtons();
        }
    }
    private void ActivateUserButtons() {
        this.editUserButton.Enabled = true;
        this.viewUserButton.Enabled = true;
        this.deleteUserButton.Enabled = true;
    }

    private void DeactivateUserButtons() {
        this.editUserButton.Enabled = false;
        this.viewUserButton.Enabled = false;
        this.deleteUserButton.Enabled = false;
    }
    private void CreateUserButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<UserService>().CreateNewDtoInstance();
    }
    private void ViewUserButton_Click(object sender, EventArgs e) {
        if (this.UserComboBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Utilisateur Sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<UserService>().DisplayDtoInstance((UserDTO) this.UserComboBox.SelectedItem);
        }
    }

    private void EditUserButton_Click(object sender, EventArgs e) {
        if (this.UserComboBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Utilisateur Sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<UserService>().DisplayDtoInstance((UserDTO) this.UserComboBox.SelectedItem);
        }
    }

    private void DeleteUserButton_Click(object sender, EventArgs e) {
        if (this.UserComboBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Utilisateur Sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<UserService>().DisplayDtoInstance((UserDTO) this.UserComboBox.SelectedItem);
        }
    }
    #endregion

    #region Gestion des Rôles
    private void ActivateRoleButtons() {
        this.RoleEditButton.Enabled = true;
        this.RoleViewButton.Enabled = true;
        this.RoleDeleteButton.Enabled = true;
    }

    private void DeactivateRoleButtons() {
        this.RoleEditButton.Enabled = false;
        this.RoleViewButton.Enabled = false;
        this.RoleDeleteButton.Enabled = false;
    }
    private void RolesFilterListBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.RolesFilterListBox.SelectedItem != null) {
            this.ActivateRoleButtons();
        } else {
            this.DeactivateRoleButtons();
        }
    }
    private void RoleCreateButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<RoleService>().CreateNewDtoInstance();
    }
    private void RoleViewButton_Click(object sender, EventArgs e) {
        if (this.RolesFilterListBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Role sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<RoleService>().DisplayDtoInstance((RoleDTO) this.RolesFilterListBox.SelectedItem);
        }
    }

    private void RoleEditButton_Click(object sender, EventArgs e) {
        if (this.RolesFilterListBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Role sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<RoleService>().DisplayDtoInstance((RoleDTO) this.RolesFilterListBox.SelectedItem);
        }
    }

    private void RoleDeleteButton_Click(object sender, EventArgs e) {
        if (this.RolesFilterListBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Role sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<RoleService>().DisplayDtoInstance((RoleDTO) this.RolesFilterListBox.SelectedItem);
        }
    }
    public void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        this.RolesFilterListBox.DataSource = this.ParentFacade.GetService<RoleService>().SearchRole(this.RoleSearchTextBox.Text);
    }
    #endregion

    #region Gestion des Entrepots

    private void LoadEntrepotCombobox() {
        this.entrepotSelector.DataSource = this.ParentFacade.GetService<EntrepotService>().GetAllEntrepots();
    }

    private void EntrepotSelector_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem is not null) {
            this.ActivateEntrepotsButtons();
        } else {
            this.DeactivateEntrepotsButtons();
        }
    }

    private void ActivateEntrepotsButtons() {
        this.viewEntrepotButton.Enabled = true;
        this.editEntrepotButton.Enabled = true;
        this.deleteEntrepotButton.Enabled = true;
    }

    private void DeactivateEntrepotsButtons() {
        this.viewEntrepotButton.Enabled = false;
        this.editEntrepotButton.Enabled = false;
        this.deleteEntrepotButton.Enabled = false;
    }

    private void CreateEntrepotButton_Click(object sender, EventArgs e) {
        EntrepotDTO? newEntrepot = this.ParentFacade.GetService<EntrepotService>().CreateNewDtoInstance();
        if (newEntrepot is not null) {
            this.LoadEntrepotCombobox();
            if (this.entrepotSelector.Items.Contains(newEntrepot)) {
                this.entrepotSelector.SelectedItem = newEntrepot;
            }
        }
    }

    private void ViewEntrepotButton_Click(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem == null) {
            _ = MessageBox.Show("Pas d'entrepôt sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<EntrepotService>().DisplayDtoInstance((EntrepotDTO) this.entrepotSelector.SelectedItem);
        }
    }

    private void EditEntrepotButton_Click(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem == null) {
            _ = MessageBox.Show("Pas d'entrepôt sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<EntrepotService>().UpdateDtoInstance((EntrepotDTO) this.entrepotSelector.SelectedItem);
            this.LoadEntrepotCombobox();
        }
    }

    private void DeleteEntrepotButton_Click(object sender, EventArgs e) {
        if (this.entrepotSelector.SelectedItem == null) {
            _ = MessageBox.Show("Pas d'entrepôt sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<EntrepotService>().DeleteDtoInstance((EntrepotDTO) this.entrepotSelector.SelectedItem);
            this.LoadEntrepotCombobox();
        }
    }

    #endregion

    #region Gestion des Restock Orders


    private void CreateROButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<RestockOrderService>().CreateNewDtoInstance();
    }

    private void RoSearchFilterTextBox_TextChanged(object sender, EventArgs e) {
        this.roSearchResultsListBox.DataSource =
            this.ParentFacade.GetService<RestockOrderService>().SearchRestockOrders(this.roSearchFilterTextBox.Text);
    }

    private void RoSearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e) {
        this.viewROButton.Enabled = this.roSearchResultsListBox.SelectedItem is not null;
    }

    private void ViewROButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<RestockOrderService>().DisplayDtoInstance(
            (RestockOrderDTO) this.roSearchResultsListBox.SelectedItem
            );
    }


    #endregion

    #region Gestion des Shipments

    private void HideShipmentButtons() {
        this.UpdateShipmentButton.Enabled = false;
        this.DeleteShipmentButton.Enabled = false;
        this.ViewShipmentButton.Enabled = false;   

    }
    private void ShowShipmentButtons() {
        this.UpdateShipmentButton.Enabled = true;
        this.DeleteShipmentButton.Enabled = true;
        this.ViewShipmentButton.Enabled = true;
    }
    private void CreateShipmentButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ShipmentsService>().CreateNewDtoInstance();
    }
    private void FilteredShipment_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.FilteredShipment.SelectedItem != null) {
            this.ShowShipmentButtons();
        } else {
            this.HideShipmentButtons();
        }
    }
    private void ViewShipmentButton_Click(object sender, EventArgs e) {

        _ = this.ParentFacade.GetService<ShipmentsService>().DisplayDtoInstance((ShipmentsDTO) this.FilteredShipment.SelectedItem);
    }

    private void UpdateShipmentButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ShipmentsService>().UpdateDtoInstance((ShipmentsDTO) this.FilteredShipment.SelectedItem);
    }

    private void DeleteShipmentButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ShipmentsService>().DeleteDtoInstance((ShipmentsDTO) this.FilteredShipment.SelectedItem);
    }
    #endregion

    #region gestion des ShipOrders

    private void HideShipOrdersButtons() {
        this.UpdateShipOrderButton.Enabled = false;
        this.DeleteShipOrderButton.Enabled = false;
        this.ViewShipOrderButton.Enabled = false;

    }
    private void ShowShipOrdersButtons() {
        this.UpdateShipOrderButton.Enabled = true;
        this.DeleteShipOrderButton.Enabled = true;
        this.ViewShipOrderButton.Enabled = true;
    }

    private void FilteredShipOrder_SelectedIndexChanged(object sender, EventArgs e) {
        if (this.FilteredShipment.SelectedItem != null) {
            this.ShowShipOrdersButtons();
        } else {
            this.HideShipOrdersButtons();
        }
    }
    private void CreateShiporderButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ShipOrdersService>().CreateNewDtoInstance();
    }

    private void ViewShipOrderButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ShipOrdersService>().DisplayDtoInstance((ShipOrdersDTO) this.FilteredShipment.SelectedItem);
    }

    private void UpdateShipOrderButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ShipOrdersService>().UpdateDtoInstance((ShipOrdersDTO) this.FilteredShipment.SelectedItem);
    }

    private void DeleteShipOrderButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<ShipOrdersService>().DeleteDtoInstance((ShipOrdersDTO) this.FilteredShipment.SelectedItem);
    }
    #endregion 


    private void ButtonQuit_Click(object sender, EventArgs e) {
        this.ParentFacade.ShutdownParentApplication();
    }
}
