using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System.ComponentModel;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ExampleMainMenu : Form {
    private readonly ExampleService service;
    private readonly AbstractApplication application;
    private List<ExampleDTO> examplesList;

    public ExampleMainMenu(AbstractApplication app, ExampleService service, List<ExampleDTO> list) {
        this.examplesList = list;
        this.application = app;
        this.service = service;
        this.InitializeComponent();
        this.RefreshList();
    }

    public void SetExamplesList(List<ExampleDTO> list) {
        this.examplesList = list;
    }

    private void RefreshList() {
        object selected = this.examplesComboBox.SelectedItem;
        this.examplesComboBox.Items.Clear();
        this.examplesComboBox.Items.AddRange(this.examplesList.ToArray());
        this.examplesComboBox.SelectedItem = selected;
        this.examplesComboBox.Refresh();
    }

    private void CreateButton_Click(object sender, EventArgs e) {
        ExampleDTO? createdInstance = this.service.CreateNewExample();
        if (createdInstance is not null) {
            this.examplesList.Add(createdInstance);
            _ = this.service.DisplayExample(createdInstance);
            this.RefreshList();
        }
    }

    private void ViewButton_Click(object sender, EventArgs e) {
        _ = this.service.DisplayExample((ExampleDTO) this.examplesComboBox.SelectedItem);
    }

    private void EditButton_Click(object sender, EventArgs e) {
        ExampleDTO? editedInstance = this.service.EditExample((ExampleDTO) this.examplesComboBox.SelectedItem);
        if (editedInstance is not null) {
            this.RefreshList();
        }
    }

    private void DeleteButton_Click(object sender, EventArgs e) {
        ExampleDTO? deletedInstance = this.service.DeleteExample((ExampleDTO) this.examplesComboBox.SelectedItem);
        if (deletedInstance is not null) {
            _ = this.examplesList.Remove(deletedInstance);
            this.RefreshList();
        }
    }

    private void ExitButton_Click(object sender, EventArgs e) {
        this.Hide();
        this.application.Shutdown();
    }
}
