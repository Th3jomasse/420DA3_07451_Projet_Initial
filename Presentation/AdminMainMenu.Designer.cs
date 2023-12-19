namespace _420DA3_07451_Projet_Initial.Presentation;

partial class AdminMainMenu {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.bottomBarPanel = new Panel();
        this.buttonQuit = new Button();
        this.topBarPanel = new Panel();
        this.mainPanel = new TableLayoutPanel();
        this.addressManagementPanel = new Panel();
        this.addressMgmtMainPanel = new Panel();
        this.deleteAddressButton = new Button();
        this.editAddressButton = new Button();
        this.viewAddressButton = new Button();
        this.filteredAddresses = new ListBox();
        this.addressSearchTextBox = new TextBox();
        this.existingAddressesLabel = new Label();
        this.createAddressButton = new Button();
        this.addressMgmtTopBar = new Panel();
        this.addressMgmtLabel = new Label();
        this.clientsMgmtPanel = new Panel();
        this.clientMgmtTopBar = new Panel();
        this.clientMgmtLabel = new Label();
        this.clientMgmtMainPanel = new Panel();
        this.clientCreateButton = new Button();
        this.existingClientsLabel = new Label();
        this.clientFilteringBox = new TextBox();
        this.filteredClients = new ListBox();
        this.clientDeleteButton = new Button();
        this.clientEditButton = new Button();
        this.clientViewButton = new Button();
        this.bottomBarPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        this.addressManagementPanel.SuspendLayout();
        this.addressMgmtMainPanel.SuspendLayout();
        this.addressMgmtTopBar.SuspendLayout();
        this.clientsMgmtPanel.SuspendLayout();
        this.clientMgmtTopBar.SuspendLayout();
        this.clientMgmtMainPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.buttonQuit);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 821);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1184, 40);
        this.bottomBarPanel.TabIndex = 0;
        // 
        // buttonQuit
        // 
        this.buttonQuit.Location = new Point(1069, 6);
        this.buttonQuit.Name = "buttonQuit";
        this.buttonQuit.Size = new Size(103, 31);
        this.buttonQuit.TabIndex = 0;
        this.buttonQuit.Text = "Quitter";
        this.buttonQuit.UseVisualStyleBackColor = true;
        this.buttonQuit.Click += this.ButtonQuit_Click;
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1184, 40);
        this.topBarPanel.TabIndex = 1;
        // 
        // mainPanel
        // 
        this.mainPanel.ColumnCount = 5;
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.mainPanel.Controls.Add(this.addressManagementPanel, 1, 0);
        this.mainPanel.Controls.Add(this.clientsMgmtPanel, 1, 1);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(0, 40);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.RowCount = 2;
        this.mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainPanel.Size = new Size(1184, 781);
        this.mainPanel.TabIndex = 2;
        // 
        // addressManagementPanel
        // 
        this.addressManagementPanel.Controls.Add(this.addressMgmtMainPanel);
        this.addressManagementPanel.Controls.Add(this.addressMgmtTopBar);
        this.addressManagementPanel.Dock = DockStyle.Fill;
        this.addressManagementPanel.Location = new Point(239, 3);
        this.addressManagementPanel.Name = "addressManagementPanel";
        this.addressManagementPanel.Padding = new Padding(10);
        this.addressManagementPanel.Size = new Size(230, 384);
        this.addressManagementPanel.TabIndex = 0;
        // 
        // addressMgmtMainPanel
        // 
        this.addressMgmtMainPanel.Controls.Add(this.deleteAddressButton);
        this.addressMgmtMainPanel.Controls.Add(this.editAddressButton);
        this.addressMgmtMainPanel.Controls.Add(this.viewAddressButton);
        this.addressMgmtMainPanel.Controls.Add(this.filteredAddresses);
        this.addressMgmtMainPanel.Controls.Add(this.addressSearchTextBox);
        this.addressMgmtMainPanel.Controls.Add(this.existingAddressesLabel);
        this.addressMgmtMainPanel.Controls.Add(this.createAddressButton);
        this.addressMgmtMainPanel.Dock = DockStyle.Fill;
        this.addressMgmtMainPanel.Location = new Point(10, 50);
        this.addressMgmtMainPanel.Name = "addressMgmtMainPanel";
        this.addressMgmtMainPanel.Size = new Size(210, 324);
        this.addressMgmtMainPanel.TabIndex = 1;
        // 
        // deleteAddressButton
        // 
        this.deleteAddressButton.Dock = DockStyle.Top;
        this.deleteAddressButton.Location = new Point(0, 245);
        this.deleteAddressButton.Name = "deleteAddressButton";
        this.deleteAddressButton.Size = new Size(210, 35);
        this.deleteAddressButton.TabIndex = 6;
        this.deleteAddressButton.Text = "Supprimer l'Adresse";
        this.deleteAddressButton.UseVisualStyleBackColor = true;
        this.deleteAddressButton.Click += this.DeleteAddressButton_Click;
        // 
        // editAddressButton
        // 
        this.editAddressButton.Dock = DockStyle.Top;
        this.editAddressButton.Location = new Point(0, 210);
        this.editAddressButton.Name = "editAddressButton";
        this.editAddressButton.Size = new Size(210, 35);
        this.editAddressButton.TabIndex = 5;
        this.editAddressButton.Text = "Modifier l'Adresse";
        this.editAddressButton.UseVisualStyleBackColor = true;
        this.editAddressButton.Click += this.EditAddressButton_Click;
        // 
        // viewAddressButton
        // 
        this.viewAddressButton.Dock = DockStyle.Top;
        this.viewAddressButton.Location = new Point(0, 175);
        this.viewAddressButton.Name = "viewAddressButton";
        this.viewAddressButton.Size = new Size(210, 35);
        this.viewAddressButton.TabIndex = 4;
        this.viewAddressButton.Text = "Voir Détails";
        this.viewAddressButton.UseVisualStyleBackColor = true;
        this.viewAddressButton.Click += this.ViewAddressButton_Click;
        // 
        // filteredAddresses
        // 
        this.filteredAddresses.Dock = DockStyle.Top;
        this.filteredAddresses.FormattingEnabled = true;
        this.filteredAddresses.ItemHeight = 15;
        this.filteredAddresses.Location = new Point(0, 81);
        this.filteredAddresses.Name = "filteredAddresses";
        this.filteredAddresses.Size = new Size(210, 94);
        this.filteredAddresses.TabIndex = 3;
        this.filteredAddresses.SelectedIndexChanged += this.FilteredAddresses_SelectedIndexChanged;
        // 
        // addressSearchTextBox
        // 
        this.addressSearchTextBox.Dock = DockStyle.Top;
        this.addressSearchTextBox.Location = new Point(0, 58);
        this.addressSearchTextBox.Name = "addressSearchTextBox";
        this.addressSearchTextBox.Size = new Size(210, 23);
        this.addressSearchTextBox.TabIndex = 2;
        this.addressSearchTextBox.TextChanged += this.AddressSearchTextBox_TextChanged;
        // 
        // existingAddressesLabel
        // 
        this.existingAddressesLabel.Dock = DockStyle.Top;
        this.existingAddressesLabel.Location = new Point(0, 35);
        this.existingAddressesLabel.Name = "existingAddressesLabel";
        this.existingAddressesLabel.Size = new Size(210, 23);
        this.existingAddressesLabel.TabIndex = 1;
        this.existingAddressesLabel.Text = "Adresses existantes:";
        this.existingAddressesLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // createAddressButton
        // 
        this.createAddressButton.Dock = DockStyle.Top;
        this.createAddressButton.Location = new Point(0, 0);
        this.createAddressButton.Name = "createAddressButton";
        this.createAddressButton.Size = new Size(210, 35);
        this.createAddressButton.TabIndex = 0;
        this.createAddressButton.Text = "Nouvelle Adresse";
        this.createAddressButton.UseVisualStyleBackColor = true;
        this.createAddressButton.Click += this.CreateAddressButton_Click;
        // 
        // addressMgmtTopBar
        // 
        this.addressMgmtTopBar.Controls.Add(this.addressMgmtLabel);
        this.addressMgmtTopBar.Dock = DockStyle.Top;
        this.addressMgmtTopBar.Location = new Point(10, 10);
        this.addressMgmtTopBar.Name = "addressMgmtTopBar";
        this.addressMgmtTopBar.Size = new Size(210, 40);
        this.addressMgmtTopBar.TabIndex = 0;
        // 
        // addressMgmtLabel
        // 
        this.addressMgmtLabel.Dock = DockStyle.Fill;
        this.addressMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.addressMgmtLabel.Location = new Point(0, 0);
        this.addressMgmtLabel.Name = "addressMgmtLabel";
        this.addressMgmtLabel.Size = new Size(210, 40);
        this.addressMgmtLabel.TabIndex = 0;
        this.addressMgmtLabel.Text = "Gestion des Adresses";
        this.addressMgmtLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientsMgmtPanel
        // 
        this.clientsMgmtPanel.Controls.Add(this.clientMgmtMainPanel);
        this.clientsMgmtPanel.Controls.Add(this.clientMgmtTopBar);
        this.clientsMgmtPanel.Dock = DockStyle.Fill;
        this.clientsMgmtPanel.Location = new Point(239, 393);
        this.clientsMgmtPanel.Name = "clientsMgmtPanel";
        this.clientsMgmtPanel.Padding = new Padding(10);
        this.clientsMgmtPanel.Size = new Size(230, 385);
        this.clientsMgmtPanel.TabIndex = 1;
        // 
        // clientMgmtTopBar
        // 
        this.clientMgmtTopBar.Controls.Add(this.clientMgmtLabel);
        this.clientMgmtTopBar.Dock = DockStyle.Top;
        this.clientMgmtTopBar.Location = new Point(10, 10);
        this.clientMgmtTopBar.Name = "clientMgmtTopBar";
        this.clientMgmtTopBar.Size = new Size(210, 40);
        this.clientMgmtTopBar.TabIndex = 0;
        // 
        // clientMgmtLabel
        // 
        this.clientMgmtLabel.Dock = DockStyle.Fill;
        this.clientMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.clientMgmtLabel.Location = new Point(0, 0);
        this.clientMgmtLabel.Name = "clientMgmtLabel";
        this.clientMgmtLabel.Size = new Size(210, 40);
        this.clientMgmtLabel.TabIndex = 0;
        this.clientMgmtLabel.Text = "Gestion des clients";
        this.clientMgmtLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientMgmtMainPanel
        // 
        this.clientMgmtMainPanel.Controls.Add(this.clientDeleteButton);
        this.clientMgmtMainPanel.Controls.Add(this.clientEditButton);
        this.clientMgmtMainPanel.Controls.Add(this.clientViewButton);
        this.clientMgmtMainPanel.Controls.Add(this.filteredClients);
        this.clientMgmtMainPanel.Controls.Add(this.clientFilteringBox);
        this.clientMgmtMainPanel.Controls.Add(this.existingClientsLabel);
        this.clientMgmtMainPanel.Controls.Add(this.clientCreateButton);
        this.clientMgmtMainPanel.Dock = DockStyle.Fill;
        this.clientMgmtMainPanel.Location = new Point(10, 50);
        this.clientMgmtMainPanel.Name = "clientMgmtMainPanel";
        this.clientMgmtMainPanel.Size = new Size(210, 325);
        this.clientMgmtMainPanel.TabIndex = 1;
        // 
        // clientCreateButton
        // 
        this.clientCreateButton.Dock = DockStyle.Top;
        this.clientCreateButton.Location = new Point(0, 0);
        this.clientCreateButton.Name = "clientCreateButton";
        this.clientCreateButton.Size = new Size(210, 35);
        this.clientCreateButton.TabIndex = 1;
        this.clientCreateButton.Text = "Nouveau Client";
        this.clientCreateButton.UseVisualStyleBackColor = true;
        this.clientCreateButton.Click += this.ClientCreateButton_Click;
        // 
        // existingClientsLabel
        // 
        this.existingClientsLabel.Dock = DockStyle.Top;
        this.existingClientsLabel.Location = new Point(0, 35);
        this.existingClientsLabel.Name = "existingClientsLabel";
        this.existingClientsLabel.Size = new Size(210, 23);
        this.existingClientsLabel.TabIndex = 2;
        this.existingClientsLabel.Text = "Clients existants:";
        this.existingClientsLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientFilteringBox
        // 
        this.clientFilteringBox.Dock = DockStyle.Top;
        this.clientFilteringBox.Location = new Point(0, 58);
        this.clientFilteringBox.Name = "clientFilteringBox";
        this.clientFilteringBox.Size = new Size(210, 23);
        this.clientFilteringBox.TabIndex = 3;
        this.clientFilteringBox.TextChanged += this.ClientFilteringBox_TextChanged;
        // 
        // filteredClients
        // 
        this.filteredClients.Dock = DockStyle.Top;
        this.filteredClients.FormattingEnabled = true;
        this.filteredClients.ItemHeight = 15;
        this.filteredClients.Location = new Point(0, 81);
        this.filteredClients.Name = "filteredClients";
        this.filteredClients.Size = new Size(210, 94);
        this.filteredClients.TabIndex = 4;
        this.filteredClients.SelectedIndexChanged += this.FilteredClients_SelectedIndexChanged;
        // 
        // clientDeleteButton
        // 
        this.clientDeleteButton.Dock = DockStyle.Top;
        this.clientDeleteButton.Location = new Point(0, 245);
        this.clientDeleteButton.Name = "clientDeleteButton";
        this.clientDeleteButton.Size = new Size(210, 35);
        this.clientDeleteButton.TabIndex = 9;
        this.clientDeleteButton.Text = "Supprimer l'Adresse";
        this.clientDeleteButton.UseVisualStyleBackColor = true;
        this.clientDeleteButton.Click += this.ClientDeleteButton_Click;
        // 
        // clientEditButton
        // 
        this.clientEditButton.Dock = DockStyle.Top;
        this.clientEditButton.Location = new Point(0, 210);
        this.clientEditButton.Name = "clientEditButton";
        this.clientEditButton.Size = new Size(210, 35);
        this.clientEditButton.TabIndex = 8;
        this.clientEditButton.Text = "Modifier l'Adresse";
        this.clientEditButton.UseVisualStyleBackColor = true;
        this.clientEditButton.Click += this.ClientEditButton_Click;
        // 
        // clientViewButton
        // 
        this.clientViewButton.Dock = DockStyle.Top;
        this.clientViewButton.Location = new Point(0, 175);
        this.clientViewButton.Name = "clientViewButton";
        this.clientViewButton.Size = new Size(210, 35);
        this.clientViewButton.TabIndex = 7;
        this.clientViewButton.Text = "Voir Détails";
        this.clientViewButton.UseVisualStyleBackColor = true;
        this.clientViewButton.Click += this.ClientViewButton_Click;
        // 
        // AdminMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1184, 861);
        this.Controls.Add(this.mainPanel);
        this.Controls.Add(this.topBarPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Name = "AdminMainMenu";
        this.Text = "Menu Administration";
        this.WindowState = FormWindowState.Maximized;
        this.bottomBarPanel.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.addressManagementPanel.ResumeLayout(false);
        this.addressMgmtMainPanel.ResumeLayout(false);
        this.addressMgmtMainPanel.PerformLayout();
        this.addressMgmtTopBar.ResumeLayout(false);
        this.clientsMgmtPanel.ResumeLayout(false);
        this.clientMgmtTopBar.ResumeLayout(false);
        this.clientMgmtMainPanel.ResumeLayout(false);
        this.clientMgmtMainPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel bottomBarPanel;
    private Button buttonQuit;
    private Panel topBarPanel;
    private TableLayoutPanel mainPanel;
    private Panel addressManagementPanel;
    private Panel addressMgmtMainPanel;
    private Button createAddressButton;
    private Panel addressMgmtTopBar;
    private Label addressMgmtLabel;
    private Label existingAddressesLabel;
    private TextBox addressSearchTextBox;
    private Button viewAddressButton;
    private ListBox filteredAddresses;
    private Button deleteAddressButton;
    private Button editAddressButton;
    private Panel clientsMgmtPanel;
    private Panel clientMgmtTopBar;
    private Panel clientMgmtMainPanel;
    private Button clientCreateButton;
    private Label clientMgmtLabel;
    private Button clientDeleteButton;
    private Button clientEditButton;
    private Button clientViewButton;
    private ListBox filteredClients;
    private TextBox clientFilteringBox;
    private Label existingClientsLabel;
}