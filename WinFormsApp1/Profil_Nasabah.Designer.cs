namespace WinFormsApp1
{
    partial class Profil_Nasabah
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
            btnUbahSandi = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbGender = new ComboBox();
            btnKembali = new Button();
            btnSimpan = new Button();
            dtpTanggalLahir = new DateTimePicker();
            tbAlamat = new TextBox();
            tbEmail = new TextBox();
            tbNomorHP = new TextBox();
            tbNama = new TextBox();
            SuspendLayout();
            // 
            // btnUbahSandi
            // 
            btnUbahSandi.Location = new Point(273, 296);
            btnUbahSandi.Name = "btnUbahSandi";
            btnUbahSandi.Size = new Size(94, 29);
            btnUbahSandi.TabIndex = 64;
            btnUbahSandi.Text = "Ubah Sandi";
            btnUbahSandi.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(126, 252);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 63;
            label8.Text = "Alamat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 209);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 62;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 162);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 61;
            label6.Text = "Nomor HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 121);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 60;
            label5.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 78);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 59;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 37);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 58;
            label2.Text = "Nama";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(230, 75);
            cbGender.Margin = new Padding(2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(267, 28);
            cbGender.TabIndex = 57;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(11, 322);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 56;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(539, 322);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 55;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(231, 116);
            dtpTanggalLahir.Margin = new Padding(2);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(266, 27);
            dtpTanggalLahir.TabIndex = 54;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(230, 249);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(266, 27);
            tbAlamat.TabIndex = 53;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(230, 206);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(266, 27);
            tbEmail.TabIndex = 52;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(230, 159);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(266, 27);
            tbNomorHP.TabIndex = 51;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(230, 34);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(267, 27);
            tbNama.TabIndex = 50;
            // 
            // Profil_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "Profil_Nasabah";
            Text = "InTrash";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUbahSandi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox cbGender;
        private Button btnKembali;
        private Button btnSimpan;
        private DateTimePicker dtpTanggalLahir;
        private TextBox tbAlamat;
        private TextBox tbEmail;
        private TextBox tbNomorHP;
        private TextBox tbNama;
    }
}