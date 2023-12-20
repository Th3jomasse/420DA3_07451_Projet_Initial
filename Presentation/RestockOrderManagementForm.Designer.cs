namespace _420DA3_07451_Projet_Initial.Presentation;

partial class RestockOrderManagementForm {
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
        this.entrepotSelector = new ComboBox();
        this.statusSelector = new ComboBox();
        this.quantityNumUpDown = new NumericUpDown();
        this.produitLabel = new Label();
        this.productSearchListBox = new ListBox();
        this.productSearchFilter = new TextBox();
        this.statutLabel = new Label();
        this.quantiteLabel = new Label();
        this.productLabel = new Label();
        this.warehouseLabel = new Label();
        this.idNumUpDown = new NumericUpDown();
        this.idLabel = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.mainTableLayoutPanel.SuspendLayout();
        this.mainPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.quantityNumUpDown).BeginInit();
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
        this.headerLabel.TabIndex = 2;
        this.headerLabel.Text = "Gestion de commande de restockage";
        this.headerLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 321);
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
        this.mainTableLayoutPanel.Size = new Size(484, 281);
        this.mainTableLayoutPanel.TabIndex = 2;
        // 
        // mainPanel
        // 
        this.mainPanel.Controls.Add(this.entrepotSelector);
        this.mainPanel.Controls.Add(this.statusSelector);
        this.mainPanel.Controls.Add(this.quantityNumUpDown);
        this.mainPanel.Controls.Add(this.produitLabel);
        this.mainPanel.Controls.Add(this.productSearchListBox);
        this.mainPanel.Controls.Add(this.productSearchFilter);
        this.mainPanel.Controls.Add(this.statutLabel);
        this.mainPanel.Controls.Add(this.quantiteLabel);
        this.mainPanel.Controls.Add(this.productLabel);
        this.mainPanel.Controls.Add(this.warehouseLabel);
        this.mainPanel.Controls.Add(this.idNumUpDown);
        this.mainPanel.Controls.Add(this.idLabel);
        this.mainPanel.Dock = DockStyle.Fill;
        this.mainPanel.Location = new Point(70, 3);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Padding = new Padding(10);
        this.mainPanel.Size = new Size(344, 275);
        this.mainPanel.TabIndex = 0;
        // 
        // entrepotSelector
        // 
        this.entrepotSelector.FormattingEnabled = true;
        this.entrepotSelector.Location = new Point(139, 195);
        this.entrepotSelector.Name = "entrepotSelector";
        this.entrepotSelector.Size = new Size(192, 23);
        this.entrepotSelector.TabIndex = 12;
        // 
        // statusSelector
        // 
        this.statusSelector.FormattingEnabled = true;
        this.statusSelector.Location = new Point(139, 166);
        this.statusSelector.Name = "statusSelector";
        this.statusSelector.Size = new Size(192, 23);
        this.statusSelector.TabIndex = 11;
        // 
        // quantityNumUpDown
        // 
        this.quantityNumUpDown.Location = new Point(139, 138);
        this.quantityNumUpDown.Name = "quantityNumUpDown";
        this.quantityNumUpDown.Size = new Size(192, 23);
        this.quantityNumUpDown.TabIndex = 10;
        // 
        // produitLabel
        // 
        this.produitLabel.Location = new Point(13, 68);
        this.produitLabel.Margin = new Padding(3, 0, 3, 5);
        this.produitLabel.Name = "produitLabel";
        this.produitLabel.Size = new Size(120, 23);
        this.produitLabel.TabIndex = 9;
        this.produitLabel.Text = "Produit:";
        this.produitLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // productSearchListBox
        // 
        this.productSearchListBox.FormattingEnabled = true;
        this.productSearchListBox.ItemHeight = 15;
        this.productSearchListBox.Location = new Point(139, 68);
        this.productSearchListBox.Name = "productSearchListBox";
        this.productSearchListBox.Size = new Size(192, 64);
        this.productSearchListBox.TabIndex = 8;
        this.productSearchListBox.SelectedIndexChanged += this.ProductSearchListBox_SelectedIndexChanged;
        // 
        // productSearchFilter
        // 
        this.productSearchFilter.Location = new Point(139, 39);
        this.productSearchFilter.Name = "productSearchFilter";
        this.productSearchFilter.Size = new Size(192, 23);
        this.productSearchFilter.TabIndex = 7;
        this.productSearchFilter.TextChanged += this.ProductSearchFilter_TextChanged;
        // 
        // statutLabel
        // 
        this.statutLabel.Location = new Point(13, 166);
        this.statutLabel.Margin = new Padding(3, 0, 3, 5);
        this.statutLabel.Name = "statutLabel";
        this.statutLabel.Size = new Size(120, 23);
        this.statutLabel.TabIndex = 5;
        this.statutLabel.Text = "État:";
        this.statutLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // quantiteLabel
        // 
        this.quantiteLabel.Location = new Point(13, 138);
        this.quantiteLabel.Margin = new Padding(3, 0, 3, 5);
        this.quantiteLabel.Name = "quantiteLabel";
        this.quantiteLabel.Size = new Size(120, 23);
        this.quantiteLabel.TabIndex = 4;
        this.quantiteLabel.Text = "Quantité:";
        this.quantiteLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // productLabel
        // 
        this.productLabel.Location = new Point(13, 38);
        this.productLabel.Margin = new Padding(3, 0, 3, 5);
        this.productLabel.Name = "productLabel";
        this.productLabel.Size = new Size(120, 23);
        this.productLabel.TabIndex = 3;
        this.productLabel.Text = "Recherche produit:";
        this.productLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseLabel
        // 
        this.warehouseLabel.Location = new Point(13, 194);
        this.warehouseLabel.Margin = new Padding(3, 0, 3, 5);
        this.warehouseLabel.Name = "warehouseLabel";
        this.warehouseLabel.Size = new Size(120, 23);
        this.warehouseLabel.TabIndex = 2;
        this.warehouseLabel.Text = "Entrepôt destinataire:";
        this.warehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idNumUpDown
        // 
        this.idNumUpDown.Enabled = false;
        this.idNumUpDown.Location = new Point(139, 12);
        this.idNumUpDown.Name = "idNumUpDown";
        this.idNumUpDown.Size = new Size(192, 23);
        this.idNumUpDown.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(13, 10);
        this.idLabel.Margin = new Padding(3, 0, 3, 5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(120, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RestockOrderManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(484, 361);
        this.Controls.Add(this.mainTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "RestockOrderManagementForm";
        this.Text = "RestockOrderManagementForm";
        this.topBarPanel.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.mainTableLayoutPanel.ResumeLayout(false);
        this.mainPanel.ResumeLayout(false);
        this.mainPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.quantityNumUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.idNumUpDown).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel mainTableLayoutPanel;
    private Panel mainPanel;
    private Label warehouseLabel;
    private NumericUpDown idNumUpDown;
    private Label idLabel;
    private Label productLabel;
    private Label quantiteLabel;
    private Label statutLabel;
    private ComboBox entrepotSelector;
    private ComboBox statusSelector;
    private NumericUpDown quantityNumUpDown;
    private Label produitLabel;
    private ListBox productSearchListBox;
    private TextBox productSearchFilter;
    private Button actionButton;
    private Button cancelButton;
    private Label headerLabel;
}