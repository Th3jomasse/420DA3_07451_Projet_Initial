namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ClientManagementForm {
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
        this.topBarPanel = new Panel();
        this.headerLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.mainTableLayoutPanel = new TableLayoutPanel();
        this.mainPanel = new Panel();
        this.telephoneContactTextBox = new TextBox();
        this.telephoneContactLabel = new Label();
        this.courrielContactTextBox = new TextBox();
        this.courrielContactLabel = new Label();
        this.prenomContactTextBox = new TextBox();
        this.prenomContactLabel = new Label();
        this.contactNameTextBox = new TextBox();
        this.contactNameLabel = new Label();
        this.warehouseSelector = new ComboBox();
        this.addressSelector = new ComboBox();
        this.addressLabel = new Label();
        this.warehouseLabel = new Label();
        this.contactFieldsLabel = new Label();
        this.nomClientTextBox = new TextBox();
        this.nomClientLabel = new Label();
        this.idNumUpDown = new NumericUpDown();
        this.idLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.mainTableLayoutPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.headerLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(434, 40);
        this.topBarPanel.TabIndex = 0;
        // 
        // headerLabel
        // 
        this.headerLabel.Dock = DockStyle.Fill;
        this.headerLabel.Font = new Font("Segoe UI Black", 15.75F,  FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        this.headerLabel.Location = new Point(0, 0);
        this.headerLabel.Name = "headerLabel";
        this.headerLabel.Size = new Size(434, 40);
        this.headerLabel.TabIndex = 1;
        this.headerLabel.Text = "Gestion de client";
        this.headerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 421);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(434, 40);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(219, 6);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(122, 23);
        this.actionButton.TabIndex = 1;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(347, 6);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(75, 23);
        this.cancelButton.TabIndex = 0;
        this.cancelButton.Text = "Annuler";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += this.CancelButton_Click;
        // 
        // mainTableLayoutPanel
        // 
        this.mainTableLayoutPanel.ColumnCount = 3;
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.Controls.Add(this.mainPanel, 1, 0);
        this.mainTableLayoutPanel.Dock = DockStyle.Fill;
        this.mainTableLayoutPanel.Location = new Point(0, 40);
        this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        this.mainTableLayoutPanel.RowCount = 1;
        this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.mainTableLayoutPanel.Size = new Size(434, 381);
        this.mainTableLayoutPanel.TabIndex = 2;
        // 
        // mainPanel
        // 
        this.mainPanel.Controls.Add(this.telephoneContactTextBox);
        this.mainPanel.Controls.Add(this.telephoneContactLabel);
        this.mainPanel.Controls.Add(this.courrielContactTextBox);
        this.mainPanel.Controls.Add(this.courrielContactLabel);
        this.mainPanel.Controls.Add(this.prenomContactTextBox);
        this.mainPanel.Controls.Add(this.prenomContactLabel);
        this.mainPanel.Controls.Add(this.contactNameTextBox);
        this.mainPanel.Controls.Add(this.contactNameLabel);
        this.mainPanel.Controls.Add(this.warehouseSelector);
        this.mainPanel.Controls.Add(this.addressSelector);
        this.mainPanel.Controls.Add(this.addressLabel);
        this.mainPanel.Controls.Add(this.warehouseLabel);
        this.mainPanel.Controls.Add(this.contactFieldsLabel);
        this.mainPanel.Controls.Add(this.nomClientTextBox);
        this.mainPanel.Controls.Add(this.nomClientLabel);
        this.mainPanel.Controls.Add(this.idNumUpDown);
        this.mainPanel.Controls.Add(this.idLabel);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(70, 3);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Padding = new Padding(10);
        this.mainPanel.Size = new Size(294, 375);
        this.mainPanel.TabIndex = 0;
        // 
        // telephoneContactTextBox
        // 
        this.telephoneContactTextBox.Location = new Point(119, 309);
        this.telephoneContactTextBox.Name = "telephoneContactTextBox";
        this.telephoneContactTextBox.PlaceholderText = "Chiffres seulement";
        this.telephoneContactTextBox.Size = new Size(162, 23);
        this.telephoneContactTextBox.TabIndex = 16;
        this.telephoneContactTextBox.Leave += this.TelephoneContactTextBox_Leave;
        // 
        // telephoneContactLabel
        // 
        this.telephoneContactLabel.Location = new Point(13, 308);
        this.telephoneContactLabel.Margin = new Padding(3, 5, 3, 5);
        this.telephoneContactLabel.Name = "telephoneContactLabel";
        this.telephoneContactLabel.Size = new Size(100, 23);
        this.telephoneContactLabel.TabIndex = 15;
        this.telephoneContactLabel.Text = "Tel. contact:";
        this.telephoneContactLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // courrielContactTextBox
        // 
        this.courrielContactTextBox.Location = new Point(119, 276);
        this.courrielContactTextBox.Name = "courrielContactTextBox";
        this.courrielContactTextBox.PlaceholderText = "Format xxx@xxx.xxx";
        this.courrielContactTextBox.Size = new Size(162, 23);
        this.courrielContactTextBox.TabIndex = 14;
        // 
        // courrielContactLabel
        // 
        this.courrielContactLabel.Location = new Point(13, 275);
        this.courrielContactLabel.Margin = new Padding(3, 5, 3, 5);
        this.courrielContactLabel.Name = "courrielContactLabel";
        this.courrielContactLabel.Size = new Size(100, 23);
        this.courrielContactLabel.TabIndex = 13;
        this.courrielContactLabel.Text = "Courriel contact:";
        this.courrielContactLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // prenomContactTextBox
        // 
        this.prenomContactTextBox.Location = new Point(119, 243);
        this.prenomContactTextBox.Name = "prenomContactTextBox";
        this.prenomContactTextBox.Size = new Size(162, 23);
        this.prenomContactTextBox.TabIndex = 12;
        // 
        // prenomContactLabel
        // 
        this.prenomContactLabel.Location = new Point(13, 242);
        this.prenomContactLabel.Margin = new Padding(3, 5, 3, 5);
        this.prenomContactLabel.Name = "prenomContactLabel";
        this.prenomContactLabel.Size = new Size(100, 23);
        this.prenomContactLabel.TabIndex = 11;
        this.prenomContactLabel.Text = "Prénom contact:";
        this.prenomContactLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactNameTextBox
        // 
        this.contactNameTextBox.Location = new Point(119, 210);
        this.contactNameTextBox.Name = "contactNameTextBox";
        this.contactNameTextBox.Size = new Size(162, 23);
        this.contactNameTextBox.TabIndex = 10;
        // 
        // contactNameLabel
        // 
        this.contactNameLabel.Location = new Point(13, 209);
        this.contactNameLabel.Margin = new Padding(3, 5, 3, 5);
        this.contactNameLabel.Name = "contactNameLabel";
        this.contactNameLabel.Size = new Size(100, 23);
        this.contactNameLabel.TabIndex = 9;
        this.contactNameLabel.Text = "Nom contact:";
        this.contactNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseSelector
        // 
        this.warehouseSelector.FormattingEnabled = true;
        this.warehouseSelector.Location = new Point(119, 125);
        this.warehouseSelector.Name = "warehouseSelector";
        this.warehouseSelector.Size = new Size(162, 23);
        this.warehouseSelector.TabIndex = 8;
        // 
        // addressSelector
        // 
        this.addressSelector.FormattingEnabled = true;
        this.addressSelector.Location = new Point(119, 92);
        this.addressSelector.Name = "addressSelector";
        this.addressSelector.Size = new Size(162, 23);
        this.addressSelector.TabIndex = 7;
        // 
        // addressLabel
        // 
        this.addressLabel.Location = new Point(13, 91);
        this.addressLabel.Margin = new Padding(3, 5, 3, 5);
        this.addressLabel.Name = "addressLabel";
        this.addressLabel.Size = new Size(100, 23);
        this.addressLabel.TabIndex = 6;
        this.addressLabel.Text = "Adresse du client:";
        this.addressLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseLabel
        // 
        this.warehouseLabel.Location = new Point(13, 124);
        this.warehouseLabel.Margin = new Padding(3, 5, 3, 5);
        this.warehouseLabel.Name = "warehouseLabel";
        this.warehouseLabel.Size = new Size(100, 23);
        this.warehouseLabel.TabIndex = 5;
        this.warehouseLabel.Text = "Entrepot assigné:";
        this.warehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactFieldsLabel
        // 
        this.contactFieldsLabel.Location = new Point(13, 176);
        this.contactFieldsLabel.Margin = new Padding(3, 5, 3, 5);
        this.contactFieldsLabel.Name = "contactFieldsLabel";
        this.contactFieldsLabel.Size = new Size(268, 23);
        this.contactFieldsLabel.TabIndex = 4;
        this.contactFieldsLabel.Text = "Informations de la personne-contact:";
        this.contactFieldsLabel.TextAlign = ContentAlignment.BottomLeft;
        // 
        // nomClientTextBox
        // 
        this.nomClientTextBox.Location = new Point(119, 59);
        this.nomClientTextBox.Name = "nomClientTextBox";
        this.nomClientTextBox.Size = new Size(162, 23);
        this.nomClientTextBox.TabIndex = 3;
        // 
        // nomClientLabel
        // 
        this.nomClientLabel.Location = new Point(13, 58);
        this.nomClientLabel.Margin = new Padding(3, 5, 3, 5);
        this.nomClientLabel.Name = "nomClientLabel";
        this.nomClientLabel.Size = new Size(100, 23);
        this.nomClientLabel.TabIndex = 2;
        this.nomClientLabel.Text = "Nom du client:";
        this.nomClientLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idNumUpDown
        // 
        this.idNumUpDown.Enabled = false;
        this.idNumUpDown.Location = new Point(119, 27);
        this.idNumUpDown.Name = "idNumUpDown";
        this.idNumUpDown.Size = new Size(162, 23);
        this.idNumUpDown.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(13, 25);
        this.idLabel.Margin = new Padding(3, 5, 3, 5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(100, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // ClientManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(434, 461);
        this.Controls.Add(this.mainTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "ClientManagementForm";
        this.Text = "ClientManagementForm";
        this.topBarPanel.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.mainTableLayoutPanel.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.mainPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel mainTableLayoutPanel;
    private Panel mainPanel;
    private Label headerLabel;
    private Button actionButton;
    private Button cancelButton;
    private TextBox nomClientTextBox;
    private Label nomClientLabel;
    private NumericUpDown idNumUpDown;
    private Label idLabel;
    private Label addressLabel;
    private Label warehouseLabel;
    private Label contactFieldsLabel;
    private ComboBox warehouseSelector;
    private ComboBox addressSelector;
    private Label contactNameLabel;
    private Label courrielContactLabel;
    private TextBox prenomContactTextBox;
    private Label prenomContactLabel;
    private TextBox contactNameTextBox;
    private Label telephoneContactLabel;
    private TextBox courrielContactTextBox;
    private TextBox telephoneContactTextBox;
}