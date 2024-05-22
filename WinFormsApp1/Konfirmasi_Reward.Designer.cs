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
            label1.Location = new Point(135, 108);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 162);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Metode Pencairan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 217);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Nominal";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(10, 323);
            btnKembali.Margin = new Padding(2, 2, 2, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(539, 322);
            btnKonfirmasi.Margin = new Padding(2, 2, 2, 2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(90, 27);
            btnKonfirmasi.TabIndex = 4;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // lblMetodePencairan
            // 
            lblMetodePencairan.AutoSize = true;
            lblMetodePencairan.Location = new Point(324, 162);
            lblMetodePencairan.Margin = new Padding(2, 0, 2, 0);
            lblMetodePencairan.Name = "lblMetodePencairan";
            lblMetodePencairan.Size = new Size(61, 20);
            lblMetodePencairan.TabIndex = 5;
            lblMetodePencairan.Text = "Dummy";
            // 
            // lblNominal
            // 
            lblNominal.AutoSize = true;
            lblNominal.Location = new Point(324, 217);
            lblNominal.Margin = new Padding(2, 0, 2, 0);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(61, 20);
            lblNominal.TabIndex = 6;
            lblNominal.Text = "Dummy";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(324, 108);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(61, 20);
            lblNama.TabIndex = 7;
            lblNama.Text = "Dummy";
            // 
            // Konfirmasi_Reward
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblNama);
            Controls.Add(lblNominal);
            Controls.Add(lblMetodePencairan);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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