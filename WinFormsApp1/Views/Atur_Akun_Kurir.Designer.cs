namespace WinFormsApp1.Views
{
    partial class Atur_Akun_Kurir
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
            btnEditAkun = new Button();
            dgvListKurir = new DataGridView();
            id_kurir = new DataGridViewTextBoxColumn();
            nama_kurir = new DataGridViewTextBoxColumn();
            username_kurir = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            noHP = new DataGridViewTextBoxColumn();
            tempatpengepul = new DataGridViewTextBoxColumn();
            btnHapusAkun = new Button();
            cbEdit = new ComboBox();
            cbHapus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(32, 248);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 37);
            btnKembali.TabIndex = 43;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnEditAkun
            // 
            btnEditAkun.BackColor = Color.MediumTurquoise;
            btnEditAkun.BackgroundImage = Properties.Resources.Wireframe___56;
            btnEditAkun.ForeColor = Color.Black;
            btnEditAkun.Location = new Point(502, 258);
            btnEditAkun.Margin = new Padding(2);
            btnEditAkun.Name = "btnEditAkun";
            btnEditAkun.Size = new Size(106, 27);
            btnEditAkun.TabIndex = 41;
            btnEditAkun.Text = "Edit Akun";
            btnEditAkun.UseVisualStyleBackColor = false;
            btnEditAkun.Click += btnEditAkun_Click;
            // 
            // dgvListKurir
            // 
            dgvListKurir.BackgroundColor = Color.Gainsboro;
            dgvListKurir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListKurir.Columns.AddRange(new DataGridViewColumn[] { id_kurir, nama_kurir, username_kurir, password, noHP, tempatpengepul });
            dgvListKurir.Location = new Point(33, 11);
            dgvListKurir.Margin = new Padding(2);
            dgvListKurir.Name = "dgvListKurir";
            dgvListKurir.RowHeadersWidth = 62;
            dgvListKurir.Size = new Size(575, 225);
            dgvListKurir.TabIndex = 40;
            // 
            // id_kurir
            // 
            id_kurir.HeaderText = "ID";
            id_kurir.MinimumWidth = 6;
            id_kurir.Name = "id_kurir";
            id_kurir.Width = 40;
            // 
            // nama_kurir
            // 
            nama_kurir.HeaderText = "Nama";
            nama_kurir.MinimumWidth = 6;
            nama_kurir.Name = "nama_kurir";
            nama_kurir.Width = 125;
            // 
            // username_kurir
            // 
            username_kurir.HeaderText = "Username";
            username_kurir.MinimumWidth = 6;
            username_kurir.Name = "username_kurir";
            username_kurir.Width = 125;
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // noHP
            // 
            noHP.HeaderText = "Nomor HP";
            noHP.MinimumWidth = 6;
            noHP.Name = "noHP";
            noHP.Width = 125;
            // 
            // tempatpengepul
            // 
            tempatpengepul.HeaderText = "Tempat Pengepul";
            tempatpengepul.MinimumWidth = 6;
            tempatpengepul.Name = "tempatpengepul";
            tempatpengepul.Width = 150;
            // 
            // btnHapusAkun
            // 
            btnHapusAkun.BackColor = Color.MediumTurquoise;
            btnHapusAkun.BackgroundImage = Properties.Resources.Wireframe___56;
            btnHapusAkun.Location = new Point(502, 299);
            btnHapusAkun.Margin = new Padding(2);
            btnHapusAkun.Name = "btnHapusAkun";
            btnHapusAkun.Size = new Size(106, 27);
            btnHapusAkun.TabIndex = 45;
            btnHapusAkun.Text = "Hapus Akun";
            btnHapusAkun.UseVisualStyleBackColor = false;
            btnHapusAkun.Click += btnHapusAkun_Click;
            // 
            // cbEdit
            // 
            cbEdit.FormattingEnabled = true;
            cbEdit.Location = new Point(434, 258);
            cbEdit.Name = "cbEdit";
            cbEdit.Size = new Size(63, 28);
            cbEdit.TabIndex = 46;
            // 
            // cbHapus
            // 
            cbHapus.FormattingEnabled = true;
            cbHapus.Location = new Point(434, 298);
            cbHapus.Name = "cbHapus";
            cbHapus.Size = new Size(63, 28);
            cbHapus.TabIndex = 47;
            // 
            // Atur_Akun_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(637, 350);
            Controls.Add(cbHapus);
            Controls.Add(cbEdit);
            Controls.Add(btnHapusAkun);
            Controls.Add(btnKembali);
            Controls.Add(btnEditAkun);
            Controls.Add(dgvListKurir);
            Name = "Atur_Akun_Kurir";
            Text = "InTrash";
            Load += Atur_Akun_Kurir_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKembali;
        private Button btnEditAkun;
        private DataGridView dgvListKurir;
        private Button btnHapusAkun;
        private ComboBox cbEdit;
        private ComboBox cbHapus;
        private DataGridViewTextBoxColumn id_kurir;
        private DataGridViewTextBoxColumn nama_kurir;
        private DataGridViewTextBoxColumn username_kurir;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn noHP;
        private DataGridViewTextBoxColumn tempatpengepul;
    }
}