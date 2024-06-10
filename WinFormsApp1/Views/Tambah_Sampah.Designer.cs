namespace WinFormsApp1.Views
{
    partial class Tambah_Sampah
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
            btnSimpan = new Button();
            btnKembali = new Button();
            tbKuantitas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbSatuan = new ComboBox();
            cbJenisSampah = new ComboBox();
            lblInstruksi = new Label();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Font = new Font("Palatino Linotype", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(677, 388);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.Font = new Font("Palatino Linotype", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(37, 388);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // tbKuantitas
            // 
            tbKuantitas.Location = new Point(374, 241);
            tbKuantitas.Margin = new Padding(2);
            tbKuantitas.Name = "tbKuantitas";
            tbKuantitas.Size = new Size(150, 34);
            tbKuantitas.TabIndex = 3;
            tbKuantitas.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(230, 197);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 4;
            label1.Text = "Jenis Sampah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(239, 241);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 5;
            label2.Text = "Kuantitas";
            // 
            // cbSatuan
            // 
            cbSatuan.FormattingEnabled = true;
            cbSatuan.Location = new Point(531, 241);
            cbSatuan.Margin = new Padding(4);
            cbSatuan.Name = "cbSatuan";
            cbSatuan.Size = new Size(100, 35);
            cbSatuan.TabIndex = 6;
            // 
            // cbJenisSampah
            // 
            cbJenisSampah.FormattingEnabled = true;
            cbJenisSampah.Location = new Point(374, 190);
            cbJenisSampah.Margin = new Padding(4);
            cbJenisSampah.Name = "cbJenisSampah";
            cbJenisSampah.Size = new Size(150, 35);
            cbJenisSampah.TabIndex = 7;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruksi.ForeColor = Color.Transparent;
            lblInstruksi.Location = new Point(100, 129);
            lblInstruksi.Margin = new Padding(4, 0, 4, 0);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(550, 26);
            lblInstruksi.TabIndex = 8;
            lblInstruksi.Text = "Masukkan jenis sampah yang ingin anda tambahkan kedalam list";
            // 
            // Tambah_Sampah
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInstruksi);
            Controls.Add(cbJenisSampah);
            Controls.Add(cbSatuan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbKuantitas);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "Tambah_Sampah";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnKembali;
        private TextBox tbKuantitas;
        private Label label1;
        private Label label2;
        private ComboBox cbSatuan;
        private ComboBox cbJenisSampah;
        private Label lblInstruksi;
    }
}