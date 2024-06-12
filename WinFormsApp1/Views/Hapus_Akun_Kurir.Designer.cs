namespace WinFormsApp1.Views
{
    partial class InTrash
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
            btnKonfirmasi = new Button();
            btnKembali = new Button();
            tbID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSandi = new TextBox();
            dgvHapusKurir = new DataGridView();
            id_kurir = new DataGridViewTextBoxColumn();
            nama_kurir = new DataGridViewTextBoxColumn();
            username_kurir = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            noHP = new DataGridViewTextBoxColumn();
            tempatpengepul = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHapusKurir).BeginInit();
            SuspendLayout();
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(517, 296);
            btnKonfirmasi.Margin = new Padding(2, 3, 2, 3);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(94, 39);
            btnKonfirmasi.TabIndex = 50;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(38, 297);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 43);
            btnKembali.TabIndex = 49;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(295, 251);
            tbID.Margin = new Padding(2, 3, 2, 3);
            tbID.Name = "tbID";
            tbID.Size = new Size(166, 27);
            tbID.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 253);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 51;
            label1.Text = "ID Kurir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(214, 284);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 52;
            label2.Text = "Sandi Kurir";
            // 
            // tbSandi
            // 
            tbSandi.Location = new Point(295, 281);
            tbSandi.Margin = new Padding(2, 3, 2, 3);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(166, 27);
            tbSandi.TabIndex = 53;
            // 
            // dgvHapusKurir
            // 
            dgvHapusKurir.BackgroundColor = Color.Gainsboro;
            dgvHapusKurir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHapusKurir.Columns.AddRange(new DataGridViewColumn[] { id_kurir, nama_kurir, username_kurir, password, noHP, tempatpengepul });
            dgvHapusKurir.Location = new Point(36, 11);
            dgvHapusKurir.Margin = new Padding(2);
            dgvHapusKurir.Name = "dgvHapusKurir";
            dgvHapusKurir.RowHeadersWidth = 62;
            dgvHapusKurir.Size = new Size(575, 225);
            dgvHapusKurir.TabIndex = 54;
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
            // InTrash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(637, 347);
            Controls.Add(dgvHapusKurir);
            Controls.Add(tbSandi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Controls.Add(tbID);
            Name = "InTrash";
            Text = "InTrash";
            Load += InTrash_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHapusKurir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKonfirmasi;
        private Button btnKembali;
        private TextBox tbID;
        private Label label1;
        private Label label2;
        private TextBox tbSandi;
        private DataGridView dgvHapusKurir;
        private DataGridViewTextBoxColumn id_kurir;
        private DataGridViewTextBoxColumn nama_kurir;
        private DataGridViewTextBoxColumn username_kurir;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn noHP;
        private DataGridViewTextBoxColumn tempatpengepul;
    }
}