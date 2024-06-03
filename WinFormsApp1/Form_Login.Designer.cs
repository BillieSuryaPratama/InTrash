namespace WinFormsApp1
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSignUp = new Button();
            gbLoginSebagai = new GroupBox();
            rbKurir = new RadioButton();
            rbNasabah = new RadioButton();
            rbAdmin = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogIn = new Button();
            btnLupaPassword = new Button();
            gbLoginSebagai.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSignUp.Location = new Point(298, 219);
            btnSignUp.Margin = new Padding(2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(79, 31);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += button2_Click;
            // 
            // gbLoginSebagai
            // 
            gbLoginSebagai.BackColor = Color.Transparent;
            gbLoginSebagai.Controls.Add(rbKurir);
            gbLoginSebagai.Controls.Add(rbNasabah);
            gbLoginSebagai.Controls.Add(rbAdmin);
            gbLoginSebagai.ForeColor = Color.White;
            gbLoginSebagai.Location = new Point(166, 15);
            gbLoginSebagai.Margin = new Padding(2);
            gbLoginSebagai.Name = "gbLoginSebagai";
            gbLoginSebagai.Padding = new Padding(2);
            gbLoginSebagai.Size = new Size(210, 99);
            gbLoginSebagai.TabIndex = 7;
            gbLoginSebagai.TabStop = false;
            gbLoginSebagai.Text = "Login Sebagai";
            // 
            // rbKurir
            // 
            rbKurir.AutoSize = true;
            rbKurir.Location = new Point(24, 68);
            rbKurir.Margin = new Padding(3, 2, 3, 2);
            rbKurir.Name = "rbKurir";
            rbKurir.Size = new Size(50, 19);
            rbKurir.TabIndex = 10;
            rbKurir.TabStop = true;
            rbKurir.Text = "Kurir";
            rbKurir.UseVisualStyleBackColor = true;
            // 
            // rbNasabah
            // 
            rbNasabah.AutoSize = true;
            rbNasabah.Location = new Point(24, 46);
            rbNasabah.Margin = new Padding(2);
            rbNasabah.Name = "rbNasabah";
            rbNasabah.Size = new Size(71, 19);
            rbNasabah.TabIndex = 9;
            rbNasabah.TabStop = true;
            rbNasabah.Text = "Nasabah";
            rbNasabah.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(24, 25);
            rbAdmin.Margin = new Padding(2);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(61, 19);
            rbAdmin.TabIndex = 8;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 125);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(164, 153);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(239, 124);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(137, 23);
            tbUsername.TabIndex = 10;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(239, 153);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(137, 23);
            tbPassword.TabIndex = 11;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Red;
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(166, 219);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(79, 31);
            btnLogIn.TabIndex = 12;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // btnLupaPassword
            // 
            btnLupaPassword.BackColor = Color.Transparent;
            btnLupaPassword.Location = new Point(167, 180);
            btnLupaPassword.Margin = new Padding(2);
            btnLupaPassword.Name = "btnLupaPassword";
            btnLupaPassword.Size = new Size(210, 35);
            btnLupaPassword.TabIndex = 13;
            btnLupaPassword.Text = "Lupa Password";
            btnLupaPassword.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55__1_;
            ClientSize = new Size(560, 270);
            Controls.Add(btnLupaPassword);
            Controls.Add(btnLogIn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbLoginSebagai);
            Controls.Add(btnSignUp);
            Margin = new Padding(2);
            Name = "Form_Login";
            Text = "InTrash";
            Load += Form1_Load;
            gbLoginSebagai.ResumeLayout(false);
            gbLoginSebagai.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSignUp;
        private GroupBox gbLoginSebagai;
        private RadioButton rbNasabah;
        private RadioButton rbAdmin;
        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogIn;
        private RadioButton rbKurir;
        private Button btnLupaPassword;
    }
}
