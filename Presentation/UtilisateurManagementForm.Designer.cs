namespace _420DA3_07451_Projet_Initial.Presentation;

partial class UtilisateurManagementForm {
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
        panel1 = new Panel();
        boutonAction = new Button();
        buttonAnnuler = new Button();
        panel2 = new Panel();
        openModeValueLabel = new Label();
        openModeLabel = new Label();
        panel3 = new Panel();
        userDateCreatedTextBox = new TextBox();
        userPasswordTextBox = new TextBox();
        userPasswordLabel = new Label();
        userPasswordAdminResetButton = new Button();
        userRolesListbox = new ListBox();
        userRolesLabel = new Label();
        userWarehouseCombobox = new ComboBox();
        userWarehouseLabel = new Label();
        userDateCreatedLabel = new Label();
        userPasswordHashTextBox = new TextBox();
        userPasswordHashLabel = new Label();
        userUsernameTextBox = new TextBox();
        userUsernameLabel = new Label();
        userIdNumericUD = new NumericUpDown();
        userIdLabel = new Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) userIdNumericUD).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(boutonAction);
        panel1.Controls.Add(buttonAnnuler);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 463);
        panel1.Name = "panel1";
        panel1.Size = new Size(582, 60);
        panel1.TabIndex = 4;
        // 
        // boutonAction
        // 
        boutonAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        boutonAction.FlatStyle = FlatStyle.Flat;
        boutonAction.Location = new Point(300, 13);
        boutonAction.Name = "boutonAction";
        boutonAction.Size = new Size(132, 35);
        boutonAction.TabIndex = 1;
        boutonAction.Text = "ACTION";
        boutonAction.UseVisualStyleBackColor = true;
        boutonAction.Click += this.BoutonAction_Click;
        // 
        // buttonAnnuler
        // 
        buttonAnnuler.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        buttonAnnuler.FlatStyle = FlatStyle.Flat;
        buttonAnnuler.Location = new Point(438, 13);
        buttonAnnuler.Name = "buttonAnnuler";
        buttonAnnuler.Size = new Size(132, 35);
        buttonAnnuler.TabIndex = 0;
        buttonAnnuler.Text = "Annuler";
        buttonAnnuler.UseVisualStyleBackColor = true;
        buttonAnnuler.Click += this.ButtonAnnuler_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(openModeValueLabel);
        panel2.Controls.Add(openModeLabel);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(582, 50);
        panel2.TabIndex = 5;
        // 
        // openModeValueLabel
        // 
        openModeValueLabel.AutoSize = true;
        openModeValueLabel.Location = new Point(73, 19);
        openModeValueLabel.Name = "openModeValueLabel";
        openModeValueLabel.Size = new Size(108, 20);
        openModeValueLabel.TabIndex = 6;
        openModeValueLabel.Text = "PLACEHOLDER";
        // 
        // openModeLabel
        // 
        openModeLabel.AutoSize = true;
        openModeLabel.Location = new Point(12, 19);
        openModeLabel.Name = "openModeLabel";
        openModeLabel.Size = new Size(55, 20);
        openModeLabel.TabIndex = 6;
        openModeLabel.Text = "Mode :";
        // 
        // panel3
        // 
        panel3.Controls.Add(userDateCreatedTextBox);
        panel3.Controls.Add(userPasswordTextBox);
        panel3.Controls.Add(userPasswordLabel);
        panel3.Controls.Add(userPasswordAdminResetButton);
        panel3.Controls.Add(userRolesListbox);
        panel3.Controls.Add(userRolesLabel);
        panel3.Controls.Add(userWarehouseCombobox);
        panel3.Controls.Add(userWarehouseLabel);
        panel3.Controls.Add(userDateCreatedLabel);
        panel3.Controls.Add(userPasswordHashTextBox);
        panel3.Controls.Add(userPasswordHashLabel);
        panel3.Controls.Add(userUsernameTextBox);
        panel3.Controls.Add(userUsernameLabel);
        panel3.Controls.Add(userIdNumericUD);
        panel3.Controls.Add(userIdLabel);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 50);
        panel3.Name = "panel3";
        panel3.Padding = new Padding(10);
        panel3.Size = new Size(582, 413);
        panel3.TabIndex = 6;
        // 
        // userDateCreatedTextBox
        // 
        userDateCreatedTextBox.Enabled = false;
        userDateCreatedTextBox.Location = new Point(219, 169);
        userDateCreatedTextBox.Name = "userDateCreatedTextBox";
        userDateCreatedTextBox.Size = new Size(275, 27);
        userDateCreatedTextBox.TabIndex = 15;
        // 
        // userPasswordTextBox
        // 
        userPasswordTextBox.Location = new Point(219, 108);
        userPasswordTextBox.Name = "userPasswordTextBox";
        userPasswordTextBox.PlaceholderText = "New password here";
        userPasswordTextBox.Size = new Size(275, 27);
        userPasswordTextBox.TabIndex = 14;
        userPasswordTextBox.UseSystemPasswordChar = true;
        userPasswordTextBox.TextChanged += this.UserPasswordTextBox_Leave;
        userPasswordTextBox.Leave += this.UserPasswordTextBox_Leave;
        // 
        // userPasswordLabel
        // 
        userPasswordLabel.Location = new Point(13, 107);
        userPasswordLabel.Name = "userPasswordLabel";
        userPasswordLabel.Size = new Size(200, 28);
        userPasswordLabel.TabIndex = 13;
        userPasswordLabel.Text = "Password :";
        userPasswordLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userPasswordAdminResetButton
        // 
        userPasswordAdminResetButton.Enabled = false;
        userPasswordAdminResetButton.Location = new Point(500, 107);
        userPasswordAdminResetButton.Name = "userPasswordAdminResetButton";
        userPasswordAdminResetButton.Size = new Size(71, 28);
        userPasswordAdminResetButton.TabIndex = 12;
        userPasswordAdminResetButton.Text = "Reset";
        userPasswordAdminResetButton.UseVisualStyleBackColor = true;
        userPasswordAdminResetButton.Click += this.UserPasswordResetButton_Click;
        // 
        // userRolesListbox
        // 
        userRolesListbox.FormattingEnabled = true;
        userRolesListbox.ItemHeight = 20;
        userRolesListbox.Location = new Point(219, 236);
        userRolesListbox.Name = "userRolesListbox";
        userRolesListbox.Size = new Size(274, 144);
        userRolesListbox.TabIndex = 11;
        // 
        // userRolesLabel
        // 
        userRolesLabel.Location = new Point(12, 236);
        userRolesLabel.Name = "userRolesLabel";
        userRolesLabel.Size = new Size(200, 28);
        userRolesLabel.TabIndex = 10;
        userRolesLabel.Text = "Rôles :";
        userRolesLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userWarehouseCombobox
        // 
        userWarehouseCombobox.FormattingEnabled = true;
        userWarehouseCombobox.Location = new Point(219, 202);
        userWarehouseCombobox.Name = "userWarehouseCombobox";
        userWarehouseCombobox.Size = new Size(274, 28);
        userWarehouseCombobox.TabIndex = 9;
        // 
        // userWarehouseLabel
        // 
        userWarehouseLabel.Location = new Point(13, 201);
        userWarehouseLabel.Name = "userWarehouseLabel";
        userWarehouseLabel.Size = new Size(200, 28);
        userWarehouseLabel.TabIndex = 8;
        userWarehouseLabel.Text = "Entrpôt de travail :";
        userWarehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userDateCreatedLabel
        // 
        userDateCreatedLabel.Location = new Point(13, 168);
        userDateCreatedLabel.Name = "userDateCreatedLabel";
        userDateCreatedLabel.Size = new Size(200, 28);
        userDateCreatedLabel.TabIndex = 6;
        userDateCreatedLabel.Text = "Date de Création :";
        userDateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userPasswordHashTextBox
        // 
        userPasswordHashTextBox.Location = new Point(219, 136);
        userPasswordHashTextBox.Name = "userPasswordHashTextBox";
        userPasswordHashTextBox.ReadOnly = true;
        userPasswordHashTextBox.Size = new Size(275, 27);
        userPasswordHashTextBox.TabIndex = 5;
        // 
        // userPasswordHashLabel
        // 
        userPasswordHashLabel.Location = new Point(13, 135);
        userPasswordHashLabel.Name = "userPasswordHashLabel";
        userPasswordHashLabel.Size = new Size(200, 28);
        userPasswordHashLabel.TabIndex = 4;
        userPasswordHashLabel.Text = "Password Hash :";
        userPasswordHashLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userUsernameTextBox
        // 
        userUsernameTextBox.Location = new Point(218, 75);
        userUsernameTextBox.Name = "userUsernameTextBox";
        userUsernameTextBox.Size = new Size(275, 27);
        userUsernameTextBox.TabIndex = 3;
        userUsernameTextBox.TextChanged += this.UserUsernameTextBox_TextChanged;
        userUsernameTextBox.Leave += this.UserUsernameTextBox_Leave;
        // 
        // userUsernameLabel
        // 
        userUsernameLabel.Location = new Point(12, 74);
        userUsernameLabel.Name = "userUsernameLabel";
        userUsernameLabel.Size = new Size(200, 28);
        userUsernameLabel.TabIndex = 2;
        userUsernameLabel.Text = "Username :";
        userUsernameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userIdNumericUD
        // 
        userIdNumericUD.Enabled = false;
        userIdNumericUD.Location = new Point(218, 42);
        userIdNumericUD.Name = "userIdNumericUD";
        userIdNumericUD.ReadOnly = true;
        userIdNumericUD.Size = new Size(275, 27);
        userIdNumericUD.TabIndex = 1;
        // 
        // userIdLabel
        // 
        userIdLabel.Location = new Point(12, 40);
        userIdLabel.Name = "userIdLabel";
        userIdLabel.Size = new Size(200, 28);
        userIdLabel.TabIndex = 0;
        userIdLabel.Text = "Id :";
        userIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UtilisateurManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(582, 523);
        this.Controls.Add(panel3);
        this.Controls.Add(panel2);
        this.Controls.Add(panel1);
        this.Margin = new Padding(3, 4, 3, 4);
        this.Name = "UtilisateurManagementForm";
        this.Text = "Utilisateur Management Form";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) userIdNumericUD).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
    private Panel panel1;
    private Button buttonAnnuler;
    private Button boutonAction;
    private Panel panel2;
    private Label openModeValueLabel;
    private Label openModeLabel;
    private Panel panel3;
    private Label userIdLabel;
    private Label userUsernameLabel;
    private NumericUpDown userIdNumericUD;
    private TextBox userUsernameTextBox;
    private Label userPasswordHashLabel;
    private TextBox userPasswordHashTextBox;
    private Label userDateCreatedLabel;
    private ListBox userRolesListbox;
    private Label userRolesLabel;
    private ComboBox userWarehouseCombobox;
    private Label userWarehouseLabel;
    private Button userPasswordAdminResetButton;
    private TextBox userPasswordTextBox;
    private Label userPasswordLabel;
    private TextBox userDateCreatedTextBox;
}