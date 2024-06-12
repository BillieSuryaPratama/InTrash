namespace WinFormsApp1.Views
{
    partial class Form1
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
            buttonOK = new Button();
            buttonKembali = new Button();
            textBoxJumlahSaldo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxMetodePencairan = new ComboBox();
            textBoxRekeningTujuan = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttonLihatRiwayat = new Button();
            textBoxNominal = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.None;
            buttonOK.Location = new Point(439, 266);
            buttonOK.Margin = new Padding(2);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(90, 27);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonKembali
            // 
            buttonKembali.Anchor = AnchorStyles.None;
            buttonKembali.BackColor = Color.Red;
            buttonKembali.ForeColor = Color.White;
            buttonKembali.Location = new Point(11, 322);
            buttonKembali.Margin = new Padding(2);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Size = new Size(90, 27);
            buttonKembali.TabIndex = 1;
            buttonKembali.Text = "Kembali";
            buttonKembali.UseVisualStyleBackColor = false;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // textBoxJumlahSaldo
            // 
            textBoxJumlahSaldo.Anchor = AnchorStyles.None;
            textBoxJumlahSaldo.Location = new Point(306, 89);
            textBoxJumlahSaldo.Margin = new Padding(2);
            textBoxJumlahSaldo.Name = "textBoxJumlahSaldo";
            textBoxJumlahSaldo.ReadOnly = true;
            textBoxJumlahSaldo.Size = new Size(223, 27);
            textBoxJumlahSaldo.TabIndex = 2;
            textBoxJumlahSaldo.TextChanged += textBoxJumlahSaldo_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 92);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Jumlah Saldo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 4;
            label2.Text = "Pilih Jenis Pencairan:";
            // 
            // comboBoxMetodePencairan
            // 
            comboBoxMetodePencairan.Anchor = AnchorStyles.None;
            comboBoxMetodePencairan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMetodePencairan.FormattingEnabled = true;
            comboBoxMetodePencairan.Location = new Point(306, 125);
            comboBoxMetodePencairan.Name = "comboBoxMetodePencairan";
            comboBoxMetodePencairan.Size = new Size(223, 28);
            comboBoxMetodePencairan.TabIndex = 5;
            comboBoxMetodePencairan.SelectedIndexChanged += comboBoxMetodePencairan_SelectedIndexChanged;
            // 
            // textBoxRekeningTujuan
            // 
            textBoxRekeningTujuan.Anchor = AnchorStyles.None;
            textBoxRekeningTujuan.Location = new Point(306, 163);
            textBoxRekeningTujuan.Margin = new Padding(2);
            textBoxRekeningTujuan.Name = "textBoxRekeningTujuan";
            textBoxRekeningTujuan.Size = new Size(223, 27);
            textBoxRekeningTujuan.TabIndex = 6;
            textBoxRekeningTujuan.TextChanged += textBoxRekeningTujuan_TextChanged;
            textBoxRekeningTujuan.KeyPress += textBoxRekeningTujuan_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(115, 166);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 7;
            label3.Text = "Masukkan Rekening Tujuan";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(125, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(394, 54);
            label4.TabIndex = 8;
            label4.Text = "PENCAIRAN SALDO";
            // 
            // buttonLihatRiwayat
            // 
            buttonLihatRiwayat.Anchor = AnchorStyles.None;
            buttonLihatRiwayat.Location = new Point(125, 257);
            buttonLihatRiwayat.Margin = new Padding(2);
            buttonLihatRiwayat.Name = "buttonLihatRiwayat";
            buttonLihatRiwayat.Size = new Size(125, 36);
            buttonLihatRiwayat.TabIndex = 9;
            buttonLihatRiwayat.Text = "Lihat Riwayat";
            buttonLihatRiwayat.UseVisualStyleBackColor = true;
            buttonLihatRiwayat.Click += buttonLihatRiwayat_Click;
            // 
            // textBoxNominal
            // 
            textBoxNominal.Anchor = AnchorStyles.None;
            textBoxNominal.Location = new Point(306, 200);
            textBoxNominal.Margin = new Padding(2);
            textBoxNominal.Name = "textBoxNominal";
            textBoxNominal.Size = new Size(223, 27);
            textBoxNominal.TabIndex = 10;
            textBoxNominal.KeyPress += textBoxNominal_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(115, 203);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 11;
            label5.Text = "Nominal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(640, 360);
            Controls.Add(label5);
            Controls.Add(textBoxNominal);
            Controls.Add(buttonLihatRiwayat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxRekeningTujuan);
            Controls.Add(comboBoxMetodePencairan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxJumlahSaldo);
            Controls.Add(buttonKembali);
            Controls.Add(buttonOK);
            Margin = new Padding(2);
            MinimumSize = new Size(658, 407);
            Name = "Form1";
            Text = "InTrash";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Button buttonKembali;
        private TextBox textBoxJumlahSaldo;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxMetodePencairan;
        private TextBox textBoxRekeningTujuan;
        private Label label3;
        private Label label4;
        private Button buttonLihatRiwayat;
        private TextBox textBoxNominal;
        private Label label5;
    }
}