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
    private void ActivateUserButtons() {
        this.EditUserButton.Enabled = true;
        this.ViewUserButton.Enabled = true;
        this.DeleteUserButton.Enabled = true;
    }

    private void DeactivateUserButtons() {
        this.EditUserButton.Enabled = false;
        this.ViewUserButton.Enabled = false;
        this.DeleteUserButton.Enabled = false;
    }
    private void CreateUserButton_Click(object sender, EventArgs e) {
        _ = this.ParentFacade.GetService<UserService>().CreateNewDtoInstance();
    }
    private void ViewUserButton_Click(object sender, EventArgs e) {
        if (this.UserComboBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Utilisateur Sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<AddressService>().DisplayDtoInstance((AddressDTO) this.UserComboBox.SelectedItem);
        }
    }

    private void EditUserButton_Click(object sender, EventArgs e) {
        if (this.UserComboBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Utilisateur Sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<AddressService>().DisplayDtoInstance((AddressDTO) this.UserComboBox.SelectedItem);
        }
    }

    private void DeleteUserButton_Click(object sender, EventArgs e) {
        if (this.UserComboBox.SelectedItem == null) {
            _ = MessageBox.Show("Aucun Utilisateur Sélectionné.");
        } else {
            _ = this.ParentFacade.GetService<AddressService>().DisplayDtoInstance((AddressDTO) this.UserComboBox.SelectedItem);
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
        this.filteredAddresses.DataSource = this.ParentFacade.GetService<AddressService>().SearchAddresses(this.addressSearchTextBox.Text);
    }
    #endregion

    private void ButtonQuit_Click(object sender, EventArgs e) {
        this.ParentFacade.ShutdownParentApplication();
    }
}
