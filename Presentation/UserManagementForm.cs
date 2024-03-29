﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
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
public partial class UserManagementForm : Form, IDtoManagementView<UserDTO>
{
    private readonly AbstractFacade facade;
    private UserDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;
    private int nullWarehouseCombobox = 0;

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="UserManagementForm"/>.
    /// </summary>
    /// <param name="facade">La façade abstraite fournissant l'accès à la logique métier.</param>
    public UserManagementForm(AbstractFacade facade)
    {
        this.facade = facade;
        this.workingDtoInstance = new UserDTO("", null);
        this.InitializeComponent();
        this.LoadRolesListBox(this.facade.GetService<RoleService>().GetRoles());
        this.LoadWarehousesInCombobox(this.facade.GetService<EntrepotService>().GetAllEntrepots());
    }

    public void LoadRolesListBox(List<RoleDTO> getRoles) {
        this.roleslistBox.Items.Clear();
        this.roleslistBox.Items.AddRange(getRoles.ToArray());
    }

    /// <summary>
    /// Ouvre le formulaire pour créer un nouvel utilisateur.
    /// </summary>
    /// <param name="blankInstance">L'instance d'utilisateur vide à remplir et à créer.</param>
    /// <returns>Le résultat de la boîte de dialogue.</returns>
    public DialogResult OpenForCreation(UserDTO blankInstance)
    {
        this.workingDtoInstance = blankInstance;
        this.workingViewIntent = ViewIntentEnum.Creation;

        this.actionButton.Text = "Create";
        this.EnableEditableFieldsCreate();
        _ = this.OpenFor(blankInstance);

        return this.ShowDialog();
    }
    /// <summary>
    /// Ouvre le formulaire pour supprimer un utilisateur existant.
    /// </summary>
    /// <param name="instance">L'instance d'utilisateur à supprimer.</param>
    /// <returns>Le résultat de la boîte de dialogue.</returns>
    public DialogResult OpenForDeletion(UserDTO instance)
    {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Deletion;

        this.actionButton.Text = "Delete";
        this.DisableEditableFields();
        _ = this.OpenFor(instance);

        return this.ShowDialog();
    }
    /// <summary>
    /// Ouvre le formulaire pour éditer un utilisateur existant.
    /// </summary>
    /// <param name="instance">L'instance d'utilisateur à éditer.</param>
    /// <returns>Le résultat de la boîte de dialogue.</returns>
    public DialogResult OpenForEdition(UserDTO instance)
    {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Edition;

        this.actionButton.Text = "Save";
        this.EnableEditableFields();
        _ = this.OpenFor(instance);

        return this.ShowDialog();
    }
    /// <summary>
    /// Ouvre le formulaire pour visualiser un utilisateur existant sans permettre de modifications.
    /// </summary>
    /// <param name="instance">L'instance d'utilisateur à visualiser.</param>
    /// <returns>Le résultat de la boîte de dialogue.</returns>
    public DialogResult OpenForVisualization(UserDTO instance)
    {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Visualization;

        this.actionButton.Text = "OK";
        this.DisableEditableFields();
        _ = this.OpenFor(instance);

        return this.ShowDialog();
    }

    private DialogResult OpenFor(UserDTO instance) {
        this.workingDtoInstance = instance;
        switch (this.workingViewIntent) {
            case ViewIntentEnum.Creation:
                this.EnableEditableFieldsCreate();
                break;
            case ViewIntentEnum.Edition:
                this.EnableEditableFields();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
            default:
                this.DisableEditableFields();
                break;
        }
        this.LoadUserDataInControls(instance);
        return this.ShowDialog();
    }
    /// <summary>
    /// Définit les champs du formulaire en fonction des valeurs de l'objet UserDTO.
    /// </summary>
    /// <param name="dto">L'objet UserDTO utilisé pour remplir les champs du formulaire.</param>
    private void SetFieldsValidate()
    {
        if (!UserDTO.ValidateNameUser(this.nameTextBox.Text)) {
            throw new Exception("Incorrect Username");
        }
        if (!string.IsNullOrEmpty(this.passwordTextBox.Text)
            && !UserDTO.ValidatePasswordUser(this.passwordTextBox.Text)) {
            throw new Exception("Incorect password");
        }
        if (string.IsNullOrEmpty(this.passwordHashtextBox.Text)) {
            throw new Exception("Password Hash is empty");
        } 
    }

    /// <summary>
    /// Désactive les champs éditables du formulaire.
    /// </summary>
    private void DisableEditableFields()
    {
        this.userIdNumeric.Enabled = false;
        this.nameTextBox.Enabled = false;
        this.passwordTextBox.Enabled = false;
        this.passwordHashtextBox.Enabled = false;
        this.dateCreationTextBox.Enabled = false;
        this.warehouseComboBox.Enabled = false;
        this.roleslistBox.Enabled = false;
    }

    /// <summary>
    /// Active les champs éditables du formulaire pour les creations.
    /// </summary>
    private void EnableEditableFieldsCreate()
    {
        this.userIdNumeric.Enabled = false;
        this.nameTextBox.Enabled = true;
        this.passwordTextBox.Enabled = true;
        this.passwordHashtextBox.Enabled = false;
        this.dateCreationTextBox.Enabled = false;
        this.warehouseComboBox.Enabled = true;
        this.roleslistBox.Enabled = true;
    }

