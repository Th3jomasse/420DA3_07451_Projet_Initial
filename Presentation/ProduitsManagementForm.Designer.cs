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
        this.textBoxProduitId = new TextBox();
        this.buttonNew = new Button();
        this.buttonSearch = new Button();
        this.buttonDelete = new Button();
        this.textBoxFournisseurId = new TextBox();
        this.textBoxProduitNom = new TextBox();
        this.textBoxProduitDesc = new TextBox();
        this.textBoxProduitUpc = new TextBox();
        this.textBoxProduitUnitStock = new TextBox();
        this.textBoxProduitPoids = new TextBox();
        this.textBoxProduitMinStock = new TextBox();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.label5 = new Label();
        this.label6 = new Label();
        this.label7 = new Label();
        this.label8 = new Label();
        this.label9 = new Label();
        this.label10 = new Label();
        this.comboBoxFournisseurs = new ComboBox();
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
        this.label1.Location = new Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new Size(1240, 52);
        this.label1.TabIndex = 0;
        this.label1.Text = "Produits Management";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // textBoxProduitId
        // 
        this.textBoxProduitId.Location = new Point(12, 117);
        this.textBoxProduitId.Name = "textBoxProduitId";
        this.textBoxProduitId.Size = new Size(224, 23);
        this.textBoxProduitId.TabIndex = 1;
        this.textBoxProduitId.TextChanged += this.textBoxProduitId_TextChanged;
        // 
        // buttonNew
        // 
        this.buttonNew.Location = new Point(1070, 177);
        this.buttonNew.Name = "buttonNew";
        this.buttonNew.Size = new Size(134, 50);
        this.buttonNew.TabIndex = 4;
        this.buttonNew.Text = "Creer";
        this.buttonNew.UseVisualStyleBackColor = true;
        this.buttonNew.Click += this.buttonNew_Click;
        // 
        // buttonSearch
        // 
        this.buttonSearch.Location = new Point(1070, 65);
        this.buttonSearch.Name = "buttonSearch";
        this.buttonSearch.Size = new Size(134, 49);
        this.buttonSearch.TabIndex = 5;
        this.buttonSearch.Text = "Search";
        this.buttonSearch.UseVisualStyleBackColor = true;
        this.buttonSearch.Click += this.buttonSearch_Click;
        // 
        // buttonDelete
        // 
        this.buttonDelete.Location = new Point(1070, 120);
        this.buttonDelete.Name = "buttonDelete";
        this.buttonDelete.Size = new Size(134, 49);
        this.buttonDelete.TabIndex = 6;
        this.buttonDelete.Text = "Effacer";
        this.buttonDelete.UseVisualStyleBackColor = true;
        this.buttonDelete.Click += this.buttonDelete_Click;
        // 
        // textBoxFournisseurId
        // 
        this.textBoxFournisseurId.Location = new Point(12, 230);
        this.textBoxFournisseurId.Name = "textBoxFournisseurId";
        this.textBoxFournisseurId.Size = new Size(224, 23);
        this.textBoxFournisseurId.TabIndex = 8;
        this.textBoxFournisseurId.TextChanged += this.textBoxFournisseurId_TextChanged;
        // 
        // textBoxProduitNom
        // 
        this.textBoxProduitNom.Location = new Point(276, 172);
        this.textBoxProduitNom.Name = "textBoxProduitNom";
        this.textBoxProduitNom.Size = new Size(300, 23);
        this.textBoxProduitNom.TabIndex = 9;
        this.textBoxProduitNom.TextChanged += this.textBoxProduitNom_TextChanged;
        // 
        // textBoxProduitDesc
        // 
        this.textBoxProduitDesc.Location = new Point(276, 230);
        this.textBoxProduitDesc.Name = "textBoxProduitDesc";
        this.textBoxProduitDesc.Size = new Size(300, 23);
        this.textBoxProduitDesc.TabIndex = 10;
        this.textBoxProduitDesc.TextChanged += this.textBoxProduitDesc_TextChanged;
        // 
        // textBoxProduitUpc
        // 
        this.textBoxProduitUpc.Location = new Point(276, 117);
        this.textBoxProduitUpc.Name = "textBoxProduitUpc";
        this.textBoxProduitUpc.Size = new Size(300, 23);
        this.textBoxProduitUpc.TabIndex = 11;
        this.textBoxProduitUpc.TextChanged += this.textBoxProduitUpc_TextChanged;
        // 
        // textBoxProduitUnitStock
        // 
        this.textBoxProduitUnitStock.Location = new Point(643, 117);
        this.textBoxProduitUnitStock.Name = "textBoxProduitUnitStock";
        this.textBoxProduitUnitStock.Size = new Size(224, 23);
        this.textBoxProduitUnitStock.TabIndex = 12;
        this.textBoxProduitUnitStock.TextChanged += this.textBoxProduitUnitStock_TextChanged;
        // 
        // textBoxProduitPoids
        // 
        this.textBoxProduitPoids.Location = new Point(643, 172);
        this.textBoxProduitPoids.Name = "textBoxProduitPoids";
        this.textBoxProduitPoids.Size = new Size(224, 23);
        this.textBoxProduitPoids.TabIndex = 13;
        this.textBoxProduitPoids.TextChanged += this.textBoxProduitPoids_TextChanged;
        // 
        // textBoxProduitMinStock
        // 
        this.textBoxProduitMinStock.Location = new Point(643, 230);
        this.textBoxProduitMinStock.Name = "textBoxProduitMinStock";
        this.textBoxProduitMinStock.Size = new Size(224, 23);
        this.textBoxProduitMinStock.TabIndex = 14;
        this.textBoxProduitMinStock.TextChanged += this.textBoxProduitMinStock_TextChanged;
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
        this.label3.Location = new Point(276, 99);
        this.label3.Name = "label3";
        this.label3.Size = new Size(72, 15);
        this.label3.TabIndex = 16;
        this.label3.Text = "Produit UPC";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(276, 154);
        this.label4.Name = "label4";
        this.label4.Size = new Size(76, 15);
        this.label4.TabIndex = 17;
        this.label4.Text = "Produit Nom";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(276, 212);
        this.label5.Name = "label5";
        this.label5.Size = new Size(109, 15);
        this.label5.TabIndex = 18;
        this.label5.Text = "Produit Description";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(643, 154);
        this.label6.Name = "label6";
        this.label6.Size = new Size(103, 15);
        this.label6.TabIndex = 19;
        this.label6.Text = "Produit Poids (KG)";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(643, 99);
        this.label7.Name = "label7";
        this.label7.Size = new Size(125, 15);
        this.label7.TabIndex = 20;
        this.label7.Text = "Produit UniteeEnStock";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new Point(643, 212);
        this.label8.Name = "label8";
        this.label8.Size = new Size(144, 15);
        this.label8.TabIndex = 21;
        this.label8.Text = "Produit MinimumEnStock";
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new Point(12, 154);
        this.label9.Name = "label9";
        this.label9.Size = new Size(98, 15);
        this.label9.TabIndex = 22;
        this.label9.Text = "Fournisseur Nom";
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Location = new Point(12, 212);
        this.label10.Name = "label10";
        this.label10.Size = new Size(82, 15);
        this.label10.TabIndex = 23;
        this.label10.Text = "Fournisseur ID";
        // 
        // comboBoxFournisseurs
        // 
        this.comboBoxFournisseurs.FormattingEnabled = true;
        this.comboBoxFournisseurs.Location = new Point(14, 179);
        this.comboBoxFournisseurs.Name = "comboBoxFournisseurs";
        this.comboBoxFournisseurs.Size = new Size(222, 23);
        this.comboBoxFournisseurs.TabIndex = 24;
        this.comboBoxFournisseurs.SelectedIndexChanged += this.comboBoxFournisseurs_SelectedIndexChanged;
        // 
        // buttonEdit
        // 
        this.buttonEdit.Location = new Point(930, 65);
        this.buttonEdit.Name = "buttonEdit";
        this.buttonEdit.Size = new Size(134, 49);
        this.buttonEdit.TabIndex = 25;
        this.buttonEdit.Text = "Edit";
        this.buttonEdit.UseVisualStyleBackColor = true;
        this.buttonEdit.Click += this.buttonEdit_Click;
        // 
        // buttonView
        // 
        this.buttonView.Location = new Point(930, 120);
        this.buttonView.Name = "buttonView";
        this.buttonView.Size = new Size(134, 49);
        this.buttonView.TabIndex = 26;
        this.buttonView.Text = "View All";
        this.buttonView.UseVisualStyleBackColor = true;
        this.buttonView.Click += this.buttonView_Click;
        // 
        // buttonExit
        // 
        this.buttonExit.Location = new Point(930, 179);
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
        this.listBoxFournisseurs.Size = new Size(416, 454);
        this.listBoxFournisseurs.TabIndex = 28;
        // 
        // listBoxProduits
        // 
        this.listBoxProduits.FormattingEnabled = true;
        this.listBoxProduits.ItemHeight = 15;
        this.listBoxProduits.Location = new Point(451, 282);
        this.listBoxProduits.Name = "listBoxProduits";
        this.listBoxProduits.Size = new Size(801, 454);
        this.listBoxProduits.TabIndex = 29;
        // 
        // ProduitsManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.PeachPuff;
        this.ClientSize = new Size(1264, 754);
        this.Controls.Add(this.listBoxProduits);
        this.Controls.Add(this.listBoxFournisseurs);
        this.Controls.Add(this.buttonExit);
        this.Controls.Add(this.buttonView);
        this.Controls.Add(this.buttonEdit);
        this.Controls.Add(this.comboBoxFournisseurs);
        this.Controls.Add(this.label10);
        this.Controls.Add(this.label9);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.textBoxProduitMinStock);
        this.Controls.Add(this.textBoxProduitPoids);
        this.Controls.Add(this.textBoxProduitUnitStock);
        this.Controls.Add(this.textBoxProduitUpc);
        this.Controls.Add(this.textBoxProduitDesc);
        this.Controls.Add(this.textBoxProduitNom);
        this.Controls.Add(this.textBoxFournisseurId);
        this.Controls.Add(this.buttonDelete);
        this.Controls.Add(this.buttonSearch);
        this.Controls.Add(this.buttonNew);
        this.Controls.Add(this.textBoxProduitId);
        this.Controls.Add(this.label1);
        this.Name = "ProduitsManagementForm";
        this.Text = "ProduitsManagementForm";
        this.Load += this.ProduitsManagementForm_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBoxProduitId;
    private Button buttonNew;
    private Button buttonSearch;
    private Button buttonDelete;
    private TextBox textBoxFournisseurId;
    private TextBox textBoxProduitNom;
    private TextBox textBoxProduitDesc;
    private TextBox textBoxProduitUpc;
    private TextBox textBoxProduitUnitStock;
    private TextBox textBoxProduitPoids;
    private TextBox textBoxProduitMinStock;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private ComboBox comboBoxFournisseurs;
    private Button buttonEdit;
    private Button buttonView;
    private Button buttonExit;
    private ListBox listBoxFournisseurs;
    private ListBox listBoxProduits;
}