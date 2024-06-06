namespace WinFormsApp1
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
            tbTahun = new TextBox();
            tbBulan = new TextBox();
            btnTahun = new Button();
            btnBulan = new Button();
            btnKembali = new Button();
            dgvRiwayatTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
            SuspendLayout();
            // 
            // tbTahun
            // 
            tbTahun.Location = new Point(265, 308);
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(166, 27);
            tbTahun.TabIndex = 35;
            // 
            // tbBulan
            // 
            tbBulan.Location = new Point(265, 264);
            tbBulan.Name = "tbBulan";
            tbBulan.Size = new Size(166, 27);
            tbBulan.TabIndex = 34;
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
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.BackgroundColor = Color.Gainsboro;
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Location = new Point(28, 21);
            dgvRiwayatTransaksi.Margin = new Padding(2);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 62;
            dgvRiwayatTransaksi.Size = new Size(583, 228);
            dgvRiwayatTransaksi.TabIndex = 30;
            // 
            // Riwayat_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(638, 357);
            Controls.Add(tbTahun);
            Controls.Add(tbBulan);
            Controls.Add(btnTahun);
            Controls.Add(btnBulan);
            Controls.Add(btnKembali);
            Controls.Add(dgvRiwayatTransaksi);
            Name = "Riwayat_Admin";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTahun;
        private TextBox tbBulan;
        private Button btnTahun;
        private Button btnBulan;
        private Button btnKembali;
        private DataGridView dgvRiwayatTransaksi;
    }
}