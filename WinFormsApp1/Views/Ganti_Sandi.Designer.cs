namespace WinFormsApp1.Views
{
    partial class Ganti_Sandi
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            btnKembali = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gbKonfirmasi = new GroupBox();
            label4 = new Label();
            btnSetuju = new Button();
            btnBatal = new Button();
            lblInstruksi = new Label();
            btnSimpan = new Button();
            gbKonfirmasi.SuspendLayout();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(279, 189);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 143);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 96);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 4;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(11, 309);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 40);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(149, 99);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 10;
            label1.Text = "Sandi saat ini";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(149, 145);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "Sandi Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 192);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 12;
            label3.Text = "Konfirmasi Sandi";
            // 
            // gbKonfirmasi
            // 
            gbKonfirmasi.BackColor = Color.LightGray;
            gbKonfirmasi.Controls.Add(label4);
            gbKonfirmasi.Controls.Add(btnSetuju);
            gbKonfirmasi.Controls.Add(btnBatal);
            gbKonfirmasi.ForeColor = Color.Black;
            gbKonfirmasi.Location = new Point(389, 229);
            gbKonfirmasi.Margin = new Padding(2, 3, 2, 3);
            gbKonfirmasi.Name = "gbKonfirmasi";
            gbKonfirmasi.Padding = new Padding(2, 3, 2, 3);
            gbKonfirmasi.Size = new Size(240, 120);
            gbKonfirmasi.TabIndex = 13;
            gbKonfirmasi.TabStop = false;
            gbKonfirmasi.Text = "Ubah Sandi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 33);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 2;
            label4.Text = "Konfirmasi Perubahan Sandi";
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.LimeGreen;
            btnSetuju.ForeColor = Color.White;
            btnSetuju.Location = new Point(136, 68);
            btnSetuju.Margin = new Padding(2, 3, 2, 3);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(90, 39);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(11, 68);
            btnBatal.Margin = new Padding(2, 3, 2, 3);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 39);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 15F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(103, 28);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(502, 35);
            lblInstruksi.TabIndex = 14;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Location = new Point(262, 239);
            btnSimpan.Margin = new Padding(2, 3, 2, 3);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 44);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // Ganti_Sandi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(lblInstruksi);
            Controls.Add(gbKonfirmasi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ganti_Sandi";
            Text = "InTrash";
            gbKonfirmasi.ResumeLayout(false);
            gbKonfirmasi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnKembali;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox gbKonfirmasi;
        private Label label4;
        private Button btnSetuju;
        private Button btnBatal;
        private Label lblInstruksi;
        private Button btnSimpan;
    }
}