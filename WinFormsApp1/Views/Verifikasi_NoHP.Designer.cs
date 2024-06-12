namespace WinFormsApp1.Views
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
            btnBerikutnya.BackgroundImage = Properties.Resources.Wireframe___56;
            btnBerikutnya.Location = new Point(852, 469);
            btnBerikutnya.Name = "btnBerikutnya";
            btnBerikutnya.Size = new Size(146, 43);
            btnBerikutnya.TabIndex = 0;
            btnBerikutnya.Text = "Berikutnya";
            btnBerikutnya.UseVisualStyleBackColor = true;
            btnBerikutnya.Click += btnBerikutnya_Click;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(372, 315);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(279, 39);
            tbNomorHP.TabIndex = 1;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruksi.ForeColor = SystemColors.ButtonHighlight;
            lblInstruksi.Location = new Point(224, 182);
            lblInstruksi.Margin = new Padding(5, 0, 5, 0);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(589, 36);
            lblInstruksi.TabIndex = 2;
            lblInstruksi.Text = "Masukkan nomor HP anda sebagai tahap verifikasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(445, 258);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 3;
            label2.Text = "Nomor HP";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.Location = new Point(36, 469);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(146, 43);
            btnKembali.TabIndex = 4;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnkembali_Click;
            // 
            // Verifikasi_NoHP
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(1040, 576);
            Controls.Add(btnKembali);
            Controls.Add(label2);
            Controls.Add(lblInstruksi);
            Controls.Add(tbNomorHP);
            Controls.Add(btnBerikutnya);
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