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
public partial class UserManagementForm : Form, IDtoManagementView<UserDTO> {
    private readonly AbstractFacade facade;
    private UserDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public UserManagementForm(AbstractFacade facade) {
        this.facade = facade;
        this.workingDtoInstance = new UserDTO("", null);
        this.InitializeComponent();
    }
    public DialogResult OpenForCreation(UserDTO blankInstance) {
        this.workingDtoInstance = blankInstance;
        this.workingViewIntent = ViewIntentEnum.Creation;

        this.actionButton.Text = "Create";
        this.EnableEditableFields();
        this.SetFields(blankInstance);

        return this.ShowDialog();
    }

    public DialogResult OpenForDeletion(UserDTO instance) {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Deletion;

        this.actionButton.Text = "Delete";
        this.DisableEditableFields();
        this.SetFields(instance);

        return this.ShowDialog();
    }

    public DialogResult OpenForEdition(UserDTO instance) {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Edition;

        this.actionButton.Text = "Save";
        this.EnableEditableFields();
        this.SetFields(instance);

        return this.ShowDialog();
    }

    public DialogResult OpenForVisualization(UserDTO instance) {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Visualization;

        this.actionButton.Text = "OK";
        this.DisableEditableFields();
        this.SetFields(instance);

        return this.ShowDialog();
    }

    private void SetFields(UserDTO dto) {

        this.idTextBox.Text = dto.Id.ToString() ?? "";
        this.nameTextBox.Text = dto.UserName ?? "";

        if (dto.DateCreation is null) {
            this.dateCreatedBox.Format = DateTimePickerFormat.Custom;
            this.dateCreatedBox.CustomFormat = "";
        } else {
            this.dateCreatedBox.Format = DateTimePickerFormat.Long;
            this.dateCreatedBox.Value = (DateTime) dto.DateCreation;
        }

    }

    private void DisableEditableFields() {
        this.nameTextBox.Enabled = false;
        this.roleIdTextBox.Enabled = false;
        this.warehouseIdtextBox.Enabled = false;
    }

    private void EnableEditableFields() {
        this.nameTextBox.Enabled = true;
        this.roleIdTextBox.Enabled = true;
    }

    private void DoCreateAction() {
        if (!UserDTO.ValidateNameUser(this.nameTextBox.Text)) {
            this.nameTextBox.Invalidate();
            return;
        }
        if (!UserDTO.ValidateNameUser(this.passwordHashtextBox.Text)) {
            this.passwordHashtextBox.Invalidate();
            return;
        }
        this.workingDtoInstance.UserName = this.nameTextBox.Text;
        this.workingDtoInstance.Password = this.passwordHashtextBox.Text.IsNullOrEmpty() ? null : this.passwordHashtextBox.Text;

        this.DialogResult = DialogResult.OK;
    }

    private void DoVisualizeAction() {
        this.DialogResult = DialogResult.OK;
    }

    private void DoEditAction() {
        if (!UserDTO.ValidateNameUser(this.nameTextBox.Text)) {
            this.nameTextBox.Invalidate();
            return;
        }
        if (!UserDTO.ValidatePasswordUser(this.passwordHashtextBox.Text)) {
            this.passwordHashtextBox.Invalidate();
            return;
        }
        this.workingDtoInstance.Password = this.passwordHashtextBox.Text;
        this.workingDtoInstance.Password = this.passwordHashtextBox.Text.IsNullOrEmpty() ? null : this.passwordHashtextBox.Text;

        this.DialogResult = DialogResult.OK;
    }

    private void DoDeleteAction() {
        this.DialogResult = DialogResult.OK;
    }

    private void OnActionButtonClick(object? sender, EventArgs args) {
        switch (this.workingViewIntent) {
            case ViewIntentEnum.Creation:
                this.DoCreateAction();
                break;
            case ViewIntentEnum.Edition:
                this.DoEditAction();
                break;
            case ViewIntentEnum.Deletion:
                this.DoDeleteAction();
                break;
            case ViewIntentEnum.Visualization:
            default:
                this.DoVisualizeAction();
                break;
        }
    }

    
    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
