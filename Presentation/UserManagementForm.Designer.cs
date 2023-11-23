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
        dateDeletedLabel = new Label();
        dateDeletedBox = new DateTimePicker();
        dateUpdatedBox = new DateTimePicker();
        label1 = new Label();
        dateCreatedBox = new DateTimePicker();
        descriptionLabel = new Label();
        descriptionTextBox = new TextBox();
        nameTextBox = new TextBox();
        nameLabel = new Label();
        idTextBox = new TextBox();
        idLabel = new Label();
        dateCreatedLabel = new Label();
        textBox1 = new TextBox();
        label2 = new Label();
        this.SuspendLayout();
        // 
        // actionButton
        // 
        actionButton.Location = new Point(559, 415);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(113, 23);
        actionButton.TabIndex = 27;
        actionButton.Text = "Action";
        actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(678, 415);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(113, 23);
        cancelButton.TabIndex = 26;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // dateDeletedLabel
        // 
        dateDeletedLabel.Location = new Point(41, 343);
        dateDeletedLabel.Name = "dateDeletedLabel";
        dateDeletedLabel.Size = new Size(123, 23);
        dateDeletedLabel.TabIndex = 25;
        dateDeletedLabel.Text = "Date Deleted:";
        dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedBox
        // 
        dateDeletedBox.Enabled = false;
        dateDeletedBox.Location = new Point(170, 343);
        dateDeletedBox.Name = "dateDeletedBox";
        dateDeletedBox.Size = new Size(331, 23);
        dateDeletedBox.TabIndex = 24;
        // 
        // dateUpdatedBox
        // 
        dateUpdatedBox.Enabled = false;
        dateUpdatedBox.Location = new Point(170, 314);
        dateUpdatedBox.Name = "dateUpdatedBox";
        dateUpdatedBox.Size = new Size(331, 23);
        dateUpdatedBox.TabIndex = 23;
        // 
        // label1
        // 
        label1.Location = new Point(41, 314);
        label1.Name = "label1";
        label1.Size = new Size(123, 23);
        label1.TabIndex = 22;
        label1.Text = "Date Last Modified:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedBox
        // 
        dateCreatedBox.Enabled = false;
        dateCreatedBox.Location = new Point(170, 285);
        dateCreatedBox.Name = "dateCreatedBox";
        dateCreatedBox.Size = new Size(331, 23);
        dateCreatedBox.TabIndex = 20;
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(41, 189);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(123, 23);
        descriptionLabel.TabIndex = 19;
        descriptionLabel.Text = "Description:";
        descriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(170, 189);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(331, 90);
        descriptionTextBox.TabIndex = 18;
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
        idLabel.Text = "ID:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        dateCreatedLabel.Location = new Point(41, 285);
        dateCreatedLabel.Name = "dateCreatedLabel";
        dateCreatedLabel.Size = new Size(123, 23);
        dateCreatedLabel.TabIndex = 21;
        dateCreatedLabel.Text = "Date Created:";
        dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(170, 109);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(331, 23);
        textBox1.TabIndex = 29;
        // 
        // label2
        // 
        label2.Location = new Point(41, 108);
        label2.Name = "label2";
        label2.Size = new Size(123, 23);
        label2.TabIndex = 28;
        label2.Text = "Name:";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UserManagementForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(textBox1);
        this.Controls.Add(label2);
        this.Controls.Add(actionButton);
        this.Controls.Add(cancelButton);
        this.Controls.Add(dateDeletedLabel);
        this.Controls.Add(dateDeletedBox);
        this.Controls.Add(dateUpdatedBox);
        this.Controls.Add(label1);
        this.Controls.Add(dateCreatedLabel);
        this.Controls.Add(dateCreatedBox);
        this.Controls.Add(descriptionLabel);
        this.Controls.Add(descriptionTextBox);
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
    private Label dateDeletedLabel;
    private DateTimePicker dateDeletedBox;
    private DateTimePicker dateUpdatedBox;
    private Label label1;
    private DateTimePicker dateCreatedBox;
    private Label descriptionLabel;
    private TextBox descriptionTextBox;
    private TextBox nameTextBox;
    private Label nameLabel;
    private TextBox idTextBox;
    private Label idLabel;
    private Label dateCreatedLabel;
    private TextBox textBox1;
    private Label label2;
}