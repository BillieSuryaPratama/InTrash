namespace WinFormsApp1.Views
{
    partial class Konfirmasi_Jemput_Sampah
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblNama = new Label();
            label2 = new Label();
            btnKembali = new Button();
            btnKonfirmasi = new Button();
            label4 = new Label();
            label1 = new Label();
            lblAlamatBankSampah = new Label();
            label6 = new Label();
            label10 = new Label();
            tbImbalan = new TextBox();
            lblBankSampah = new Label();
            label5 = new Label();
            dgvListSampah = new DataGridView();
            JenisSampah = new DataGridViewTextBoxColumn();
            Bobot = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListSampah).BeginInit();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.Transparent;
            lblNama.ForeColor = Color.White;
            lblNama.Location = new Point(219, 13);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 20);
            lblNama.TabIndex = 64;
            lblNama.Text = "dummy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 147);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 60;
            label2.Text = "List Sampah";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(23, 313);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 32);
            btnKembali.TabIndex = 53;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(529, 313);
            btnKonfirmasi.Margin = new Padding(2, 3, 2, 3);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(89, 31);
            btnKonfirmasi.TabIndex = 59;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 83);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 52;
            label1.Text = "Nama";
            // 
            // lblAlamatBankSampah
            // 
            lblAlamatBankSampah.AutoSize = true;
            lblAlamatBankSampah.BackColor = Color.Transparent;
            lblAlamatBankSampah.ForeColor = Color.White;
            lblAlamatBankSampah.Location = new Point(219, 83);
            lblAlamatBankSampah.Name = "lblAlamatBankSampah";
            lblAlamatBankSampah.Size = new Size(59, 20);
            lblAlamatBankSampah.TabIndex = 63;
            lblAlamatBankSampah.Text = "dummy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 83);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 55;
            label6.Text = "Alamat Bank Sampah";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.White;
            label10.Location = new Point(59, 115);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 58;
            label10.Text = "Jumlah Imbalan";
            // 
            // tbImbalan
            // 
            tbImbalan.Location = new Point(219, 112);
            tbImbalan.Name = "tbImbalan";
            tbImbalan.Size = new Size(125, 27);
            tbImbalan.TabIndex = 65;
            // 
            // lblBankSampah
            // 
            lblBankSampah.AutoSize = true;
            lblBankSampah.BackColor = Color.Transparent;
            lblBankSampah.ForeColor = Color.White;
            lblBankSampah.Location = new Point(219, 49);
            lblBankSampah.Name = "lblBankSampah";
            lblBankSampah.Size = new Size(59, 20);
            lblBankSampah.TabIndex = 67;
            lblBankSampah.Text = "dummy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 49);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 66;
            label5.Text = "Nama Bank Sampah";
            // 
            // dgvListSampah
            // 
            dgvListSampah.Anchor = AnchorStyles.None;
            dgvListSampah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListSampah.BackgroundColor = Color.Gainsboro;
            dgvListSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListSampah.Columns.AddRange(new DataGridViewColumn[] { JenisSampah, Bobot });
            dgvListSampah.Location = new Point(59, 179);
            dgvListSampah.Margin = new Padding(2);
            dgvListSampah.Name = "dgvListSampah";
            dgvListSampah.RowHeadersWidth = 62;
            dgvListSampah.Size = new Size(500, 120);
            dgvListSampah.TabIndex = 68;
            // 
            // JenisSampah
            // 
            JenisSampah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            JenisSampah.HeaderText = "Jenis Sampah";
            JenisSampah.MinimumWidth = 6;
            JenisSampah.Name = "JenisSampah";
            JenisSampah.ReadOnly = true;
            // 
            // Bobot
            // 
            Bobot.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Bobot.HeaderText = "Bobot";
            Bobot.MinimumWidth = 6;
            Bobot.Name = "Bobot";
            Bobot.ReadOnly = true;
            // 
            // Konfirmasi_Jemput_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(dgvListSampah);
            Controls.Add(lblBankSampah);
            Controls.Add(label5);
            Controls.Add(tbImbalan);
            Controls.Add(lblNama);
            Controls.Add(lblAlamatBankSampah);
            Controls.Add(label2);
            Controls.Add(btnKembali);
            Controls.Add(btnKonfirmasi);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Konfirmasi_Jemput_Sampah";
            Text = "InTrash";
            Load += Konfirmasi_Jemput_Sampah_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListSampah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblNama;
        private Label label2;
        private Button btnKembali;
        private Button btnKonfirmasi;
        private Label label4;
        private Label label1;
        private Label lblAlamatBankSampah;
        private Label label6;
        private Label label10;
        private TextBox tbImbalan;
        private Label lblBankSampah;
        private Label label5;
        private DataGridView dgvListSampah;
        private DataGridViewTextBoxColumn JenisSampah;
        private DataGridViewTextBoxColumn Bobot;
    }
}