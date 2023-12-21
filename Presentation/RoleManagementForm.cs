using _420DA3_07451_Projet_Initial.Business.Abstracts;
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
public partial class RoleManagementForm : Form, IDtoManagementView<RoleDTO>
{
    private readonly AbstractFacade facade;
    private RoleDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public RoleManagementForm(AbstractFacade facade)
    {
        this.facade = facade;
        // création d'une instance de DTO vide juste pour garantir qu'il y aura quelque chose
        // dans le champ associé et éviter de devoir dealer avec un type nullable.
        this.workingDtoInstance = new RoleDTO("", null);
        this.InitializeComponent();
    }

    public DialogResult OpenForCreation(RoleDTO blankInstance) {
        this.workingViewIntent = ViewIntentEnum.Creation;
        this.actionButton.Text = "Créer!";
        return this.OpenFor(blankInstance);
    }

    public DialogResult OpenForDeletion(RoleDTO instance) {
        this.workingViewIntent = ViewIntentEnum.Deletion;
        this.actionButton.Text = "Supprimer!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(RoleDTO instance) {
        this.workingViewIntent = ViewIntentEnum.Edition;
        this.actionButton.Text = "Sauvegarder!";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForVisualization(RoleDTO instance) {
        this.workingViewIntent = ViewIntentEnum.Visualization;
        this.actionButton.Text = "OK";
        return this.OpenFor(instance);
    }
    private void ActivateControls() {
        this.idRoleComboBox.Enabled = false;
        this.roleNameTextBox.Enabled = true;
        this.userIdtextBox.Enabled = true;
        this.roleDescriptionTextBox.Enabled = true;
    }

    private void DeactivateControls() {
        this.idRoleComboBox.Enabled = true;
        this.roleNameTextBox.Enabled = false;
        this.userIdtextBox.Enabled = false;
        this.roleDescriptionTextBox.Enabled = false;
    }

    private DialogResult OpenFor(RoleDTO instance) {
        this.workingDtoInstance = instance;
        this.LoadInstanceDataInControls(instance);
        switch (this.workingViewIntent) {
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                this.ActivateControls();
                break;
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
                this.DeactivateControls();
                break;
            default:
                throw new NotImplementedException("Porbleme survenu.");
        }
        return this.ShowDialog();
    }
    private void LoadInstanceDataInControls(RoleDTO instance) {
        this.idRoleComboBox.Text = instance.Id.ToString();
        this.roleNameTextBox.Text = instance.RoleName;
        this.roleDescriptionLabel.Text = instance.RoleDescription;
    }
    private bool ValidateControlsData() {
        return this.idRoleComboBox.SelectedItem is null
            ? throw new Exception("Pas de Role sélectionnée.")
            : this.roleNameTextBox.Text.IsNullOrEmpty()
                ? throw new Exception("Nom Role vide.")
                : true;
    }
    /// <summary>
    /// Actions à faire lorsque le bouton d'action est cliqué pour l'intention de création
    /// </summary>
    private void DoCreateAction()
    {
        if (!RoleDTO.ValidateNameRole(this.roleNameTextBox.Text))
        {
            this.roleNameTextBox.Invalidate();
            return;
        }
        if (!RoleDTO.ValidateDescriptionRole(this.roleDescriptionTextBox.Text))
        {
            this.roleDescriptionLabel.Invalidate();
            return;
        }
        this.workingDtoInstance.RoleName = this.roleNameTextBox.Text;
        this.workingDtoInstance.RoleDescription = this.roleDescriptionTextBox.Text.IsNullOrEmpty() ? null : this.roleDescriptionLabel.Text;

        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Actions à faire lorsque le bouton d'action est cliqué pour l'intention d'édition
    /// </summary>
    private void DoEditAction()
    {
        if (!RoleDTO.ValidateNameRole(this.roleNameTextBox.Text))
        {
            this.roleNameTextBox.Invalidate();
            return;
        }
        if (!RoleDTO.ValidateDescriptionRole(this.roleDescriptionTextBox.Text))
        {
            this.roleDescriptionLabel.Invalidate();
            return;
        }
        this.workingDtoInstance.RoleName = this.roleNameTextBox.Text;
        this.workingDtoInstance.RoleDescription = this.roleDescriptionTextBox.Text.IsNullOrEmpty() ? null : this.roleDescriptionLabel.Text;

        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Gestionnaire de l'événement clic du bouton annuler.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

    /// <summary>
    /// Gestionnaire de l'événement clic du bouton d'action.
    /// Déclenche les méthodes d'actions spécifiques selon l'intention au moment
    /// de l'ouverture de la fenêtre.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void ActionButton_Click(object sender, EventArgs e)
    {
        try {
            if (this.ValidateControlsData()) {
                switch (this.workingViewIntent) {
                    case ViewIntentEnum.Creation:
                    case ViewIntentEnum.Edition:
                        break;
                    case ViewIntentEnum.Visualization:
                    case ViewIntentEnum.Deletion:
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
