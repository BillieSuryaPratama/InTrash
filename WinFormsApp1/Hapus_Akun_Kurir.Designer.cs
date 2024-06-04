namespace WinFormsApp1
{
    partial class Hapus_Akun_Kurir
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
            dgvListKurir = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbSandi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).BeginInit();
            SuspendLayout();
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(452, 222);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(82, 29);
            btnKonfirmasi.TabIndex = 50;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(33, 223);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 32);
            btnKembali.TabIndex = 49;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // tbID
            // 
            tbID.Location = new Point(258, 188);
            tbID.Margin = new Padding(2);
            tbID.Name = "tbID";
            tbID.Size = new Size(146, 23);
            tbID.TabIndex = 48;
            // 
            // dgvListKurir
            // 
            dgvListKurir.BackgroundColor = Color.Gainsboro;
            dgvListKurir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListKurir.Location = new Point(31, 6);
            dgvListKurir.Margin = new Padding(2);
            dgvListKurir.Name = "dgvListKurir";
            dgvListKurir.RowHeadersWidth = 62;
            dgvListKurir.Size = new Size(503, 169);
            dgvListKurir.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 190);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 51;
            label1.Text = "ID Kurir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(187, 213);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 52;
            label2.Text = "Sandi Kurir";
            // 
            // tbSandi
            // 
            tbSandi.Location = new Point(258, 211);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(146, 23);
            tbSandi.TabIndex = 53;
            // 
            // Hapus_Akun_Kurir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(557, 260);
            Controls.Add(tbSandi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Controls.Add(tbID);
            Controls.Add(dgvListKurir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Hapus_Akun_Kurir";
            Text = "Hapus_Akun_Kurir";
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKonfirmasi;
        private Button btnKembali;
        private TextBox tbID;
        private DataGridView dgvListKurir;
        private Label label1;
        private Label label2;
        private TextBox tbSandi;
    }
}