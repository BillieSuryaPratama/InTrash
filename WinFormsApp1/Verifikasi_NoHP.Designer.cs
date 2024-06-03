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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verifikasi_NoHP));
            btnBerikutnya = new Button();
            tbNomorHP = new TextBox();
            lblInstruksi = new Label();
            label2 = new Label();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // btnBerikutnya
            // 
            btnBerikutnya.Location = new Point(655, 366);
            btnBerikutnya.Margin = new Padding(2);
            btnBerikutnya.Name = "btnBerikutnya";
            btnBerikutnya.Size = new Size(112, 34);
            btnBerikutnya.TabIndex = 0;
            btnBerikutnya.Text = "Berikutnya";
            btnBerikutnya.UseVisualStyleBackColor = true;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(286, 246);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(215, 31);
            tbNomorHP.TabIndex = 1;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruksi.ForeColor = SystemColors.ButtonHighlight;
            lblInstruksi.Location = new Point(173, 142);
            lblInstruksi.Margin = new Padding(4, 0, 4, 0);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(447, 28);
            lblInstruksi.TabIndex = 2;
            lblInstruksi.Text = "Masukkan nomor HP anda sebagai tahap verifikasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(343, 201);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "Nomor HP";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(28, 366);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // Verifikasi_NoHP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(label2);
            Controls.Add(lblInstruksi);
            Controls.Add(tbNomorHP);
            Controls.Add(btnBerikutnya);
            Margin = new Padding(2);
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