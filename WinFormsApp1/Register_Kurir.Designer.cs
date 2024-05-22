namespace WinFormsApp1
{
    partial class Register_Kurir
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
            btnSimpan = new Button();
            tbSandi = new TextBox();
            tbUsername = new TextBox();
            tbNomorHP = new TextBox();
            tbNama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblInstruksi = new Label();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(12, 325);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 51;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(536, 325);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 27);
            btnSimpan.TabIndex = 42;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // tbSandi
            // 
            tbSandi.Location = new Point(316, 181);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(121, 27);
            tbSandi.TabIndex = 40;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(316, 152);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(121, 27);
            tbUsername.TabIndex = 43;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(316, 122);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(121, 27);
            tbNomorHP.TabIndex = 44;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(316, 92);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(121, 27);
            tbNama.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 94);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 46;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 125);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 47;
            label2.Text = "Nomor HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 155);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 48;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 184);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 49;
            label4.Text = "Sandi";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(273, 48);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(102, 20);
            lblInstruksi.TabIndex = 52;
            lblInstruksi.Text = "Edit data kurir";
            // 
            // Register_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 363);
            Controls.Add(lblInstruksi);
            Controls.Add(btnKembali);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNama);
            Controls.Add(tbNomorHP);
            Controls.Add(tbUsername);
            Controls.Add(btnSimpan);
            Controls.Add(tbSandi);
            Name = "Register_Kurir";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnKembali;
        private Button btnSimpan;
        private TextBox tbSandi;
        private TextBox tbUsername;
        private TextBox tbNomorHP;
        private TextBox tbNama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblInstruksi;
    }
}