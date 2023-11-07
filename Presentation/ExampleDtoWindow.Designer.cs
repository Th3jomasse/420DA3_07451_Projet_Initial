namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ExampleDtoWindow {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        idLabel = new Label();
        idTextBox = new TextBox();
        nameLabel = new Label();
        nameTextBox = new TextBox();
        descriptionTextBox = new TextBox();
        descriptionLabel = new Label();
        dateCreatedBox = new DateTimePicker();
        dateCreatedLabel = new Label();
        label1 = new Label();
        dateUpdatedBox = new DateTimePicker();
        dateDeletedBox = new DateTimePicker();
        dateDeletedLabel = new Label();
        cancelButton = new Button();
        actionButton = new Button();
        this.SuspendLayout();
        // 
        // idLabel
        // 
        idLabel.Location = new Point(12, 34);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(123, 23);
        idLabel.TabIndex = 0;
        idLabel.Text = "ID:";
        idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idTextBox
        // 
        idTextBox.Location = new Point(141, 35);
        idTextBox.Name = "idTextBox";
        idTextBox.ReadOnly = true;
        idTextBox.Size = new Size(331, 23);
        idTextBox.TabIndex = 1;
        // 
        // nameLabel
        // 
        nameLabel.Location = new Point(12, 63);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(123, 23);
        nameLabel.TabIndex = 2;
        nameLabel.Text = "Name:";
        nameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(141, 64);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(331, 23);
        nameTextBox.TabIndex = 3;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(141, 93);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(331, 90);
        descriptionTextBox.TabIndex = 4;
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(12, 93);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(123, 23);
        descriptionLabel.TabIndex = 5;
        descriptionLabel.Text = "Description:";
        descriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedBox
        // 
        dateCreatedBox.Enabled = false;
        dateCreatedBox.Location = new Point(141, 189);
        dateCreatedBox.Name = "dateCreatedBox";
        dateCreatedBox.Size = new Size(331, 23);
        dateCreatedBox.TabIndex = 6;
        // 
        // dateCreatedLabel
        // 
        dateCreatedLabel.Location = new Point(12, 189);
        dateCreatedLabel.Name = "dateCreatedLabel";
        dateCreatedLabel.Size = new Size(123, 23);
        dateCreatedLabel.TabIndex = 7;
        dateCreatedLabel.Text = "Date Created:";
        dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label1
        // 
        label1.Location = new Point(12, 218);
        label1.Name = "label1";
        label1.Size = new Size(123, 23);
        label1.TabIndex = 8;
        label1.Text = "Date Last Modified:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateUpdatedBox
        // 
        dateUpdatedBox.Enabled = false;
        dateUpdatedBox.Location = new Point(141, 218);
        dateUpdatedBox.Name = "dateUpdatedBox";
        dateUpdatedBox.Size = new Size(331, 23);
        dateUpdatedBox.TabIndex = 9;
        // 
        // dateDeletedBox
        // 
        dateDeletedBox.Enabled = false;
        dateDeletedBox.Location = new Point(141, 247);
        dateDeletedBox.Name = "dateDeletedBox";
        dateDeletedBox.Size = new Size(331, 23);
        dateDeletedBox.TabIndex = 10;
        // 
        // dateDeletedLabel
        // 
        dateDeletedLabel.Location = new Point(12, 247);
        dateDeletedLabel.Name = "dateDeletedLabel";
        dateDeletedLabel.Size = new Size(123, 23);
        dateDeletedLabel.TabIndex = 11;
        dateDeletedLabel.Text = "Date Deleted:";
        dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cancelButton
        // 
        cancelButton.Location = new Point(359, 276);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(113, 23);
        cancelButton.TabIndex = 12;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += this.CancelButton_Click;
        // 
        // actionButton
        // 
        actionButton.Location = new Point(240, 276);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(113, 23);
        actionButton.TabIndex = 13;
        actionButton.Text = "Action";
        actionButton.UseVisualStyleBackColor = true;
        actionButton.Click += this.OnActionButtonClick;
        // 
        // ExampleDtoForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(484, 311);
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
        this.Name = "ExampleDtoForm";
        this.Text = "Example Management";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label idLabel;
    private TextBox idTextBox;
    private Label nameLabel;
    private TextBox nameTextBox;
    private TextBox descriptionTextBox;
    private Label descriptionLabel;
    private DateTimePicker dateCreatedBox;
    private Label dateCreatedLabel;
    private Label label1;
    private DateTimePicker dateUpdatedBox;
    private DateTimePicker dateDeletedBox;
    private Label dateDeletedLabel;
    private Button cancelButton;
    private Button actionButton;
}
