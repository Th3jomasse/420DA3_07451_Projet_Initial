namespace _420DA3_07451_Projet_Initial.Presentation;

partial class UserManagementForm
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
    private void InitializeComponent()
    {
        this.roleslistBox = new ListBox();
        this.Roleslabel = new Label();
        this.dateCreationTextBox = new TextBox();
        this.passwordTextBox = new TextBox();
        this.passworedLabel = new Label();
        this.userIdNumeric = new ComboBox();
        this.warehouselabel = new Label();
        this.passwordHashtextBox = new TextBox();
        this.passwordHashlabel = new Label();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.dateCreatedlabel = new Label();
        this.nameTextBox = new TextBox();
        this.nameLabel = new Label();
        this.idLabel = new Label();
        this.warehouseComboBox = new ComboBox();
        this.SuspendLayout();
        // 
        // roleslistBox
        // 
        this.roleslistBox.FormattingEnabled = true;
        this.roleslistBox.ItemHeight = 15;
        this.roleslistBox.Location = new Point(162, 184);
        this.roleslistBox.Name = "roleslistBox";
        this.roleslistBox.Size = new Size(331, 94);
        this.roleslistBox.TabIndex = 55;
        // 
        // Roleslabel
        // 
        this.Roleslabel.Location = new Point(33, 184);
        this.Roleslabel.Name = "Roleslabel";
        this.Roleslabel.Size = new Size(123, 23);
        this.Roleslabel.TabIndex = 54;
        this.Roleslabel.Text = "Rôles:";
        this.Roleslabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreationTextBox
        // 
        this.dateCreationTextBox.Location = new Point(162, 161);
        this.dateCreationTextBox.Name = "dateCreationTextBox";
        this.dateCreationTextBox.Size = new Size(331, 23);
        this.dateCreationTextBox.TabIndex = 53;
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.Location = new Point(162, 71);
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.Size = new Size(331, 23);
        this.passwordTextBox.TabIndex = 52;
        // 
        // passworedLabel
        // 
        this.passworedLabel.Location = new Point(33, 70);
        this.passworedLabel.Name = "passworedLabel";
        this.passworedLabel.Size = new Size(123, 23);
        this.passworedLabel.TabIndex = 51;
        this.passworedLabel.Text = "Passeword:";
        this.passworedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userIdNumeric
        // 
        this.userIdNumeric.FormattingEnabled = true;
        this.userIdNumeric.Location = new Point(162, 13);
        this.userIdNumeric.Name = "userIdNumeric";
        this.userIdNumeric.Size = new Size(331, 23);
        this.userIdNumeric.TabIndex = 50;
        // 
        // warehouselabel
        // 
        this.warehouselabel.Location = new Point(33, 131);
        this.warehouselabel.Name = "warehouselabel";
        this.warehouselabel.Size = new Size(123, 23);
        this.warehouselabel.TabIndex = 48;
        this.warehouselabel.Text = "Warehouse:";
        this.warehouselabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordHashtextBox
        // 
        this.passwordHashtextBox.Location = new Point(162, 103);
        this.passwordHashtextBox.Name = "passwordHashtextBox";
        this.passwordHashtextBox.Size = new Size(331, 23);
        this.passwordHashtextBox.TabIndex = 47;
        // 
        // passwordHashlabel
        // 
        this.passwordHashlabel.Location = new Point(33, 102);
        this.passwordHashlabel.Name = "passwordHashlabel";
        this.passwordHashlabel.Size = new Size(123, 23);
        this.passwordHashlabel.TabIndex = 46;
        this.passwordHashlabel.Text = "PassewordHash:";
        this.passwordHashlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // actionButton
        // 
        this.actionButton.Location = new Point(261, 305);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(113, 23);
        this.actionButton.TabIndex = 45;
        this.actionButton.Text = "Action";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.actionButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Location = new Point(380, 305);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(113, 23);
        this.cancelButton.TabIndex = 44;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // dateCreatedlabel
        // 
        this.dateCreatedlabel.Location = new Point(33, 161);
        this.dateCreatedlabel.Name = "dateCreatedlabel";
        this.dateCreatedlabel.Size = new Size(123, 23);
        this.dateCreatedlabel.TabIndex = 43;
        this.dateCreatedlabel.Text = "Date Created:";
        this.dateCreatedlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nameTextBox
        // 
        this.nameTextBox.Location = new Point(162, 42);
        this.nameTextBox.Name = "nameTextBox";
        this.nameTextBox.Size = new Size(331, 23);
        this.nameTextBox.TabIndex = 42;
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new Point(33, 41);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new Size(123, 23);
        this.nameLabel.TabIndex = 41;
        this.nameLabel.Text = "Name:";
        this.nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(33, 12);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(123, 23);
        this.idLabel.TabIndex = 40;
        this.idLabel.Text = "UserID:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseComboBox
        // 
        this.warehouseComboBox.FormattingEnabled = true;
        this.warehouseComboBox.Location = new Point(162, 132);
        this.warehouseComboBox.Name = "warehouseComboBox";
        this.warehouseComboBox.Size = new Size(331, 23);
        this.warehouseComboBox.TabIndex = 56;
        // 
        // UserManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(638, 333);
        this.Controls.Add(this.warehouseComboBox);
        this.Controls.Add(this.roleslistBox);
        this.Controls.Add(this.Roleslabel);
        this.Controls.Add(this.dateCreationTextBox);
        this.Controls.Add(this.passwordTextBox);
        this.Controls.Add(this.passworedLabel);
        this.Controls.Add(this.userIdNumeric);
        this.Controls.Add(this.warehouselabel);
        this.Controls.Add(this.passwordHashtextBox);
        this.Controls.Add(this.passwordHashlabel);
        this.Controls.Add(this.actionButton);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.dateCreatedlabel);
        this.Controls.Add(this.nameTextBox);
        this.Controls.Add(this.nameLabel);
        this.Controls.Add(this.idLabel);
        this.Name = "UserManagementForm";
        this.Text = "UserManagementForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private ListBox roleslistBox;
    private Label Roleslabel;
    private TextBox dateCreationTextBox;
    private TextBox passwordTextBox;
    private Label passworedLabel;
    private ComboBox userIdNumeric;
    private Label warehouselabel;
    private TextBox passwordHashtextBox;
    private Label passwordHashlabel;
    private Button actionButton;
    private Button cancelButton;
    private Label dateCreatedlabel;
    private TextBox nameTextBox;
    private Label nameLabel;
    private Label idLabel;
    private ComboBox warehouseComboBox;
}