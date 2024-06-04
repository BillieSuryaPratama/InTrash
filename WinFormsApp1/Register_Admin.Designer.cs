namespace WinFormsApp1
{
    partial class Register_Admin
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
            tbNama = new TextBox();
            tbNomorHP = new TextBox();
            tbAlamat = new TextBox();
            btnSimpan = new Button();
            tbEmail = new TextBox();
            tbSandi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnKembali = new Button();
            lblInstruksi = new Label();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Location = new Point(354, 135);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(136, 30);
            tbNama.TabIndex = 19;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(354, 169);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(136, 30);
            tbNomorHP.TabIndex = 18;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(354, 204);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(136, 30);
            tbAlamat.TabIndex = 17;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(592, 355);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(101, 31);
            btnSimpan.TabIndex = 16;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(354, 271);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(136, 30);
            tbEmail.TabIndex = 14;
            // 
            // tbSandi
            // 
            tbSandi.Location = new Point(354, 237);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(136, 30);
            tbSandi.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(233, 136);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 20;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(233, 171);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 21;
            label2.Text = "Nomor HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(233, 206);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 22;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(233, 240);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 23;
            label4.Text = "Sandi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(233, 275);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(20, 363);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(101, 31);
            btnKembali.TabIndex = 25;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 13F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(224, 59);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(289, 30);
            lblInstruksi.TabIndex = 26;
            lblInstruksi.Text = "Daftarkan diri sebagai admin";
            // 
            // Register_Admin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(720, 414);
            Controls.Add(lblInstruksi);
            Controls.Add(btnKembali);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNama);
            Controls.Add(tbNomorHP);
            Controls.Add(tbAlamat);
            Controls.Add(btnSimpan);
            Controls.Add(tbEmail);
            Controls.Add(tbSandi);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(2);
            Name = "Register_Admin";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private TextBox tbNomorHP;
        private TextBox tbAlamat;
        private Button btnSimpan;
        private TextBox tbEmail;
        private TextBox tbSandi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnKembali;
        private Label lblInstruksi;
    }
}