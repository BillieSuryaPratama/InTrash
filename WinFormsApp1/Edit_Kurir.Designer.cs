namespace WinFormsApp1
{
    partial class Edit_Kurir
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
            btnKembali = new Button();
            btnSimpan = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            tbNama = new TextBox();
            tbNomorHP = new TextBox();
            tbUsername = new TextBox();
            tbSandi = new TextBox();
            SuspendLayout();
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 15F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(113, 15);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(352, 28);
            lblInstruksi.TabIndex = 16;
            lblInstruksi.Text = "Masukkan data kurir yang ingin diubah";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(10, 221);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 28);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe_56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(469, 221);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(79, 28);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(178, 162);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 60;
            label4.Text = "Sandi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(178, 130);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 59;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 99);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 58;
            label2.Text = "Nomor HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(178, 65);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 57;
            label5.Text = "Nama";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(273, 64);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(106, 23);
            tbNama.TabIndex = 56;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(273, 97);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(106, 23);
            tbNomorHP.TabIndex = 55;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(273, 128);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(106, 23);
            tbUsername.TabIndex = 54;
            // 
            // tbSandi
            // 
            tbSandi.Location = new Point(273, 160);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(106, 23);
            tbSandi.TabIndex = 53;
            // 
            // Edit_Kurir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(557, 257);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(tbNama);
            Controls.Add(tbNomorHP);
            Controls.Add(tbUsername);
            Controls.Add(tbSandi);
            Controls.Add(lblInstruksi);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Edit_Kurir";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruksi;
        private Button btnKembali;
        private Button btnSimpan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox tbNama;
        private TextBox tbNomorHP;
        private TextBox tbUsername;
        private TextBox tbSandi;
    }
}