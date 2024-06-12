namespace WinFormsApp1.Views
{
    partial class Lupa_Password_Admin
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
            tb_confirmsandi = new TextBox();
            tb_sandibaru = new TextBox();
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
            btnSimpan.Location = new Point(446, 314);
            btnSimpan.Margin = new Padding(4, 4, 4, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(147, 55);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tb_confirmsandi
            // 
            tb_confirmsandi.Location = new Point(520, 220);
            tb_confirmsandi.Margin = new Padding(4, 4, 4, 4);
            tb_confirmsandi.Name = "tb_confirmsandi";
            tb_confirmsandi.Size = new Size(193, 39);
            tb_confirmsandi.TabIndex = 6;
            // 
            // tb_sandibaru
            // 
            tb_sandibaru.Location = new Point(520, 145);
            tb_sandibaru.Margin = new Padding(4, 4, 4, 4);
            tb_sandibaru.Name = "tb_sandibaru";
            tb_sandibaru.Size = new Size(193, 39);
            tb_sandibaru.TabIndex = 5;
            // 
            // gbKonfirmasi
            // 
            gbKonfirmasi.BackColor = Color.LightGray;
            gbKonfirmasi.Controls.Add(label3);
            gbKonfirmasi.Controls.Add(btnSetuju);
            gbKonfirmasi.Controls.Add(btnBatal);
            gbKonfirmasi.Location = new Point(19, 331);
            gbKonfirmasi.Margin = new Padding(4, 4, 4, 4);
            gbKonfirmasi.Name = "gbKonfirmasi";
            gbKonfirmasi.Padding = new Padding(4, 4, 4, 4);
            gbKonfirmasi.Size = new Size(390, 192);
            gbKonfirmasi.TabIndex = 8;
            gbKonfirmasi.TabStop = false;
            gbKonfirmasi.Text = "Ubah Sandi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(37, 55);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(312, 32);
            label3.TabIndex = 2;
            label3.Text = "Konfirmasi Perubahan Sandi";
            // 
            // btnSetuju
            // 
            btnSetuju.BackColor = Color.LimeGreen;
            btnSetuju.ForeColor = Color.White;
            btnSetuju.Location = new Point(221, 122);
            btnSetuju.Margin = new Padding(4, 4, 4, 4);
            btnSetuju.Name = "btnSetuju";
            btnSetuju.Size = new Size(147, 49);
            btnSetuju.TabIndex = 1;
            btnSetuju.Text = "Setuju";
            btnSetuju.UseVisualStyleBackColor = false;
            btnSetuju.Click += btnSetuju_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(19, 122);
            btnBatal.Margin = new Padding(4, 4, 4, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(147, 49);
            btnBatal.TabIndex = 0;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(290, 151);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 37);
            label1.TabIndex = 9;
            label1.Text = "Sandi Baru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(290, 224);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 37);
            label2.TabIndex = 10;
            label2.Text = "Konfirmasi Sandi";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 12F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(210, 60);
            lblInstruksi.Margin = new Padding(6, 0, 6, 0);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(645, 45);
            lblInstruksi.TabIndex = 11;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // Lupa_Password_Admin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(1040, 576);
            Controls.Add(lblInstruksi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbKonfirmasi);
            Controls.Add(btnSimpan);
            Controls.Add(tb_confirmsandi);
            Controls.Add(tb_sandibaru);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Lupa_Password_Admin";
            Text = "InTrash";
            gbKonfirmasi.ResumeLayout(false);
            gbKonfirmasi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private TextBox tb_confirmsandi;
        private TextBox tb_sandibaru;
        private GroupBox gbKonfirmasi;
        private Button btnSetuju;
        private Button btnBatal;
        private Label label1;
        private Label label2;
        private Label lblInstruksi;
        private Label label3;
    }
}