namespace WinFormsApp1.Views
{
    partial class Riwayat_Admin
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
            btnTahun = new Button();
            btnBulan = new Button();
            btnKembali = new Button();
            dgvRiwayatTransaksi = new DataGridView();
            id_transaksi = new DataGridViewTextBoxColumn();
            tanggal_transaksi = new DataGridViewTextBoxColumn();
            tempat_pengepul = new DataGridViewTextBoxColumn();
            admin = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            Status_Transaksi = new DataGridViewTextBoxColumn();
            cbPerBulan = new ComboBox();
            cbPerTahun = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
            SuspendLayout();
            // 
            // btnTahun
            // 
            btnTahun.BackgroundImage = Properties.Resources.Wireframe___56;
            btnTahun.Location = new Point(446, 308);
            btnTahun.Margin = new Padding(2);
            btnTahun.Name = "btnTahun";
            btnTahun.Size = new Size(148, 27);
            btnTahun.TabIndex = 33;
            btnTahun.Text = "Riwayat per tahun";
            btnTahun.UseVisualStyleBackColor = true;
            btnTahun.Click += btnTahun_Click;
            // 
            // btnBulan
            // 
            btnBulan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnBulan.Location = new Point(446, 264);
            btnBulan.Margin = new Padding(2);
            btnBulan.Name = "btnBulan";
            btnBulan.Size = new Size(148, 27);
            btnBulan.TabIndex = 32;
            btnBulan.Text = "Riwayat per bulan";
            btnBulan.UseVisualStyleBackColor = true;
            btnBulan.Click += btnBulan_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.Location = new Point(28, 308);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 31;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.BackgroundColor = Color.Gainsboro;
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Columns.AddRange(new DataGridViewColumn[] { id_transaksi, tanggal_transaksi, tempat_pengepul, admin, customer, Status_Transaksi });
            dgvRiwayatTransaksi.Location = new Point(28, 21);
            dgvRiwayatTransaksi.Margin = new Padding(2);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 62;
            dgvRiwayatTransaksi.Size = new Size(583, 228);
            dgvRiwayatTransaksi.TabIndex = 30;
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
            // cbPerBulan
            // 
            cbPerBulan.FormattingEnabled = true;
            cbPerBulan.Location = new Point(265, 264);
            cbPerBulan.Name = "cbPerBulan";
            cbPerBulan.Size = new Size(166, 28);
            cbPerBulan.TabIndex = 36;
            // 
            // cbPerTahun
            // 
            cbPerTahun.FormattingEnabled = true;
            cbPerTahun.Location = new Point(265, 308);
            cbPerTahun.Name = "cbPerTahun";
            cbPerTahun.Size = new Size(166, 28);
            cbPerTahun.TabIndex = 37;
            // 
            // Riwayat_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(638, 357);
            Controls.Add(cbPerTahun);
            Controls.Add(cbPerBulan);
            Controls.Add(btnTahun);
            Controls.Add(btnBulan);
            Controls.Add(btnKembali);
            Controls.Add(dgvRiwayatTransaksi);
            Name = "Riwayat_Admin";
            Text = "InTrash";
            Load += Riwayat_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTahun;
        private Button btnBulan;
        private Button btnKembali;
        private DataGridView dgvRiwayatTransaksi;
        private ComboBox cbPerBulan;
        private ComboBox cbPerTahun;
        private DataGridViewTextBoxColumn id_transaksi;
        private DataGridViewTextBoxColumn tanggal_transaksi;
        private DataGridViewTextBoxColumn tempat_pengepul;
        private DataGridViewTextBoxColumn admin;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn Status_Transaksi;
    }
}