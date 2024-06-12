namespace WinFormsApp1.Views
{
    partial class Riwayat_Nasbah
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
            dgvRiwayatTransaksi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnKembali = new Button();
            btnBulan = new Button();
            btnTahun = new Button();
            cbPerBulan = new ComboBox();
            cbPerTahun = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.BackgroundColor = Color.Gainsboro;
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvRiwayatTransaksi.Location = new Point(25, 23);
            dgvRiwayatTransaksi.Margin = new Padding(2);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 62;
            dgvRiwayatTransaksi.Size = new Size(583, 228);
            dgvRiwayatTransaksi.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Transaksi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tanggal Transaksi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Jumlah Imbalan";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Nama Tempat Pengepul";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status Transaksi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(25, 310);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 25;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnBulan
            // 
            btnBulan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnBulan.Location = new Point(443, 266);
            btnBulan.Margin = new Padding(2);
            btnBulan.Name = "btnBulan";
            btnBulan.Size = new Size(148, 27);
            btnBulan.TabIndex = 26;
            btnBulan.Text = "Riwayat per bulan";
            btnBulan.UseVisualStyleBackColor = true;
            btnBulan.Click += btnBulan_Click;
            // 
            // btnTahun
            // 
            btnTahun.BackgroundImage = Properties.Resources.Wireframe___56;
            btnTahun.Location = new Point(443, 310);
            btnTahun.Margin = new Padding(2);
            btnTahun.Name = "btnTahun";
            btnTahun.Size = new Size(148, 27);
            btnTahun.TabIndex = 27;
            btnTahun.Text = "Riwayat per tahun";
            btnTahun.UseVisualStyleBackColor = true;
            btnTahun.Click += btnTahun_Click;
            // 
            // cbPerBulan
            // 
            cbPerBulan.FormattingEnabled = true;
            cbPerBulan.Location = new Point(276, 266);
            cbPerBulan.Name = "cbPerBulan";
            cbPerBulan.Size = new Size(151, 28);
            cbPerBulan.TabIndex = 28;
            // 
            // cbPerTahun
            // 
            cbPerTahun.FormattingEnabled = true;
            cbPerTahun.Location = new Point(276, 309);
            cbPerTahun.Name = "cbPerTahun";
            cbPerTahun.Size = new Size(151, 28);
            cbPerTahun.TabIndex = 29;
            // 
            // Riwayat_Nasbah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(640, 360);
            Controls.Add(cbPerTahun);
            Controls.Add(cbPerBulan);
            Controls.Add(btnTahun);
            Controls.Add(btnBulan);
            Controls.Add(btnKembali);
            Controls.Add(dgvRiwayatTransaksi);
            Margin = new Padding(2);
            Name = "Riwayat_Nasbah";
            Text = "InTrash";
            Load += Riwayat_Nasbah_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRiwayatTransaksi;
        private Button btnKembali;
        private Button btnBulan;
        private Button btnTahun;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox cbPerBulan;
        private ComboBox cbPerTahun;
    }
}