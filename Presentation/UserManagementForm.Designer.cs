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
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.nameTextBox = new TextBox();
        this.nameLabel = new Label();
        this.idLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.passwordHashtextBox = new TextBox();
        this.passwordHashlabel = new Label();
        this.warehousetextBox = new TextBox();
        this.warehouselabel = new Label();
        this.userIdNumeric = new ComboBox();
        this.textBox1 = new TextBox();
        this.passworedLabel = new Label();
        this.textBox2 = new TextBox();
        this.SuspendLayout();
        // 
        // actionButton
        // 
        this.actionButton.Location = new Point(269, 311);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(113, 23);
        this.actionButton.TabIndex = 27;
        this.actionButton.Text = "Action";
        this.actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        this.cancelButton.Location = new Point(388, 311);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(113, 23);
        this.cancelButton.TabIndex = 26;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // nameTextBox
        // 
        this.nameTextBox.Location = new Point(170, 80);
        this.nameTextBox.Name = "nameTextBox";
        this.nameTextBox.Size = new Size(331, 23);
        this.nameTextBox.TabIndex = 17;
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new Point(41, 79);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new Size(123, 23);
        this.nameLabel.TabIndex = 16;
        this.nameLabel.Text = "Name:";
        this.nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(41, 50);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(123, 23);
        this.idLabel.TabIndex = 14;
        this.idLabel.Text = "UserID:";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(41, 199);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(123, 23);
        this.dateCreatedLabel.TabIndex = 21;
        this.dateCreatedLabel.Text = "Date Created:";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // passwordHashtextBox
        // 
        this.passwordHashtextBox.Location = new Point(170, 141);
        this.passwordHashtextBox.Name = "passwordHashtextBox";
        this.passwordHashtextBox.Size = new Size(331, 23);
        this.passwordHashtextBox.TabIndex = 29;
        // 
        // passwordHashlabel
        // 
        this.passwordHashlabel.Location = new Point(41, 140);
        this.passwordHashlabel.Name = "passwordHashlabel";
        this.passwordHashlabel.Size = new Size(123, 23);
        this.passwordHashlabel.TabIndex = 28;
        this.passwordHashlabel.Text = "PassewordHash:";
        this.passwordHashlabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehousetextBox
        // 
        this.warehousetextBox.Location = new Point(170, 170);
        this.warehousetextBox.Name = "warehousetextBox";
        this.warehousetextBox.Size = new Size(331, 23);
        this.warehousetextBox.TabIndex = 33;
        // 
        // warehouselabel
        // 
        this.warehouselabel.Location = new Point(41, 169);
        this.warehouselabel.Name = "warehouselabel";
        this.warehouselabel.Size = new Size(123, 23);
        this.warehouselabel.TabIndex = 32;
        this.warehouselabel.Text = "Warehouse:";
        this.warehouselabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // userIdNumeric
        // 
        this.userIdNumeric.FormattingEnabled = true;
        this.userIdNumeric.Location = new Point(170, 51);
        this.userIdNumeric.Name = "userIdNumeric";
        this.userIdNumeric.Size = new Size(331, 23);
        this.userIdNumeric.TabIndex = 34;
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(170, 109);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(331, 23);
        this.textBox1.TabIndex = 36;
        // 
        // passworedLabel
        // 
        this.passworedLabel.Location = new Point(41, 108);
        this.passworedLabel.Name = "passworedLabel";
        this.passworedLabel.Size = new Size(123, 23);
        this.passworedLabel.TabIndex = 35;
        this.passworedLabel.Text = "Passeword:";
        this.passworedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // textBox2
        // 
        this.textBox2.Location = new Point(170, 199);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new Size(331, 23);
        this.textBox2.TabIndex = 37;
        // 
        // UserManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(636, 378);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.passworedLabel);
        this.Controls.Add(this.userIdNumeric);
        this.Controls.Add(this.warehousetextBox);
        this.Controls.Add(this.warehouselabel);
        this.Controls.Add(this.passwordHashtextBox);
        this.Controls.Add(this.passwordHashlabel);
        this.Controls.Add(this.actionButton);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.dateCreatedLabel);
        this.Controls.Add(this.nameTextBox);
        this.Controls.Add(this.nameLabel);
        this.Controls.Add(this.idLabel);
        this.Name = "UserManagementForm";
        this.Text = "UserManagementForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button actionButton;
    private Button cancelButton;
    private TextBox nameTextBox;
    private Label nameLabel;
    private Label idLabel;
    private Label dateCreatedLabel;
    private TextBox passwordHashtextBox;
    private Label passwordHashlabel;
    private TextBox warehousetextBox;
    private Label warehouselabel;
    private ComboBox userIdNumeric;
    private TextBox textBox1;
    private Label passworedLabel;
    private TextBox textBox2;
}