    /// <summary>
    /// Active les champs éditables du formulaire.
    /// </summary>
    private void EnableEditableFields()
    {
        this.userIdNumeric.Enabled = false;
        this.nameTextBox.Enabled = false;
        this.passwordTextBox.Enabled = true;
        this.passwordHashtextBox.Enabled = false;
        this.dateCreationTextBox.Enabled = false;
        this.warehouseComboBox.Enabled = true;
        this.roleslistBox.Enabled = true;
    }

    /// <summary>
    /// Charge dans le combobox les entrepots.
    /// </summary>
    public void LoadWarehousesInCombobox(List<EntrepotDTO> warehouseList) {
        this.warehouseComboBox.Items.Clear();
        this.warehouseComboBox.Items.AddRange(warehouseList.ToArray());
        this.nullWarehouseCombobox = this.warehouseComboBox.Items.Add("Aucun");
        this.warehouseComboBox.Refresh();
    }

    /// <summary>
    /// Effectue l'action de création d'un utilisateur.
    /// </summary>
    private void DoCreateAction()
    {
        if (!UserDTO.ValidateNameUser(this.nameTextBox.Text))
        {
            this.nameTextBox.Invalidate();
            return;
        }
        if (!UserDTO.ValidateNameUser(this.passwordHashtextBox.Text))
        {
            this.passwordHashtextBox.Invalidate();
            return;
        }
        this.workingDtoInstance.UserName = this.nameTextBox.Text;
        this.workingDtoInstance.Password = this.passwordHashtextBox.Text.IsNullOrEmpty() ? null : this.passwordHashtextBox.Text;

        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Effectue l'action de modification d'un utilisateur.
    /// </summary>
    private void DoEditAction()
    {
        if (!UserDTO.ValidateNameUser(this.nameTextBox.Text))
        {
            this.nameTextBox.Invalidate();
            return;
        }
        if (!UserDTO.ValidatePasswordUser(this.passwordHashtextBox.Text))
        {
            this.passwordHashtextBox.Invalidate();
            return;
        }
        this.workingDtoInstance.Password = this.passwordHashtextBox.Text;
        this.workingDtoInstance.Password = this.passwordHashtextBox.Text.IsNullOrEmpty() ? null : this.passwordHashtextBox.Text;

        this.DialogResult = DialogResult.OK;
    }

    private void LoadUserDataInControls(UserDTO user) {
        this.userIdNumeric.Text = user.Id.ToString();
        this.nameTextBox.Text = user.UserName;
        this.passwordHashtextBox.Text = user.Password;
        this.dateCreationTextBox.Text = user.DateCreation.ToString();
        this.warehouseComboBox.SelectedItem =
            user.ShippingOrders is not null
            ? user.ShippingOrders
            : this.warehouseComboBox.Items[this.nullWarehouseCombobox];

        foreach (RoleDTO role in user.Roles) {
            this.roleslistBox.SelectedItems.Add(role);
        }
    }

    private void SaveDataInInstance() {
        this.SetFieldsValidate();
        this.workingDtoInstance.UserName = this.nameTextBox.Text;
        this.workingDtoInstance.Password = this.passwordHashtextBox.Text;

        if (this.warehouseComboBox.SelectedIndex == this.nullWarehouseCombobox) {
            this.workingDtoInstance.WarehouseWork = null;
            this.workingDtoInstance.WarehouseWork = null;
        } else {
            EntrepotDTO entrepotSelectionne = (EntrepotDTO) this.warehouseComboBox.SelectedItem;
            this.workingDtoInstance.WarehouseWork = entrepotSelectionne;
        }

        this.workingDtoInstance.Roles = this.roleslistBox.SelectedItems.Cast<RoleDTO>().ToList();
    }

    /// <summary>
    /// Gère l'événement de clic du bouton Annuler, définissant le DialogResult sur Annuler.
    /// </summary>
    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Gère l'événement de clic du bouton d'action.
    /// </summary>
    /// <param name="sender">L'objet déclenchant l'événement.</param>
    /// <param name="args">Les arguments de l'événement.</param>
    private void ActionButton_Click(object sender, EventArgs e)
    {
        try {
            switch (this.workingViewIntent) {
                case ViewIntentEnum.Creation:
                case ViewIntentEnum.Edition:
                    this.SaveDataInInstance();
                    break;
                case ViewIntentEnum.Deletion:
                case ViewIntentEnum.Visualization:
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message);
            return;
        }
    }
    private void NameTextBox_TextChanged(object sender, EventArgs e) {
        if (!UserDTO.ValidateNameUser(this.nameTextBox.Text)) {
            this.nameTextBox.ForeColor = Color.Red;
            this.nameTextBox.Invalidate(true);
        } else {
            this.nameTextBox.ForeColor = SystemColors.WindowText;
            this.nameTextBox.Invalidate(true);
        }
    }

    private void NameTextBox_Leave(object sender, EventArgs e) {
        UserDTO? existingUser =
            this.facade.GetService<UserService>().FindUserByUsername(this.nameTextBox.Text);
        if (existingUser is not null) {
            _ = MessageBox.Show("Un utilisateur avec le même username existe déjà!");
            this.nameTextBox.ForeColor = Color.Red;
            this.nameTextBox.Invalidate(true);
        }
    }
}
