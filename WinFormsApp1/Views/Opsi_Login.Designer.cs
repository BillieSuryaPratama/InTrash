namespace WinFormsApp1.Views
{
    partial class Opsi_Login
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
            btnAdmin = new Button();
            btnNasabah = new Button();
            btnKurir = new Button();
            btnRegAdmin = new Button();
            label1 = new Label();
            btnRegNasabah = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.MediumTurquoise;
            btnAdmin.Location = new Point(109, 205);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(94, 29);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnNasabah
            // 
            btnNasabah.BackColor = Color.MediumTurquoise;
            btnNasabah.Location = new Point(263, 205);
            btnNasabah.Name = "btnNasabah";
            btnNasabah.Size = new Size(94, 29);
            btnNasabah.TabIndex = 1;
            btnNasabah.Text = "Nasabah";
            btnNasabah.UseVisualStyleBackColor = false;
            btnNasabah.Click += btnNasabah_Click;
            // 
            // btnKurir
            // 
            btnKurir.BackColor = Color.MediumTurquoise;
            btnKurir.Location = new Point(424, 205);
            btnKurir.Name = "btnKurir";
            btnKurir.Size = new Size(94, 29);
            btnKurir.TabIndex = 2;
            btnKurir.Text = "Kurir";
            btnKurir.UseVisualStyleBackColor = false;
            btnKurir.Click += btnKurir_Click;
            // 
            // btnRegAdmin
            // 
            btnRegAdmin.BackColor = Color.MediumTurquoise;
            btnRegAdmin.Location = new Point(12, 292);
            btnRegAdmin.Name = "btnRegAdmin";
            btnRegAdmin.Size = new Size(141, 29);
            btnRegAdmin.TabIndex = 3;
            btnRegAdmin.Text = "Register Admin";
            btnRegAdmin.UseVisualStyleBackColor = false;
            btnRegAdmin.Click += btnRegAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(213, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 69);
            label1.TabIndex = 12;
            label1.Text = "Login";
            // 
            // btnRegNasabah
            // 
            btnRegNasabah.BackColor = Color.MediumTurquoise;
            btnRegNasabah.Location = new Point(12, 336);
            btnRegNasabah.Name = "btnRegNasabah";
            btnRegNasabah.Size = new Size(141, 29);
            btnRegNasabah.TabIndex = 13;
            btnRegNasabah.Text = "Register Nasabah";
            btnRegNasabah.UseVisualStyleBackColor = false;
            btnRegNasabah.Click += btnRegNasabah_Click;
            // 
            // Opsi_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(634, 377);
            Controls.Add(btnRegNasabah);
            Controls.Add(label1);
            Controls.Add(btnRegAdmin);
            Controls.Add(btnKurir);
            Controls.Add(btnNasabah);
            Controls.Add(btnAdmin);
            Name = "Opsi_Login";
            Text = "inTrash";
            Load += Opsi_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmin;
        private Button btnNasabah;
        private Button btnKurir;
        private Button btnRegAdmin;
        private Label label1;
        private Button btnRegNasabah;
    }
}