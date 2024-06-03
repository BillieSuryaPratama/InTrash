namespace WinFormsApp1
{
    partial class Beranda_Kurir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda_Kurir));
            btnLogOut = new Button();
            btnDaftarPenjemputan = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(21, 330);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 17;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnDaftarPenjemputan
            // 
            btnDaftarPenjemputan.ForeColor = Color.Black;
            btnDaftarPenjemputan.Image = (Image)resources.GetObject("btnDaftarPenjemputan.Image");
            btnDaftarPenjemputan.Location = new Point(244, 161);
            btnDaftarPenjemputan.Margin = new Padding(2);
            btnDaftarPenjemputan.Name = "btnDaftarPenjemputan";
            btnDaftarPenjemputan.Size = new Size(159, 47);
            btnDaftarPenjemputan.TabIndex = 15;
            btnDaftarPenjemputan.Text = "Daftar Penjemputan";
            btnDaftarPenjemputan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(181, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 74);
            label1.TabIndex = 11;
            label1.Text = "Beranda";
            // 
            // Beranda_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(643, 371);
            Controls.Add(btnLogOut);
            Controls.Add(btnDaftarPenjemputan);
            Controls.Add(label1);
            Name = "Beranda_Kurir";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnProfil;
        private Button btnDaftarPenjemputan;
        private Button btnHapusAkun;
        private Button btnSetorSampah;
        private Button btnInformasiSampah;
        private Label label1;
    }
}