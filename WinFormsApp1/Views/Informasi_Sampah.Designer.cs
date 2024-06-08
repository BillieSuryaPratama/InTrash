namespace WinFormsApp1
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
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).BeginInit();
            SuspendLayout();
            // 
            // dgvInformasiSampah
            // 
            dgvInformasiSampah.BackgroundColor = Color.Gainsboro;
            dgvInformasiSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformasiSampah.Location = new Point(20, 15);
            dgvInformasiSampah.Margin = new Padding(2);
            dgvInformasiSampah.Name = "dgvInformasiSampah";
            dgvInformasiSampah.RowHeadersWidth = 62;
            dgvInformasiSampah.Size = new Size(518, 195);
            dgvInformasiSampah.TabIndex = 10;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(20, 235);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 24);
            btnKembali.TabIndex = 26;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // Informasi_Sampah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(560, 270);
            Controls.Add(btnKembali);
            Controls.Add(dgvInformasiSampah);
            Margin = new Padding(2);
            Name = "Informasi_Sampah";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvInformasiSampah;
        private Button btnKembali;
    }
}