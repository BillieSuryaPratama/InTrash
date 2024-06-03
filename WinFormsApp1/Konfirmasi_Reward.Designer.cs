namespace WinFormsApp1
{
    partial class Konfirmasi_Reward
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKembali = new Button();
            btnKonfirmasi = new Button();
            lblMetodePencairan = new Label();
            lblNominal = new Label();
            lblNama = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(118, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(118, 113);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 1;
            label2.Text = "Metode Pencairan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(118, 163);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Nominal";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(14, 229);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(79, 29);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(464, 229);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(79, 29);
            btnKonfirmasi.TabIndex = 4;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // lblMetodePencairan
            // 
            lblMetodePencairan.AutoSize = true;
            lblMetodePencairan.Font = new Font("Segoe UI", 13F);
            lblMetodePencairan.Location = new Point(307, 113);
            lblMetodePencairan.Margin = new Padding(2, 0, 2, 0);
            lblMetodePencairan.Name = "lblMetodePencairan";
            lblMetodePencairan.Size = new Size(76, 25);
            lblMetodePencairan.TabIndex = 5;
            lblMetodePencairan.Text = "Dummy";
            // 
            // lblNominal
            // 
            lblNominal.AutoSize = true;
            lblNominal.Font = new Font("Segoe UI", 13F);
            lblNominal.Location = new Point(307, 163);
            lblNominal.Margin = new Padding(2, 0, 2, 0);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(76, 25);
            lblNominal.TabIndex = 6;
            lblNominal.Text = "Dummy";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 13F);
            lblNama.Location = new Point(307, 64);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(76, 25);
            lblNama.TabIndex = 7;
            lblNama.Text = "Dummy";
            // 
            // Konfirmasi_Reward
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(560, 270);
            Controls.Add(lblNama);
            Controls.Add(lblNominal);
            Controls.Add(lblMetodePencairan);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Konfirmasi_Reward";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKembali;
        private Button btnKonfirmasi;
        private Label lblMetodePencairan;
        private Label lblNominal;
        private Label lblNama;
    }
}