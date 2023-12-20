namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ProduitsManagementForm {
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
        this.label1 = new Label();
        this.textBoxProdId = new TextBox();
        this.buttonNew = new Button();
        this.buttonSearch = new Button();
        this.buttonDelete = new Button();
        this.textBoxProdFourName = new TextBox();
        this.textBoxProdCodeFour = new TextBox();
        this.textBoxProdKg = new TextBox();
        this.textBoxProdUnitStock = new TextBox();
        this.textBoxProdDesc = new TextBox();
        this.textBoxProdMinUnit = new TextBox();
        this.textBoxProdUpc = new TextBox();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.label5 = new Label();
        this.label6 = new Label();
        this.label7 = new Label();
        this.label8 = new Label();
        this.label9 = new Label();
        this.label10 = new Label();
        this.comboBoxProdFourId = new ComboBox();
        this.buttonEdit = new Button();
        this.buttonView = new Button();
        this.buttonExit = new Button();
        this.listBoxFournisseurs = new ListBox();
        this.listBoxProduits = new ListBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
        this.label1.Location = new Point(14, 9);
        this.label1.Name = "label1";
        this.label1.Size = new Size(1240, 52);
        this.label1.TabIndex = 0;
        this.label1.Text = "Produits Management";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // textBoxProdId
        // 
        this.textBoxProdId.Location = new Point(12, 117);
        this.textBoxProdId.Name = "textBoxProdId";
        this.textBoxProdId.Size = new Size(224, 23);
        this.textBoxProdId.TabIndex = 1;
        // 
        // buttonNew
        // 
        this.buttonNew.Location = new Point(953, 120);
        this.buttonNew.Name = "buttonNew";
        this.buttonNew.Size = new Size(134, 50);
        this.buttonNew.TabIndex = 4;
        this.buttonNew.Text = "Creer";
        this.buttonNew.UseVisualStyleBackColor = true;
        this.buttonNew.Click += this.buttonNew_Click;
        // 
        // buttonSearch
        // 
        this.buttonSearch.Location = new Point(1093, 65);
        this.buttonSearch.Name = "buttonSearch";
        this.buttonSearch.Size = new Size(134, 49);
        this.buttonSearch.TabIndex = 5;
        this.buttonSearch.Text = "Search";
        this.buttonSearch.UseVisualStyleBackColor = true;
        this.buttonSearch.Click += this.buttonSearch_Click;
        // 
        // buttonDelete
        // 
        this.buttonDelete.Location = new Point(1093, 120);
        this.buttonDelete.Name = "buttonDelete";
        this.buttonDelete.Size = new Size(134, 49);
        this.buttonDelete.TabIndex = 6;
        this.buttonDelete.Text = "Effacer";
        this.buttonDelete.UseVisualStyleBackColor = true;
        this.buttonDelete.Click += this.buttonDelete_Click;
        // 
        // textBoxProdFourName
        // 
        this.textBoxProdFourName.Location = new Point(12, 230);
        this.textBoxProdFourName.Name = "textBoxProdFourName";
        this.textBoxProdFourName.Size = new Size(224, 23);
        this.textBoxProdFourName.TabIndex = 8;
        // 
        // textBoxProdCodeFour
        // 
        this.textBoxProdCodeFour.Location = new Point(276, 172);
        this.textBoxProdCodeFour.Name = "textBoxProdCodeFour";
        this.textBoxProdCodeFour.Size = new Size(300, 23);
        this.textBoxProdCodeFour.TabIndex = 9;
        // 
        // textBoxProdKg
        // 
        this.textBoxProdKg.Location = new Point(276, 230);
        this.textBoxProdKg.Name = "textBoxProdKg";
        this.textBoxProdKg.Size = new Size(300, 23);
        this.textBoxProdKg.TabIndex = 10;
        // 
        // textBoxProdUnitStock
        // 
        this.textBoxProdUnitStock.Location = new Point(643, 230);
        this.textBoxProdUnitStock.Name = "textBoxProdUnitStock";
        this.textBoxProdUnitStock.Size = new Size(238, 23);
        this.textBoxProdUnitStock.TabIndex = 11;
        // 
        // textBoxProdDesc
        // 
        this.textBoxProdDesc.Location = new Point(276, 117);
        this.textBoxProdDesc.Name = "textBoxProdDesc";
        this.textBoxProdDesc.Size = new Size(605, 23);
        this.textBoxProdDesc.TabIndex = 12;
        // 
        // textBoxProdMinUnit
        // 
        this.textBoxProdMinUnit.Location = new Point(930, 230);
        this.textBoxProdMinUnit.Name = "textBoxProdMinUnit";
        this.textBoxProdMinUnit.Size = new Size(224, 23);
        this.textBoxProdMinUnit.TabIndex = 13;
        // 
        // textBoxProdUpc
        // 
        this.textBoxProdUpc.Location = new Point(643, 172);
        this.textBoxProdUpc.Name = "textBoxProdUpc";
        this.textBoxProdUpc.Size = new Size(238, 23);
        this.textBoxProdUpc.TabIndex = 14;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(12, 99);
        this.label2.Name = "label2";
        this.label2.Size = new Size(60, 15);
        this.label2.TabIndex = 15;
        this.label2.Text = "Produit ID";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(14, 154);
        this.label3.Name = "label3";
        this.label3.Size = new Size(82, 15);
        this.label3.TabIndex = 16;
        this.label3.Text = "Fournisseur ID";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(276, 154);
        this.label4.Name = "label4";
        this.label4.Size = new Size(99, 15);
        this.label4.TabIndex = 17;
        this.label4.Text = "Code Fournisseur";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(276, 212);
        this.label5.Name = "label5";
        this.label5.Size = new Size(61, 15);
        this.label5.TabIndex = 18;
        this.label5.Text = "Poids (Kg)";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(930, 212);
        this.label6.Name = "label6";
        this.label6.Size = new Size(88, 15);
        this.label6.TabIndex = 19;
        this.label6.Text = "Unitee minimal";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(276, 99);
        this.label7.Name = "label7";
        this.label7.Size = new Size(67, 15);
        this.label7.TabIndex = 20;
        this.label7.Text = "Description";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new Point(643, 212);
        this.label8.Name = "label8";
        this.label8.Size = new Size(93, 15);
        this.label8.TabIndex = 21;
        this.label8.Text = "Unitees en stock";
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new Point(643, 154);
        this.label9.Name = "label9";
        this.label9.Size = new Size(72, 15);
        this.label9.TabIndex = 22;
        this.label9.Text = "Produit UPC";
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Location = new Point(12, 212);
        this.label10.Name = "label10";
        this.label10.Size = new Size(98, 15);
        this.label10.TabIndex = 23;
        this.label10.Text = "Fournisseur Nom";
        // 
        // comboBoxProdFourId
        // 
        this.comboBoxProdFourId.FormattingEnabled = true;
        this.comboBoxProdFourId.Location = new Point(12, 172);
        this.comboBoxProdFourId.Name = "comboBoxProdFourId";
        this.comboBoxProdFourId.Size = new Size(224, 23);
        this.comboBoxProdFourId.TabIndex = 24;
        // 
        // buttonEdit
        // 
        this.buttonEdit.Location = new Point(953, 65);
        this.buttonEdit.Name = "buttonEdit";
        this.buttonEdit.Size = new Size(134, 49);
        this.buttonEdit.TabIndex = 25;
        this.buttonEdit.Text = "Edit";
        this.buttonEdit.UseVisualStyleBackColor = true;
        this.buttonEdit.Click += this.buttonEdit_Click;
        // 
        // buttonView
        // 
        this.buttonView.Location = new Point(953, 687);
        this.buttonView.Name = "buttonView";
        this.buttonView.Size = new Size(134, 49);
        this.buttonView.TabIndex = 26;
        this.buttonView.Text = "View All";
        this.buttonView.UseVisualStyleBackColor = true;
        this.buttonView.Click += this.buttonView_Click;
        // 
        // buttonExit
        // 
        this.buttonExit.Location = new Point(1093, 687);
        this.buttonExit.Name = "buttonExit";
        this.buttonExit.Size = new Size(134, 49);
        this.buttonExit.TabIndex = 27;
        this.buttonExit.Text = "Exit";
        this.buttonExit.UseVisualStyleBackColor = true;
        this.buttonExit.Click += this.buttonExit_Click;
        // 
        // listBoxFournisseurs
        // 
        this.listBoxFournisseurs.FormattingEnabled = true;
        this.listBoxFournisseurs.ItemHeight = 15;
        this.listBoxFournisseurs.Location = new Point(12, 282);
        this.listBoxFournisseurs.Name = "listBoxFournisseurs";
        this.listBoxFournisseurs.Size = new Size(912, 454);
        this.listBoxFournisseurs.TabIndex = 28;
        // 
        // listBoxProduits
        // 
        this.listBoxProduits.FormattingEnabled = true;
        this.listBoxProduits.ItemHeight = 15;
        this.listBoxProduits.Location = new Point(953, 282);
        this.listBoxProduits.Name = "listBoxProduits";
        this.listBoxProduits.Size = new Size(274, 334);
        this.listBoxProduits.TabIndex = 29;
        // 
        // ProduitsManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.PaleTurquoise;
        this.ClientSize = new Size(1264, 754);
        this.Controls.Add(this.listBoxProduits);
        this.Controls.Add(this.listBoxFournisseurs);
        this.Controls.Add(this.buttonExit);
        this.Controls.Add(this.buttonView);
        this.Controls.Add(this.buttonEdit);
        this.Controls.Add(this.comboBoxProdFourId);
        this.Controls.Add(this.label10);
        this.Controls.Add(this.label9);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.textBoxProdUpc);
        this.Controls.Add(this.textBoxProdMinUnit);
        this.Controls.Add(this.textBoxProdDesc);
        this.Controls.Add(this.textBoxProdUnitStock);
        this.Controls.Add(this.textBoxProdKg);
        this.Controls.Add(this.textBoxProdCodeFour);
        this.Controls.Add(this.textBoxProdFourName);
        this.Controls.Add(this.buttonDelete);
        this.Controls.Add(this.buttonSearch);
        this.Controls.Add(this.buttonNew);
        this.Controls.Add(this.textBoxProdId);
        this.Controls.Add(this.label1);
        this.Name = "ProduitsManagementForm";
        this.Text = "ProduitsManagementForm";
        this.Load += this.ProduitsManagementForm_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBoxProdId;
    private Button buttonNew;
    private Button buttonSearch;
    private Button buttonDelete;
    private TextBox textBoxProdFourName;
    private TextBox textBoxProdCodeFour;
    private TextBox textBoxProdKg;
    private TextBox textBoxProdUnitStock;
    private TextBox textBoxProdDesc;
    private TextBox textBoxProdMinUnit;
    private TextBox textBoxProdUpc;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private ComboBox comboBoxProdFourId;
    private Button buttonEdit;
    private Button buttonView;
    private Button buttonExit;
    private ListBox listBoxFournisseurs;
    private ListBox listBoxProduits;
}