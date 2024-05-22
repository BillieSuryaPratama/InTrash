namespace WinFormsApp1
{
    partial class Hapus_Akun_Admin
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
            btnSandi = new TextBox();
            label1 = new Label();
            btnKonfirmasi = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(111, 108);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(429, 20);
            lblInstruksi.TabIndex = 9;
            lblInstruksi.Text = "Masukkan sandi anda untuk mengkonfirmasi penghapusan akun";
            // 
            // btnSandi
            // 
            btnSandi.Location = new Point(321, 169);
            btnSandi.Name = "btnSandi";
            btnSandi.Size = new Size(125, 27);
            btnSandi.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 172);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Sandi";
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(533, 320);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(94, 29);
            btnKonfirmasi.TabIndex = 6;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(12, 320);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // Hapus_Akun_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 359);
            Controls.Add(lblInstruksi);
            Controls.Add(btnSandi);
            Controls.Add(label1);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Name = "Hapus_Akun_Admin";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruksi;
        private TextBox btnSandi;
        private Label label1;
        private Button btnKonfirmasi;
        private Button btnKembali;
    }
}