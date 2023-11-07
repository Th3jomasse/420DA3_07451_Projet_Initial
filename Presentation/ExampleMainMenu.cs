using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;

namespace _420DA3_07451_Projet_Initial.Presentation;

/// <summary>
/// Menu principal de l'application. Les fenêtres de gestion d'entités s'ouvriront par
/// dessus celle-ci selon les actions de l'utilisateur.
/// </summary>
public partial class ExampleMainMenu : Form {
    private readonly ExampleService service;
    private readonly AbstractFacade facade;

    public ExampleMainMenu(AbstractFacade facade) {
        this.facade = facade;
        this.service = facade.GetService<ExampleService>();
        this.InitializeComponent();
        // remplissage du combobox d'ExemplesDTO sélectionnable
        this.RefreshList();
    }

    /// <summary>
    /// Vide, efface la sélection et rerempli le combobox. En gros, met à jour la liste
    /// d'ExampleDTO dans le combobox.
    /// </summary>
    private void RefreshList() {
        object selected = this.examplesComboBox.SelectedItem;
        this.examplesComboBox.Items.Clear();
        this.examplesComboBox.Items.AddRange(this.service.GetAllExamples().ToArray());
        this.examplesComboBox.SelectedItem = selected;
        this.examplesComboBox.Refresh();
    }

    /// <summary>
    /// Gestion de l'événement clic sur le bouton de création d'ExempleDTO.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateButton_Click(object sender, EventArgs e) {
        // déclenche la création (ouvre la fenêtre etc...)
        ExampleDTO? createdInstance = this.service.CreateNewDtoInstance();

        // si instance créée (opération complétée, pas annulée par l'utilisateur, alors l'afficher...
        if (createdInstance is not null) {
            _ = this.service.DisplayDtoInstance(createdInstance);
            // ... et recharger la liste du combobox (avec maintenant la nouvelle instance créée dans la liste)
            this.RefreshList();
        }
    }

    /// <summary>
    /// Gestion de l'événement clic sur le bouton de visualisation d'ExempleDTO.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ViewButton_Click(object sender, EventArgs e) {
        _ = this.service.DisplayDtoInstance((ExampleDTO) this.examplesComboBox.SelectedItem);
    }

    /// <summary>
    /// Gestion de l'événement clic sur le bouton d'édition d'ExempleDTO.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EditButton_Click(object sender, EventArgs e) {

        // même principe que pour CreateButton_Click, mais sans l'affichare post-action
        ExampleDTO? editedInstance = this.service.UpdateDtoInstance((ExampleDTO) this.examplesComboBox.SelectedItem);
        if (editedInstance is not null) {
            this.RefreshList();
        }
    }

    /// <summary>
    /// Gestion de l'événement clic sur le bouton de suppression d'ExempleDTO.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteButton_Click(object sender, EventArgs e) {

        // même principe que pour CreateButton_Click, mais sans l'affichare post-action
        ExampleDTO? deletedInstance = this.service.DeleteDtoInstance((ExampleDTO) this.examplesComboBox.SelectedItem);
        if (deletedInstance is not null) {
            this.RefreshList();
        }
    }

    private void ExitButton_Click(object sender, EventArgs e) {
        this.Hide();
        this.facade.ShutdownParentApplication();
    }
}
