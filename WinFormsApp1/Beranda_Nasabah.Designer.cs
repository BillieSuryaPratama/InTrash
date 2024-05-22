namespace WinFormsApp1
{
    partial class Beranda_Nasabah
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
            label1 = new Label();
            btnInformasiSampah = new Button();
            btnSetorSampah = new Button();
            btnHapusAkun = new Button();
            btnRiwayatTransaksi = new Button();
            btnProfil = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 74);
            label1.TabIndex = 0;
            label1.Text = "Beranda";
            // 
            // btnInformasiSampah
            // 
            btnInformasiSampah.Location = new Point(337, 192);
            btnInformasiSampah.Margin = new Padding(2);
            btnInformasiSampah.Name = "btnInformasiSampah";
            btnInformasiSampah.Size = new Size(142, 27);
            btnInformasiSampah.TabIndex = 1;
            btnInformasiSampah.Text = "Informasi Sampah";
            btnInformasiSampah.UseVisualStyleBackColor = true;
            // 
            // btnSetorSampah
            // 
            btnSetorSampah.Location = new Point(337, 137);
            btnSetorSampah.Margin = new Padding(2);
            btnSetorSampah.Name = "btnSetorSampah";
            btnSetorSampah.Size = new Size(142, 27);
            btnSetorSampah.TabIndex = 2;
            btnSetorSampah.Text = "Setor Sampah";
            btnSetorSampah.UseVisualStyleBackColor = true;
            // 
            // btnHapusAkun
            // 
            btnHapusAkun.Location = new Point(248, 251);
            btnHapusAkun.Margin = new Padding(2);
            btnHapusAkun.Name = "btnHapusAkun";
            btnHapusAkun.Size = new Size(142, 27);
            btnHapusAkun.TabIndex = 3;
            btnHapusAkun.Text = "Hapus Akun";
            btnHapusAkun.UseVisualStyleBackColor = true;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.Location = new Point(160, 192);
            btnRiwayatTransaksi.Margin = new Padding(2);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(142, 27);
            btnRiwayatTransaksi.TabIndex = 4;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.Location = new Point(160, 137);
            btnProfil.Margin = new Padding(2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(142, 27);
            btnProfil.TabIndex = 9;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(12, 312);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // Beranda_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnLogOut);
            Controls.Add(btnProfil);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnHapusAkun);
            Controls.Add(btnSetorSampah);
            Controls.Add(btnInformasiSampah);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Beranda_Nasabah";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInformasiSampah;
        private Button btnSetorSampah;
        private Button btnHapusAkun;
        private Button btnRiwayatTransaksi;
        private Button btnProfil;
        private Button btnLogOut;
    }
}