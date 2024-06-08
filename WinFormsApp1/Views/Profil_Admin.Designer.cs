namespace WinFormsApp1
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
            dtpTanggalLahir = new DateTimePicker();
            tbAlamat = new TextBox();
            tbEmail = new TextBox();
            tbNomorHP = new TextBox();
            tbNama = new TextBox();
            btnSimpan = new Button();
            btnKembali = new Button();
            cbGender = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            btnUbahSandi = new Button();
            SuspendLayout();
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(272, 114);
            dtpTanggalLahir.Margin = new Padding(2);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(266, 27);
            dtpTanggalLahir.TabIndex = 33;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(271, 247);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(266, 27);
            tbAlamat.TabIndex = 26;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(271, 204);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(266, 27);
            tbEmail.TabIndex = 25;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(271, 157);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(266, 27);
            tbNomorHP.TabIndex = 24;
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
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(271, 73);
            cbGender.Margin = new Padding(2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(267, 28);
            cbGender.TabIndex = 41;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(123, 76);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 43;
            label3.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(126, 250);
            label8.Name = "label8";
            label8.Size = new Size(64, 23);
            label8.TabIndex = 48;
            label8.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(123, 160);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 46;
            label6.Text = "Nomor HP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(126, 207);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 47;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(123, 119);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 45;
            label5.Text = "Tanggal Lahir";
            // 
            // btnUbahSandi
            // 
            btnUbahSandi.BackColor = Color.MediumTurquoise;
            btnUbahSandi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnUbahSandi.Font = new Font("Segoe UI", 10F);
            btnUbahSandi.Location = new Point(273, 294);
            btnUbahSandi.Name = "btnUbahSandi";
            btnUbahSandi.Size = new Size(94, 29);
            btnUbahSandi.TabIndex = 49;
            btnUbahSandi.Text = "Ubah Sandi";
            btnUbahSandi.UseVisualStyleBackColor = false;
            // 
            // Profil_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(btnUbahSandi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbGender);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(tbAlamat);
            Controls.Add(tbEmail);
            Controls.Add(tbNomorHP);
            Controls.Add(tbNama);
            Margin = new Padding(2);
            Name = "Profil_Admin";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTanggalLahir;
        private TextBox tbAlamat;
        private TextBox tbEmail;
        private TextBox tbNomorHP;
        private TextBox tbNama;
        private Button btnSimpan;
        private Button btnKembali;
        private ComboBox cbGender;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Button btnUbahSandi;
    }
}