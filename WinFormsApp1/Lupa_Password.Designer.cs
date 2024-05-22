namespace WinFormsApp1
{
    partial class Lupa_Password
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            gbKonfirmasi = new GroupBox();
            btnSetuju = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();
            lblInstruksi = new Label();
            label3 = new Label();
            gbKonfirmasi.SuspendLayout();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(274, 196);
            btnSimpan.Margin = new Padding(2, 2, 2, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 137);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 91);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 5;
            // 
            // gbKonfirmasi
            // 
            gbKonfirmasi.Controls.Add(label3);
            gbKonfirmasi.Controls.Add(btnSetuju);
            gbKonfirmasi.Controls.Add(btnBatal);
            gbKonfirmasi.Location = new Point(11, 207);
            gbKonfirmasi.Margin = new Padding(2, 2, 2, 2);
            gbKonfirmasi.Name = "gbKonfirmasi";
            gbKonfirmasi.Padding = new Padding(2, 2, 2, 2);
            gbKonfirmasi.Size = new Size(240, 120);
            gbKonfirmasi.TabIndex = 8;
            gbKonfirmasi.TabStop = false;
            gbKonfirmasi.Text = "Ubah Sandi";
            // 
            // btnSetuju
            // 
            btnSetuju.Location = new Point(136, 80);
            btnSetuju.Margin = new Padding(2, 2, 2, 2);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(90, 27);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(11, 80);
            btnBatal.Margin = new Padding(2, 2, 2, 2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 27);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 94);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 9;
            label1.Text = "Sandi Baru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 140);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 10;
            label2.Text = "Konfirmasi Sandi";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(173, 37);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(297, 20);
            lblInstruksi.TabIndex = 11;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 34);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 2;
            label3.Text = "Konfirmasi Perubahan Sandi";
            // 
            // Lupa_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblInstruksi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbKonfirmasi);
            Controls.Add(btnSimpan);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Lupa_Password";
            Text = "InTrash";
            gbKonfirmasi.ResumeLayout(false);
            gbKonfirmasi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox gbKonfirmasi;
        private Button btnSetuju;
        private Button btnBatal;
        private Label label1;
        private Label label2;
        private Label lblInstruksi;
        private Label label3;
    }
}