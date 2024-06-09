namespace WinFormsApp1.Views
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
            btnKembali.Location = new Point(23, 313);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 32);
            btnKembali.TabIndex = 39;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // tbKonfirmasi
            // 
            tbKonfirmasi.Location = new Point(331, 267);
            tbKonfirmasi.Margin = new Padding(2, 3, 2, 3);
            tbKonfirmasi.Name = "tbKonfirmasi";
            tbKonfirmasi.Size = new Size(166, 27);
            tbKonfirmasi.TabIndex = 38;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(518, 267);
            btnKonfirmasi.Margin = new Padding(2, 3, 2, 3);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(90, 31);
            btnKonfirmasi.TabIndex = 37;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // dgvListPenjemputan
            // 
            dgvListPenjemputan.BackgroundColor = Color.Gainsboro;
            dgvListPenjemputan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPenjemputan.Location = new Point(33, 20);
            dgvListPenjemputan.Margin = new Padding(2, 3, 2, 3);
            dgvListPenjemputan.Name = "dgvListPenjemputan";
            dgvListPenjemputan.RowHeadersWidth = 62;
            dgvListPenjemputan.Size = new Size(575, 225);
            dgvListPenjemputan.TabIndex = 36;
            // 
            // Jemput_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(btnKembali);
            Controls.Add(tbKonfirmasi);
            Controls.Add(btnKonfirmasi);
            Controls.Add(dgvListPenjemputan);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Jemput_Sampah";
            Text = "InTrash";
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