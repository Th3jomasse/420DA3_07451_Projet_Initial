namespace _420DA3_07451_Projet_Initial.Presentation;

partial class EntrepotManagementForm {
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
        this.addressSelector = new ComboBox();
        this.addressLabel = new Label();
        this.nomTextBox = new TextBox();
        this.nomLabel = new Label();
        this.idNumUpDown = new NumericUpDown();
        this.idLabel = new Label();
        this.createAddrssButton = new Button();
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
        this.topBarPanel.Size = new Size(484, 40);
        this.topBarPanel.TabIndex = 0;
        // 
        // headerLabel
        // 
        this.headerLabel.Dock = DockStyle.Fill;
        this.headerLabel.Font = new Font("Segoe UI Black", 15.75F,  FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        this.headerLabel.Location = new Point(0, 0);
        this.headerLabel.Name = "headerLabel";
        this.headerLabel.Size = new Size(484, 40);
        this.headerLabel.TabIndex = 3;
        this.headerLabel.Text = "Gestion d'un entrepôt";
        this.headerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 171);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(484, 40);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(262, 6);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(129, 23);
        this.actionButton.TabIndex = 1;
        this.actionButton.Text = "ACTION";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(397, 6);
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
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
        this.mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTableLayoutPanel.Controls.Add(this.mainPanel, 1, 0);
        this.mainTableLayoutPanel.Dock = DockStyle.Fill;
        this.mainTableLayoutPanel.Location = new Point(0, 40);
        this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        this.mainTableLayoutPanel.RowCount = 1;
        this.mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.mainTableLayoutPanel.Size = new Size(484, 131);
        this.mainTableLayoutPanel.TabIndex = 2;
        // 
        // mainPanel
        // 
        this.mainPanel.Controls.Add(this.createAddrssButton);
        this.mainPanel.Controls.Add(this.addressSelector);
        this.mainPanel.Controls.Add(this.addressLabel);
        this.mainPanel.Controls.Add(this.nomTextBox);
        this.mainPanel.Controls.Add(this.nomLabel);
        this.mainPanel.Controls.Add(this.idNumUpDown);
        this.mainPanel.Controls.Add(this.idLabel);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(70, 3);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Padding = new Padding(10);
        this.mainPanel.Size = new Size(344, 125);
        this.mainPanel.TabIndex = 0;
        // 
        // addressSelector
        // 
        this.addressSelector.FormattingEnabled = true;
        this.addressSelector.Location = new Point(119, 67);
        this.addressSelector.Name = "addressSelector";
        this.addressSelector.Size = new Size(181, 23);
        this.addressSelector.TabIndex = 5;
        // 
        // addressLabel
        // 
        this.addressLabel.Location = new Point(13, 66);
        this.addressLabel.Margin = new Padding(3, 0, 3, 5);
        this.addressLabel.Name = "addressLabel";
        this.addressLabel.Size = new Size(100, 23);
        this.addressLabel.TabIndex = 4;
        this.addressLabel.Text = "Adresse:";
        this.addressLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nomTextBox
        // 
        this.nomTextBox.Location = new Point(119, 39);
        this.nomTextBox.Name = "nomTextBox";
        this.nomTextBox.Size = new Size(212, 23);
        this.nomTextBox.TabIndex = 3;
        // 
        // nomLabel
        // 
        this.nomLabel.Location = new Point(13, 38);
        this.nomLabel.Margin = new Padding(3, 0, 3, 5);
        this.nomLabel.Name = "nomLabel";
        this.nomLabel.Size = new Size(100, 23);
        this.nomLabel.TabIndex = 2;
        this.nomLabel.Text = "Nom entrepôt:";
        this.nomLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idNumUpDown
        // 
        this.idNumUpDown.Location = new Point(119, 12);
        this.idNumUpDown.Name = "idNumUpDown";
        this.idNumUpDown.Size = new Size(212, 23);
        this.idNumUpDown.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(13, 10);
        this.idLabel.Margin = new Padding(3, 0, 3, 5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(100, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // createAddrssButton
        // 
        this.createAddrssButton.Cursor = Cursors.Hand;
        this.createAddrssButton.FlatStyle = FlatStyle.Flat;
        this.createAddrssButton.Image = Properties.Resources.plus_20px;
        this.createAddrssButton.Location = new Point(306, 67);
        this.createAddrssButton.Name = "createAddrssButton";
        this.createAddrssButton.Size = new Size(25, 23);
        this.createAddrssButton.TabIndex = 6;
        this.createAddrssButton.UseVisualStyleBackColor = true;
        this.createAddrssButton.Click += this.CreateAddressButton_Click;
        // 
        // EntrepotManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(484, 211);
        this.Controls.Add(this.mainTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "EntrepotManagementForm";
        this.Text = "EntrepotManagementForm";
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
    private Label headerLabel;
    private Panel mainPanel;
    private Label idLabel;
    private Label addressLabel;
    private TextBox nomTextBox;
    private Label nomLabel;
    private NumericUpDown idNumUpDown;
    private ComboBox addressSelector;
    private Button actionButton;
    private Button cancelButton;
    private Button createAddrssButton;
}