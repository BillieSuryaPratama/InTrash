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
            tbNama.Location = new Point(315, 89);
            tbNama.Margin = new Padding(2, 2, 2, 2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(121, 27);
            tbNama.TabIndex = 19;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(315, 119);
            tbNomorHP.Margin = new Padding(2, 2, 2, 2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(121, 27);
            tbNomorHP.TabIndex = 18;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(315, 149);
            tbAlamat.Margin = new Padding(2, 2, 2, 2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(121, 27);
            tbAlamat.TabIndex = 17;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(272, 260);
            btnSimpan.Margin = new Padding(2, 2, 2, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 16;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(315, 208);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(121, 27);
            tbEmail.TabIndex = 14;
            // 
            // tbSandi
            // 
            tbSandi.Location = new Point(315, 178);
            tbSandi.Margin = new Padding(2, 2, 2, 2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(121, 27);
            tbSandi.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 91);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 20;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 122);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 21;
            label2.Text = "Nomor HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 152);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 22;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 181);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 23;
            label4.Text = "Sandi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 211);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(11, 322);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 25;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(221, 45);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(202, 20);
            lblInstruksi.TabIndex = 26;
            lblInstruksi.Text = "Daftarkan diri sebagai admin";
            // 
            // Register_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Margin = new Padding(2, 2, 2, 2);
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