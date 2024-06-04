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
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 12F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(50, 50);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(458, 21);
            lblInstruksi.TabIndex = 9;
            lblInstruksi.Text = "Masukkan sandi anda untuk mengkonfirmasi penghapusan akun";
            // 
            // btnSandi
            // 
            btnSandi.Location = new Point(280, 126);
            btnSandi.Margin = new Padding(3, 2, 3, 2);
            btnSandi.Name = "btnSandi";
            btnSandi.Size = new Size(110, 23);
            btnSandi.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(184, 129);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Sandi";
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(451, 217);
            btnKonfirmasi.Margin = new Padding(3, 2, 3, 2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(82, 34);
            btnKonfirmasi.TabIndex = 6;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(22, 217);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(82, 34);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // Hapus_Akun_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(558, 269);
            Controls.Add(lblInstruksi);
            Controls.Add(btnSandi);
            Controls.Add(label1);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Margin = new Padding(3, 2, 3, 2);
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