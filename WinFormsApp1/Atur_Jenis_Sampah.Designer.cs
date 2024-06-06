namespace WinFormsApp1
{
    partial class Atur_Jenis_Sampah
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
            tbEdit = new TextBox();
            btnEditTambah = new Button();
            dgvListJenisSampah = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListJenisSampah).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(27, 256);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 36);
            btnKembali.TabIndex = 49;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // tbEdit
            // 
            tbEdit.Location = new Point(314, 263);
            tbEdit.Margin = new Padding(2, 3, 2, 3);
            tbEdit.Name = "tbEdit";
            tbEdit.Size = new Size(159, 27);
            tbEdit.TabIndex = 48;
            // 
            // btnEditTambah
            // 
            btnEditTambah.BackColor = Color.MediumTurquoise;
            btnEditTambah.BackgroundImage = Properties.Resources.Wireframe___56;
            btnEditTambah.Location = new Point(493, 261);
            btnEditTambah.Margin = new Padding(2, 3, 2, 3);
            btnEditTambah.Name = "btnEditTambah";
            btnEditTambah.Size = new Size(122, 31);
            btnEditTambah.TabIndex = 47;
            btnEditTambah.Text = "Edit / Tambah";
            btnEditTambah.UseVisualStyleBackColor = false;
            // 
            // dgvListJenisSampah
            // 
            dgvListJenisSampah.BackgroundColor = Color.Gainsboro;
            dgvListJenisSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListJenisSampah.Location = new Point(27, 11);
            dgvListJenisSampah.Margin = new Padding(2, 3, 2, 3);
            dgvListJenisSampah.Name = "dgvListJenisSampah";
            dgvListJenisSampah.RowHeadersWidth = 62;
            dgvListJenisSampah.Size = new Size(587, 225);
            dgvListJenisSampah.TabIndex = 46;
            // 
            // Atur_Jenis_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(637, 348);
            Controls.Add(btnKembali);
            Controls.Add(tbEdit);
            Controls.Add(btnEditTambah);
            Controls.Add(dgvListJenisSampah);
            Name = "Atur_Jenis_Sampah";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvListJenisSampah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private TextBox tbEdit;
        private Button btnEditTambah;
        private DataGridView dgvListJenisSampah;
    }
}