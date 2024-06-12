namespace WinFormsApp1.Views
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
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnSimpan = new Button();
            tbAlamat = new TextBox();
            tbNoHP = new TextBox();
            SuspendLayout();
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 13F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(166, 22);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(308, 30);
            lblInstruksi.TabIndex = 39;
            lblInstruksi.Text = "Daftarkan diri sebagai nasabah";
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
            btnKembali.Click += btnKembali_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(200, 223);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 37;
            label5.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(200, 193);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 36;
            label4.Text = "No HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(200, 164);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 35;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 134);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 34;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 103);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 33;
            label1.Text = "Nama";
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 10F);
            tbNama.Location = new Point(312, 99);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(121, 30);
            tbNama.TabIndex = 32;
            // 
            // tbUserName
            // 
            tbUserName.Font = new Font("Segoe UI", 10F);
            tbUserName.Location = new Point(312, 129);
            tbUserName.Margin = new Padding(2);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(121, 30);
            tbUserName.TabIndex = 31;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10F);
            tbPassword.Location = new Point(312, 159);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(121, 30);
            tbPassword.TabIndex = 30;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(529, 322);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 29;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 10F);
            tbAlamat.Location = new Point(312, 218);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(121, 30);
            tbAlamat.TabIndex = 28;
            // 
            // tbNoHP
            // 
            tbNoHP.Font = new Font("Segoe UI", 10F);
            tbNoHP.Location = new Point(312, 188);
            tbNoHP.Margin = new Padding(2);
            tbNoHP.Name = "tbNoHP";
            tbNoHP.Size = new Size(121, 30);
            tbNoHP.TabIndex = 27;
            // 
            // Register_Nasabah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
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
            Controls.Add(tbUserName);
            Controls.Add(tbPassword);
            Controls.Add(btnSimpan);
            Controls.Add(tbAlamat);
            Controls.Add(tbNoHP);
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
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnSimpan;
        private TextBox tbAlamat;
        private TextBox tbNoHP;
    }
}