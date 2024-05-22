namespace WinFormsApp1
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
            btnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gbKonfirmasi = new GroupBox();
            label4 = new Label();
            btnSetuju = new Button();
            btnBatal = new Button();
            lblInstruksi = new Label();
            gbKonfirmasi.SuspendLayout();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(279, 153);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 106);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 60);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 4;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(11, 322);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(262, 207);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 63);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 10;
            label1.Text = "Sandi saat ini";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 109);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "Sandi Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 156);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 12;
            label3.Text = "Konfirmasi Sandi";
            // 
            // gbKonfirmasi
            // 
            gbKonfirmasi.Controls.Add(label4);
            gbKonfirmasi.Controls.Add(btnSetuju);
            gbKonfirmasi.Controls.Add(btnBatal);
            gbKonfirmasi.Location = new Point(389, 229);
            gbKonfirmasi.Margin = new Padding(2);
            gbKonfirmasi.Name = "gbKonfirmasi";
            gbKonfirmasi.Padding = new Padding(2);
            gbKonfirmasi.Size = new Size(240, 120);
            gbKonfirmasi.TabIndex = 13;
            gbKonfirmasi.TabStop = false;
            gbKonfirmasi.Text = "Ubah Sandi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 33);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 2;
            label4.Text = "Konfirmasi Perubahan Sandi";
            // 
            // btnSetuju
            // 
            btnSetuju.Location = new Point(136, 80);
            btnSetuju.Margin = new Padding(2);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(90, 27);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(11, 80);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 27);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(163, 21);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(297, 20);
            lblInstruksi.TabIndex = 14;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // Ganti_Sandi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Margin = new Padding(2);
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
        private Button btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox gbKonfirmasi;
        private Label label4;
        private Button btnSetuju;
        private Button btnBatal;
        private Label lblInstruksi;
    }
}