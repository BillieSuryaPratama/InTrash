namespace WinFormsApp1.Views
{
    partial class Profil_Admin
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
            tbtempatpengepul = new TextBox();
            tbalamat = new TextBox();
            tbNama = new TextBox();
            btnSimpan = new Button();
            btnKembali = new Button();
            label2 = new Label();
            label6 = new Label();
            btnUbahSandi = new Button();
            label8 = new Label();
            tbnoHP = new TextBox();
            label7 = new Label();
            label5 = new Label();
            tbUsername = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbtempatpengepul
            // 
            tbtempatpengepul.Location = new Point(271, 207);
            tbtempatpengepul.Margin = new Padding(2);
            tbtempatpengepul.Name = "tbtempatpengepul";
            tbtempatpengepul.ReadOnly = true;
            tbtempatpengepul.Size = new Size(266, 27);
            tbtempatpengepul.TabIndex = 26;
            // 
            // tbalamat
            // 
            tbalamat.Location = new Point(271, 117);
            tbalamat.Margin = new Padding(2);
            tbalamat.Name = "tbalamat";
            tbalamat.Size = new Size(266, 27);
            tbalamat.TabIndex = 24;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(271, 32);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(267, 27);
            tbNama.TabIndex = 23;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(539, 322);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 39;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(11, 322);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 40;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(123, 35);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 42;
            label2.Text = "Nama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(123, 120);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 46;
            label6.Text = "Alamat";
            // 
            // btnUbahSandi
            // 
            btnUbahSandi.BackColor = Color.MediumTurquoise;
            btnUbahSandi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnUbahSandi.Font = new Font("Segoe UI", 10F);
            btnUbahSandi.Location = new Point(273, 254);
            btnUbahSandi.Name = "btnUbahSandi";
            btnUbahSandi.Size = new Size(94, 29);
            btnUbahSandi.TabIndex = 49;
            btnUbahSandi.Text = "Ubah Sandi";
            btnUbahSandi.UseVisualStyleBackColor = false;
            btnUbahSandi.Click += btnUbahSandi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(126, 210);
            label8.Name = "label8";
            label8.Size = new Size(142, 23);
            label8.TabIndex = 48;
            label8.Text = "Tempat Pengepul";
            // 
            // tbnoHP
            // 
            tbnoHP.Location = new Point(271, 164);
            tbnoHP.Margin = new Padding(2);
            tbnoHP.Name = "tbnoHP";
            tbnoHP.Size = new Size(266, 27);
            tbnoHP.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(126, 167);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 47;
            label7.Text = "Nomor HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(123, 79);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 45;
            label5.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(271, 75);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(266, 27);
            tbUsername.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 257);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 51;
            label1.Text = "Sandi";
            // 
            // Profil_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(label1);
            Controls.Add(tbUsername);
            Controls.Add(btnUbahSandi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(tbtempatpengepul);
            Controls.Add(tbnoHP);
            Controls.Add(tbalamat);
            Controls.Add(tbNama);
            Margin = new Padding(2);
            Name = "Profil_Admin";
            Text = "InTrash";
            Load += Profil_Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbtempatpengepul;
        private TextBox tbalamat;
        private TextBox tbNama;
        private Button btnSimpan;
        private Button btnKembali;
        private Label label2;
        private Label label6;
        private Button btnUbahSandi;
        private Label label8;
        private TextBox tbnoHP;
        private Label label7;
        private Label label5;
        private TextBox tbUsername;
        private Label label1;
    }
}