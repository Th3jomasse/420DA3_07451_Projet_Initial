namespace _420DA3_07451_Projet_Initial.Presentation;

partial class RoleManagementForm {
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
        PrenomtextBox = new TextBox();
        Prenomlabel = new Label();
        actionButton = new Button();
        cancelButton = new Button();
        dateCreatedLabel = new Label();
        dateCreatedBox = new DateTimePicker();
        descriptionLabel = new Label();
        descriptionTextBox = new TextBox();
        nameTextBox = new TextBox();
        nameLabel = new Label();
        idTextBox = new TextBox();
        idLabel = new Label();
        RoleIdlabel = new Label();
        RoleIdtextBox = new TextBox();
        this.SuspendLayout();
        // 
        // PrenomtextBox
        // 
        PrenomtextBox.Location = new Point(154, 90);
        PrenomtextBox.Name = "PrenomtextBox";
        PrenomtextBox.Size = new Size(331, 23);
        PrenomtextBox.TabIndex = 45;
        // 
        // Prenomlabel
        // 
        Prenomlabel.Location = new Point(25, 89);
        Prenomlabel.Name = "Prenomlabel";
        Prenomlabel.Size = new Size(123, 23);
        Prenomlabel.TabIndex = 44;
        Prenomlabel.Text = "Prenom:";
        Prenomlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // actionButton
        // 
        actionButton.Location = new Point(543, 396);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(113, 23);
        actionButton.TabIndex = 43;
        actionButton.Text = "Action";
        actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(662, 396);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(113, 23);
        cancelButton.TabIndex = 42;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // dateCreatedLabel
        // 
        dateCreatedLabel.Location = new Point(25, 266);
        dateCreatedLabel.Name = "dateCreatedLabel";
        dateCreatedLabel.Size = new Size(123, 23);
        dateCreatedLabel.TabIndex = 37;
        dateCreatedLabel.Text = "Date Created:";
        dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedBox
        // 
        dateCreatedBox.Enabled = false;
        dateCreatedBox.Location = new Point(154, 266);
        dateCreatedBox.Name = "dateCreatedBox";
        dateCreatedBox.Size = new Size(331, 23);
        dateCreatedBox.TabIndex = 36;
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(25, 170);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(123, 23);
        descriptionLabel.TabIndex = 35;
        descriptionLabel.Text = "Description:";
        descriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(154, 170);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(331, 90);
        descriptionTextBox.TabIndex = 34;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(154, 61);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(331, 23);
        nameTextBox.TabIndex = 33;
        // 
        // nameLabel
        // 
        nameLabel.Location = new Point(25, 60);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(123, 23);
        nameLabel.TabIndex = 32;
        nameLabel.Text = "Name:";
        nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idTextBox
        // 
        idTextBox.Location = new Point(154, 32);
        idTextBox.Name = "idTextBox";
        idTextBox.ReadOnly = true;
        idTextBox.Size = new Size(331, 23);
        idTextBox.TabIndex = 31;
        // 
        // idLabel
        // 
        idLabel.Location = new Point(25, 31);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(123, 23);
        idLabel.TabIndex = 30;
        idLabel.Text = "ID:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RoleIdlabel
        // 
        RoleIdlabel.Location = new Point(25, 118);
        RoleIdlabel.Name = "RoleIdlabel";
        RoleIdlabel.Size = new Size(123, 23);
        RoleIdlabel.TabIndex = 46;
        RoleIdlabel.Text = "RoleId:";
        RoleIdlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RoleIdtextBox
        // 
        RoleIdtextBox.Location = new Point(154, 118);
        RoleIdtextBox.Name = "RoleIdtextBox";
        RoleIdtextBox.ReadOnly = true;
        RoleIdtextBox.Size = new Size(331, 23);
        RoleIdtextBox.TabIndex = 48;
        // 
        // RoleManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(RoleIdtextBox);
        this.Controls.Add(RoleIdlabel);
        this.Controls.Add(PrenomtextBox);
        this.Controls.Add(Prenomlabel);
        this.Controls.Add(actionButton);
        this.Controls.Add(cancelButton);
        this.Controls.Add(dateCreatedLabel);
        this.Controls.Add(dateCreatedBox);
        this.Controls.Add(descriptionLabel);
        this.Controls.Add(descriptionTextBox);
        this.Controls.Add(nameTextBox);
        this.Controls.Add(nameLabel);
        this.Controls.Add(idTextBox);
        this.Controls.Add(idLabel);
        this.Name = "RoleManagementForm";
        this.Text = "RoleManagementForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TextBox PrenomtextBox;
    private Label Prenomlabel;
    private Button actionButton;
    private Button cancelButton;
    private Label dateCreatedLabel;
    private DateTimePicker dateCreatedBox;
    private Label descriptionLabel;
    private TextBox descriptionTextBox;
    private TextBox nameTextBox;
    private Label nameLabel;
    private TextBox idTextBox;
    private Label idLabel;
    private Label RoleIdlabel;
    private TextBox RoleIdtextBox;
}