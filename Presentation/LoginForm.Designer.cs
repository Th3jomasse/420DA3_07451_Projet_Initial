namespace _420DA3_07451_Projet_Initial.Presentation;

partial class LoginForm {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        this.panel1 = new Panel();
        this.label2 = new Label();
        this.button1 = new Button();
        this.buttonLogin = new Button();
        this.textBoxUserName = new TextBox();
        this.label1 = new Label();
        this.panel2 = new Panel();
        this.pictureBox4 = new PictureBox();
        this.pictureBox3 = new PictureBox();
        this.linkLabel2 = new LinkLabel();
        this.linkLabelForgotPassword = new LinkLabel();
        this.label4 = new Label();
        this.textBoxPassword = new TextBox();
        this.label3 = new Label();
        this.pictureBox2 = new PictureBox();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.pictureBox2).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.BackColor = Color.Coral;
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.button1);
        this.panel1.Dock = DockStyle.Top;
        this.panel1.Location = new Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(894, 49);
        this.panel1.TabIndex = 0;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.ForeColor = SystemColors.ButtonFace;
        this.label2.Location = new Point(12, 17);
        this.label2.Name = "label2";
        this.label2.Size = new Size(37, 15);
        this.label2.TabIndex = 4;
        this.label2.Text = "Login";
        // 
        // button1
        // 
        this.button1.BackgroundImage = (Image) resources.GetObject("button1.BackgroundImage");
        this.button1.BackgroundImageLayout = ImageLayout.Zoom;
        this.button1.Dock = DockStyle.Right;
        this.button1.FlatAppearance.BorderSize = 0;
        this.button1.FlatStyle = FlatStyle.Flat;
        this.button1.Location = new Point(844, 0);
        this.button1.Name = "button1";
        this.button1.Size = new Size(50, 49);
        this.button1.TabIndex = 0;
        this.button1.UseVisualStyleBackColor = true;
        // 
        // buttonLogin
        // 
        this.buttonLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonLogin.ForeColor = Color.Black;
        this.buttonLogin.Location = new Point(108, 314);
        this.buttonLogin.Name = "buttonLogin";
        this.buttonLogin.Size = new Size(190, 44);
        this.buttonLogin.TabIndex = 1;
        this.buttonLogin.Text = "Login";
        this.buttonLogin.UseVisualStyleBackColor = true;
        this.buttonLogin.Click += this.LoginButton_Click;
        // 
        // textBoxUserName
        // 
        this.textBoxUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.textBoxUserName.ForeColor = Color.White;
        this.textBoxUserName.Location = new Point(63, 173);
        this.textBoxUserName.Name = "textBoxUserName";
        this.textBoxUserName.Size = new Size(285, 26);
        this.textBoxUserName.TabIndex = 2;
        this.textBoxUserName.TextChanged += this.textBoxUserName_TextChanged;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.label1.ForeColor = Color.White;
        this.label1.Location = new Point(172, 102);
        this.label1.Name = "label1";
        this.label1.Size = new Size(64, 20);
        this.label1.TabIndex = 3;
        this.label1.Text = "LOGIN";
        // 
        // panel2
        // 
        this.panel2.BackColor = Color.Silver;
        this.panel2.BackgroundImage = (Image) resources.GetObject("panel2.BackgroundImage");
        this.panel2.Controls.Add(this.pictureBox4);
        this.panel2.Controls.Add(this.pictureBox3);
        this.panel2.Controls.Add(this.linkLabel2);
        this.panel2.Controls.Add(this.linkLabelForgotPassword);
        this.panel2.Controls.Add(this.buttonLogin);
        this.panel2.Controls.Add(this.label4);
        this.panel2.Controls.Add(this.textBoxPassword);
        this.panel2.Controls.Add(this.label3);
        this.panel2.Controls.Add(this.label1);
        this.panel2.Controls.Add(this.textBoxUserName);
        this.panel2.Location = new Point(0, 49);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(410, 440);
        this.panel2.TabIndex = 4;
        // 
        // pictureBox4
        // 
        this.pictureBox4.BackColor = Color.Transparent;
        this.pictureBox4.Image = (Image) resources.GetObject("pictureBox4.Image");
        this.pictureBox4.Location = new Point(25, 229);
        this.pictureBox4.Name = "pictureBox4";
        this.pictureBox4.Size = new Size(32, 27);
        this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox4.TabIndex = 11;
        this.pictureBox4.TabStop = false;
        // 
        // pictureBox3
        // 
        this.pictureBox3.BackColor = Color.Transparent;
        this.pictureBox3.Image = (Image) resources.GetObject("pictureBox3.Image");
        this.pictureBox3.Location = new Point(25, 172);
        this.pictureBox3.Name = "pictureBox3";
        this.pictureBox3.Size = new Size(32, 27);
        this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox3.TabIndex = 10;
        this.pictureBox3.TabStop = false;
        // 
        // linkLabel2
        // 
        this.linkLabel2.AutoSize = true;
        this.linkLabel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.linkLabel2.ForeColor = Color.White;
        this.linkLabel2.LinkColor = Color.FromArgb(  0,   0,   64);
        this.linkLabel2.Location = new Point(138, 361);
        this.linkLabel2.Name = "linkLabel2";
        this.linkLabel2.Size = new Size(134, 20);
        this.linkLabel2.TabIndex = 8;
        this.linkLabel2.TabStop = true;
        this.linkLabel2.Text = "Create Account";
        // 
        // linkLabelForgotPassword
        // 
        this.linkLabelForgotPassword.AutoSize = true;
        this.linkLabelForgotPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.linkLabelForgotPassword.ForeColor = Color.White;
        this.linkLabelForgotPassword.LinkColor = Color.FromArgb(  0,   0,   64);
        this.linkLabelForgotPassword.Location = new Point(128, 281);
        this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
        this.linkLabelForgotPassword.Size = new Size(159, 20);
        this.linkLabelForgotPassword.TabIndex = 7;
        this.linkLabelForgotPassword.TabStop = true;
        this.linkLabelForgotPassword.Text = "Forgot Password ?";
        this.linkLabelForgotPassword.LinkClicked += this.linkLabelForgotPassword_LinkClicked;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.label4.ForeColor = Color.White;
        this.label4.Location = new Point(63, 207);
        this.label4.Name = "label4";
        this.label4.Size = new Size(86, 20);
        this.label4.TabIndex = 6;
        this.label4.Text = "Password";
        this.label4.Click += this.label4_Click;
        // 
        // textBoxPassword
        // 
        this.textBoxPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.textBoxPassword.ForeColor = Color.White;
        this.textBoxPassword.Location = new Point(63, 230);
        this.textBoxPassword.Name = "textBoxPassword";
        this.textBoxPassword.Size = new Size(285, 26);
        this.textBoxPassword.TabIndex = 5;
        this.textBoxPassword.TextChanged += this.textBoxPassword_TextChanged;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
        this.label3.ForeColor = Color.White;
        this.label3.Location = new Point(63, 150);
        this.label3.Name = "label3";
        this.label3.Size = new Size(93, 20);
        this.label3.TabIndex = 4;
        this.label3.Text = "UserName";
        // 
        // pictureBox2
        // 
        this.pictureBox2.Dock = DockStyle.Fill;
        this.pictureBox2.Image = (Image) resources.GetObject("pictureBox2.Image");
        this.pictureBox2.Location = new Point(0, 49);
        this.pictureBox2.Name = "pictureBox2";
        this.pictureBox2.Size = new Size(894, 567);
        this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
        this.pictureBox2.TabIndex = 6;
        this.pictureBox2.TabStop = false;
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = SystemColors.ActiveBorder;
        this.ClientSize = new Size(894, 616);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.pictureBox2);
        this.Controls.Add(this.panel1);
        this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = "LoginForm";
        this.ShowIcon = false;
        this.Text = "LoginForm";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.pictureBox2).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Button button1;
    private Label label2;
    private Button buttonLogin;
    private TextBox textBoxUserName;
    private Label label1;
    private Panel panel2;
    private LinkLabel linkLabel2;
    private LinkLabel linkLabelForgotPassword;
    private Label label4;
    private TextBox textBoxPassword;
    private Label label3;
    private PictureBox pictureBox2;
    private PictureBox pictureBox4;
    private PictureBox pictureBox3;
}