namespace WinFormsApp1
{
    partial class Verifikasi_NoHP
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
            btnBerikutnya = new Button();
            tbNomorHP = new TextBox();
            lblInstruksi = new Label();
            label2 = new Label();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // btnBerikutnya
            // 
            btnBerikutnya.Location = new Point(524, 310);
            btnBerikutnya.Margin = new Padding(2, 2, 2, 2);
            btnBerikutnya.Name = "btnBerikutnya";
            btnBerikutnya.Size = new Size(90, 27);
            btnBerikutnya.TabIndex = 0;
            btnBerikutnya.Text = "Berikutnya";
            btnBerikutnya.UseVisualStyleBackColor = true;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(296, 128);
            tbNomorHP.Margin = new Padding(2, 2, 2, 2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(121, 27);
            tbNomorHP.TabIndex = 1;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.Location = new Point(138, 84);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(349, 20);
            lblInstruksi.TabIndex = 2;
            lblInstruksi.Text = "Masukkan nomor HP anda sebagai tahap verikfikasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 131);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Nomor HP";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(24, 310);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // Verifikasi_NoHP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnKembali);
            Controls.Add(label2);
            Controls.Add(lblInstruksi);
            Controls.Add(tbNomorHP);
            Controls.Add(btnBerikutnya);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Verifikasi_NoHP";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBerikutnya;
        private TextBox tbNomorHP;
        private Label lblInstruksi;
        private Label label2;
        private Button btnKembali;
    }
}