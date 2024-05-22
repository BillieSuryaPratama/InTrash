namespace WinFormsApp1
{
    partial class Konfirmasi_Jemput_Sampah
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblNama = new Label();
            lblAlamat = new Label();
            lblDeskripsi = new Label();
            lblMetodePencairan = new Label();
            label2 = new Label();
            btnKembali = new Button();
            btnKonfirmasi = new Button();
            label10 = new Label();
            dgvListSampah = new DataGridView();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListSampah).BeginInit();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(219, 14);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 20);
            lblNama.TabIndex = 64;
            lblNama.Text = "dummy";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(219, 43);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(59, 20);
            lblAlamat.TabIndex = 63;
            lblAlamat.Text = "dummy";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(219, 74);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(59, 20);
            lblDeskripsi.TabIndex = 62;
            lblDeskripsi.Text = "dummy";
            // 
            // lblMetodePencairan
            // 
            lblMetodePencairan.AutoSize = true;
            lblMetodePencairan.Location = new Point(219, 107);
            lblMetodePencairan.Name = "lblMetodePencairan";
            lblMetodePencairan.Size = new Size(59, 20);
            lblMetodePencairan.TabIndex = 61;
            lblMetodePencairan.Text = "dummy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 146);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 60;
            label2.Text = "List Sampah";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(11, 319);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 53;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(541, 318);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(89, 27);
            btnKonfirmasi.TabIndex = 59;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(59, 74);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 58;
            label10.Text = "Deskripsi";
            // 
            // dgvListSampah
            // 
            dgvListSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListSampah.Location = new Point(59, 168);
            dgvListSampah.Margin = new Padding(2);
            dgvListSampah.Name = "dgvListSampah";
            dgvListSampah.RowHeadersWidth = 62;
            dgvListSampah.Size = new Size(530, 120);
            dgvListSampah.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 107);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 56;
            label8.Text = "Metode Pencairan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 43);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 55;
            label6.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 43);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 52;
            label1.Text = "Nama";
            // 
            // Konfirmasi_Jemput_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblNama);
            Controls.Add(lblAlamat);
            Controls.Add(lblDeskripsi);
            Controls.Add(lblMetodePencairan);
            Controls.Add(label2);
            Controls.Add(btnKembali);
            Controls.Add(btnKonfirmasi);
            Controls.Add(label10);
            Controls.Add(dgvListSampah);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Konfirmasi_Jemput_Sampah";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvListSampah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblNama;
        private Label lblAlamat;
        private Label lblDeskripsi;
        private Label lblMetodePencairan;
        private Label label2;
        private Button btnKembali;
        private Button btnKonfirmasi;
        private Label label10;
        private DataGridView dgvListSampah;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label1;
    }
}