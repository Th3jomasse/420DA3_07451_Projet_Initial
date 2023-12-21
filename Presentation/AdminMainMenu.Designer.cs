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
        bottomBarPanel = new Panel();
        buttonQuit = new Button();
        topBarPanel = new Panel();
        mainPanel = new TableLayoutPanel();
        shipmentOrderMgmtPanel = new Panel();
        shipmentOrdersMgmtHeaderLabel = new Label();
        restockOrdersMgmtPanel = new Panel();
        viewROButton = new Button();
        roSearchResultsListBox = new ListBox();
        roSearchFilterTextBox = new TextBox();
        existingROLabel = new Label();
        createROButton = new Button();
        restockOrdersMgmtHeaderLabel = new Label();
        shipmentMgmtPanel = new Panel();
        shipmentMgmtHeaderLabel = new Label();
        fournisseursMgmtPanel = new Panel();
        fournisseursMgmtHeaderLabel = new Label();
        produitsMgmtPanel = new Panel();
        produitsMgmtHeaderLabel = new Label();
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
        utilisateurMgMtPanel = new Panel();
        utilisateurMgmtMainPanel = new Panel();
        deleteUserButton = new Button();
        editUserButton = new Button();
        viewUserButton = new Button();
        UserComboBox = new ComboBox();
        utilisateurSeparatorLabel = new Label();
        newUserButton = new Button();
        UserLabel = new Label();
        roleMgmtPanel = new Panel();
        RoleSearchTextBox = new TextBox();
        RolesFilterListBox = new ListBox();
        RoleDeleteButton = new Button();
        RoleEditButton = new Button();
        RoleViewButton = new Button();
        RoleSearchLabel = new Label();
        RoleCreateButton = new Button();
        RolesLabel = new Label();
        entrepotMgmtPanel = new Panel();
        deleteEntrepotButton = new Button();
        editEntrepotButton = new Button();
        viewEntrepotButton = new Button();
        entrepotSelector = new ComboBox();
        existingEntrepotsLabel = new Label();
        createEntrepotButton = new Button();
        entrepotMgmtHeaderLabel = new Label();
        CreateShipmentButton = new Button();
        this.ShipmentLabel = new Label();
        textBox1 = new TextBox();
        listBox1 = new ListBox();
        button2 = new Button();
        button3 = new Button();
        ViewShipmentButton = new Button();
        listBox2 = new ListBox();
        textBox2 = new TextBox();
        label2 = new Label();
        button8 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        bottomBarPanel.SuspendLayout();
        mainPanel.SuspendLayout();
        shipmentOrderMgmtPanel.SuspendLayout();
        restockOrdersMgmtPanel.SuspendLayout();
        shipmentMgmtPanel.SuspendLayout();
        fournisseursMgmtPanel.SuspendLayout();
        produitsMgmtPanel.SuspendLayout();
        addressManagementPanel.SuspendLayout();
        addressMgmtMainPanel.SuspendLayout();
        addressMgmtTopBar.SuspendLayout();
        clientsMgmtPanel.SuspendLayout();
        clientMgmtMainPanel.SuspendLayout();
        clientMgmtTopBar.SuspendLayout();
        utilisateurMgMtPanel.SuspendLayout();
        utilisateurMgmtMainPanel.SuspendLayout();
        roleMgmtPanel.SuspendLayout();
        entrepotMgmtPanel.SuspendLayout();
        this.SuspendLayout();
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
        buttonQuit.Click += this.ButtonQuit_Click;
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
        mainPanel.Controls.Add(shipmentOrderMgmtPanel, 4, 1);
        mainPanel.Controls.Add(restockOrdersMgmtPanel, 3, 1);
        mainPanel.Controls.Add(shipmentMgmtPanel, 0, 1);
        mainPanel.Controls.Add(fournisseursMgmtPanel, 4, 0);
        mainPanel.Controls.Add(produitsMgmtPanel, 3, 0);
        mainPanel.Controls.Add(addressManagementPanel, 1, 0);
        mainPanel.Controls.Add(clientsMgmtPanel, 1, 1);
        mainPanel.Controls.Add(utilisateurMgMtPanel, 2, 0);
        mainPanel.Controls.Add(roleMgmtPanel, 2, 1);
        mainPanel.Controls.Add(entrepotMgmtPanel, 0, 0);
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.Location = new Point(0, 40);
        mainPanel.Name = "mainPanel";
        mainPanel.RowCount = 2;
        mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        mainPanel.Size = new Size(1184, 781);
        mainPanel.TabIndex = 2;
        // 
        // shipmentOrderMgmtPanel
        // 
        shipmentOrderMgmtPanel.Controls.Add(button5);
        shipmentOrderMgmtPanel.Controls.Add(shipmentOrdersMgmtHeaderLabel);
        shipmentOrderMgmtPanel.Controls.Add(button6);
        shipmentOrderMgmtPanel.Controls.Add(button7);
        shipmentOrderMgmtPanel.Controls.Add(button8);
        shipmentOrderMgmtPanel.Controls.Add(label2);
        shipmentOrderMgmtPanel.Controls.Add(listBox2);
        shipmentOrderMgmtPanel.Controls.Add(textBox2);
        shipmentOrderMgmtPanel.Dock = DockStyle.Fill;
        shipmentOrderMgmtPanel.Location = new Point(947, 393);
        shipmentOrderMgmtPanel.Name = "shipmentOrderMgmtPanel";
        shipmentOrderMgmtPanel.Padding = new Padding(10);
        shipmentOrderMgmtPanel.Size = new Size(234, 385);
        shipmentOrderMgmtPanel.TabIndex = 9;
        // 
        // shipmentOrdersMgmtHeaderLabel
        // 
        shipmentOrdersMgmtHeaderLabel.Dock = DockStyle.Top;
        shipmentOrdersMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        shipmentOrdersMgmtHeaderLabel.Location = new Point(10, 10);
        shipmentOrdersMgmtHeaderLabel.Name = "shipmentOrdersMgmtHeaderLabel";
        shipmentOrdersMgmtHeaderLabel.Size = new Size(214, 59);
        shipmentOrdersMgmtHeaderLabel.TabIndex = 3;
        shipmentOrdersMgmtHeaderLabel.Text = "Gestion des ordres d'expédition";
        shipmentOrdersMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // restockOrdersMgmtPanel
        // 
        restockOrdersMgmtPanel.Controls.Add(viewROButton);
        restockOrdersMgmtPanel.Controls.Add(roSearchResultsListBox);
        restockOrdersMgmtPanel.Controls.Add(roSearchFilterTextBox);
        restockOrdersMgmtPanel.Controls.Add(existingROLabel);
        restockOrdersMgmtPanel.Controls.Add(createROButton);
        restockOrdersMgmtPanel.Controls.Add(restockOrdersMgmtHeaderLabel);
        restockOrdersMgmtPanel.Dock = DockStyle.Fill;
        restockOrdersMgmtPanel.Location = new Point(711, 393);
        restockOrdersMgmtPanel.Name = "restockOrdersMgmtPanel";
        restockOrdersMgmtPanel.Padding = new Padding(10);
        restockOrdersMgmtPanel.Size = new Size(230, 385);
        restockOrdersMgmtPanel.TabIndex = 8;
        // 
        // viewROButton
        // 
        viewROButton.Dock = DockStyle.Top;
        viewROButton.Location = new Point(10, 235);
        viewROButton.Name = "viewROButton";
        viewROButton.Size = new Size(210, 26);
        viewROButton.TabIndex = 8;
        viewROButton.Text = "Nouvel ordre de restockage";
        viewROButton.UseVisualStyleBackColor = true;
        viewROButton.Click += this.ViewROButton_Click;
        // 
        // roSearchResultsListBox
        // 
        roSearchResultsListBox.Dock = DockStyle.Top;
        roSearchResultsListBox.FormattingEnabled = true;
        roSearchResultsListBox.ItemHeight = 15;
        roSearchResultsListBox.Location = new Point(10, 141);
        roSearchResultsListBox.Name = "roSearchResultsListBox";
        roSearchResultsListBox.Size = new Size(210, 94);
        roSearchResultsListBox.TabIndex = 7;
        roSearchResultsListBox.SelectedIndexChanged += this.RoSearchResultsListBox_SelectedIndexChanged;
        // 
        // roSearchFilterTextBox
        // 
        roSearchFilterTextBox.Dock = DockStyle.Top;
        roSearchFilterTextBox.Location = new Point(10, 118);
        roSearchFilterTextBox.Name = "roSearchFilterTextBox";
        roSearchFilterTextBox.Size = new Size(210, 23);
        roSearchFilterTextBox.TabIndex = 6;
        roSearchFilterTextBox.TextChanged += this.RoSearchFilterTextBox_TextChanged;
        // 
        // existingROLabel
        // 
        existingROLabel.Dock = DockStyle.Top;
        existingROLabel.Location = new Point(10, 95);
        existingROLabel.Name = "existingROLabel";
        existingROLabel.Size = new Size(210, 23);
        existingROLabel.TabIndex = 5;
        existingROLabel.Text = "Ordres de restockage existants:";
        existingROLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // createROButton
        // 
        createROButton.Dock = DockStyle.Top;
        createROButton.Location = new Point(10, 69);
        createROButton.Name = "createROButton";
        createROButton.Size = new Size(210, 26);
        createROButton.TabIndex = 4;
        createROButton.Text = "Nouvel ordre de restockage";
        createROButton.UseVisualStyleBackColor = true;
        createROButton.Click += this.CreateROButton_Click;
        // 
        // restockOrdersMgmtHeaderLabel
        // 
        restockOrdersMgmtHeaderLabel.Dock = DockStyle.Top;
        restockOrdersMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        restockOrdersMgmtHeaderLabel.Location = new Point(10, 10);
        restockOrdersMgmtHeaderLabel.Name = "restockOrdersMgmtHeaderLabel";
        restockOrdersMgmtHeaderLabel.Size = new Size(210, 59);
        restockOrdersMgmtHeaderLabel.TabIndex = 3;
        restockOrdersMgmtHeaderLabel.Text = "Gestion des ordres de restockage";
        restockOrdersMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipmentMgmtPanel
        // 
        shipmentMgmtPanel.Controls.Add(shipmentMgmtHeaderLabel);
        shipmentMgmtPanel.Dock = DockStyle.Fill;
        shipmentMgmtPanel.Location = new Point(3, 393);
        shipmentMgmtPanel.Name = "shipmentMgmtPanel";
        shipmentMgmtPanel.Padding = new Padding(10);
        shipmentMgmtPanel.Size = new Size(230, 385);
        shipmentMgmtPanel.TabIndex = 7;
        // 
        // shipmentMgmtHeaderLabel
        // 
        shipmentMgmtHeaderLabel.Dock = DockStyle.Top;
        shipmentMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        shipmentMgmtHeaderLabel.Location = new Point(10, 10);
        shipmentMgmtHeaderLabel.Name = "shipmentMgmtHeaderLabel";
        shipmentMgmtHeaderLabel.Size = new Size(210, 59);
        shipmentMgmtHeaderLabel.TabIndex = 2;
        shipmentMgmtHeaderLabel.Text = "Gestion des Expéditions";
        shipmentMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // fournisseursMgmtPanel
        // 
        fournisseursMgmtPanel.Controls.Add(ViewShipmentButton);
        fournisseursMgmtPanel.Controls.Add(button3);
        fournisseursMgmtPanel.Controls.Add(button2);
        fournisseursMgmtPanel.Controls.Add(listBox1);
        fournisseursMgmtPanel.Controls.Add(textBox1);
        fournisseursMgmtPanel.Controls.Add(this.ShipmentLabel);
        fournisseursMgmtPanel.Controls.Add(CreateShipmentButton);
        fournisseursMgmtPanel.Controls.Add(fournisseursMgmtHeaderLabel);
        fournisseursMgmtPanel.Dock = DockStyle.Fill;
        fournisseursMgmtPanel.Location = new Point(947, 3);
        fournisseursMgmtPanel.Name = "fournisseursMgmtPanel";
        fournisseursMgmtPanel.Padding = new Padding(10);
        fournisseursMgmtPanel.Size = new Size(234, 384);
        fournisseursMgmtPanel.TabIndex = 6;
        // 
        // fournisseursMgmtHeaderLabel
        // 
        fournisseursMgmtHeaderLabel.Dock = DockStyle.Top;
        fournisseursMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        fournisseursMgmtHeaderLabel.Location = new Point(10, 10);
        fournisseursMgmtHeaderLabel.Name = "fournisseursMgmtHeaderLabel";
        fournisseursMgmtHeaderLabel.Size = new Size(214, 59);
        fournisseursMgmtHeaderLabel.TabIndex = 3;
        fournisseursMgmtHeaderLabel.Text = "Gestion des Expéditions";
        fournisseursMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // produitsMgmtPanel
        // 
        produitsMgmtPanel.Controls.Add(produitsMgmtHeaderLabel);
        produitsMgmtPanel.Dock = DockStyle.Fill;
        produitsMgmtPanel.Location = new Point(711, 3);
        produitsMgmtPanel.Name = "produitsMgmtPanel";
        produitsMgmtPanel.Padding = new Padding(10);
        produitsMgmtPanel.Size = new Size(230, 384);
        produitsMgmtPanel.TabIndex = 5;
        // 
        // produitsMgmtHeaderLabel
        // 
        produitsMgmtHeaderLabel.Dock = DockStyle.Top;
        produitsMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        produitsMgmtHeaderLabel.Location = new Point(10, 10);
        produitsMgmtHeaderLabel.Name = "produitsMgmtHeaderLabel";
        produitsMgmtHeaderLabel.Size = new Size(210, 59);
        produitsMgmtHeaderLabel.TabIndex = 3;
        produitsMgmtHeaderLabel.Text = "Gestion des Produits";
        produitsMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        addressMgmtMainPanel.Location = new Point(10, 69);
        addressMgmtMainPanel.Name = "addressMgmtMainPanel";
        addressMgmtMainPanel.Size = new Size(210, 305);
        addressMgmtMainPanel.TabIndex = 1;
        // 
        // deleteAddressButton
        // 
        deleteAddressButton.Dock = DockStyle.Top;
        deleteAddressButton.Location = new Point(0, 218);
        deleteAddressButton.Name = "deleteAddressButton";
        deleteAddressButton.Size = new Size(210, 26);
        deleteAddressButton.TabIndex = 6;
        deleteAddressButton.Text = "Supprimer l'Adresse";
        deleteAddressButton.UseVisualStyleBackColor = true;
        deleteAddressButton.Click += this.DeleteAddressButton_Click;
        // 
        // editAddressButton
        // 
        editAddressButton.Dock = DockStyle.Top;
        editAddressButton.Location = new Point(0, 192);
        editAddressButton.Name = "editAddressButton";
        editAddressButton.Size = new Size(210, 26);
        editAddressButton.TabIndex = 5;
        editAddressButton.Text = "Modifier l'Adresse";
        editAddressButton.UseVisualStyleBackColor = true;
        editAddressButton.Click += this.EditAddressButton_Click;
        // 
        // viewAddressButton
        // 
        viewAddressButton.Dock = DockStyle.Top;
        viewAddressButton.Location = new Point(0, 166);
        viewAddressButton.Name = "viewAddressButton";
        viewAddressButton.Size = new Size(210, 26);
        viewAddressButton.TabIndex = 4;
        viewAddressButton.Text = "Voir Détails";
        viewAddressButton.UseVisualStyleBackColor = true;
        viewAddressButton.Click += this.ViewAddressButton_Click;
        // 
        // filteredAddresses
        // 
        filteredAddresses.Dock = DockStyle.Top;
        filteredAddresses.FormattingEnabled = true;
        filteredAddresses.ItemHeight = 15;
        filteredAddresses.Location = new Point(0, 72);
        filteredAddresses.Name = "filteredAddresses";
        filteredAddresses.Size = new Size(210, 94);
        filteredAddresses.TabIndex = 3;
        filteredAddresses.SelectedIndexChanged += this.FilteredAddresses_SelectedIndexChanged;
        // 
        // addressSearchTextBox
        // 
        addressSearchTextBox.Dock = DockStyle.Top;
        addressSearchTextBox.Location = new Point(0, 49);
        addressSearchTextBox.Name = "addressSearchTextBox";
        addressSearchTextBox.Size = new Size(210, 23);
        addressSearchTextBox.TabIndex = 2;
        addressSearchTextBox.TextChanged += this.AddressSearchTextBox_TextChanged;
        // 
        // existingAddressesLabel
        // 
        existingAddressesLabel.Dock = DockStyle.Top;
        existingAddressesLabel.Location = new Point(0, 26);
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
        createAddressButton.Size = new Size(210, 26);
        createAddressButton.TabIndex = 0;
        createAddressButton.Text = "Nouvelle Adresse";
        createAddressButton.UseVisualStyleBackColor = true;
        createAddressButton.Click += this.CreateAddressButton_Click;
        // 
        // addressMgmtTopBar
        // 
        addressMgmtTopBar.Controls.Add(addressMgmtLabel);
        addressMgmtTopBar.Dock = DockStyle.Top;
        addressMgmtTopBar.Location = new Point(10, 10);
        addressMgmtTopBar.Name = "addressMgmtTopBar";
        addressMgmtTopBar.Size = new Size(210, 59);
        addressMgmtTopBar.TabIndex = 0;
        // 
        // addressMgmtLabel
        // 
        addressMgmtLabel.Dock = DockStyle.Fill;
        addressMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        addressMgmtLabel.Location = new Point(0, 0);
        addressMgmtLabel.Name = "addressMgmtLabel";
        addressMgmtLabel.Size = new Size(210, 59);
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
        clientMgmtMainPanel.Location = new Point(10, 69);
        clientMgmtMainPanel.Name = "clientMgmtMainPanel";
        clientMgmtMainPanel.Size = new Size(210, 306);
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
        clientDeleteButton.Click += this.ClientDeleteButton_Click;
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
        clientEditButton.Click += this.ClientEditButton_Click;
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
        clientViewButton.Click += this.ClientViewButton_Click;
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
        filteredClients.SelectedIndexChanged += this.FilteredClients_SelectedIndexChanged;
        // 
        // clientFilteringBox
        // 
        clientFilteringBox.Dock = DockStyle.Top;
        clientFilteringBox.Location = new Point(0, 58);
        clientFilteringBox.Name = "clientFilteringBox";
        clientFilteringBox.Size = new Size(210, 23);
        clientFilteringBox.TabIndex = 3;
        clientFilteringBox.TextChanged += this.ClientFilteringBox_TextChanged;
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
        clientCreateButton.Click += this.ClientCreateButton_Click;
        // 
        // clientMgmtTopBar
        // 
        clientMgmtTopBar.Controls.Add(clientMgmtLabel);
        clientMgmtTopBar.Dock = DockStyle.Top;
        clientMgmtTopBar.Location = new Point(10, 10);
        clientMgmtTopBar.Name = "clientMgmtTopBar";
        clientMgmtTopBar.Size = new Size(210, 59);
        clientMgmtTopBar.TabIndex = 0;
        // 
        // clientMgmtLabel
        // 
        clientMgmtLabel.Dock = DockStyle.Fill;
        clientMgmtLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        clientMgmtLabel.Location = new Point(0, 0);
        clientMgmtLabel.Name = "clientMgmtLabel";
        clientMgmtLabel.Size = new Size(210, 59);
        clientMgmtLabel.TabIndex = 0;
        clientMgmtLabel.Text = "Gestion des clients";
        clientMgmtLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // utilisateurMgMtPanel
        // 
        utilisateurMgMtPanel.Controls.Add(utilisateurMgmtMainPanel);
        utilisateurMgMtPanel.Location = new Point(475, 3);
        utilisateurMgMtPanel.Name = "utilisateurMgMtPanel";
        utilisateurMgMtPanel.Size = new Size(230, 384);
        utilisateurMgMtPanel.TabIndex = 2;
        // 
        // utilisateurMgmtMainPanel
        // 
        utilisateurMgmtMainPanel.Controls.Add(deleteUserButton);
        utilisateurMgmtMainPanel.Controls.Add(editUserButton);
        utilisateurMgmtMainPanel.Controls.Add(viewUserButton);
        utilisateurMgmtMainPanel.Controls.Add(UserComboBox);
        utilisateurMgmtMainPanel.Controls.Add(utilisateurSeparatorLabel);
        utilisateurMgmtMainPanel.Controls.Add(newUserButton);
        utilisateurMgmtMainPanel.Controls.Add(UserLabel);
        utilisateurMgmtMainPanel.Dock = DockStyle.Fill;
        utilisateurMgmtMainPanel.Location = new Point(0, 0);
        utilisateurMgmtMainPanel.Name = "utilisateurMgmtMainPanel";
        utilisateurMgmtMainPanel.Padding = new Padding(10);
        utilisateurMgmtMainPanel.Size = new Size(230, 384);
        utilisateurMgmtMainPanel.TabIndex = 0;
        // 
        // deleteUserButton
        // 
        deleteUserButton.Dock = DockStyle.Top;
        deleteUserButton.Location = new Point(10, 193);
        deleteUserButton.Name = "deleteUserButton";
        deleteUserButton.Size = new Size(210, 26);
        deleteUserButton.TabIndex = 19;
        deleteUserButton.Text = "Supprimer Utilisateur";
        deleteUserButton.UseVisualStyleBackColor = true;
        deleteUserButton.Click += this.DeleteUserButton_Click;
        // 
        // editUserButton
        // 
        editUserButton.Dock = DockStyle.Top;
        editUserButton.Location = new Point(10, 167);
        editUserButton.Name = "editUserButton";
        editUserButton.Size = new Size(210, 26);
        editUserButton.TabIndex = 18;
        editUserButton.Text = "Modifier Utilisteur";
        editUserButton.UseVisualStyleBackColor = true;
        editUserButton.Click += this.EditUserButton_Click;
        // 
        // viewUserButton
        // 
        viewUserButton.Dock = DockStyle.Top;
        viewUserButton.Location = new Point(10, 141);
        viewUserButton.Name = "viewUserButton";
        viewUserButton.Size = new Size(210, 26);
        viewUserButton.TabIndex = 17;
        viewUserButton.Text = "Voir Détails";
        viewUserButton.UseVisualStyleBackColor = true;
        viewUserButton.Click += this.ViewUserButton_Click;
        // 
        // UserComboBox
        // 
        UserComboBox.Dock = DockStyle.Top;
        UserComboBox.FormattingEnabled = true;
        UserComboBox.Location = new Point(10, 118);
        UserComboBox.Name = "UserComboBox";
        UserComboBox.Size = new Size(210, 23);
        UserComboBox.TabIndex = 16;
        // 
        // utilisateurSeparatorLabel
        // 
        utilisateurSeparatorLabel.Dock = DockStyle.Top;
        utilisateurSeparatorLabel.Location = new Point(10, 95);
        utilisateurSeparatorLabel.Name = "utilisateurSeparatorLabel";
        utilisateurSeparatorLabel.Size = new Size(210, 23);
        utilisateurSeparatorLabel.TabIndex = 15;
        utilisateurSeparatorLabel.Text = "Utilisateurs existants:";
        utilisateurSeparatorLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // newUserButton
        // 
        newUserButton.Dock = DockStyle.Top;
        newUserButton.Location = new Point(10, 69);
        newUserButton.Name = "newUserButton";
        newUserButton.Size = new Size(210, 26);
        newUserButton.TabIndex = 14;
        newUserButton.Text = "Nouveau Utilisateur";
        newUserButton.UseVisualStyleBackColor = true;
        newUserButton.Click += this.CreateUserButton_Click;
        // 
        // UserLabel
        // 
        UserLabel.Dock = DockStyle.Top;
        UserLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        UserLabel.Location = new Point(10, 10);
        UserLabel.Name = "UserLabel";
        UserLabel.Size = new Size(210, 59);
        UserLabel.TabIndex = 13;
        UserLabel.Text = "Gestion des Utilisateurs";
        UserLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // roleMgmtPanel
        // 
        roleMgmtPanel.Controls.Add(RoleSearchTextBox);
        roleMgmtPanel.Controls.Add(RolesFilterListBox);
        roleMgmtPanel.Controls.Add(RoleDeleteButton);
        roleMgmtPanel.Controls.Add(RoleEditButton);
        roleMgmtPanel.Controls.Add(RoleViewButton);
        roleMgmtPanel.Controls.Add(RoleSearchLabel);
        roleMgmtPanel.Controls.Add(RoleCreateButton);
        roleMgmtPanel.Controls.Add(RolesLabel);
        roleMgmtPanel.Location = new Point(475, 393);
        roleMgmtPanel.Name = "roleMgmtPanel";
        roleMgmtPanel.Size = new Size(230, 385);
        roleMgmtPanel.TabIndex = 3;
        // 
        // RoleSearchTextBox
        // 
        RoleSearchTextBox.Location = new Point(15, 127);
        RoleSearchTextBox.Name = "RoleSearchTextBox";
        RoleSearchTextBox.Size = new Size(198, 23);
        RoleSearchTextBox.TabIndex = 15;
        RoleSearchTextBox.TextChanged += this.RoleSearchTextBox_TextChanged;
        // 
        // RolesFilterListBox
        // 
        RolesFilterListBox.FormattingEnabled = true;
        RolesFilterListBox.ItemHeight = 15;
        RolesFilterListBox.Location = new Point(15, 150);
        RolesFilterListBox.Name = "RolesFilterListBox";
        RolesFilterListBox.Size = new Size(198, 94);
        RolesFilterListBox.TabIndex = 14;
        // 
        // RoleDeleteButton
        // 
        RoleDeleteButton.Location = new Point(15, 314);
        RoleDeleteButton.Name = "RoleDeleteButton";
        RoleDeleteButton.Size = new Size(198, 35);
        RoleDeleteButton.TabIndex = 13;
        RoleDeleteButton.Text = "Supprimer Rôle";
        RoleDeleteButton.UseVisualStyleBackColor = true;
        RoleDeleteButton.Click += this.RoleDeleteButton_Click;
        // 
        // RoleEditButton
        // 
        RoleEditButton.Location = new Point(15, 279);
        RoleEditButton.Name = "RoleEditButton";
        RoleEditButton.Size = new Size(198, 35);
        RoleEditButton.TabIndex = 12;
        RoleEditButton.Text = "Modifier Rôle";
        RoleEditButton.UseVisualStyleBackColor = true;
        RoleEditButton.Click += this.RoleEditButton_Click;
        // 
        // RoleViewButton
        // 
        RoleViewButton.Location = new Point(15, 244);
        RoleViewButton.Name = "RoleViewButton";
        RoleViewButton.Size = new Size(198, 35);
        RoleViewButton.TabIndex = 11;
        RoleViewButton.Text = "Voir Détails";
        RoleViewButton.UseVisualStyleBackColor = true;
        RoleViewButton.Click += this.RoleViewButton_Click;
        // 
        // RoleSearchLabel
        // 
        RoleSearchLabel.AutoSize = true;
        RoleSearchLabel.Location = new Point(72, 108);
        RoleSearchLabel.Name = "RoleSearchLabel";
        RoleSearchLabel.Size = new Size(79, 15);
        RoleSearchLabel.TabIndex = 9;
        RoleSearchLabel.Text = "Rôle existants";
        // 
        // RoleCreateButton
        // 
        RoleCreateButton.Location = new Point(15, 69);
        RoleCreateButton.Name = "RoleCreateButton";
        RoleCreateButton.Size = new Size(198, 35);
        RoleCreateButton.TabIndex = 8;
        RoleCreateButton.Text = "Nouveau Rôles";
        RoleCreateButton.UseVisualStyleBackColor = true;
        RoleCreateButton.Click += this.RoleCreateButton_Click;
        // 
        // RolesLabel
        // 
        RolesLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        RolesLabel.Location = new Point(15, 10);
        RolesLabel.Name = "RolesLabel";
        RolesLabel.Size = new Size(205, 59);
        RolesLabel.TabIndex = 7;
        RolesLabel.Text = "Gestion des Rôles";
        RolesLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // entrepotMgmtPanel
        // 
        entrepotMgmtPanel.Controls.Add(deleteEntrepotButton);
        entrepotMgmtPanel.Controls.Add(editEntrepotButton);
        entrepotMgmtPanel.Controls.Add(viewEntrepotButton);
        entrepotMgmtPanel.Controls.Add(entrepotSelector);
        entrepotMgmtPanel.Controls.Add(existingEntrepotsLabel);
        entrepotMgmtPanel.Controls.Add(createEntrepotButton);
        entrepotMgmtPanel.Controls.Add(entrepotMgmtHeaderLabel);
        entrepotMgmtPanel.Dock = DockStyle.Fill;
        entrepotMgmtPanel.Location = new Point(3, 3);
        entrepotMgmtPanel.Name = "entrepotMgmtPanel";
        entrepotMgmtPanel.Padding = new Padding(10);
        entrepotMgmtPanel.Size = new Size(230, 384);
        entrepotMgmtPanel.TabIndex = 4;
        // 
        // deleteEntrepotButton
        // 
        deleteEntrepotButton.Dock = DockStyle.Top;
        deleteEntrepotButton.Location = new Point(10, 193);
        deleteEntrepotButton.Name = "deleteEntrepotButton";
        deleteEntrepotButton.Size = new Size(210, 26);
        deleteEntrepotButton.TabIndex = 7;
        deleteEntrepotButton.Text = "Supprimer l'Entrepôt";
        deleteEntrepotButton.UseVisualStyleBackColor = true;
        deleteEntrepotButton.Click += this.DeleteEntrepotButton_Click;
        // 
        // editEntrepotButton
        // 
        editEntrepotButton.Dock = DockStyle.Top;
        editEntrepotButton.Location = new Point(10, 167);
        editEntrepotButton.Name = "editEntrepotButton";
        editEntrepotButton.Size = new Size(210, 26);
        editEntrepotButton.TabIndex = 6;
        editEntrepotButton.Text = "Modifier l'Entrepôt";
        editEntrepotButton.UseVisualStyleBackColor = true;
        editEntrepotButton.Click += this.EditEntrepotButton_Click;
        // 
        // viewEntrepotButton
        // 
        viewEntrepotButton.Dock = DockStyle.Top;
        viewEntrepotButton.Location = new Point(10, 141);
        viewEntrepotButton.Name = "viewEntrepotButton";
        viewEntrepotButton.Size = new Size(210, 26);
        viewEntrepotButton.TabIndex = 5;
        viewEntrepotButton.Text = "Voir Détails";
        viewEntrepotButton.UseVisualStyleBackColor = true;
        viewEntrepotButton.Click += this.ViewEntrepotButton_Click;
        // 
        // entrepotSelector
        // 
        entrepotSelector.Dock = DockStyle.Top;
        entrepotSelector.FormattingEnabled = true;
        entrepotSelector.Location = new Point(10, 118);
        entrepotSelector.Name = "entrepotSelector";
        entrepotSelector.Size = new Size(210, 23);
        entrepotSelector.TabIndex = 4;
        entrepotSelector.SelectedIndexChanged += this.EntrepotSelector_SelectedIndexChanged;
        // 
        // existingEntrepotsLabel
        // 
        existingEntrepotsLabel.Dock = DockStyle.Top;
        existingEntrepotsLabel.Location = new Point(10, 95);
        existingEntrepotsLabel.Name = "existingEntrepotsLabel";
        existingEntrepotsLabel.Size = new Size(210, 23);
        existingEntrepotsLabel.TabIndex = 3;
        existingEntrepotsLabel.Text = "Entrepôts existants:";
        existingEntrepotsLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // createEntrepotButton
        // 
        createEntrepotButton.Dock = DockStyle.Top;
        createEntrepotButton.Location = new Point(10, 69);
        createEntrepotButton.Name = "createEntrepotButton";
        createEntrepotButton.Size = new Size(210, 26);
        createEntrepotButton.TabIndex = 2;
        createEntrepotButton.Text = "Nouveau Entrepôt";
        createEntrepotButton.UseVisualStyleBackColor = true;
        createEntrepotButton.Click += this.CreateEntrepotButton_Click;
        // 
        // entrepotMgmtHeaderLabel
        // 
        entrepotMgmtHeaderLabel.Dock = DockStyle.Top;
        entrepotMgmtHeaderLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        entrepotMgmtHeaderLabel.Location = new Point(10, 10);
        entrepotMgmtHeaderLabel.Name = "entrepotMgmtHeaderLabel";
        entrepotMgmtHeaderLabel.Size = new Size(210, 59);
        entrepotMgmtHeaderLabel.TabIndex = 1;
        entrepotMgmtHeaderLabel.Text = "Gestion des Entrepôts";
        entrepotMgmtHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // CreateShipmentButton
        // 
        CreateShipmentButton.Location = new Point(14, 69);
        CreateShipmentButton.Name = "CreateShipmentButton";
        CreateShipmentButton.Size = new Size(210, 26);
        CreateShipmentButton.TabIndex = 4;
        CreateShipmentButton.Text = "Nouvelle Expédition";
        CreateShipmentButton.UseVisualStyleBackColor = true;
        // 
        // ShipmentLabel
        // 
        this.ShipmentLabel.AutoSize = true;
        this.ShipmentLabel.Location = new Point(111, 101);
        this.ShipmentLabel.Name = "ShipmentLabel";
        this.ShipmentLabel.Size = new Size(38, 15);
        this.ShipmentLabel.TabIndex = 5;
        this.ShipmentLabel.Text = "label1";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(14, 118);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(210, 23);
        textBox1.TabIndex = 6;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new Point(15, 141);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(210, 94);
        listBox1.TabIndex = 7;
        // 
        // button2
        // 
        button2.Location = new Point(15, 287);
        button2.Name = "button2";
        button2.Size = new Size(210, 26);
        button2.TabIndex = 8;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(15, 261);
        button3.Name = "button3";
        button3.Size = new Size(210, 26);
        button3.TabIndex = 9;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // ViewShipmentButton
        // 
        ViewShipmentButton.Location = new Point(15, 235);
        ViewShipmentButton.Name = "ViewShipmentButton";
        ViewShipmentButton.Size = new Size(210, 26);
        ViewShipmentButton.TabIndex = 10;
        ViewShipmentButton.Text = "Voir Détails";
        ViewShipmentButton.UseVisualStyleBackColor = true;
        // 
        // listBox2
        // 
        listBox2.FormattingEnabled = true;
        listBox2.ItemHeight = 15;
        listBox2.Location = new Point(15, 141);
        listBox2.Name = "listBox2";
        listBox2.Size = new Size(210, 94);
        listBox2.TabIndex = 15;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(14, 118);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(210, 23);
        textBox2.TabIndex = 14;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(111, 101);
        label2.Name = "label2";
        label2.Size = new Size(38, 15);
        label2.TabIndex = 13;
        label2.Text = "label2";
        // 
        // button8
        // 
        button8.Location = new Point(14, 69);
        button8.Name = "button8";
        button8.Size = new Size(210, 26);
        button8.TabIndex = 12;
        button8.Text = "button8";
        button8.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(15, 235);
        button5.Name = "button5";
        button5.Size = new Size(210, 26);
        button5.TabIndex = 14;
        button5.Text = "button5";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new Point(15, 261);
        button6.Name = "button6";
        button6.Size = new Size(210, 26);
        button6.TabIndex = 13;
        button6.Text = "button6";
        button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new Point(15, 287);
        button7.Name = "button7";
        button7.Size = new Size(210, 26);
        button7.TabIndex = 12;
        button7.Text = "button7";
        button7.UseVisualStyleBackColor = true;
        // 
        // AdminMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1184, 861);
        this.Controls.Add(mainPanel);
        this.Controls.Add(topBarPanel);
        this.Controls.Add(bottomBarPanel);
        this.Name = "AdminMainMenu";
        this.Text = "Menu Administration";
        this.WindowState = FormWindowState.Maximized;
        bottomBarPanel.ResumeLayout(false);
        mainPanel.ResumeLayout(false);
        shipmentOrderMgmtPanel.ResumeLayout(false);
        shipmentOrderMgmtPanel.PerformLayout();
        restockOrdersMgmtPanel.ResumeLayout(false);
        restockOrdersMgmtPanel.PerformLayout();
        shipmentMgmtPanel.ResumeLayout(false);
        fournisseursMgmtPanel.ResumeLayout(false);
        fournisseursMgmtPanel.PerformLayout();
        produitsMgmtPanel.ResumeLayout(false);
        addressManagementPanel.ResumeLayout(false);
        addressMgmtMainPanel.ResumeLayout(false);
        addressMgmtMainPanel.PerformLayout();
        addressMgmtTopBar.ResumeLayout(false);
        clientsMgmtPanel.ResumeLayout(false);
        clientMgmtMainPanel.ResumeLayout(false);
        clientMgmtMainPanel.PerformLayout();
        clientMgmtTopBar.ResumeLayout(false);
        utilisateurMgMtPanel.ResumeLayout(false);
        utilisateurMgmtMainPanel.ResumeLayout(false);
        roleMgmtPanel.ResumeLayout(false);
        roleMgmtPanel.PerformLayout();
        entrepotMgmtPanel.ResumeLayout(false);
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
    private Panel utilisateurMgmtMainPanel;
    private Button deleteUserButton;
    private Button editUserButton;
    private Button viewUserButton;
    private ComboBox UserComboBox;
    private Label utilisateurSeparatorLabel;
    private Button newUserButton;
    private Label UserLabel;
    private Button deleteEntrepotButton;
    private Button editEntrepotButton;
    private Button viewEntrepotButton;
    private ComboBox entrepotSelector;
    private Label existingEntrepotsLabel;
    private Button createEntrepotButton;
    private Button createROButton;
    private Button viewROButton;
    private ListBox roSearchResultsListBox;
    private TextBox roSearchFilterTextBox;
    private Label existingROLabel;
    private Button button8;
    private Label label2;
    private ListBox listBox2;
    private TextBox textBox2;
    private Label label3;
    private Button ViewShipmentButton;
    private Button button3;
    private Button button2;
    private ListBox listBox1;
    private TextBox textBox1;
    private Label label1;
    private Button CreateShipmentButton;
    private Button button5;
    private Button button6;
    private Button button7;
    private Label ShipmentLabel;
}