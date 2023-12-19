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
            this.ActivateAddressButtons();
        } else {
            this.DeactivateAddressButtons();
        }
    }

    #endregion


    private void ButtonQuit_Click(object sender, EventArgs e) {
        this.ParentFacade.ShutdownParentApplication();
    }

}
