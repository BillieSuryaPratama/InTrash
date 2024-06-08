namespace WinFormsApp1
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
            btnKembali = new Button();
            btnBulan = new Button();
            btnTahun = new Button();
            tbBulan = new TextBox();
            tbTahun = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.BackgroundColor = Color.Gainsboro;
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Location = new Point(25, 23);
            dgvRiwayatTransaksi.Margin = new Padding(2);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 62;
            dgvRiwayatTransaksi.Size = new Size(583, 228);
            dgvRiwayatTransaksi.TabIndex = 0;
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
            // 
            // tbBulan
            // 
            tbBulan.Location = new Point(262, 266);
            tbBulan.Name = "tbBulan";
            tbBulan.Size = new Size(166, 27);
            tbBulan.TabIndex = 28;
            // 
            // tbTahun
            // 
            tbTahun.Location = new Point(262, 310);
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(166, 27);
            tbTahun.TabIndex = 29;
            // 
            // Riwayat_Nasbah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(640, 360);
            Controls.Add(tbTahun);
            Controls.Add(tbBulan);
            Controls.Add(btnTahun);
            Controls.Add(btnBulan);
            Controls.Add(btnKembali);
            Controls.Add(dgvRiwayatTransaksi);
            Margin = new Padding(2);
            Name = "Riwayat_Nasbah";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRiwayatTransaksi;
        private Button btnKembali;
        private Button btnBulan;
        private Button btnTahun;
        private TextBox tbBulan;
        private TextBox tbTahun;
    }
}