namespace WinFormsApp1
{
    partial class Edit_Jenis_Sampah
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
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            tbJenisSampah = new TextBox();
            tbDeskripsi = new TextBox();
            lblInstruksi = new Label();
            btnKembali = new Button();
            btnSimpan = new Button();
            tbHarga = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(176, 158);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 68;
            label3.Text = "Deskripsi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(176, 125);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 67;
            label2.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(176, 88);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 66;
            label5.Text = "Jenis Sampah";
            // 
            // tbJenisSampah
            // 
            tbJenisSampah.Location = new Point(270, 87);
            tbJenisSampah.Margin = new Padding(2);
            tbJenisSampah.Name = "tbJenisSampah";
            tbJenisSampah.Size = new Size(106, 23);
            tbJenisSampah.TabIndex = 65;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(270, 156);
            tbDeskripsi.Margin = new Padding(2);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(106, 23);
            tbDeskripsi.TabIndex = 63;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 15F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(147, 35);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(261, 28);
            lblInstruksi.TabIndex = 61;
            lblInstruksi.Text = "Masukkan data jenis sampah";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(16, 219);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 30);
            btnKembali.TabIndex = 70;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(464, 221);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(79, 27);
            btnSimpan.TabIndex = 71;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(270, 122);
            tbHarga.Margin = new Padding(2);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(106, 23);
            tbHarga.TabIndex = 72;
            // 
            // Edit_Jenis_Sampah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55__1_;
            ClientSize = new Size(558, 260);
            Controls.Add(tbHarga);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(tbJenisSampah);
            Controls.Add(tbDeskripsi);
            Controls.Add(lblInstruksi);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Edit_Jenis_Sampah";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox tbJenisSampah;
        private TextBox tbNomorHP;
        private TextBox tbDeskripsi;
        private TextBox tbSandi;
        private Label lblInstruksi;
        private Button btnKembali;
        private Button btnSimpan;
        private TextBox tbHarga;
    }
}