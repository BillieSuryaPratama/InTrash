namespace WinFormsApp1.Views
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
            buttonPencairanSaldo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(199, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 69);
            label1.TabIndex = 0;
            label1.Text = "Beranda";
            // 
            // btnInformasiSampah
            // 
            btnInformasiSampah.Anchor = AnchorStyles.None;
            btnInformasiSampah.AutoSize = true;
            btnInformasiSampah.BackColor = Color.MediumTurquoise;
            btnInformasiSampah.Location = new Point(337, 192);
            btnInformasiSampah.Margin = new Padding(2);
            btnInformasiSampah.Name = "btnInformasiSampah";
            btnInformasiSampah.Size = new Size(142, 40);
            btnInformasiSampah.TabIndex = 1;
            btnInformasiSampah.Text = "Informasi Sampah";
            btnInformasiSampah.UseVisualStyleBackColor = false;
            btnInformasiSampah.Click += btnInformasiSampah_Click;
            // 
            // btnSetorSampah
            // 
            btnSetorSampah.Anchor = AnchorStyles.None;
            btnSetorSampah.AutoSize = true;
            btnSetorSampah.BackColor = Color.MediumTurquoise;
            btnSetorSampah.Location = new Point(337, 137);
            btnSetorSampah.Margin = new Padding(2);
            btnSetorSampah.Name = "btnSetorSampah";
            btnSetorSampah.Size = new Size(142, 40);
            btnSetorSampah.TabIndex = 2;
            btnSetorSampah.Text = "Setor Sampah";
            btnSetorSampah.UseVisualStyleBackColor = false;
            btnSetorSampah.Click += btnSetorSampah_Click;
            // 
            // btnHapusAkun
            // 
            btnHapusAkun.Anchor = AnchorStyles.None;
            btnHapusAkun.AutoSize = true;
            btnHapusAkun.BackColor = Color.MediumTurquoise;
            btnHapusAkun.Location = new Point(160, 247);
            btnHapusAkun.Margin = new Padding(2);
            btnHapusAkun.Name = "btnHapusAkun";
            btnHapusAkun.Size = new Size(142, 40);
            btnHapusAkun.TabIndex = 3;
            btnHapusAkun.Text = "Hapus Akun";
            btnHapusAkun.UseVisualStyleBackColor = false;
            btnHapusAkun.Click += btnHapusAkun_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.Anchor = AnchorStyles.None;
            btnRiwayatTransaksi.AutoSize = true;
            btnRiwayatTransaksi.BackColor = Color.MediumTurquoise;
            btnRiwayatTransaksi.Location = new Point(160, 192);
            btnRiwayatTransaksi.Margin = new Padding(2);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(142, 40);
            btnRiwayatTransaksi.TabIndex = 4;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.None;
            btnProfil.AutoSize = true;
            btnProfil.BackColor = Color.MediumTurquoise;
            btnProfil.Location = new Point(160, 137);
            btnProfil.Margin = new Padding(2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(142, 40);
            btnProfil.TabIndex = 9;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click_1;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.None;
            btnLogOut.AutoSize = true;
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(26, 311);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(70, 30);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // buttonPencairanSaldo
            // 
            buttonPencairanSaldo.Anchor = AnchorStyles.None;
            buttonPencairanSaldo.AutoSize = true;
            buttonPencairanSaldo.BackColor = Color.MediumTurquoise;
            buttonPencairanSaldo.Location = new Point(337, 247);
            buttonPencairanSaldo.Margin = new Padding(2);
            buttonPencairanSaldo.Name = "buttonPencairanSaldo";
            buttonPencairanSaldo.Size = new Size(142, 40);
            buttonPencairanSaldo.TabIndex = 11;
            buttonPencairanSaldo.Text = "Pencairan Saldo";
            buttonPencairanSaldo.UseVisualStyleBackColor = false;
            buttonPencairanSaldo.Click += buttonPencairanSaldo_Click;
            // 
            // Beranda_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(640, 360);
            Controls.Add(buttonPencairanSaldo);
            Controls.Add(btnLogOut);
            Controls.Add(btnProfil);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnHapusAkun);
            Controls.Add(btnSetorSampah);
            Controls.Add(btnInformasiSampah);
            Controls.Add(label1);
            Margin = new Padding(2);
            MinimumSize = new Size(658, 407);
            Name = "Beranda_Nasabah";
            Text = "InTrash";
            Load += Beranda_Nasabah_Load;
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
        private Button buttonPencairanSaldo;
    }
}