namespace WinFormsApp1.Views
{
    partial class Form_Login_Kurir
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
            btnLogIn = new Button();
            btnLupaPassword = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Red;
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(361, 293);
            btnLogIn.Margin = new Padding(2, 3, 2, 3);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(90, 41);
            btnLogIn.TabIndex = 18;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // btnLupaPassword
            // 
            btnLupaPassword.BackColor = Color.Transparent;
            btnLupaPassword.Location = new Point(175, 293);
            btnLupaPassword.Margin = new Padding(2, 3, 2, 3);
            btnLupaPassword.Name = "btnLupaPassword";
            btnLupaPassword.Size = new Size(125, 43);
            btnLupaPassword.TabIndex = 19;
            btnLupaPassword.Text = "Lupa Password";
            btnLupaPassword.UseVisualStyleBackColor = false;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(286, 161);
            tbPassword.Margin = new Padding(2, 3, 2, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(156, 27);
            tbPassword.TabIndex = 17;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(286, 122);
            tbUsername.Margin = new Padding(2, 3, 2, 3);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(156, 27);
            tbUsername.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 161);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 124);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 14;
            label1.Text = "Username";
            // 
            // Form_Login_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(642, 382);
            Controls.Add(btnLogIn);
            Controls.Add(btnLupaPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Login_Kurir";
            Text = "Form_Login_Kurir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Button btnLupaPassword;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label2;
        private Label label1;
    }
}