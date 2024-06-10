namespace WinFormsApp1.Views
{
    partial class Lupa_Password_Nasabah
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
            lblInstruksi = new Label();
            label2 = new Label();
            label1 = new Label();
            gbKonfirmasi = new GroupBox();
            label3 = new Label();
            btnSetuju = new Button();
            btnBatal = new Button();
            btnSimpan = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            gbKonfirmasi.SuspendLayout();
            SuspendLayout();
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 12F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(133, 74);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(395, 28);
            lblInstruksi.TabIndex = 18;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(182, 177);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 17;
            label2.Text = "Konfirmasi Sandi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(182, 132);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 16;
            label1.Text = "Sandi Baru";
            // 
            // gbKonfirmasi
            // 
            gbKonfirmasi.BackColor = Color.LightGray;
            gbKonfirmasi.Controls.Add(label3);
            gbKonfirmasi.Controls.Add(btnSetuju);
            gbKonfirmasi.Controls.Add(btnBatal);
            gbKonfirmasi.Location = new Point(15, 244);
            gbKonfirmasi.Margin = new Padding(2, 3, 2, 3);
            gbKonfirmasi.Name = "gbKonfirmasi";
            gbKonfirmasi.Padding = new Padding(2, 3, 2, 3);
            gbKonfirmasi.Size = new Size(240, 120);
            gbKonfirmasi.TabIndex = 15;
            gbKonfirmasi.TabStop = false;
            gbKonfirmasi.Text = "Ubah Sandi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(22, 35);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 2;
            label3.Text = "Konfirmasi Perubahan Sandi";
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.LimeGreen;
            btnSetuju.ForeColor = Color.White;
            btnSetuju.Location = new Point(136, 76);
            btnSetuju.Margin = new Padding(2, 3, 2, 3);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(90, 31);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(11, 76);
            btnBatal.Margin = new Padding(2, 3, 2, 3);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 31);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Location = new Point(278, 233);
            btnSimpan.Margin = new Padding(2, 3, 2, 3);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 35);
            btnSimpan.TabIndex = 14;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 174);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 128);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 12;
            // 
            // Lupa_Password_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(653, 386);
            Controls.Add(lblInstruksi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbKonfirmasi);
            Controls.Add(btnSimpan);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Lupa_Password_Nasabah";
            Text = "InTrash";
            gbKonfirmasi.ResumeLayout(false);
            gbKonfirmasi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruksi;
        private Label label2;
        private Label label1;
        private GroupBox gbKonfirmasi;
        private Label label3;
        private Button btnSetuju;
        private Button btnBatal;
        private Button btnSimpan;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}