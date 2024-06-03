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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat_Nasbah));
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
            dgvRiwayatTransaksi.BackgroundColor = Color.DarkSlateGray;
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Location = new Point(31, 29);
            dgvRiwayatTransaksi.Margin = new Padding(2);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 62;
            dgvRiwayatTransaksi.Size = new Size(729, 285);
            dgvRiwayatTransaksi.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.DarkCyan;
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(31, 388);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 25;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // btnBulan
            // 
            btnBulan.Location = new Point(554, 332);
            btnBulan.Margin = new Padding(2);
            btnBulan.Name = "btnBulan";
            btnBulan.Size = new Size(185, 34);
            btnBulan.TabIndex = 26;
            btnBulan.Text = "Riwayat per bulan";
            btnBulan.UseVisualStyleBackColor = true;
            // 
            // btnTahun
            // 
            btnTahun.Location = new Point(554, 388);
            btnTahun.Margin = new Padding(2);
            btnTahun.Name = "btnTahun";
            btnTahun.Size = new Size(185, 34);
            btnTahun.TabIndex = 27;
            btnTahun.Text = "Riwayat per tahun";
            btnTahun.UseVisualStyleBackColor = true;
            // 
            // tbBulan
            // 
            tbBulan.Location = new Point(328, 332);
            tbBulan.Margin = new Padding(4, 4, 4, 4);
            tbBulan.Name = "tbBulan";
            tbBulan.Size = new Size(206, 31);
            tbBulan.TabIndex = 28;
            // 
            // tbTahun
            // 
            tbTahun.Location = new Point(328, 388);
            tbTahun.Margin = new Padding(4, 4, 4, 4);
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(206, 31);
            tbTahun.TabIndex = 29;
            // 
            // Riwayat_Nasbah
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
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