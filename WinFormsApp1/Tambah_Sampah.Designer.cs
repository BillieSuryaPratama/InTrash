namespace WinFormsApp1
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
            btnSimpan.Location = new Point(541, 323);
            btnSimpan.Margin = new Padding(2, 2, 2, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(10, 323);
            btnKembali.Margin = new Padding(2, 2, 2, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // tbKuantitas
            // 
            tbKuantitas.Location = new Point(299, 193);
            tbKuantitas.Margin = new Padding(2, 2, 2, 2);
            tbKuantitas.Name = "tbKuantitas";
            tbKuantitas.Size = new Size(121, 27);
            tbKuantitas.TabIndex = 3;
            tbKuantitas.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 155);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Jenis Sampah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 196);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Kuantitas";
            // 
            // cbSatuan
            // 
            cbSatuan.FormattingEnabled = true;
            cbSatuan.Location = new Point(425, 193);
            cbSatuan.Name = "cbSatuan";
            cbSatuan.Size = new Size(81, 28);
            cbSatuan.TabIndex = 6;
            // 
            // cbJenisSampah
            // 
            cbJenisSampah.FormattingEnabled = true;
            cbJenisSampah.Location = new Point(299, 152);
            cbJenisSampah.Name = "cbJenisSampah";
            cbJenisSampah.Size = new Size(121, 28);
            cbJenisSampah.TabIndex = 7;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(109, 87);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(436, 20);
            lblInstruksi.TabIndex = 8;
            lblInstruksi.Text = "Masukkan jenis sampah yang ingin anda tambahkan kedalam list";
            // 
            // Tambah_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblInstruksi);
            Controls.Add(cbJenisSampah);
            Controls.Add(cbSatuan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbKuantitas);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Margin = new Padding(2, 2, 2, 2);
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