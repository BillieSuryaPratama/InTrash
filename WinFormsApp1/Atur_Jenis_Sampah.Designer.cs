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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atur_Jenis_Sampah));
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
            btnKembali.Location = new Point(24, 220);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 27);
            btnKembali.TabIndex = 49;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // tbEdit
            // 
            tbEdit.Location = new Point(275, 194);
            tbEdit.Margin = new Padding(2);
            tbEdit.Name = "tbEdit";
            tbEdit.Size = new Size(140, 23);
            tbEdit.TabIndex = 48;
            // 
            // btnEditTambah
            // 
            btnEditTambah.BackColor = Color.Black;
            btnEditTambah.BackgroundImage = (Image)resources.GetObject("btnEditTambah.BackgroundImage");
            btnEditTambah.Location = new Point(431, 194);
            btnEditTambah.Margin = new Padding(2);
            btnEditTambah.Name = "btnEditTambah";
            btnEditTambah.Size = new Size(107, 23);
            btnEditTambah.TabIndex = 47;
            btnEditTambah.Text = "Edit / Tambah";
            btnEditTambah.UseVisualStyleBackColor = false;
            // 
            // dgvListJenisSampah
            // 
            dgvListJenisSampah.BackgroundColor = Color.Gainsboro;
            dgvListJenisSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListJenisSampah.Location = new Point(24, 8);
            dgvListJenisSampah.Margin = new Padding(2);
            dgvListJenisSampah.Name = "dgvListJenisSampah";
            dgvListJenisSampah.RowHeadersWidth = 62;
            dgvListJenisSampah.Size = new Size(514, 169);
            dgvListJenisSampah.TabIndex = 46;
            // 
            // Atur_Jenis_Sampah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55__1_;
            ClientSize = new Size(557, 261);
            Controls.Add(btnKembali);
            Controls.Add(tbEdit);
            Controls.Add(btnEditTambah);
            Controls.Add(dgvListJenisSampah);
            Margin = new Padding(3, 2, 3, 2);
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