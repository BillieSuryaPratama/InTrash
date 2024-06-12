namespace WinFormsApp1.Views
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
            btnEdit = new Button();
            dgvListJenisSampah = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            jenis_sampah = new DataGridViewTextBoxColumn();
            harga_per_kilo = new DataGridViewTextBoxColumn();
            deskripsi = new DataGridViewTextBoxColumn();
            btnTambah = new Button();
            cbEdit = new ComboBox();
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
            btnKembali.Click += btnKembali_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MediumTurquoise;
            btnEdit.BackgroundImage = Properties.Resources.Wireframe___56;
            btnEdit.Location = new Point(493, 261);
            btnEdit.Margin = new Padding(2, 3, 2, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(122, 31);
            btnEdit.TabIndex = 47;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvListJenisSampah
            // 
            dgvListJenisSampah.BackgroundColor = Color.Gainsboro;
            dgvListJenisSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListJenisSampah.Columns.AddRange(new DataGridViewColumn[] { ID, jenis_sampah, harga_per_kilo, deskripsi });
            dgvListJenisSampah.Location = new Point(27, 11);
            dgvListJenisSampah.Margin = new Padding(2, 3, 2, 3);
            dgvListJenisSampah.Name = "dgvListJenisSampah";
            dgvListJenisSampah.RowHeadersWidth = 62;
            dgvListJenisSampah.Size = new Size(587, 225);
            dgvListJenisSampah.TabIndex = 46;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 40;
            // 
            // jenis_sampah
            // 
            jenis_sampah.HeaderText = "Jenis Sampah";
            jenis_sampah.MinimumWidth = 6;
            jenis_sampah.Name = "jenis_sampah";
            jenis_sampah.Width = 125;
            // 
            // harga_per_kilo
            // 
            harga_per_kilo.HeaderText = "Harga / Kilo";
            harga_per_kilo.MinimumWidth = 6;
            harga_per_kilo.Name = "harga_per_kilo";
            harga_per_kilo.Width = 125;
            // 
            // deskripsi
            // 
            deskripsi.HeaderText = "Deskripsi";
            deskripsi.MinimumWidth = 6;
            deskripsi.Name = "deskripsi";
            deskripsi.Width = 300;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.MediumTurquoise;
            btnTambah.BackgroundImage = Properties.Resources.Wireframe___56;
            btnTambah.Location = new Point(493, 307);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(121, 29);
            btnTambah.TabIndex = 50;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // cbEdit
            // 
            cbEdit.FormattingEnabled = true;
            cbEdit.Location = new Point(412, 261);
            cbEdit.Name = "cbEdit";
            cbEdit.Size = new Size(76, 28);
            cbEdit.TabIndex = 51;
            // 
            // Atur_Jenis_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(637, 348);
            Controls.Add(cbEdit);
            Controls.Add(btnTambah);
            Controls.Add(btnKembali);
            Controls.Add(btnEdit);
            Controls.Add(dgvListJenisSampah);
            Name = "Atur_Jenis_Sampah";
            Text = "InTrash";
            Load += Atur_Jenis_Sampah_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListJenisSampah).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKembali;
        private Button btnEdit;
        private DataGridView dgvListJenisSampah;
        private Button btnTambah;
        private ComboBox cbEdit;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn jenis_sampah;
        private DataGridViewTextBoxColumn harga_per_kilo;
        private DataGridViewTextBoxColumn deskripsi;
    }
}