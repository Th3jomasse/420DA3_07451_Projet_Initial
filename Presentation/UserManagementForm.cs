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
public partial class UserManagementForm : Form, IDtoManagementView<UserDTO>
{
    private readonly AbstractFacade facade;
    private UserDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="UserManagementForm"/>.
    /// </summary>
    /// <param name="facade">La façade abstraite fournissant l'accès à la logique métier.</param>
    public UserManagementForm(AbstractFacade facade)
    {
        this.facade = facade;
        this.workingDtoInstance = new UserDTO("", null);
        this.InitializeComponent();
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
        this.EnableEditableFields();
        this.SetFields(blankInstance);

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
        this.SetFields(instance);

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
        this.SetFields(instance);

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
        this.SetFields(instance);

        return this.ShowDialog();
    }

    /// <summary>
    /// Définit les champs du formulaire en fonction des valeurs de l'objet UserDTO.
    /// </summary>
    /// <param name="dto">L'objet UserDTO utilisé pour remplir les champs du formulaire.</param>
    private void SetFields(UserDTO dto)
    {

        this.idTextBox.Text = dto.Id.ToString() ?? "";
        this.nameTextBox.Text = dto.UserName ?? "";

        if (dto.DateCreation is null)
        {
            this.dateCreatedBox.Format = DateTimePickerFormat.Custom;
            this.dateCreatedBox.CustomFormat = "";
        } else
        {
            this.dateCreatedBox.Format = DateTimePickerFormat.Long;
            this.dateCreatedBox.Value = (DateTime) dto.DateCreation;
        }

    }

    /// <summary>
    /// Désactive les champs éditables du formulaire.
    /// </summary>
    private void DisableEditableFields()
    {
        this.nameTextBox.Enabled = false;
        this.roleIdTextBox.Enabled = false;
        this.warehouseIdtextBox.Enabled = false;
    }

    /// <summary>
    /// Active les champs éditables du formulaire.
    /// </summary>
    private void EnableEditableFields()
    {
        this.nameTextBox.Enabled = true;
        this.roleIdTextBox.Enabled = true;
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
    /// Effectue l'action de visualisation d'un utilisateur.
    /// </summary>
    private void DoVisualizeAction()
    {
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

    /// <summary>
    /// Effectue l'action de suppression d'un utilisateur.
    /// </summary>
    private void DoDeleteAction()
    {
        this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Gère l'événement de clic du bouton d'action.
    /// </summary>
    /// <param name="sender">L'objet déclenchant l'événement.</param>
    /// <param name="args">Les arguments de l'événement.</param>
    private void OnActionButtonClick(object? sender, EventArgs args)
    {
        switch (this.workingViewIntent)
        {
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
    /// Gère l'événement de clic du bouton Annuler, définissant le DialogResult sur Annuler.
    /// </summary>
    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
}
