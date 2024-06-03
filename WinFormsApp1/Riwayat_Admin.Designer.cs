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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat_Admin));
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
            tbTahun.Location = new Point(331, 385);
            tbTahun.Margin = new Padding(4, 4, 4, 4);
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(206, 31);
            tbTahun.TabIndex = 35;
            // 
            // tbBulan
            // 
            tbBulan.Location = new Point(331, 330);
            tbBulan.Margin = new Padding(4, 4, 4, 4);
            tbBulan.Name = "tbBulan";
            tbBulan.Size = new Size(206, 31);
            tbBulan.TabIndex = 34;
            // 
            // btnTahun
            // 
            btnTahun.Location = new Point(558, 385);
            btnTahun.Margin = new Padding(2);
            btnTahun.Name = "btnTahun";
            btnTahun.Size = new Size(185, 34);
            btnTahun.TabIndex = 33;
            btnTahun.Text = "Riwayat per tahun";
            btnTahun.UseVisualStyleBackColor = true;
            // 
            // btnBulan
            // 
            btnBulan.Location = new Point(558, 330);
            btnBulan.Margin = new Padding(2);
            btnBulan.Name = "btnBulan";
            btnBulan.Size = new Size(185, 34);
            btnBulan.TabIndex = 32;
            btnBulan.Text = "Riwayat per bulan";
            btnBulan.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.MediumTurquoise;
            btnKembali.Location = new Point(35, 385);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 31;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.BackgroundColor = Color.CadetBlue;
            dgvRiwayatTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatTransaksi.Location = new Point(35, 26);
            dgvRiwayatTransaksi.Margin = new Padding(2);
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersWidth = 62;
            dgvRiwayatTransaksi.Size = new Size(729, 285);
            dgvRiwayatTransaksi.TabIndex = 30;
            // 
            // Riwayat_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(798, 446);
            Controls.Add(tbTahun);
            Controls.Add(tbBulan);
            Controls.Add(btnTahun);
            Controls.Add(btnBulan);
            Controls.Add(btnKembali);
            Controls.Add(dgvRiwayatTransaksi);
            Margin = new Padding(4, 4, 4, 4);
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