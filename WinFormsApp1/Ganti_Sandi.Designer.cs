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
            textBox4.Location = new Point(244, 142);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 107);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 72);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 23);
            textBox2.TabIndex = 4;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(10, 232);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 30);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Location = new Point(229, 179);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(79, 33);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(130, 74);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 10;
            label1.Text = "Sandi saat ini";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(130, 109);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 11;
            label2.Text = "Sandi Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(130, 144);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 12;
            label3.Text = "Konfirmasi Sandi";
            // 
            // gbKonfirmasi
            // 
            gbKonfirmasi.BackColor = Color.Transparent;
            gbKonfirmasi.Controls.Add(label4);
            gbKonfirmasi.Controls.Add(btnSetuju);
            gbKonfirmasi.Controls.Add(btnBatal);
            gbKonfirmasi.ForeColor = Color.White;
            gbKonfirmasi.Location = new Point(340, 172);
            gbKonfirmasi.Margin = new Padding(2);
            gbKonfirmasi.Name = "gbKonfirmasi";
            gbKonfirmasi.Padding = new Padding(2);
            gbKonfirmasi.Size = new Size(210, 90);
            gbKonfirmasi.TabIndex = 13;
            gbKonfirmasi.TabStop = false;
            gbKonfirmasi.Text = "Ubah Sandi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 25);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 2;
            label4.Text = "Konfirmasi Perubahan Sandi";
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.Transparent;
            btnSetuju.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSetuju.ForeColor = Color.Black;
            btnSetuju.Location = new Point(119, 51);
            btnSetuju.Margin = new Padding(2);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(79, 29);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(10, 51);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(79, 29);
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
            lblInstruksi.Location = new Point(90, 21);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(395, 28);
            lblInstruksi.TabIndex = 14;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // Ganti_Sandi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55__1_;
            ClientSize = new Size(560, 270);
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