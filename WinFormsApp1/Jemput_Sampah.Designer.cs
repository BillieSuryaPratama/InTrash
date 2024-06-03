namespace WinFormsApp1
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
            tbKonfirmasi = new TextBox();
            btnKonfirmasi = new Button();
            dgvListPenjemputan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListPenjemputan).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(20, 235);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 24);
            btnKembali.TabIndex = 39;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // tbKonfirmasi
            // 
            tbKonfirmasi.Location = new Point(290, 200);
            tbKonfirmasi.Margin = new Padding(2);
            tbKonfirmasi.Name = "tbKonfirmasi";
            tbKonfirmasi.Size = new Size(146, 23);
            tbKonfirmasi.TabIndex = 38;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(453, 200);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(79, 23);
            btnKonfirmasi.TabIndex = 37;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // dgvListPenjemputan
            // 
            dgvListPenjemputan.BackgroundColor = Color.Gainsboro;
            dgvListPenjemputan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPenjemputan.Location = new Point(29, 15);
            dgvListPenjemputan.Margin = new Padding(2);
            dgvListPenjemputan.Name = "dgvListPenjemputan";
            dgvListPenjemputan.RowHeadersWidth = 62;
            dgvListPenjemputan.Size = new Size(503, 169);
            dgvListPenjemputan.TabIndex = 36;
            // 
            // Jemput_Sampah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(560, 270);
            Controls.Add(btnKembali);
            Controls.Add(tbKonfirmasi);
            Controls.Add(btnKonfirmasi);
            Controls.Add(dgvListPenjemputan);
            Margin = new Padding(2);
            Name = "Jemput_Sampah";
            Text = "InTrash";
            Load += Form16_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPenjemputan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private TextBox tbKonfirmasi;
        private Button btnKonfirmasi;
        private DataGridView dgvListPenjemputan;
    }
}