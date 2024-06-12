namespace WinFormsApp1.Views
{
    partial class Jemput_Sampah
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
            btnKonfirmasi = new Button();
            cbKonfirmasi = new ComboBox();
            btnSelesai = new Button();
            cbSelesai = new ComboBox();
            btnTampil1 = new Button();
            btnTampil2 = new Button();
            dgvListPenjemputan = new DataGridView();
            id_transaksi = new DataGridViewTextBoxColumn();
            tanggal_transaksi = new DataGridViewTextBoxColumn();
            tempat_pengepul = new DataGridViewTextBoxColumn();
            admin = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            Status_Transaksi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListPenjemputan).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(23, 313);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 32);
            btnKembali.TabIndex = 39;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(518, 267);
            btnKonfirmasi.Margin = new Padding(2, 3, 2, 3);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(90, 31);
            btnKonfirmasi.TabIndex = 37;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // cbKonfirmasi
            // 
            cbKonfirmasi.FormattingEnabled = true;
            cbKonfirmasi.Location = new Point(463, 269);
            cbKonfirmasi.Name = "cbKonfirmasi";
            cbKonfirmasi.Size = new Size(50, 28);
            cbKonfirmasi.TabIndex = 40;
            // 
            // btnSelesai
            // 
            btnSelesai.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSelesai.Location = new Point(518, 313);
            btnSelesai.Margin = new Padding(2, 3, 2, 3);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(90, 31);
            btnSelesai.TabIndex = 41;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // cbSelesai
            // 
            cbSelesai.FormattingEnabled = true;
            cbSelesai.Location = new Point(463, 315);
            cbSelesai.Name = "cbSelesai";
            cbSelesai.Size = new Size(50, 28);
            cbSelesai.TabIndex = 42;
            // 
            // btnTampil1
            // 
            btnTampil1.BackgroundImage = Properties.Resources.Wireframe___56;
            btnTampil1.Location = new Point(189, 267);
            btnTampil1.Margin = new Padding(2, 3, 2, 3);
            btnTampil1.Name = "btnTampil1";
            btnTampil1.Size = new Size(252, 31);
            btnTampil1.TabIndex = 43;
            btnTampil1.Text = "Tampilkan 'Diproses'";
            btnTampil1.UseVisualStyleBackColor = true;
            btnTampil1.Click += btnTampil1_Click;
            // 
            // btnTampil2
            // 
            btnTampil2.BackgroundImage = Properties.Resources.Wireframe___56;
            btnTampil2.Location = new Point(189, 314);
            btnTampil2.Margin = new Padding(2, 3, 2, 3);
            btnTampil2.Name = "btnTampil2";
            btnTampil2.Size = new Size(252, 31);
            btnTampil2.TabIndex = 44;
            btnTampil2.Text = "Tampilkan 'Terkonfirmasi'";
            btnTampil2.UseVisualStyleBackColor = true;
            btnTampil2.Click += btnTampil2_Click;
            // 
            // dgvListPenjemputan
            // 
            dgvListPenjemputan.BackgroundColor = Color.Gainsboro;
            dgvListPenjemputan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPenjemputan.Columns.AddRange(new DataGridViewColumn[] { id_transaksi, tanggal_transaksi, tempat_pengepul, admin, customer, Status_Transaksi });
            dgvListPenjemputan.Location = new Point(25, 11);
            dgvListPenjemputan.Margin = new Padding(2);
            dgvListPenjemputan.Name = "dgvListPenjemputan";
            dgvListPenjemputan.RowHeadersWidth = 62;
            dgvListPenjemputan.Size = new Size(583, 228);
            dgvListPenjemputan.TabIndex = 45;
            // 
            // id_transaksi
            // 
            id_transaksi.HeaderText = "ID Transaksi";
            id_transaksi.MinimumWidth = 6;
            id_transaksi.Name = "id_transaksi";
            id_transaksi.Width = 125;
            // 
            // tanggal_transaksi
            // 
            tanggal_transaksi.HeaderText = "Tanggal Transaksi";
            tanggal_transaksi.MinimumWidth = 6;
            tanggal_transaksi.Name = "tanggal_transaksi";
            tanggal_transaksi.Width = 125;
            // 
            // tempat_pengepul
            // 
            tempat_pengepul.HeaderText = "Tempat Pengepul";
            tempat_pengepul.MinimumWidth = 6;
            tempat_pengepul.Name = "tempat_pengepul";
            tempat_pengepul.Width = 125;
            // 
            // admin
            // 
            admin.HeaderText = "Admin";
            admin.MinimumWidth = 6;
            admin.Name = "admin";
            admin.Width = 125;
            // 
            // customer
            // 
            customer.HeaderText = "Customer";
            customer.MinimumWidth = 6;
            customer.Name = "customer";
            customer.Width = 125;
            // 
            // Status_Transaksi
            // 
            Status_Transaksi.HeaderText = "Status";
            Status_Transaksi.MinimumWidth = 6;
            Status_Transaksi.Name = "Status_Transaksi";
            Status_Transaksi.Width = 125;
            // 
            // Jemput_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(dgvListPenjemputan);
            Controls.Add(btnTampil2);
            Controls.Add(btnTampil1);
            Controls.Add(cbSelesai);
            Controls.Add(btnSelesai);
            Controls.Add(cbKonfirmasi);
            Controls.Add(btnKembali);
            Controls.Add(btnKonfirmasi);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Jemput_Sampah";
            Text = "InTrash";
            Load += Jemput_Sampah_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPenjemputan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKembali;
        private Button btnKonfirmasi;
        private ComboBox cbKonfirmasi;
        private Button btnSelesai;
        private ComboBox cbSelesai;
        private Button btnTampil1;
        private Button btnTampil2;
        private DataGridView dgvListPenjemputan;
        private DataGridViewTextBoxColumn id_transaksi;
        private DataGridViewTextBoxColumn tanggal_transaksi;
        private DataGridViewTextBoxColumn tempat_pengepul;
        private DataGridViewTextBoxColumn admin;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn Status_Transaksi;
    }
}