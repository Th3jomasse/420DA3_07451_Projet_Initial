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
        this.clientMgmtMainPanel = new Panel();
        this.clientDeleteButton = new Button();
        this.clientEditButton = new Button();
        this.clientViewButton = new Button();
        this.filteredClients = new ListBox();
        this.clientFilteringBox = new TextBox();
        this.existingClientsLabel = new Label();
        this.clientCreateButton = new Button();
        this.clientMgmtTopBar = new Panel();
        this.clientMgmtLabel = new Label();
        this.utilisateurMgMtPanel = new Panel();
        this.DeleteUserButton = new Button();
        this.EditUserButton = new Button();
        this.ViewUserButton = new Button();
        this.UserComboBox = new ComboBox();
        this.existingUserLabel = new Label();
        this.CreateUserButton = new Button();
        this.UserLabel = new Label();
        this.roleMgmtPanel = new Panel();
        this.RoleSearchTextBox = new TextBox();
        this.RolesFilterListBox = new ListBox();
        this.RoleDeleteButton = new Button();
        this.RoleEditButton = new Button();
        this.RoleViewButton = new Button();
        this.RoleSearchLabel = new Label();
        this.RoleCreateButton = new Button();
        this.RolesLabel = new Label();
        this.entrepotMgmtPanel = new Panel();
        this.produitsMgmtPanel = new Panel();
        this.fournisseursMgmtPanel = new Panel();
        this.shipmentMgmtPanel = new Panel();
        this.restockOrdersMgmtPanel = new Panel();
        this.shipmentOrderMgmtPanel = new Panel();
        this.entrepotMgmtHeaderLabel = new Label();
        this.shipmentMgmtHeaderLabel = new Label();
        this.produitsMgmtHeaderLabel = new Label();
        this.restockOrdersMgmtHeaderLabel = new Label();
        this.fournisseursMgmtHeaderLabel = new Label();
        this.shipmentOrdersMgmtHeaderLabel = new Label();
        this.bottomBarPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        this.addressManagementPanel.SuspendLayout();
        this.addressMgmtMainPanel.SuspendLayout();
        this.addressMgmtTopBar.SuspendLayout();
        this.clientsMgmtPanel.SuspendLayout();
        this.clientMgmtMainPanel.SuspendLayout();
        this.clientMgmtTopBar.SuspendLayout();
        this.utilisateurMgMtPanel.SuspendLayout();
        this.roleMgmtPanel.SuspendLayout();
        this.entrepotMgmtPanel.SuspendLayout();
        this.produitsMgmtPanel.SuspendLayout();
        this.fournisseursMgmtPanel.SuspendLayout();
        this.shipmentMgmtPanel.SuspendLayout();
        this.restockOrdersMgmtPanel.SuspendLayout();
        this.shipmentOrderMgmtPanel.SuspendLayout();
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
        this.mainPanel.Controls.Add(this.shipmentOrderMgmtPanel, 4, 1);
        this.mainPanel.Controls.Add(this.restockOrdersMgmtPanel, 3, 1);
        this.mainPanel.Controls.Add(this.shipmentMgmtPanel, 0, 1);
        this.mainPanel.Controls.Add(this.fournisseursMgmtPanel, 4, 0);
        this.mainPanel.Controls.Add(this.produitsMgmtPanel, 3, 0);
        this.mainPanel.Controls.Add(this.addressManagementPanel, 1, 0);
        this.mainPanel.Controls.Add(this.clientsMgmtPanel, 1, 1);
        this.mainPanel.Controls.Add(this.utilisateurMgMtPanel, 2, 0);
        this.mainPanel.Controls.Add(this.roleMgmtPanel, 2, 1);
        this.mainPanel.Controls.Add(this.entrepotMgmtPanel, 0, 0);
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
        // clientFilteringBox
        // 
        this.clientFilteringBox.Dock = DockStyle.Top;
        this.clientFilteringBox.Location = new Point(0, 58);
        this.clientFilteringBox.Name = "clientFilteringBox";
        this.clientFilteringBox.Size = new Size(210, 23);
        this.clientFilteringBox.TabIndex = 3;
        this.clientFilteringBox.TextChanged += this.ClientFilteringBox_TextChanged;
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
        // utilisateurMgMtPanel
        // 
        this.utilisateurMgMtPanel.Controls.Add(this.DeleteUserButton);
        this.utilisateurMgMtPanel.Controls.Add(this.EditUserButton);
        this.utilisateurMgMtPanel.Controls.Add(this.ViewUserButton);
        this.utilisateurMgMtPanel.Controls.Add(this.UserComboBox);
        this.utilisateurMgMtPanel.Controls.Add(this.existingUserLabel);
        this.utilisateurMgMtPanel.Controls.Add(this.CreateUserButton);
        this.utilisateurMgMtPanel.Controls.Add(this.UserLabel);
        this.utilisateurMgMtPanel.Location = new Point(475, 3);
        this.utilisateurMgMtPanel.Name = "utilisateurMgMtPanel";
        this.utilisateurMgMtPanel.Size = new Size(230, 384);
        this.utilisateurMgMtPanel.TabIndex = 2;
        // 
        // DeleteUserButton
        // 
        this.DeleteUserButton.Location = new Point(15, 295);
        this.DeleteUserButton.Name = "DeleteUserButton";
        this.DeleteUserButton.Size = new Size(198, 35);
        this.DeleteUserButton.TabIndex = 6;
        this.DeleteUserButton.Text = "Supprimer Utilisateur";
        this.DeleteUserButton.UseVisualStyleBackColor = true;
        this.DeleteUserButton.Click += this.DeleteUserButton_Click;
        // 
        // EditUserButton
        // 
        this.EditUserButton.Location = new Point(15, 260);
        this.EditUserButton.Name = "EditUserButton";
        this.EditUserButton.Size = new Size(198, 35);
        this.EditUserButton.TabIndex = 5;
        this.EditUserButton.Text = "Modifier Utilisteur";
        this.EditUserButton.UseVisualStyleBackColor = true;
        this.EditUserButton.Click += this.EditUserButton_Click;
        // 
        // ViewUserButton
        // 
        this.ViewUserButton.Location = new Point(15, 225);
        this.ViewUserButton.Name = "ViewUserButton";
        this.ViewUserButton.Size = new Size(198, 35);
        this.ViewUserButton.TabIndex = 4;
        this.ViewUserButton.Text = "Voir Détails";
        this.ViewUserButton.UseVisualStyleBackColor = true;
        this.ViewUserButton.Click += this.ViewUserButton_Click;
        // 
        // UserComboBox
        // 
        this.UserComboBox.FormattingEnabled = true;
        this.UserComboBox.Location = new Point(15, 111);
        this.UserComboBox.Name = "UserComboBox";
        this.UserComboBox.Size = new Size(198, 23);
        this.UserComboBox.TabIndex = 3;
        // 
        // existingUserLabel
        // 
        this.existingUserLabel.AutoSize = true;
        this.existingUserLabel.Location = new Point(61, 93);
        this.existingUserLabel.Name = "existingUserLabel";
        this.existingUserLabel.Size = new Size(114, 15);
        this.existingUserLabel.TabIndex = 2;
        this.existingUserLabel.Text = "Utilisateurs existants";
        // 
        // CreateUserButton
        // 
        this.CreateUserButton.Location = new Point(15, 50);
        this.CreateUserButton.Name = "CreateUserButton";
        this.CreateUserButton.Size = new Size(198, 35);
        this.CreateUserButton.TabIndex = 1;
        this.CreateUserButton.Text = "Nouveau Utilisateur";
        this.CreateUserButton.UseVisualStyleBackColor = true;
        this.CreateUserButton.Click += this.CreateUserButton_Click;
        // 
        // UserLabel
        // 
        this.UserLabel.AutoSize = true;
        this.UserLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.UserLabel.Location = new Point(15, 20);
        this.UserLabel.Name = "UserLabel";
        this.UserLabel.Size = new Size(198, 21);
        this.UserLabel.TabIndex = 0;
        this.UserLabel.Text = "Gestion des Utilisateurs";
        // 
        // roleMgmtPanel
        // 
        this.roleMgmtPanel.Controls.Add(this.RoleSearchTextBox);
        this.roleMgmtPanel.Controls.Add(this.RolesFilterListBox);
        this.roleMgmtPanel.Controls.Add(this.RoleDeleteButton);
        this.roleMgmtPanel.Controls.Add(this.RoleEditButton);
        this.roleMgmtPanel.Controls.Add(this.RoleViewButton);
        this.roleMgmtPanel.Controls.Add(this.RoleSearchLabel);
        this.roleMgmtPanel.Controls.Add(this.RoleCreateButton);
        this.roleMgmtPanel.Controls.Add(this.RolesLabel);
        this.roleMgmtPanel.Location = new Point(475, 393);
        this.roleMgmtPanel.Name = "roleMgmtPanel";
        this.roleMgmtPanel.Size = new Size(230, 385);
        this.roleMgmtPanel.TabIndex = 3;
        // 
        // RoleSearchTextBox
        // 
        this.RoleSearchTextBox.Location = new Point(15, 108);
        this.RoleSearchTextBox.Name = "RoleSearchTextBox";
        this.RoleSearchTextBox.Size = new Size(198, 23);
        this.RoleSearchTextBox.TabIndex = 15;
        // 
        // RolesFilterListBox
        // 
        this.RolesFilterListBox.FormattingEnabled = true;
        this.RolesFilterListBox.ItemHeight = 15;
        this.RolesFilterListBox.Location = new Point(15, 131);
        this.RolesFilterListBox.Name = "RolesFilterListBox";
        this.RolesFilterListBox.Size = new Size(198, 94);
        this.RolesFilterListBox.TabIndex = 14;
        // 
        // RoleDeleteButton
        // 
        this.RoleDeleteButton.Location = new Point(15, 295);
        this.RoleDeleteButton.Name = "RoleDeleteButton";
        this.RoleDeleteButton.Size = new Size(198, 35);
        this.RoleDeleteButton.TabIndex = 13;
        this.RoleDeleteButton.Text = "Supprimer Rôle";
        this.RoleDeleteButton.UseVisualStyleBackColor = true;
        this.RoleDeleteButton.Click += this.RoleDeleteButton_Click;
        // 
        // RoleEditButton
        // 
        this.RoleEditButton.Location = new Point(15, 260);
        this.RoleEditButton.Name = "RoleEditButton";
        this.RoleEditButton.Size = new Size(198, 35);
        this.RoleEditButton.TabIndex = 12;
        this.RoleEditButton.Text = "Modifier Rôle";
        this.RoleEditButton.UseVisualStyleBackColor = true;
        this.RoleEditButton.Click += this.RoleEditButton_Click;
        // 
        // RoleViewButton
        // 
        this.RoleViewButton.Location = new Point(15, 225);
        this.RoleViewButton.Name = "RoleViewButton";
        this.RoleViewButton.Size = new Size(198, 35);
        this.RoleViewButton.TabIndex = 11;
        this.RoleViewButton.Text = "Voir Détails";
        this.RoleViewButton.UseVisualStyleBackColor = true;
        this.RoleViewButton.Click += this.RoleViewButton_Click;
        // 
        // RoleSearchLabel
        // 
        this.RoleSearchLabel.AutoSize = true;
        this.RoleSearchLabel.Location = new Point(72, 93);
        this.RoleSearchLabel.Name = "RoleSearchLabel";
        this.RoleSearchLabel.Size = new Size(79, 15);
        this.RoleSearchLabel.TabIndex = 9;
        this.RoleSearchLabel.Text = "Rôle existants";
        // 
        // RoleCreateButton
        // 
        this.RoleCreateButton.Location = new Point(15, 50);
        this.RoleCreateButton.Name = "RoleCreateButton";
        this.RoleCreateButton.Size = new Size(198, 35);
        this.RoleCreateButton.TabIndex = 8;
        this.RoleCreateButton.Text = "Nouveau Rôles";
        this.RoleCreateButton.UseVisualStyleBackColor = true;
        this.RoleCreateButton.Click += this.RoleCreateButton_Click;
        // 
        // RolesLabel
        // 
        this.RolesLabel.AutoSize = true;
        this.RolesLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.RolesLabel.Location = new Point(39, 20);
        this.RolesLabel.Name = "RolesLabel";
        this.RolesLabel.Size = new Size(149, 21);
        this.RolesLabel.TabIndex = 7;
        this.RolesLabel.Text = "Gestion des Rôles";
        // 
        // entrepotMgmtPanel
        // 
        this.entrepotMgmtPanel.Controls.Add(this.entrepotMgmtHeaderLabel);
        this.entrepotMgmtPanel.Dock = DockStyle.Fill;
        this.entrepotMgmtPanel.Location = new Point(3, 3);
        this.entrepotMgmtPanel.Name = "entrepotMgmtPanel";
        this.entrepotMgmtPanel.Padding = new Padding(10);
        this.entrepotMgmtPanel.Size = new Size(230, 384);
        this.entrepotMgmtPanel.TabIndex = 4;
        // 
        // produitsMgmtPanel
        // 
        this.produitsMgmtPanel.Controls.Add(this.produitsMgmtHeaderLabel);
        this.produitsMgmtPanel.Dock = DockStyle.Fill;
        this.produitsMgmtPanel.Location = new Point(711, 3);
        this.produitsMgmtPanel.Name = "produitsMgmtPanel";
        this.produitsMgmtPanel.Padding = new Padding(10);
        this.produitsMgmtPanel.Size = new Size(230, 384);
        this.produitsMgmtPanel.TabIndex = 5;
        // 
        // fournisseursMgmtPanel
        // 
        this.fournisseursMgmtPanel.Controls.Add(this.fournisseursMgmtHeaderLabel);
        this.fournisseursMgmtPanel.Dock = DockStyle.Fill;
        this.fournisseursMgmtPanel.Location = new Point(947, 3);
        this.fournisseursMgmtPanel.Name = "fournisseursMgmtPanel";
        this.fournisseursMgmtPanel.Padding = new Padding(10);
        this.fournisseursMgmtPanel.Size = new Size(234, 384);
        this.fournisseursMgmtPanel.TabIndex = 6;
        // 
        // shipmentMgmtPanel
        // 
        this.shipmentMgmtPanel.Controls.Add(this.shipmentMgmtHeaderLabel);
        this.shipmentMgmtPanel.Dock = DockStyle.Fill;
        this.shipmentMgmtPanel.Location = new Point(3, 393);
        this.shipmentMgmtPanel.Name = "shipmentMgmtPanel";
        this.shipmentMgmtPanel.Padding = new Padding(10);
        this.shipmentMgmtPanel.Size = new Size(230, 385);
        this.shipmentMgmtPanel.TabIndex = 7;
        // 
        // restockOrdersMgmtPanel
        // 
        this.restockOrdersMgmtPanel.Controls.Add(this.restockOrdersMgmtHeaderLabel);
        this.restockOrdersMgmtPanel.Dock = DockStyle.Fill;
        this.restockOrdersMgmtPanel.Location = new Point(711, 393);
        this.restockOrdersMgmtPanel.Name = "restockOrdersMgmtPanel";
        this.restockOrdersMgmtPanel.Padding = new Padding(10);
        this.restockOrdersMgmtPanel.Size = new Size(230, 385);
        this.restockOrdersMgmtPanel.TabIndex = 8;
        // 
        // shipmentOrderMgmtPanel
        // 
        this.shipmentOrderMgmtPanel.Controls.Add(this.shipmentOrdersMgmtHeaderLabel);
        this.shipmentOrderMgmtPanel.Dock = DockStyle.Fill;
        this.shipmentOrderMgmtPanel.Location = new Point(947, 393);
        this.shipmentOrderMgmtPanel.Name = "shipmentOrderMgmtPanel";
        this.shipmentOrderMgmtPanel.Padding = new Padding(10);
        this.shipmentOrderMgmtPanel.Size = new Size(234, 385);
        this.shipmentOrderMgmtPanel.TabIndex = 9;
        // 
        // entrepotMgmtHeaderLabel
        // 
        this.entrepotMgmtHeaderLabel.Dock = DockStyle.Top;
        this.entrepotMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.entrepotMgmtHeaderLabel.Location = new Point(10, 10);
        this.entrepotMgmtHeaderLabel.Name = "entrepotMgmtHeaderLabel";
        this.entrepotMgmtHeaderLabel.Size = new Size(210, 40);
        this.entrepotMgmtHeaderLabel.TabIndex = 1;
        this.entrepotMgmtHeaderLabel.Text = "Gestion des Entrepôts";
        this.entrepotMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipmentMgmtHeaderLabel
        // 
        this.shipmentMgmtHeaderLabel.Dock = DockStyle.Top;
        this.shipmentMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.shipmentMgmtHeaderLabel.Location = new Point(10, 10);
        this.shipmentMgmtHeaderLabel.Name = "shipmentMgmtHeaderLabel";
        this.shipmentMgmtHeaderLabel.Size = new Size(210, 40);
        this.shipmentMgmtHeaderLabel.TabIndex = 2;
        this.shipmentMgmtHeaderLabel.Text = "Gestion des Expéditions";
        this.shipmentMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // produitsMgmtHeaderLabel
        // 
        this.produitsMgmtHeaderLabel.Dock = DockStyle.Top;
        this.produitsMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.produitsMgmtHeaderLabel.Location = new Point(10, 10);
        this.produitsMgmtHeaderLabel.Name = "produitsMgmtHeaderLabel";
        this.produitsMgmtHeaderLabel.Size = new Size(210, 40);
        this.produitsMgmtHeaderLabel.TabIndex = 3;
        this.produitsMgmtHeaderLabel.Text = "Gestion des Produits";
        this.produitsMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // restockOrdersMgmtHeaderLabel
        // 
        this.restockOrdersMgmtHeaderLabel.Dock = DockStyle.Top;
        this.restockOrdersMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.restockOrdersMgmtHeaderLabel.Location = new Point(10, 10);
        this.restockOrdersMgmtHeaderLabel.Name = "restockOrdersMgmtHeaderLabel";
        this.restockOrdersMgmtHeaderLabel.Size = new Size(210, 40);
        this.restockOrdersMgmtHeaderLabel.TabIndex = 3;
        this.restockOrdersMgmtHeaderLabel.Text = "Gestion des ordres de restockage";
        this.restockOrdersMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // fournisseursMgmtHeaderLabel
        // 
        this.fournisseursMgmtHeaderLabel.Dock = DockStyle.Top;
        this.fournisseursMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.fournisseursMgmtHeaderLabel.Location = new Point(10, 10);
        this.fournisseursMgmtHeaderLabel.Name = "fournisseursMgmtHeaderLabel";
        this.fournisseursMgmtHeaderLabel.Size = new Size(214, 40);
        this.fournisseursMgmtHeaderLabel.TabIndex = 3;
        this.fournisseursMgmtHeaderLabel.Text = "Gestion des Expéditions";
        this.fournisseursMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipmentOrdersMgmtHeaderLabel
        // 
        this.shipmentOrdersMgmtHeaderLabel.Dock = DockStyle.Top;
        this.shipmentOrdersMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.shipmentOrdersMgmtHeaderLabel.Location = new Point(10, 10);
        this.shipmentOrdersMgmtHeaderLabel.Name = "shipmentOrdersMgmtHeaderLabel";
        this.shipmentOrdersMgmtHeaderLabel.Size = new Size(214, 40);
        this.shipmentOrdersMgmtHeaderLabel.TabIndex = 3;
        this.shipmentOrdersMgmtHeaderLabel.Text = "Gestion des ordres d'expédition";
        this.shipmentOrdersMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        this.clientMgmtMainPanel.ResumeLayout(false);
        this.clientMgmtMainPanel.PerformLayout();
        this.clientMgmtTopBar.ResumeLayout(false);
        this.utilisateurMgMtPanel.ResumeLayout(false);
        this.utilisateurMgMtPanel.PerformLayout();
        this.roleMgmtPanel.ResumeLayout(false);
        this.roleMgmtPanel.PerformLayout();
        this.entrepotMgmtPanel.ResumeLayout(false);
        this.produitsMgmtPanel.ResumeLayout(false);
        this.fournisseursMgmtPanel.ResumeLayout(false);
        this.shipmentMgmtPanel.ResumeLayout(false);
        this.restockOrdersMgmtPanel.ResumeLayout(false);
        this.shipmentOrderMgmtPanel.ResumeLayout(false);
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
    private Panel utilisateurMgMtPanel;
    private Button DeleteUserButton;
    private Button EditUserButton;
    private Button ViewUserButton;
    private ComboBox UserComboBox;
    private Label existingUserLabel;
    private Button CreateUserButton;
    private Label UserLabel;
    private Panel roleMgmtPanel;
    private TextBox RoleSearchTextBox;
    private ListBox RolesFilterListBox;
    private Button RoleDeleteButton;
    private Button RoleEditButton;
    private Button RoleViewButton;
    private Label RoleSearchLabel;
    private Button RoleCreateButton;
    private Label RolesLabel;
    private Panel fournisseursMgmtPanel;
    private Panel produitsMgmtPanel;
    private Panel entrepotMgmtPanel;
    private Panel shipmentOrderMgmtPanel;
    private Panel restockOrdersMgmtPanel;
    private Panel shipmentMgmtPanel;
    private Label shipmentMgmtHeaderLabel;
    private Label entrepotMgmtHeaderLabel;
    private Label produitsMgmtHeaderLabel;
    private Label shipmentOrdersMgmtHeaderLabel;
    private Label restockOrdersMgmtHeaderLabel;
    private Label fournisseursMgmtHeaderLabel;
}