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
            konfirmasiSandiTextBox = new TextBox();
            sandiBaruTextBox = new TextBox();
            sandiSaatIniTextBox = new TextBox();
            btnKembali = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblInstruksi = new Label();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // konfirmasiSandiTextBox
            // 
            konfirmasiSandiTextBox.Location = new Point(349, 236);
            konfirmasiSandiTextBox.Margin = new Padding(2, 4, 2, 4);
            konfirmasiSandiTextBox.Name = "konfirmasiSandiTextBox";
            konfirmasiSandiTextBox.Size = new Size(240, 31);
            konfirmasiSandiTextBox.TabIndex = 6;
            // 
            // sandiBaruTextBox
            // 
            sandiBaruTextBox.Location = new Point(349, 179);
            sandiBaruTextBox.Margin = new Padding(2, 4, 2, 4);
            sandiBaruTextBox.Name = "sandiBaruTextBox";
            sandiBaruTextBox.Size = new Size(240, 31);
            sandiBaruTextBox.TabIndex = 5;
            // 
            // sandiSaatIniTextBox
            // 
            sandiSaatIniTextBox.Location = new Point(349, 120);
            sandiSaatIniTextBox.Margin = new Padding(2, 4, 2, 4);
            sandiSaatIniTextBox.Name = "sandiSaatIniTextBox";
            sandiSaatIniTextBox.Size = new Size(240, 31);
            sandiSaatIniTextBox.TabIndex = 4;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(14, 386);
            btnKembali.Margin = new Padding(2, 4, 2, 4);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 50);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(186, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 10;
            label1.Text = "Sandi saat ini";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(186, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 11;
            label2.Text = "Sandi Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(186, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 12;
            label3.Text = "Konfirmasi Sandi";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 15F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(129, 35);
            lblInstruksi.Margin = new Padding(4, 0, 4, 0);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(600, 41);
            lblInstruksi.TabIndex = 14;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Location = new Point(328, 299);
            btnSimpan.Margin = new Padding(2, 4, 2, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 55);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // Ganti_Sandi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInstruksi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(konfirmasiSandiTextBox);
            Controls.Add(sandiBaruTextBox);
            Controls.Add(sandiSaatIniTextBox);
            Margin = new Padding(2, 4, 2, 4);
            Name = "Ganti_Sandi";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox konfirmasiSandiTextBox;
        private TextBox sandiBaruTextBox;
        private TextBox sandiSaatIniTextBox;
        private Button btnKembali;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblInstruksi;
        private Button btnSimpan;
    }
}