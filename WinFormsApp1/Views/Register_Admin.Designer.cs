namespace WinFormsApp1.Views
{
    partial class Register_Admin
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
            tbNama = new TextBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnSimpan = new Button();
            tbAlamat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnKembali = new Button();
            lblInstruksi = new Label();
            dgvTempatPengepul = new DataGridView();
            Id_tempatpengepul = new DataGridViewTextBoxColumn();
            nama_tempat = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            cbTempatPengepul = new ComboBox();
            label6 = new Label();
            tbNoHP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTempatPengepul).BeginInit();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Location = new Point(375, 51);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(136, 30);
            tbNama.TabIndex = 19;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(375, 87);
            tbUserName.Margin = new Padding(2);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(136, 30);
            tbUserName.TabIndex = 18;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(375, 123);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(136, 30);
            tbPassword.TabIndex = 17;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(608, 372);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(101, 31);
            btnSimpan.TabIndex = 16;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(375, 159);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(136, 30);
            tbAlamat.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 52);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 20;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(207, 89);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 21;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(207, 127);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(207, 162);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 23;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(207, 237);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 24;
            label5.Text = "Tempat Pengepul";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(11, 372);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(101, 31);
            btnKembali.TabIndex = 25;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 13F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(220, 5);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(289, 30);
            lblInstruksi.TabIndex = 26;
            lblInstruksi.Text = "Daftarkan diri sebagai admin";
            // 
            // dgvTempatPengepul
            // 
            dgvTempatPengepul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTempatPengepul.Columns.AddRange(new DataGridViewColumn[] { Id_tempatpengepul, nama_tempat, Alamat, Deskripsi });
            dgvTempatPengepul.Location = new Point(55, 275);
            dgvTempatPengepul.Name = "dgvTempatPengepul";
            dgvTempatPengepul.RowHeadersWidth = 51;
            dgvTempatPengepul.Size = new Size(611, 80);
            dgvTempatPengepul.TabIndex = 57;
            // 
            // Id_tempatpengepul
            // 
            Id_tempatpengepul.HeaderText = "ID";
            Id_tempatpengepul.MinimumWidth = 6;
            Id_tempatpengepul.Name = "Id_tempatpengepul";
            Id_tempatpengepul.Width = 40;
            // 
            // nama_tempat
            // 
            nama_tempat.HeaderText = "Nama Tempat Pengepul";
            nama_tempat.MinimumWidth = 6;
            nama_tempat.Name = "nama_tempat";
            nama_tempat.Width = 200;
            // 
            // Alamat
            // 
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 6;
            Alamat.Name = "Alamat";
            Alamat.Width = 200;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Width = 118;
            // 
            // cbTempatPengepul
            // 
            cbTempatPengepul.FormattingEnabled = true;
            cbTempatPengepul.Location = new Point(376, 231);
            cbTempatPengepul.Name = "cbTempatPengepul";
            cbTempatPengepul.Size = new Size(136, 31);
            cbTempatPengepul.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(207, 200);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 59;
            label6.Text = "No HP";
            // 
            // tbNoHP
            // 
            tbNoHP.Location = new Point(376, 195);
            tbNoHP.Margin = new Padding(2);
            tbNoHP.Name = "tbNoHP";
            tbNoHP.Size = new Size(136, 30);
            tbNoHP.TabIndex = 60;
            // 
            // Register_Admin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(720, 414);
            Controls.Add(tbNoHP);
            Controls.Add(label6);
            Controls.Add(cbTempatPengepul);
            Controls.Add(dgvTempatPengepul);
            Controls.Add(lblInstruksi);
            Controls.Add(btnKembali);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNama);
            Controls.Add(tbUserName);
            Controls.Add(tbPassword);
            Controls.Add(btnSimpan);
            Controls.Add(tbAlamat);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(2);
            Name = "Register_Admin";
            Text = "InTrash";
            Load += Register_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTempatPengepul).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnSimpan;
        private TextBox tbAlamat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnKembali;
        private Label lblInstruksi;
        private DataGridView dgvTempatPengepul;
        private DataGridViewTextBoxColumn Id_tempatpengepul;
        private DataGridViewTextBoxColumn nama_tempat;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn Deskripsi;
        private ComboBox cbTempatPengepul;
        private Label label6;
        private TextBox tbNoHP;
    }
}