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
        this.existingAddressesLabel = new Label();
        this.createAddressButton = new Button();
        this.addressMgmtTopBar = new Panel();
        this.label1 = new Label();
        this.addressSearchTextBox = new TextBox();
        this.filteredAddresses = new ListBox();
        this.viewAddressButton = new Button();
        this.editAddressButton = new Button();
        this.deleteAddressButton = new Button();
        this.bottomBarPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        this.addressManagementPanel.SuspendLayout();
        this.addressMgmtMainPanel.SuspendLayout();
        this.addressMgmtTopBar.SuspendLayout();
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
        this.addressMgmtTopBar.Controls.Add(this.label1);
        this.addressMgmtTopBar.Dock = DockStyle.Top;
        this.addressMgmtTopBar.Location = new Point(10, 10);
        this.addressMgmtTopBar.Name = "addressMgmtTopBar";
        this.addressMgmtTopBar.Size = new Size(210, 40);
        this.addressMgmtTopBar.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.Dock = DockStyle.Fill;
        this.label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.label1.Location = new Point(0, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(210, 40);
        this.label1.TabIndex = 0;
        this.label1.Text = "Gestion des Adresses";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
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
    private Label label1;
    private Label existingAddressesLabel;
    private TextBox addressSearchTextBox;
    private Button viewAddressButton;
    private ListBox filteredAddresses;
    private Button deleteAddressButton;
    private Button editAddressButton;
}