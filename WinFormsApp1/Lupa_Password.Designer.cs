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
            label3 = new Label();
            btnSetuju = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();
            lblInstruksi = new Label();
            gbKonfirmasi.SuspendLayout();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Location = new Point(240, 147);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(79, 26);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 103);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 68);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 5;
            // 
            // gbKonfirmasi
            // 
            gbKonfirmasi.BackColor = Color.LightGray;
            gbKonfirmasi.Controls.Add(label3);
            gbKonfirmasi.Controls.Add(btnSetuju);
            gbKonfirmasi.Controls.Add(btnBatal);
            gbKonfirmasi.Location = new Point(10, 155);
            gbKonfirmasi.Margin = new Padding(2);
            gbKonfirmasi.Name = "gbKonfirmasi";
            gbKonfirmasi.Padding = new Padding(2);
            gbKonfirmasi.Size = new Size(210, 90);
            gbKonfirmasi.TabIndex = 8;
            gbKonfirmasi.TabStop = false;
            gbKonfirmasi.Text = "Ubah Sandi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(20, 26);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 2;
            label3.Text = "Konfirmasi Perubahan Sandi";
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.LimeGreen;
            btnSetuju.ForeColor = Color.White;
            btnSetuju.Location = new Point(119, 57);
            btnSetuju.Margin = new Padding(2);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(79, 23);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(10, 57);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(79, 23);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(156, 71);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 9;
            label1.Text = "Sandi Baru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(156, 105);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 10;
            label2.Text = "Konfirmasi Sandi";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 12F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(113, 28);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(317, 21);
            lblInstruksi.TabIndex = 11;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // Lupa_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(560, 270);
            Controls.Add(lblInstruksi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbKonfirmasi);
            Controls.Add(btnSimpan);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2);
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