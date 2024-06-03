namespace WinFormsApp1
{
    partial class Register_Nasabah
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbNama = new TextBox();
            tbNomorHP = new TextBox();
            tbAlamat = new TextBox();
            btnSimpan = new Button();
            tbEmail = new TextBox();
            tbSandi = new TextBox();
            SuspendLayout();
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 12F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(188, 58);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(280, 28);
            lblInstruksi.TabIndex = 39;
            lblInstruksi.Text = "Daftarkan diri sebagai nasabah";
            lblInstruksi.Click += lblInstruksi_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(20, 322);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 38;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(203, 241);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 37;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(203, 211);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 36;
            label4.Text = "Sandi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(203, 182);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 35;
            label3.Text = "Alamat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(203, 152);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 34;
            label2.Text = "Nomor HP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 121);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 33;
            label1.Text = "Nama";
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 10F);
            tbNama.Location = new Point(315, 117);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(121, 30);
            tbNama.TabIndex = 32;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Font = new Font("Segoe UI", 10F);
            tbNomorHP.Location = new Point(315, 147);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(121, 30);
            tbNomorHP.TabIndex = 31;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 10F);
            tbAlamat.Location = new Point(315, 177);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(121, 30);
            tbAlamat.TabIndex = 30;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(529, 322);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 29;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 10F);
            tbEmail.Location = new Point(315, 236);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(121, 30);
            tbEmail.TabIndex = 28;
            // 
            // tbSandi
            // 
            tbSandi.Font = new Font("Segoe UI", 10F);
            tbSandi.Location = new Point(315, 206);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(121, 30);
            tbSandi.TabIndex = 27;
            // 
            // Register_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
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
            Margin = new Padding(2);
            Name = "Register_Nasabah";
            Text = "InTrash";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruksi;
        private Button btnKembali;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbNama;
        private TextBox tbNomorHP;
        private TextBox tbAlamat;
        private Button btnSimpan;
        private TextBox tbEmail;
        private TextBox tbSandi;
    }
}