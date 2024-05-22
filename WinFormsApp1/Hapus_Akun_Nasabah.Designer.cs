namespace WinFormsApp1
{
    partial class Hapus_Akun_Nasabah
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
            btnKembali = new Button();
            btnKonfirmasi = new Button();
            label1 = new Label();
            btnSandi = new TextBox();
            lblInstruksi = new Label();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(12, 319);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(533, 319);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(94, 29);
            btnKonfirmasi.TabIndex = 1;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 171);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Sandi";
            // 
            // btnSandi
            // 
            btnSandi.Location = new Point(321, 168);
            btnSandi.Name = "btnSandi";
            btnSandi.Size = new Size(125, 27);
            btnSandi.TabIndex = 3;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(111, 107);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(429, 20);
            lblInstruksi.TabIndex = 4;
            lblInstruksi.Text = "Masukkan sandi anda untuk mengkonfirmasi penghapusan akun";
            // 
            // Hapus_Akun_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 360);
            Controls.Add(lblInstruksi);
            Controls.Add(btnSandi);
            Controls.Add(label1);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Name = "Hapus_Akun_Nasabah";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private Button btnKonfirmasi;
        private Label label1;
        private TextBox btnSandi;
        private Label lblInstruksi;
    }
}