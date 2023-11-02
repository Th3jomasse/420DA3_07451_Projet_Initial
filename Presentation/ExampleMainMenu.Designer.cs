namespace _420DA3_07451_Projet_Initial.Presentation;

partial class ExampleMainMenu {
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
        createButton = new Button();
        examplesComboBox = new ComboBox();
        viewButton = new Button();
        editButton = new Button();
        deleteButton = new Button();
        quitButton = new Button();
        this.SuspendLayout();
        // 
        // createButton
        // 
        createButton.Location = new Point(12, 22);
        createButton.Name = "createButton";
        createButton.Size = new Size(260, 33);
        createButton.TabIndex = 0;
        createButton.Text = "Create new example";
        createButton.UseVisualStyleBackColor = true;
        createButton.Click += this.CreateButton_Click;
        // 
        // examplesComboBox
        // 
        examplesComboBox.FormattingEnabled = true;
        examplesComboBox.Location = new Point(12, 83);
        examplesComboBox.Name = "examplesComboBox";
        examplesComboBox.Size = new Size(260, 23);
        examplesComboBox.TabIndex = 1;
        // 
        // viewButton
        // 
        viewButton.Location = new Point(12, 112);
        viewButton.Name = "viewButton";
        viewButton.Size = new Size(260, 25);
        viewButton.TabIndex = 2;
        viewButton.Text = "View Selected Example";
        viewButton.UseVisualStyleBackColor = true;
        viewButton.Click += this.ViewButton_Click;
        // 
        // editButton
        // 
        editButton.Location = new Point(12, 143);
        editButton.Name = "editButton";
        editButton.Size = new Size(260, 25);
        editButton.TabIndex = 3;
        editButton.Text = "Edit Selected Example";
        editButton.UseVisualStyleBackColor = true;
        editButton.Click += this.EditButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Location = new Point(12, 174);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(260, 25);
        deleteButton.TabIndex = 4;
        deleteButton.Text = "Delete Selected Example";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += this.DeleteButton_Click;
        // 
        // quitButton
        // 
        quitButton.Location = new Point(12, 216);
        quitButton.Name = "quitButton";
        quitButton.Size = new Size(260, 33);
        quitButton.TabIndex = 5;
        quitButton.Text = "Exit";
        quitButton.UseVisualStyleBackColor = true;
        quitButton.Click += this.ExitButton_Click;
        // 
        // ExampleMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 261);
        this.Controls.Add(quitButton);
        this.Controls.Add(deleteButton);
        this.Controls.Add(editButton);
        this.Controls.Add(viewButton);
        this.Controls.Add(examplesComboBox);
        this.Controls.Add(createButton);
        this.Name = "ExampleMainMenu";
        this.Text = "Main Menu";
        this.ResumeLayout(false);
    }

    #endregion

    private Button createButton;
    private ComboBox examplesComboBox;
    private Button viewButton;
    private Button editButton;
    private Button deleteButton;
    private Button quitButton;
}