namespace WinFormsApp1.Views
{
    partial class Informasi_Sampah
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
            dgvInformasiSampah = new DataGridView();
            NamaSampah = new DataGridViewTextBoxColumn();
            HargaperKG = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).BeginInit();
            SuspendLayout();
            // 
            // dgvInformasiSampah
            // 
            dgvInformasiSampah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformasiSampah.BackgroundColor = Color.Gainsboro;
            dgvInformasiSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformasiSampah.Columns.AddRange(new DataGridViewColumn[] { NamaSampah, HargaperKG, Deskripsi });
            dgvInformasiSampah.Location = new Point(23, 20);
            dgvInformasiSampah.Margin = new Padding(2, 3, 2, 3);
            dgvInformasiSampah.Name = "dgvInformasiSampah";
            dgvInformasiSampah.RowHeadersWidth = 62;
            dgvInformasiSampah.Size = new Size(592, 260);
            dgvInformasiSampah.TabIndex = 10;
            dgvInformasiSampah.CellContentClick += dgvInformasiSampah_CellContentClick;
            // 
            // NamaSampah
            // 
            NamaSampah.HeaderText = "Nama";
            NamaSampah.MinimumWidth = 6;
            NamaSampah.Name = "NamaSampah";
            // 
            // HargaperKG
            // 
            HargaperKG.HeaderText = "Harga per KG";
            HargaperKG.MinimumWidth = 6;
            HargaperKG.Name = "HargaperKG";
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(23, 313);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 32);
            btnKembali.TabIndex = 26;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // Informasi_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(btnKembali);
            Controls.Add(dgvInformasiSampah);
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(658, 407);
            Name = "Informasi_Sampah";
            Text = "InTrash";
            Load += Informasi_Sampah_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvInformasiSampah;
        private Button btnKembali;
        private DataGridViewTextBoxColumn NamaSampah;
        private DataGridViewTextBoxColumn HargaperKG;
        private DataGridViewTextBoxColumn Deskripsi;
    }
}