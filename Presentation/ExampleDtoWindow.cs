using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;
using Microsoft.IdentityModel.Tokens;

namespace _420DA3_07451_Projet_Initial.Presentation;

/// <summary>
/// Exemple de classe de gestion d'entité spécifique.
/// </summary>
/// <remarks>
/// Hérite de <see cref="Form"/> et implémente <see cref="IDtoManagementView{DtoType}"/>.
/// </remarks>
public partial class ExampleDtoWindow : Form, IDtoManagementView<ExampleDTO> {
    private readonly AbstractFacade facade;
    private ExampleDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public ExampleDtoWindow(AbstractFacade facade) {
        this.facade = facade;
        // création d'une instance de DTO vide juste pour garantir qu'il y aura quelque chose
        // dans le champ associé et éviter de devoir dealer avec un type nullable.
        this.workingDtoInstance = new ExampleDTO("", null);
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(ExampleDTO blankInstance) {
        // Set de l'instance à travailler sur et de l'intention
        this.workingDtoInstance = blankInstance;
        this.workingViewIntent = ViewIntentEnum.Creation;

        // Changement du texte du bouton d'action.
        this.actionButton.Text = "Create";
        // Activation des contrôles graphiques pour entrer/modifier les données.
        this.EnableEditableFields();
        // chargement des valeurs de l'instance reçue en paramètre dans les contrôles graphiques.
        this.SetFields(blankInstance);

        return this.ShowDialog();
    }

    public DialogResult OpenForDeletion(ExampleDTO instance) {
        // Set de l'instance à travailler sur et de l'intention
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Deletion;

        // Changement du texte du bouton d'action.
        this.actionButton.Text = "Delete";
        // Désctivation des contrôles graphiques pour empêcher la modification des données.
        this.DisableEditableFields();
        // chargement des valeurs de l'instance reçue en paramètre dans les contrôles graphiques.
        this.SetFields(instance);

        return this.ShowDialog();
    }

    public DialogResult OpenForEdition(ExampleDTO instance) {
        // Set de l'instance à travailler sur et de l'intention
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Edition;

        // Changement du texte du bouton d'action.
        this.actionButton.Text = "Save";
        // Activation des contrôles graphiques pour entrer/modifier les données.
        this.EnableEditableFields();
        // chargement des valeurs de l'instance reçue en paramètre dans les contrôles graphiques.
        this.SetFields(instance);

        return this.ShowDialog();
    }

    public DialogResult OpenForVisualization(ExampleDTO instance) {
        // Set de l'instance à travailler sur et de l'intention
        this.workingDtoInstance = instance;
        this.workingViewIntent = ViewIntentEnum.Visualization;

        // Changement du texte du bouton d'action.
        this.actionButton.Text = "OK";
        // Désctivation des contrôles graphiques pour empêcher la modification des données.
        this.DisableEditableFields();
        // chargement des valeurs de l'instance reçue en paramètre dans les contrôles graphiques.
        this.SetFields(instance);

        return this.ShowDialog();
    }

    /// <summary>
    /// Remplis les contrôles graphiques de la fenêtre avec les valeurs des propriétés
    /// de l'instance de l'entité gérée reçue en paramètre.
    /// </summary>
    /// <param name="dto"></param>
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

    /// <summary>
    /// Désactive les contrôles graphiques des champs de données
    /// </summary>
    private void DisableEditableFields() {
        this.nameTextBox.Enabled = false;
        this.descriptionTextBox.Enabled = false;
    }

    /// <summary>
    /// Active les contrôles graphiques des champs de données
    /// </summary>
    private void EnableEditableFields() {
        this.nameTextBox.Enabled = true;
        this.descriptionTextBox.Enabled = true;
    }

    /// <summary>
    /// Actions à faire lorsque le bouton d'action est cliqué pour l'intention de création
    /// </summary>
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

    /// <summary>
    /// Actions à faire lorsque le bouton d'action est cliqué pour l'intention de visualisation
    /// </summary>
    private void DoVisualizeAction() {
        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Actions à faire lorsque le bouton d'action est cliqué pour l'intention d'édition
    /// </summary>
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

    /// <summary>
    /// Actions à faire lorsque le bouton d'action est cliqué pour l'intention de suppression
    /// </summary>
    private void DoDeleteAction() {
        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Gestionnaire de l'événement clic du bouton d'action.
    /// Déclenche les méthodes d'actions spécifiques selon l'intention au moment
    /// de l'ouverture de la fenêtre.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
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

    /// <summary>
    /// Gestionnaire de l'événement clic du bouton annuler.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
