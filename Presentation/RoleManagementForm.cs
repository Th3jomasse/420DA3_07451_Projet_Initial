﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
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
public partial class RoleManagementForm : Form, IDtoManagementView<RoleDTO> {
    private readonly AbstractFacade facade;
    private RoleDTO workingDtoInstance;
    private ViewIntentEnum? workingViewIntent;

    public RoleManagementForm(AbstractFacade facade) {
        this.facade = facade;
        // création d'une instance de DTO vide juste pour garantir qu'il y aura quelque chose
        // dans le champ associé et éviter de devoir dealer avec un type nullable.
        this.workingDtoInstance = new RoleDTO("", null);
        InitializeComponent();
    }
    public DialogResult OpenForCreation(RoleDTO blankInstance) {
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

    public DialogResult OpenForDeletion(RoleDTO instance) {
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

    public DialogResult OpenForEdition(RoleDTO instance) {
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

    public DialogResult OpenForVisualization(RoleDTO instance) {
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
    private void SetFields(RoleDTO dto) {

        this.idTextBox.Text = dto.Id.ToString() ?? "";
        this.roleNameTextBox.Text = dto.RoleName ?? "";
    }

    /// <summary>
    /// Désactive les contrôles graphiques des champs de données
    /// </summary>
    private void DisableEditableFields() {
        this.roleNameTextBox.Enabled = false;
        this.roleDescriptionTextBox.Enabled = false;
    }

    /// <summary>
    /// Active les contrôles graphiques des champs de données
    /// </summary>
    private void EnableEditableFields() {
        this.roleNameTextBox.Enabled = true;
        this.roleDescriptionTextBox.Enabled = true;
    }

    /// <summary>
    /// Actions à faire lorsque le bouton d'action est cliqué pour l'intention de création
    /// </summary>
    private void DoCreateAction() {
        if (!RoleDTO.ValidateNameRole(this.roleNameTextBox.Text)) {
            this.roleNameTextBox.Invalidate();
            return;
        }
        if (!RoleDTO.ValidateDescriptionRole(this.roleDescriptionTextBox.Text)) {
            this.roleDescriptionLabel.Invalidate();
            return;
        }
        this.workingDtoInstance.RoleName = this.roleNameTextBox.Text;
        this.workingDtoInstance.RoleDescription = this.roleDescriptionTextBox.Text.IsNullOrEmpty() ? null : this.roleDescriptionLabel.Text;

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
        if (!RoleDTO.ValidateNameRole(this.roleNameTextBox.Text)) {
            this.roleNameTextBox.Invalidate();
            return;
        }
        if (!RoleDTO.ValidateDescriptionRole(this.roleDescriptionTextBox.Text)) {
            this.roleDescriptionLabel.Invalidate();
            return;
        }
        this.workingDtoInstance.RoleName = this.roleNameTextBox.Text;
        this.workingDtoInstance.RoleDescription = this.roleDescriptionTextBox.Text.IsNullOrEmpty() ? null : this.roleDescriptionLabel.Text;

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
