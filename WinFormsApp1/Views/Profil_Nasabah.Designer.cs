namespace WinFormsApp1.Views
{
    partial class Profil_Nasabah
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
            btnUbahSandi = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnKembali = new Button();
            btnSimpan = new Button();
            tbSaldo = new TextBox();
            tbAlamat = new TextBox();
            tbNomorHP = new TextBox();
            tbNama = new TextBox();
            tbUsername = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUbahSandi
            // 
            btnUbahSandi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnUbahSandi.Font = new Font("Segoe UI", 10F);
            btnUbahSandi.Location = new Point(330, 277);
            btnUbahSandi.Margin = new Padding(4);
            btnUbahSandi.Name = "btnUbahSandi";
            btnUbahSandi.Size = new Size(118, 36);
            btnUbahSandi.TabIndex = 64;
            btnUbahSandi.Text = "Ubah Sandi";
            btnUbahSandi.UseVisualStyleBackColor = true;
            btnUbahSandi.Click += btnUbahSandi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(158, 230);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 30);
            label8.TabIndex = 63;
            label8.Text = "Saldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(158, 183);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 30);
            label7.TabIndex = 62;
            label7.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(158, 138);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 30);
            label6.TabIndex = 61;
            label6.Text = "Nomor HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(158, 90);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 30);
            label5.TabIndex = 60;
            label5.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(158, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 58;
            label2.Text = "Nama";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(14, 402);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 56;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(674, 402);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 55;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbSaldo
            // 
            tbSaldo.Location = new Point(330, 231);
            tbSaldo.Margin = new Padding(2);
            tbSaldo.Name = "tbSaldo";
            tbSaldo.ReadOnly = true;
            tbSaldo.Size = new Size(332, 31);
            tbSaldo.TabIndex = 53;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(330, 184);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(332, 31);
            tbAlamat.TabIndex = 52;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(330, 137);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(332, 31);
            tbNomorHP.TabIndex = 51;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(330, 42);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(333, 31);
            tbNama.TabIndex = 50;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(330, 89);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(332, 31);
            tbUsername.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 277);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 66;
            label1.Text = "Sandi";
            // 
            // Profil_Nasabah
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tbUsername);
            Controls.Add(btnUbahSandi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(tbSaldo);
            Controls.Add(tbAlamat);
            Controls.Add(tbNomorHP);
            Controls.Add(tbNama);
            Margin = new Padding(2);
            Name = "Profil_Nasabah";
            Text = "InTrash";
            Load += Profil_Nasabah_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUbahSandi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Button btnKembali;
        private Button btnSimpan;
        private TextBox tbSaldo;
        private TextBox tbAlamat;
        private TextBox tbNomorHP;
        private TextBox tbNama;
        private TextBox tbUsername;
        private Label label1;
    }
}