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
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(12, 314);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.MediumTurquoise;
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.ForeColor = Color.White;
            btnKonfirmasi.Location = new Point(532, 310);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(94, 29);
            btnKonfirmasi.TabIndex = 1;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(210, 163);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Sandi";
            // 
            // btnSandi
            // 
            btnSandi.Location = new Point(286, 163);
            btnSandi.Name = "btnSandi";
            btnSandi.Size = new Size(125, 27);
            btnSandi.TabIndex = 3;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 11F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(49, 75);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(554, 25);
            lblInstruksi.TabIndex = 4;
            lblInstruksi.Text = "Masukkan sandi anda untuk mengkonfirmasi penghapusan akun";
            // 
            // Hapus_Akun_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
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