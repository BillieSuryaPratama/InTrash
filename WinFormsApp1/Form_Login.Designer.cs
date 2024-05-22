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
            rbNasabah = new RadioButton();
            rbAdmin = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogIn = new Button();
            btnLupaPassword = new Button();
            rbKurir = new RadioButton();
            gbLoginSebagai.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(341, 292);
            btnSignUp.Margin = new Padding(2, 2, 2, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 27);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += button2_Click;
            // 
            // gbLoginSebagai
            // 
            gbLoginSebagai.Controls.Add(rbKurir);
            gbLoginSebagai.Controls.Add(rbNasabah);
            gbLoginSebagai.Controls.Add(rbAdmin);
            gbLoginSebagai.Location = new Point(190, 50);
            gbLoginSebagai.Margin = new Padding(2, 2, 2, 2);
            gbLoginSebagai.Name = "gbLoginSebagai";
            gbLoginSebagai.Padding = new Padding(2, 2, 2, 2);
            gbLoginSebagai.Size = new Size(240, 132);
            gbLoginSebagai.TabIndex = 7;
            gbLoginSebagai.TabStop = false;
            gbLoginSebagai.Text = "Login Sebagai";
            // 
            // rbNasabah
            // 
            rbNasabah.AutoSize = true;
            rbNasabah.Location = new Point(28, 62);
            rbNasabah.Margin = new Padding(2, 2, 2, 2);
            rbNasabah.Name = "rbNasabah";
            rbNasabah.Size = new Size(88, 24);
            rbNasabah.TabIndex = 9;
            rbNasabah.TabStop = true;
            rbNasabah.Text = "Nasabah";
            rbNasabah.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(28, 33);
            rbAdmin.Margin = new Padding(2, 2, 2, 2);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(74, 24);
            rbAdmin.TabIndex = 8;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 188);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 8;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 215);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(275, 186);
            tbUsername.Margin = new Padding(2, 2, 2, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(156, 27);
            tbUsername.TabIndex = 10;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(275, 215);
            tbPassword.Margin = new Padding(2, 2, 2, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(156, 27);
            tbPassword.TabIndex = 11;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(190, 292);
            btnLogIn.Margin = new Padding(2, 2, 2, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(90, 27);
            btnLogIn.TabIndex = 12;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnLupaPassword
            // 
            btnLupaPassword.Location = new Point(190, 246);
            btnLupaPassword.Margin = new Padding(2, 2, 2, 2);
            btnLupaPassword.Name = "btnLupaPassword";
            btnLupaPassword.Size = new Size(240, 27);
            btnLupaPassword.TabIndex = 13;
            btnLupaPassword.Text = "Lupa Password";
            btnLupaPassword.UseVisualStyleBackColor = true;
            // 
            // rbKurir
            // 
            rbKurir.AutoSize = true;
            rbKurir.Location = new Point(28, 91);
            rbKurir.Name = "rbKurir";
            rbKurir.Size = new Size(61, 24);
            rbKurir.TabIndex = 10;
            rbKurir.TabStop = true;
            rbKurir.Text = "Kurir";
            rbKurir.UseVisualStyleBackColor = true;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnLupaPassword);
            Controls.Add(btnLogIn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbLoginSebagai);
            Controls.Add(btnSignUp);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btnLupaPassword;
        private RadioButton rbKurir;
    }
}
