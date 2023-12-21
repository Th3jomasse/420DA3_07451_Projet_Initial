namespace _420DA3_07451_Projet_Initial.Presentation;

partial class RoleManagementForm
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
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.roleDescriptionLabel = new Label();
        this.roleDescriptionTextBox = new TextBox();
        this.roleNameTextBox = new TextBox();
        this.RolenameLabel = new Label();
        this.idLabel = new Label();
        this.userIdlabel = new Label();
        this.userIdtextBox = new TextBox();
        this.idRoleComboBox = new ComboBox();
        this.SuspendLayout();
        // 
        // actionButton
        // 
        this.actionButton.Location = new Point(253, 239);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(113, 23);
        this.actionButton.TabIndex = 43;
        this.actionButton.Text = "Action";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.ActionButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Location = new Point(372, 239);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(113, 23);
        this.cancelButton.TabIndex = 42;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // roleDescriptionLabel
        // 
        this.roleDescriptionLabel.Location = new Point(25, 117);
        this.roleDescriptionLabel.Name = "roleDescriptionLabel";
        this.roleDescriptionLabel.Size = new Size(123, 23);
        this.roleDescriptionLabel.TabIndex = 35;
        this.roleDescriptionLabel.Text = "RoleDescription:";
        this.roleDescriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // roleDescriptionTextBox
        // 
        this.roleDescriptionTextBox.Location = new Point(154, 117);
        this.roleDescriptionTextBox.Multiline = true;
        this.roleDescriptionTextBox.Name = "roleDescriptionTextBox";
        this.roleDescriptionTextBox.Size = new Size(331, 90);
        this.roleDescriptionTextBox.TabIndex = 34;
        // 
        // roleNameTextBox
        // 
        this.roleNameTextBox.Location = new Point(154, 61);
        this.roleNameTextBox.Name = "roleNameTextBox";
        this.roleNameTextBox.Size = new Size(331, 23);
        this.roleNameTextBox.TabIndex = 33;
        // 
        // RolenameLabel
        // 
        this.RolenameLabel.Location = new Point(25, 60);
        this.RolenameLabel.Name = "RolenameLabel";
        this.RolenameLabel.Size = new Size(123, 23);
        this.RolenameLabel.TabIndex = 32;
        this.RolenameLabel.Text = "RoleName:";
        this.RolenameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(25, 31);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(123, 23);
        this.idLabel.TabIndex = 30;
        this.idLabel.Text = "RoleID:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userIdlabel
        // 
        this.userIdlabel.Location = new Point(25, 88);
        this.userIdlabel.Name = "userIdlabel";
        this.userIdlabel.Size = new Size(123, 23);
        this.userIdlabel.TabIndex = 46;
        this.userIdlabel.Text = "UserId:";
        this.userIdlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userIdtextBox
        // 
        this.userIdtextBox.Location = new Point(154, 88);
        this.userIdtextBox.Name = "userIdtextBox";
        this.userIdtextBox.ReadOnly = true;
        this.userIdtextBox.Size = new Size(331, 23);
        this.userIdtextBox.TabIndex = 48;
        // 
        // idRoleComboBox
        // 
        this.idRoleComboBox.FormattingEnabled = true;
        this.idRoleComboBox.Location = new Point(154, 31);
        this.idRoleComboBox.Name = "idRoleComboBox";
        this.idRoleComboBox.Size = new Size(331, 23);
        this.idRoleComboBox.TabIndex = 49;
        // 
        // RoleManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(586, 285);
        this.Controls.Add(this.idRoleComboBox);
        this.Controls.Add(this.userIdtextBox);
        this.Controls.Add(this.userIdlabel);
        this.Controls.Add(this.actionButton);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.roleDescriptionLabel);
        this.Controls.Add(this.roleDescriptionTextBox);
        this.Controls.Add(this.roleNameTextBox);
        this.Controls.Add(this.RolenameLabel);
        this.Controls.Add(this.idLabel);
        this.Name = "RoleManagementForm";
        this.Text = "RoleManagementForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private Button actionButton;
    private Button cancelButton;
    private Label roleDescriptionLabel;
    private TextBox roleDescriptionTextBox;
    private TextBox roleNameTextBox;
    private Label RolenameLabel;
    private TextBox idTextBox;
    private Label idLabel;
    private Label userIdlabel;
    private TextBox userIdtextBox;
    private ComboBox idRoleComboBox;
}