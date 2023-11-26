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
        actionButton = new Button();
        cancelButton = new Button();
        roleDescriptionLabel = new Label();
        descriptionTextBox = new TextBox();
        roleNameTextBox = new TextBox();
        RolenameLabel = new Label();
        idTextBox = new TextBox();
        idLabel = new Label();
        userIdlabel = new Label();
        RoleIdtextBox = new TextBox();
        this.SuspendLayout();
        // 
        // actionButton
        // 
        actionButton.Location = new Point(253, 239);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(113, 23);
        actionButton.TabIndex = 43;
        actionButton.Text = "Action";
        actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(372, 239);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(113, 23);
        cancelButton.TabIndex = 42;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // roleDescriptionLabel
        // 
        roleDescriptionLabel.Location = new Point(25, 117);
        roleDescriptionLabel.Name = "roleDescriptionLabel";
        roleDescriptionLabel.Size = new Size(123, 23);
        roleDescriptionLabel.TabIndex = 35;
        roleDescriptionLabel.Text = "RoleDescription:";
        roleDescriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(154, 117);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(331, 90);
        descriptionTextBox.TabIndex = 34;
        // 
        // roleNameTextBox
        // 
        roleNameTextBox.Location = new Point(154, 61);
        roleNameTextBox.Name = "roleNameTextBox";
        roleNameTextBox.Size = new Size(331, 23);
        roleNameTextBox.TabIndex = 33;
        // 
        // RolenameLabel
        // 
        RolenameLabel.Location = new Point(25, 60);
        RolenameLabel.Name = "RolenameLabel";
        RolenameLabel.Size = new Size(123, 23);
        RolenameLabel.TabIndex = 32;
        RolenameLabel.Text = "RoleName:";
        RolenameLabel.TextAlign = ContentAlignment.MiddleRight;
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
        idLabel.Text = "RoleID:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userIdlabel
        // 
        userIdlabel.Location = new Point(25, 88);
        userIdlabel.Name = "userIdlabel";
        userIdlabel.Size = new Size(123, 23);
        userIdlabel.TabIndex = 46;
        userIdlabel.Text = "UserId:";
        userIdlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // RoleIdtextBox
        // 
        RoleIdtextBox.Location = new Point(154, 88);
        RoleIdtextBox.Name = "RoleIdtextBox";
        RoleIdtextBox.ReadOnly = true;
        RoleIdtextBox.Size = new Size(331, 23);
        RoleIdtextBox.TabIndex = 48;
        // 
        // RoleManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(586, 285);
        this.Controls.Add(RoleIdtextBox);
        this.Controls.Add(userIdlabel);
        this.Controls.Add(actionButton);
        this.Controls.Add(cancelButton);
        this.Controls.Add(roleDescriptionLabel);
        this.Controls.Add(descriptionTextBox);
        this.Controls.Add(roleNameTextBox);
        this.Controls.Add(RolenameLabel);
        this.Controls.Add(idTextBox);
        this.Controls.Add(idLabel);
        this.Name = "RoleManagementForm";
        this.Text = "RoleManagementForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private Button actionButton;
    private Button cancelButton;
    private Label roleDescriptionLabel;
    private TextBox descriptionTextBox;
    private TextBox roleNameTextBox;
    private Label RolenameLabel;
    private TextBox idTextBox;
    private Label idLabel;
    private Label userIdlabel;
    private TextBox RoleIdtextBox;
}