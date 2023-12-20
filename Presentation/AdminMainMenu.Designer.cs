namespace _420DA3_07451_Projet_Initial.Presentation;

partial class AdminMainMenu
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        bottomBarPanel = new Panel();
        buttonQuit = new Button();
        topBarPanel = new Panel();
        mainPanel = new TableLayoutPanel();
        addressManagementPanel = new Panel();
        addressMgmtMainPanel = new Panel();
        deleteAddressButton = new Button();
        editAddressButton = new Button();
        viewAddressButton = new Button();
        filteredAddresses = new ListBox();
        addressSearchTextBox = new TextBox();
        existingAddressesLabel = new Label();
        createAddressButton = new Button();
        addressMgmtTopBar = new Panel();
        addressMgmtLabel = new Label();
        clientsMgmtPanel = new Panel();
        clientMgmtMainPanel = new Panel();
        clientDeleteButton = new Button();
        clientEditButton = new Button();
        clientViewButton = new Button();
        filteredClients = new ListBox();
        clientFilteringBox = new TextBox();
        existingClientsLabel = new Label();
        clientCreateButton = new Button();
        clientMgmtTopBar = new Panel();
        clientMgmtLabel = new Label();
        panel1 = new Panel();
        DeleteUserButton = new Button();
        EditUserButton = new Button();
        ViewUserButton = new Button();
        UserComboBox = new ComboBox();
        existingUserLabel = new Label();
        CreateUserButton = new Button();
        UserLabel = new Label();
        panel2 = new Panel();
        RoleSearchTextBox = new TextBox();
        RolesFilterListBox = new ListBox();
        RoleDeleteButton = new Button();
        RoleEditButton = new Button();
        RoleViewButton = new Button();
        RoleSearchLabel = new Label();
        RoleCreateButton = new Button();
        RolesLabel = new Label();
        bottomBarPanel.SuspendLayout();
        mainPanel.SuspendLayout();
        addressManagementPanel.SuspendLayout();
        addressMgmtMainPanel.SuspendLayout();
        addressMgmtTopBar.SuspendLayout();
        clientsMgmtPanel.SuspendLayout();
        clientMgmtMainPanel.SuspendLayout();
        clientMgmtTopBar.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // bottomBarPanel
        // 
        bottomBarPanel.Controls.Add(buttonQuit);
        bottomBarPanel.Dock = DockStyle.Bottom;
        bottomBarPanel.Location = new Point(0, 821);
        bottomBarPanel.Name = "bottomBarPanel";
        bottomBarPanel.Size = new Size(1184, 40);
        bottomBarPanel.TabIndex = 0;
        // 
        // buttonQuit
        // 
        buttonQuit.Location = new Point(1069, 6);
        buttonQuit.Name = "buttonQuit";
        buttonQuit.Size = new Size(103, 31);
        buttonQuit.TabIndex = 0;
        buttonQuit.Text = "Quitter";
        buttonQuit.UseVisualStyleBackColor = true;
        buttonQuit.Click += ButtonQuit_Click;
        // 
        // topBarPanel
        // 
        topBarPanel.Dock = DockStyle.Top;
        topBarPanel.Location = new Point(0, 0);
        topBarPanel.Name = "topBarPanel";
        topBarPanel.Size = new Size(1184, 40);
        topBarPanel.TabIndex = 1;
        // 
        // mainPanel
        // 
        mainPanel.ColumnCount = 5;
        mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        mainPanel.Controls.Add(addressManagementPanel, 1, 0);
        mainPanel.Controls.Add(clientsMgmtPanel, 1, 1);
        mainPanel.Controls.Add(panel1, 2, 0);
        mainPanel.Controls.Add(panel2, 2, 1);
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.Location = new Point(0, 40);
        mainPanel.Name = "mainPanel";
        mainPanel.RowCount = 2;
        mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        mainPanel.Size = new Size(1184, 781);
        mainPanel.TabIndex = 2;
        // 
        // addressManagementPanel
        // 
        addressManagementPanel.Controls.Add(addressMgmtMainPanel);
        addressManagementPanel.Controls.Add(addressMgmtTopBar);
        addressManagementPanel.Dock = DockStyle.Fill;
        addressManagementPanel.Location = new Point(239, 3);
        addressManagementPanel.Name = "addressManagementPanel";
        addressManagementPanel.Padding = new Padding(10);
        addressManagementPanel.Size = new Size(230, 384);
        addressManagementPanel.TabIndex = 0;
        // 
        // addressMgmtMainPanel
        // 
        addressMgmtMainPanel.Controls.Add(deleteAddressButton);
        addressMgmtMainPanel.Controls.Add(editAddressButton);
        addressMgmtMainPanel.Controls.Add(viewAddressButton);
        addressMgmtMainPanel.Controls.Add(filteredAddresses);
        addressMgmtMainPanel.Controls.Add(addressSearchTextBox);
        addressMgmtMainPanel.Controls.Add(existingAddressesLabel);
        addressMgmtMainPanel.Controls.Add(createAddressButton);
        addressMgmtMainPanel.Dock = DockStyle.Fill;
        addressMgmtMainPanel.Location = new Point(10, 50);
        addressMgmtMainPanel.Name = "addressMgmtMainPanel";
        addressMgmtMainPanel.Size = new Size(210, 324);
        addressMgmtMainPanel.TabIndex = 1;
        // 
        // deleteAddressButton
        // 
        deleteAddressButton.Dock = DockStyle.Top;
        deleteAddressButton.Location = new Point(0, 245);
        deleteAddressButton.Name = "deleteAddressButton";
        deleteAddressButton.Size = new Size(210, 35);
        deleteAddressButton.TabIndex = 6;
        deleteAddressButton.Text = "Supprimer l'Adresse";
        deleteAddressButton.UseVisualStyleBackColor = true;
        deleteAddressButton.Click += DeleteAddressButton_Click;
        // 
        // editAddressButton
        // 
        editAddressButton.Dock = DockStyle.Top;
        editAddressButton.Location = new Point(0, 210);
        editAddressButton.Name = "editAddressButton";
        editAddressButton.Size = new Size(210, 35);
        editAddressButton.TabIndex = 5;
        editAddressButton.Text = "Modifier l'Adresse";
        editAddressButton.UseVisualStyleBackColor = true;
        editAddressButton.Click += EditAddressButton_Click;
        // 
        // viewAddressButton
        // 
        viewAddressButton.Dock = DockStyle.Top;
        viewAddressButton.Location = new Point(0, 175);
        viewAddressButton.Name = "viewAddressButton";
        viewAddressButton.Size = new Size(210, 35);
        viewAddressButton.TabIndex = 4;
        viewAddressButton.Text = "Voir Détails";
        viewAddressButton.UseVisualStyleBackColor = true;
        viewAddressButton.Click += ViewAddressButton_Click;
        // 
        // filteredAddresses
        // 
        filteredAddresses.Dock = DockStyle.Top;
        filteredAddresses.FormattingEnabled = true;
        filteredAddresses.ItemHeight = 15;
        filteredAddresses.Location = new Point(0, 81);
        filteredAddresses.Name = "filteredAddresses";
        filteredAddresses.Size = new Size(210, 94);
        filteredAddresses.TabIndex = 3;
        filteredAddresses.SelectedIndexChanged += FilteredAddresses_SelectedIndexChanged;
        // 
        // addressSearchTextBox
        // 
        addressSearchTextBox.Dock = DockStyle.Top;
        addressSearchTextBox.Location = new Point(0, 58);
        addressSearchTextBox.Name = "addressSearchTextBox";
        addressSearchTextBox.Size = new Size(210, 23);
        addressSearchTextBox.TabIndex = 2;
        addressSearchTextBox.TextChanged += AddressSearchTextBox_TextChanged;
        // 
        // existingAddressesLabel
        // 
        existingAddressesLabel.Dock = DockStyle.Top;
        existingAddressesLabel.Location = new Point(0, 35);
        existingAddressesLabel.Name = "existingAddressesLabel";
        existingAddressesLabel.Size = new Size(210, 23);
        existingAddressesLabel.TabIndex = 1;
        existingAddressesLabel.Text = "Adresses existantes:";
        existingAddressesLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // createAddressButton
        // 
        createAddressButton.Dock = DockStyle.Top;
        createAddressButton.Location = new Point(0, 0);
        createAddressButton.Name = "createAddressButton";
        createAddressButton.Size = new Size(210, 35);
        createAddressButton.TabIndex = 0;
        createAddressButton.Text = "Nouvelle Adresse";
        createAddressButton.UseVisualStyleBackColor = true;
        createAddressButton.Click += CreateAddressButton_Click;
        // 
        // addressMgmtTopBar
        // 
        addressMgmtTopBar.Controls.Add(addressMgmtLabel);
        addressMgmtTopBar.Dock = DockStyle.Top;
        addressMgmtTopBar.Location = new Point(10, 10);
        addressMgmtTopBar.Name = "addressMgmtTopBar";
        addressMgmtTopBar.Size = new Size(210, 40);
        addressMgmtTopBar.TabIndex = 0;
        // 
        // addressMgmtLabel
        // 
        addressMgmtLabel.Dock = DockStyle.Fill;
        addressMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        addressMgmtLabel.Location = new Point(0, 0);
        addressMgmtLabel.Name = "addressMgmtLabel";
        addressMgmtLabel.Size = new Size(210, 40);
        addressMgmtLabel.TabIndex = 0;
        addressMgmtLabel.Text = "Gestion des Adresses";
        addressMgmtLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientsMgmtPanel
        // 
        clientsMgmtPanel.Controls.Add(clientMgmtMainPanel);
        clientsMgmtPanel.Controls.Add(clientMgmtTopBar);
        clientsMgmtPanel.Dock = DockStyle.Fill;
        clientsMgmtPanel.Location = new Point(239, 393);
        clientsMgmtPanel.Name = "clientsMgmtPanel";
        clientsMgmtPanel.Padding = new Padding(10);
        clientsMgmtPanel.Size = new Size(230, 385);
        clientsMgmtPanel.TabIndex = 1;
        // 
        // clientMgmtMainPanel
        // 
        clientMgmtMainPanel.Controls.Add(clientDeleteButton);
        clientMgmtMainPanel.Controls.Add(clientEditButton);
        clientMgmtMainPanel.Controls.Add(clientViewButton);
        clientMgmtMainPanel.Controls.Add(filteredClients);
        clientMgmtMainPanel.Controls.Add(clientFilteringBox);
        clientMgmtMainPanel.Controls.Add(existingClientsLabel);
        clientMgmtMainPanel.Controls.Add(clientCreateButton);
        clientMgmtMainPanel.Dock = DockStyle.Fill;
        clientMgmtMainPanel.Location = new Point(10, 50);
        clientMgmtMainPanel.Name = "clientMgmtMainPanel";
        clientMgmtMainPanel.Size = new Size(210, 325);
        clientMgmtMainPanel.TabIndex = 1;
        // 
        // clientDeleteButton
        // 
        clientDeleteButton.Dock = DockStyle.Top;
        clientDeleteButton.Location = new Point(0, 245);
        clientDeleteButton.Name = "clientDeleteButton";
        clientDeleteButton.Size = new Size(210, 35);
        clientDeleteButton.TabIndex = 9;
        clientDeleteButton.Text = "Supprimer l'Adresse";
        clientDeleteButton.UseVisualStyleBackColor = true;
        clientDeleteButton.Click += ClientDeleteButton_Click;
        // 
        // clientEditButton
        // 
        clientEditButton.Dock = DockStyle.Top;
        clientEditButton.Location = new Point(0, 210);
        clientEditButton.Name = "clientEditButton";
        clientEditButton.Size = new Size(210, 35);
        clientEditButton.TabIndex = 8;
        clientEditButton.Text = "Modifier l'Adresse";
        clientEditButton.UseVisualStyleBackColor = true;
        clientEditButton.Click += ClientEditButton_Click;
        // 
        // clientViewButton
        // 
        clientViewButton.Dock = DockStyle.Top;
        clientViewButton.Location = new Point(0, 175);
        clientViewButton.Name = "clientViewButton";
        clientViewButton.Size = new Size(210, 35);
        clientViewButton.TabIndex = 7;
        clientViewButton.Text = "Voir Détails";
        clientViewButton.UseVisualStyleBackColor = true;
        clientViewButton.Click += ClientViewButton_Click;
        // 
        // filteredClients
        // 
        filteredClients.Dock = DockStyle.Top;
        filteredClients.FormattingEnabled = true;
        filteredClients.ItemHeight = 15;
        filteredClients.Location = new Point(0, 81);
        filteredClients.Name = "filteredClients";
        filteredClients.Size = new Size(210, 94);
        filteredClients.TabIndex = 4;
        filteredClients.SelectedIndexChanged += FilteredClients_SelectedIndexChanged;
        // 
        // clientFilteringBox
        // 
        clientFilteringBox.Dock = DockStyle.Top;
        clientFilteringBox.Location = new Point(0, 58);
        clientFilteringBox.Name = "clientFilteringBox";
        clientFilteringBox.Size = new Size(210, 23);
        clientFilteringBox.TabIndex = 3;
        clientFilteringBox.TextChanged += ClientFilteringBox_TextChanged;
        // 
        // existingClientsLabel
        // 
        existingClientsLabel.Dock = DockStyle.Top;
        existingClientsLabel.Location = new Point(0, 35);
        existingClientsLabel.Name = "existingClientsLabel";
        existingClientsLabel.Size = new Size(210, 23);
        existingClientsLabel.TabIndex = 2;
        existingClientsLabel.Text = "Clients existants:";
        existingClientsLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientCreateButton
        // 
        clientCreateButton.Dock = DockStyle.Top;
        clientCreateButton.Location = new Point(0, 0);
        clientCreateButton.Name = "clientCreateButton";
        clientCreateButton.Size = new Size(210, 35);
        clientCreateButton.TabIndex = 1;
        clientCreateButton.Text = "Nouveau Client";
        clientCreateButton.UseVisualStyleBackColor = true;
        clientCreateButton.Click += ClientCreateButton_Click;
        // 
        // clientMgmtTopBar
        // 
        clientMgmtTopBar.Controls.Add(clientMgmtLabel);
        clientMgmtTopBar.Dock = DockStyle.Top;
        clientMgmtTopBar.Location = new Point(10, 10);
        clientMgmtTopBar.Name = "clientMgmtTopBar";
        clientMgmtTopBar.Size = new Size(210, 40);
        clientMgmtTopBar.TabIndex = 0;
        // 
        // clientMgmtLabel
        // 
        clientMgmtLabel.Dock = DockStyle.Fill;
        clientMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        clientMgmtLabel.Location = new Point(0, 0);
        clientMgmtLabel.Name = "clientMgmtLabel";
        clientMgmtLabel.Size = new Size(210, 40);
        clientMgmtLabel.TabIndex = 0;
        clientMgmtLabel.Text = "Gestion des clients";
        clientMgmtLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.Controls.Add(DeleteUserButton);
        panel1.Controls.Add(EditUserButton);
        panel1.Controls.Add(ViewUserButton);
        panel1.Controls.Add(UserComboBox);
        panel1.Controls.Add(existingUserLabel);
        panel1.Controls.Add(CreateUserButton);
        panel1.Controls.Add(UserLabel);
        panel1.Location = new Point(475, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(230, 384);
        panel1.TabIndex = 2;
        // 
        // DeleteUserButton
        // 
        DeleteUserButton.Location = new Point(15, 295);
        DeleteUserButton.Name = "DeleteUserButton";
        DeleteUserButton.Size = new Size(198, 35);
        DeleteUserButton.TabIndex = 6;
        DeleteUserButton.Text = "Supprimer Utilisateur";
        DeleteUserButton.UseVisualStyleBackColor = true;
        DeleteUserButton.Click += DeleteUserButton_Click;
        // 
        // EditUserButton
        // 
        EditUserButton.Location = new Point(15, 260);
        EditUserButton.Name = "EditUserButton";
        EditUserButton.Size = new Size(198, 35);
        EditUserButton.TabIndex = 5;
        EditUserButton.Text = "Modifier Utilisteur";
        EditUserButton.UseVisualStyleBackColor = true;
        EditUserButton.Click += EditUserButton_Click;
        // 
        // ViewUserButton
        // 
        ViewUserButton.Location = new Point(15, 225);
        ViewUserButton.Name = "ViewUserButton";
        ViewUserButton.Size = new Size(198, 35);
        ViewUserButton.TabIndex = 4;
        ViewUserButton.Text = "Voir Détails";
        ViewUserButton.UseVisualStyleBackColor = true;
        ViewUserButton.Click += ViewUserButton_Click;
        // 
        // UserComboBox
        // 
        UserComboBox.FormattingEnabled = true;
        UserComboBox.Location = new Point(15, 111);
        UserComboBox.Name = "UserComboBox";
        UserComboBox.Size = new Size(198, 23);
        UserComboBox.TabIndex = 3;
        // 
        // existingUserLabel
        // 
        existingUserLabel.AutoSize = true;
        existingUserLabel.Location = new Point(61, 93);
        existingUserLabel.Name = "existingUserLabel";
        existingUserLabel.Size = new Size(114, 15);
        existingUserLabel.TabIndex = 2;
        existingUserLabel.Text = "Utilisateurs existants";
        // 
        // CreateUserButton
        // 
        CreateUserButton.Location = new Point(15, 50);
        CreateUserButton.Name = "CreateUserButton";
        CreateUserButton.Size = new Size(198, 35);
        CreateUserButton.TabIndex = 1;
        CreateUserButton.Text = "Nouveau Utilisateur";
        CreateUserButton.UseVisualStyleBackColor = true;
        CreateUserButton.Click += CreateUserButton_Click;
        // 
        // UserLabel
        // 
        UserLabel.AutoSize = true;
        UserLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        UserLabel.Location = new Point(15, 20);
        UserLabel.Name = "UserLabel";
        UserLabel.Size = new Size(198, 21);
        UserLabel.TabIndex = 0;
        UserLabel.Text = "Gestion des Utilisateurs";
        // 
        // panel2
        // 
        panel2.Controls.Add(RoleSearchTextBox);
        panel2.Controls.Add(RolesFilterListBox);
        panel2.Controls.Add(RoleDeleteButton);
        panel2.Controls.Add(RoleEditButton);
        panel2.Controls.Add(RoleViewButton);
        panel2.Controls.Add(RoleSearchLabel);
        panel2.Controls.Add(RoleCreateButton);
        panel2.Controls.Add(RolesLabel);
        panel2.Location = new Point(475, 393);
        panel2.Name = "panel2";
        panel2.Size = new Size(230, 385);
        panel2.TabIndex = 3;
        // 
        // RoleSearchTextBox
        // 
        RoleSearchTextBox.Location = new Point(15, 108);
        RoleSearchTextBox.Name = "RoleSearchTextBox";
        RoleSearchTextBox.Size = new Size(198, 23);
        RoleSearchTextBox.TabIndex = 15;
        // 
        // RolesFilterListBox
        // 
        RolesFilterListBox.FormattingEnabled = true;
        RolesFilterListBox.ItemHeight = 15;
        RolesFilterListBox.Location = new Point(15, 131);
        RolesFilterListBox.Name = "RolesFilterListBox";
        RolesFilterListBox.Size = new Size(198, 94);
        RolesFilterListBox.TabIndex = 14;
        // 
        // RoleDeleteButton
        // 
        RoleDeleteButton.Location = new Point(15, 295);
        RoleDeleteButton.Name = "RoleDeleteButton";
        RoleDeleteButton.Size = new Size(198, 35);
        RoleDeleteButton.TabIndex = 13;
        RoleDeleteButton.Text = "Supprimer Rôle";
        RoleDeleteButton.UseVisualStyleBackColor = true;
        // 
        // RoleEditButton
        // 
        RoleEditButton.Location = new Point(15, 260);
        RoleEditButton.Name = "RoleEditButton";
        RoleEditButton.Size = new Size(198, 35);
        RoleEditButton.TabIndex = 12;
        RoleEditButton.Text = "Modifier Rôle";
        RoleEditButton.UseVisualStyleBackColor = true;
        // 
        // RoleViewButton
        // 
        RoleViewButton.Location = new Point(15, 225);
        RoleViewButton.Name = "RoleViewButton";
        RoleViewButton.Size = new Size(198, 35);
        RoleViewButton.TabIndex = 11;
        RoleViewButton.Text = "Voir Détails";
        RoleViewButton.UseVisualStyleBackColor = true;
        // 
        // RoleSearchLabel
        // 
        RoleSearchLabel.AutoSize = true;
        RoleSearchLabel.Location = new Point(72, 93);
        RoleSearchLabel.Name = "RoleSearchLabel";
        RoleSearchLabel.Size = new Size(79, 15);
        RoleSearchLabel.TabIndex = 9;
        RoleSearchLabel.Text = "Rôle existants";
        // 
        // RoleCreateButton
        // 
        RoleCreateButton.Location = new Point(15, 50);
        RoleCreateButton.Name = "RoleCreateButton";
        RoleCreateButton.Size = new Size(198, 35);
        RoleCreateButton.TabIndex = 8;
        RoleCreateButton.Text = "Nouveau Rôles";
        RoleCreateButton.UseVisualStyleBackColor = true;
        RoleCreateButton.Click += RoleCreateButton_Click;
        // 
        // RolesLabel
        // 
        RolesLabel.AutoSize = true;
        RolesLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        RolesLabel.Location = new Point(39, 20);
        RolesLabel.Name = "RolesLabel";
        RolesLabel.Size = new Size(149, 21);
        RolesLabel.TabIndex = 7;
        RolesLabel.Text = "Gestion des Rôles";
        // 
        // AdminMainMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1184, 861);
        Controls.Add(mainPanel);
        Controls.Add(topBarPanel);
        Controls.Add(bottomBarPanel);
        Name = "AdminMainMenu";
        Text = "Menu Administration";
        WindowState = FormWindowState.Maximized;
        bottomBarPanel.ResumeLayout(false);
        mainPanel.ResumeLayout(false);
        addressManagementPanel.ResumeLayout(false);
        addressMgmtMainPanel.ResumeLayout(false);
        addressMgmtMainPanel.PerformLayout();
        addressMgmtTopBar.ResumeLayout(false);
        clientsMgmtPanel.ResumeLayout(false);
        clientMgmtMainPanel.ResumeLayout(false);
        clientMgmtMainPanel.PerformLayout();
        clientMgmtTopBar.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
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
    private Panel panel1;
    private Button DeleteUserButton;
    private Button EditUserButton;
    private Button ViewUserButton;
    private ComboBox UserComboBox;
    private Label existingUserLabel;
    private Button CreateUserButton;
    private Label UserLabel;
    private Panel panel2;
    private TextBox RoleSearchTextBox;
    private ListBox RolesFilterListBox;
    private Button RoleDeleteButton;
    private Button RoleEditButton;
    private Button RoleViewButton;
    private Label RoleSearchLabel;
    private Button RoleCreateButton;
    private Label RolesLabel;
}