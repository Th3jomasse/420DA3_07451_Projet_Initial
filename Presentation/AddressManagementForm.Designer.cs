namespace _420DA3_07451_Projet_Initial.Presentation;

partial class AddressManagementForm {
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
        this.bottomBarPanel = new Panel();
        this.mainTableLayoutPanel = new TableLayoutPanel();
        this.mainPanel = new Panel();
        this.idNumUpDown = new NumericUpDown();
        this.idLabel = new Label();
        this.civicNumberLabel = new Label();
        this.civicNumNumUpDown = new NumericUpDown();
        this.streetLabel = new Label();
        this.streetTextBox = new TextBox();
        this.cityLabel = new Label();
        this.cityTextBox = new TextBox();
        this.provinceLabel = new Label();
        this.provinceTextBox = new TextBox();
        this.countryLabel = new Label();
        this.countryTextBox = new TextBox();
        this.postalCodeLabel = new Label();
        this.postalCodeTextBox = new TextBox();
        this.buttonCancel = new Button();
        this.buttonAction = new Button();
        this.label1 = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.mainTableLayoutPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.civicNumNumUpDown).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.label1);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(384, 40);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.buttonAction);
        this.bottomBarPanel.Controls.Add(this.buttonCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 271);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(384, 40);
        this.bottomBarPanel.TabIndex = 1;
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
        this.mainTableLayoutPanel.Size = new Size(384, 231);
        this.mainTableLayoutPanel.TabIndex = 2;
        // 
        // mainPanel
        // 
        this.mainPanel.Controls.Add(this.postalCodeTextBox);
        this.mainPanel.Controls.Add(this.postalCodeLabel);
        this.mainPanel.Controls.Add(this.countryTextBox);
        this.mainPanel.Controls.Add(this.countryLabel);
        this.mainPanel.Controls.Add(this.provinceTextBox);
        this.mainPanel.Controls.Add(this.provinceLabel);
        this.mainPanel.Controls.Add(this.cityTextBox);
        this.mainPanel.Controls.Add(this.cityLabel);
        this.mainPanel.Controls.Add(this.streetTextBox);
        this.mainPanel.Controls.Add(this.streetLabel);
        this.mainPanel.Controls.Add(this.civicNumNumUpDown);
        this.mainPanel.Controls.Add(this.civicNumberLabel);
        this.mainPanel.Controls.Add(this.idNumUpDown);
        this.mainPanel.Controls.Add(this.idLabel);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(45, 3);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Padding = new Padding(10);
        this.mainPanel.Size = new Size(294, 225);
        this.mainPanel.TabIndex = 0;
        // 
        // idNumUpDown
        // 
        this.idNumUpDown.Enabled = false;
        this.idNumUpDown.Location = new Point(119, 12);
        this.idNumUpDown.Name = "idNumUpDown";
        this.idNumUpDown.Size = new Size(162, 23);
        this.idNumUpDown.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(13, 10);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(100, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // civicNumberLabel
        // 
        this.civicNumberLabel.Location = new Point(13, 38);
        this.civicNumberLabel.Name = "civicNumberLabel";
        this.civicNumberLabel.Size = new Size(100, 23);
        this.civicNumberLabel.TabIndex = 2;
        this.civicNumberLabel.Text = "Numéro Civique:";
        this.civicNumberLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // civicNumNumUpDown
        // 
        this.civicNumNumUpDown.Location = new Point(119, 40);
        this.civicNumNumUpDown.Name = "civicNumNumUpDown";
        this.civicNumNumUpDown.Size = new Size(162, 23);
        this.civicNumNumUpDown.TabIndex = 3;
        // 
        // streetLabel
        // 
        this.streetLabel.Location = new Point(13, 66);
        this.streetLabel.Name = "streetLabel";
        this.streetLabel.Size = new Size(100, 23);
        this.streetLabel.TabIndex = 4;
        this.streetLabel.Text = "Rue:";
        this.streetLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // streetTextBox
        // 
        this.streetTextBox.Location = new Point(119, 67);
        this.streetTextBox.Name = "streetTextBox";
        this.streetTextBox.PlaceholderText = "Nom de rue";
        this.streetTextBox.Size = new Size(162, 23);
        this.streetTextBox.TabIndex = 5;
        // 
        // cityLabel
        // 
        this.cityLabel.Location = new Point(13, 89);
        this.cityLabel.Name = "cityLabel";
        this.cityLabel.Size = new Size(100, 23);
        this.cityLabel.TabIndex = 6;
        this.cityLabel.Text = "Ville:";
        this.cityLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cityTextBox
        // 
        this.cityTextBox.Location = new Point(119, 90);
        this.cityTextBox.Name = "cityTextBox";
        this.cityTextBox.PlaceholderText = "Nom de ville";
        this.cityTextBox.Size = new Size(162, 23);
        this.cityTextBox.TabIndex = 7;
        // 
        // provinceLabel
        // 
        this.provinceLabel.Location = new Point(13, 112);
        this.provinceLabel.Name = "provinceLabel";
        this.provinceLabel.Size = new Size(100, 23);
        this.provinceLabel.TabIndex = 8;
        this.provinceLabel.Text = "Province/État:";
        this.provinceLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // provinceTextBox
        // 
        this.provinceTextBox.Location = new Point(119, 113);
        this.provinceTextBox.Name = "provinceTextBox";
        this.provinceTextBox.PlaceholderText = "Province ou État";
        this.provinceTextBox.Size = new Size(162, 23);
        this.provinceTextBox.TabIndex = 9;
        // 
        // countryLabel
        // 
        this.countryLabel.Location = new Point(13, 135);
        this.countryLabel.Name = "countryLabel";
        this.countryLabel.Size = new Size(100, 23);
        this.countryLabel.TabIndex = 10;
        this.countryLabel.Text = "Pays:";
        this.countryLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // countryTextBox
        // 
        this.countryTextBox.Location = new Point(119, 136);
        this.countryTextBox.Name = "countryTextBox";
        this.countryTextBox.PlaceholderText = "Pays";
        this.countryTextBox.Size = new Size(162, 23);
        this.countryTextBox.TabIndex = 11;
        // 
        // postalCodeLabel
        // 
        this.postalCodeLabel.Location = new Point(13, 158);
        this.postalCodeLabel.Name = "postalCodeLabel";
        this.postalCodeLabel.Size = new Size(100, 23);
        this.postalCodeLabel.TabIndex = 12;
        this.postalCodeLabel.Text = "Code Postal:";
        this.postalCodeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // postalCodeTextBox
        // 
        this.postalCodeTextBox.Location = new Point(119, 159);
        this.postalCodeTextBox.Name = "postalCodeTextBox";
        this.postalCodeTextBox.PlaceholderText = "Code Postal";
        this.postalCodeTextBox.Size = new Size(162, 23);
        this.postalCodeTextBox.TabIndex = 13;
        // 
        // buttonCancel
        // 
        this.buttonCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonCancel.Location = new Point(306, 6);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(75, 23);
        this.buttonCancel.TabIndex = 0;
        this.buttonCancel.Text = "Annuler";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += this.ButtonCancel_Click;
        // 
        // buttonAction
        // 
        this.buttonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonAction.Location = new Point(183, 6);
        this.buttonAction.Name = "buttonAction";
        this.buttonAction.Size = new Size(117, 23);
        this.buttonAction.TabIndex = 1;
        this.buttonAction.Text = "ACTION";
        this.buttonAction.UseVisualStyleBackColor = true;
        this.buttonAction.Click += this.ButtonAction_Click;
        // 
        // label1
        // 
        this.label1.Dock = DockStyle.Fill;
        this.label1.Font = new Font("Segoe UI Black", 15.75F,  FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        this.label1.Location = new Point(0, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(384, 40);
        this.label1.TabIndex = 0;
        this.label1.Text = "Gestion d'adresse";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AddressManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(384, 311);
        this.Controls.Add(this.mainTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "AddressManagementForm";
        this.Text = "AddressManagementForm";
        this.topBarPanel.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.mainTableLayoutPanel.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.mainPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.civicNumNumUpDown).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel mainTableLayoutPanel;
    private Panel mainPanel;
    private Label idLabel;
    private NumericUpDown idNumUpDown;
    private TextBox streetTextBox;
    private Label streetLabel;
    private NumericUpDown civicNumNumUpDown;
    private Label civicNumberLabel;
    private TextBox provinceTextBox;
    private Label provinceLabel;
    private TextBox cityTextBox;
    private Label cityLabel;
    private Label countryLabel;
    private TextBox postalCodeTextBox;
    private Label postalCodeLabel;
    private TextBox countryTextBox;
    private Label label1;
    private Button buttonAction;
    private Button buttonCancel;
}