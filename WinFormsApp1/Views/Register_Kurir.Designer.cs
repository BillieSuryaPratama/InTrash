namespace WinFormsApp1.Views
{
    partial class Register_Kurir
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
            btnKembali = new Button();
            btnSimpan = new Button();
            tbSandi = new TextBox();
            tbUsername = new TextBox();
            tbNomorHP = new TextBox();
            tbNama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblInstruksi = new Label();
            label5 = new Label();
            cbTempatPengepul = new ComboBox();
            dgvTempatPengepul = new DataGridView();
            Id_tempatpengepul = new DataGridViewTextBoxColumn();
            nama_tempat = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTempatPengepul).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.Font = new Font("Segoe UI", 9F);
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(17, 385);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 51;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(535, 383);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 42;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbSandi
            // 
            tbSandi.Font = new Font("Segoe UI", 10F);
            tbSandi.Location = new Point(291, 136);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(224, 30);
            tbSandi.TabIndex = 40;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 10F);
            tbUsername.Location = new Point(291, 107);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(224, 30);
            tbUsername.TabIndex = 43;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Font = new Font("Segoe UI", 10F);
            tbNomorHP.Location = new Point(291, 77);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(224, 30);
            tbNomorHP.TabIndex = 44;
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 10F);
            tbNama.Location = new Point(291, 47);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(224, 30);
            tbNama.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 49);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 46;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(134, 80);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 47;
            label2.Text = "Nomor HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(134, 110);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 48;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(134, 139);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 49;
            label4.Text = "Sandi";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 14F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(231, 5);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(172, 32);
            lblInstruksi.TabIndex = 52;
            lblInstruksi.Text = "Daftarkan kurir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(134, 173);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 54;
            label5.Text = "Tempat Pengepul";
            // 
            // cbTempatPengepul
            // 
            cbTempatPengepul.FormattingEnabled = true;
            cbTempatPengepul.Location = new Point(291, 168);
            cbTempatPengepul.Name = "cbTempatPengepul";
            cbTempatPengepul.Size = new Size(224, 28);
            cbTempatPengepul.TabIndex = 55;
            // 
            // dgvTempatPengepul
            // 
            dgvTempatPengepul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTempatPengepul.Columns.AddRange(new DataGridViewColumn[] { Id_tempatpengepul, nama_tempat, Alamat, Deskripsi });
            dgvTempatPengepul.Location = new Point(14, 215);
            dgvTempatPengepul.Name = "dgvTempatPengepul";
            dgvTempatPengepul.RowHeadersWidth = 51;
            dgvTempatPengepul.Size = new Size(611, 163);
            dgvTempatPengepul.TabIndex = 56;
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
            // Register_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(637, 430);
            Controls.Add(dgvTempatPengepul);
            Controls.Add(cbTempatPengepul);
            Controls.Add(label5);
            Controls.Add(lblInstruksi);
            Controls.Add(btnKembali);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNama);
            Controls.Add(tbNomorHP);
            Controls.Add(tbUsername);
            Controls.Add(btnSimpan);
            Controls.Add(tbSandi);
            Name = "Register_Kurir";
            Text = "InTrash";
            Load += Register_Kurir_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTempatPengepul).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnKembali;
        private Button btnSimpan;
        private TextBox tbSandi;
        private TextBox tbUsername;
        private TextBox tbNomorHP;
        private TextBox tbNama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblInstruksi;
        private Label label5;
        private ComboBox cbTempatPengepul;
        private DataGridView dgvTempatPengepul;
        private DataGridViewTextBoxColumn Id_tempatpengepul;
        private DataGridViewTextBoxColumn nama_tempat;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn Deskripsi;
    }
}