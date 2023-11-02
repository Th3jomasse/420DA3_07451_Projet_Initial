
using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using Microsoft.IdentityModel.Tokens;

namespace _420DA3_07451_Projet_Initial.Presentation;

public partial class ExampleDtoForm : Form, IDtoManagementView<ExampleDTO> {
    private readonly ExampleService service;
    private ExampleDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public ExampleDtoForm(ExampleService service) {
        this.service = service;
        this.workingDtoInstance = new ExampleDTO("", null);
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(ExampleDTO blankInstance) {
        this.workingDtoInstance = blankInstance;
        this.workingViewIntent = ViewIntentEnum.Creation;

        this.actionButton.Text = "Create";
        this.EnableEditableFields();
        this.SetFields(blankInstance);

        return this.ShowDialog();
    }

    public DialogResult OpenForDeletion(ExampleDTO instance) {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Deletion;

        this.actionButton.Text = "Delete";
        this.DisableEditableFields();
        this.SetFields(instance);

        return this.ShowDialog();
    }

    public DialogResult OpenForEdition(ExampleDTO instance) {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Edition;

        this.actionButton.Text = "Save";
        this.EnableEditableFields();
        this.SetFields(instance);

        return this.ShowDialog();
    }

    public DialogResult OpenForVisualization(ExampleDTO instance) {
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Visualization;

        this.actionButton.Text = "OK";
        this.DisableEditableFields();
        this.SetFields(instance);

        return this.ShowDialog();
    }

    private void SetFields(ExampleDTO dto) {

        this.idTextBox.Text = dto.Id.ToString() ?? "";
        this.nameTextBox.Text = dto.Name ?? "";
        this.descriptionTextBox.Text = dto.Description ?? "";

        if (dto.DateCreated is null) {
            this.dateCreatedBox.Format = DateTimePickerFormat.Custom;
            this.dateCreatedBox.CustomFormat = "";
        } else {
            this.dateCreatedBox.Format = DateTimePickerFormat.Long;
            this.dateCreatedBox.Value = (DateTime) dto.DateCreated;
        }

        if (dto.DateUpdated is null) {
            this.dateUpdatedBox.Format = DateTimePickerFormat.Custom;
            this.dateUpdatedBox.CustomFormat = "";
        } else {
            this.dateUpdatedBox.Format = DateTimePickerFormat.Long;
            this.dateUpdatedBox.Value = (DateTime) dto.DateUpdated;
        }

        if (dto.DateDeleted is null) {
            this.dateDeletedBox.Format = DateTimePickerFormat.Custom;
            this.dateDeletedBox.CustomFormat = "";
        } else {
            this.dateDeletedBox.Format = DateTimePickerFormat.Long;
            this.dateDeletedBox.Value = (DateTime) dto.DateDeleted;
        }

    }

    private void DisableEditableFields() {
        this.nameTextBox.Enabled = false;
        this.descriptionTextBox.Enabled = false;
    }

    private void EnableEditableFields() {
        this.nameTextBox.Enabled = true;
        this.descriptionTextBox.Enabled = true;
    }

    private void DoCreateAction() {
        if (!ExampleDTO.ValidateName(this.nameTextBox.Text)) {
            this.nameTextBox.Invalidate();
            return;
        }
        if (!ExampleDTO.ValidateDescription(this.descriptionTextBox.Text)) {
            this.descriptionTextBox.Invalidate();
            return;
        }
        this.workingDtoInstance.Name = this.nameTextBox.Text;
        this.workingDtoInstance.Description = this.descriptionTextBox.Text.IsNullOrEmpty() ? null : this.descriptionTextBox.Text;

        this.DialogResult = DialogResult.OK;
    }

    private void DoVisualizeAction() {
        this.DialogResult = DialogResult.OK;
    }

    private void DoEditAction() {
        if (!ExampleDTO.ValidateName(this.nameTextBox.Text)) {
            this.nameTextBox.Invalidate();
            return;
        }
        if (!ExampleDTO.ValidateDescription(this.descriptionTextBox.Text)) {
            this.descriptionTextBox.Invalidate();
            return;
        }
        this.workingDtoInstance.Name = this.nameTextBox.Text;
        this.workingDtoInstance.Description = this.descriptionTextBox.Text.IsNullOrEmpty() ? null : this.descriptionTextBox.Text;

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
