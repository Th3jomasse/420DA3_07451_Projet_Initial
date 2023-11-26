namespace _420DA3_07451_Projet_Initial.Presentation;

partial class UserManagementForm {
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
        actionButton = new Button();
        cancelButton = new Button();
        dateCreatedBox = new DateTimePicker();
        roleIdLabel = new Label();
        roleIdTextBox = new TextBox();
        nameTextBox = new TextBox();
        nameLabel = new Label();
        idTextBox = new TextBox();
        idLabel = new Label();
        dateCreatedLabel = new Label();
        passwordHashtextBox = new TextBox();
        passwordHashlabel = new Label();
        warehousetextBox = new TextBox();
        warehouselabel = new Label();
        warehouseIdlabel = new Label();
        warehouseIdtextBox = new TextBox();
        this.SuspendLayout();
        // 
        // actionButton
        // 
        actionButton.Location = new Point(269, 279);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(113, 23);
        actionButton.TabIndex = 27;
        actionButton.Text = "Action";
        actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(388, 279);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(113, 23);
        cancelButton.TabIndex = 26;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // dateCreatedBox
        // 
        dateCreatedBox.Enabled = false;
        dateCreatedBox.Location = new Point(170, 234);
        dateCreatedBox.Name = "dateCreatedBox";
        dateCreatedBox.Size = new Size(331, 23);
        dateCreatedBox.TabIndex = 20;
        // 
        // roleIdLabel
        // 
        roleIdLabel.Location = new Point(41, 138);
        roleIdLabel.Name = "roleIdLabel";
        roleIdLabel.Size = new Size(123, 27);
        roleIdLabel.TabIndex = 19;
        roleIdLabel.Text = "RoleID:";
        roleIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // roleIdTextBox
        // 
        roleIdTextBox.Location = new Point(170, 138);
        roleIdTextBox.Multiline = true;
        roleIdTextBox.Name = "roleIdTextBox";
        roleIdTextBox.Size = new Size(331, 27);
        roleIdTextBox.TabIndex = 18;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(170, 80);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(331, 23);
        nameTextBox.TabIndex = 17;
        // 
        // nameLabel
        // 
        nameLabel.Location = new Point(41, 79);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(123, 23);
        nameLabel.TabIndex = 16;
        nameLabel.Text = "Name:";
        nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idTextBox
        // 
        idTextBox.Location = new Point(170, 51);
        idTextBox.Name = "idTextBox";
        idTextBox.ReadOnly = true;
        idTextBox.Size = new Size(331, 23);
        idTextBox.TabIndex = 15;
        // 
        // idLabel
        // 
        idLabel.Location = new Point(41, 50);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(123, 23);
        idLabel.TabIndex = 14;
        idLabel.Text = "UserID:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        dateCreatedLabel.Location = new Point(41, 234);
        dateCreatedLabel.Name = "dateCreatedLabel";
        dateCreatedLabel.Size = new Size(123, 23);
        dateCreatedLabel.TabIndex = 21;
        dateCreatedLabel.Text = "Date Created:";
        dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordHashtextBox
        // 
        passwordHashtextBox.Location = new Point(170, 109);
        passwordHashtextBox.Name = "passwordHashtextBox";
        passwordHashtextBox.Size = new Size(331, 23);
        passwordHashtextBox.TabIndex = 29;
        // 
        // passwordHashlabel
        // 
        passwordHashlabel.Location = new Point(41, 108);
        passwordHashlabel.Name = "passwordHashlabel";
        passwordHashlabel.Size = new Size(123, 23);
        passwordHashlabel.TabIndex = 28;
        passwordHashlabel.Text = "PassewordHash:";
        passwordHashlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehousetextBox
        // 
        warehousetextBox.Location = new Point(170, 172);
        warehousetextBox.Name = "warehousetextBox";
        warehousetextBox.Size = new Size(331, 23);
        warehousetextBox.TabIndex = 33;
        // 
        // warehouselabel
        // 
        warehouselabel.Location = new Point(41, 171);
        warehouselabel.Name = "warehouselabel";
        warehouselabel.Size = new Size(123, 23);
        warehouselabel.TabIndex = 32;
        warehouselabel.Text = "Warehouse:";
        warehouselabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseIdlabel
        // 
        warehouseIdlabel.Location = new Point(41, 201);
        warehouseIdlabel.Name = "warehouseIdlabel";
        warehouseIdlabel.Size = new Size(123, 27);
        warehouseIdlabel.TabIndex = 31;
        warehouseIdlabel.Text = "WarehouseID:";
        warehouseIdlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseIdtextBox
        // 
        warehouseIdtextBox.Location = new Point(170, 201);
        warehouseIdtextBox.Multiline = true;
        warehouseIdtextBox.Name = "warehouseIdtextBox";
        warehouseIdtextBox.Size = new Size(331, 27);
        warehouseIdtextBox.TabIndex = 30;
        // 
        // UserManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(638, 333);
        this.Controls.Add(warehousetextBox);
        this.Controls.Add(warehouselabel);
        this.Controls.Add(warehouseIdlabel);
        this.Controls.Add(warehouseIdtextBox);
        this.Controls.Add(passwordHashtextBox);
        this.Controls.Add(passwordHashlabel);
        this.Controls.Add(actionButton);
        this.Controls.Add(cancelButton);
        this.Controls.Add(dateCreatedLabel);
        this.Controls.Add(dateCreatedBox);
        this.Controls.Add(roleIdLabel);
        this.Controls.Add(roleIdTextBox);
        this.Controls.Add(nameTextBox);
        this.Controls.Add(nameLabel);
        this.Controls.Add(idTextBox);
        this.Controls.Add(idLabel);
        this.Name = "UserManagementForm";
        this.Text = "UserManagementForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button actionButton;
    private Button cancelButton;
    private DateTimePicker dateCreatedBox;
    private Label roleIdLabel;
    private TextBox roleIdTextBox;
    private TextBox nameTextBox;
    private Label nameLabel;
    private TextBox idTextBox;
    private Label idLabel;
    private Label dateCreatedLabel;
    private TextBox passwordHashtextBox;
    private Label passwordHashlabel;
    private TextBox warehousetextBox;
    private Label warehouselabel;
    private Label warehouseIdlabel;
    private TextBox warehouseIdtextBox;
}