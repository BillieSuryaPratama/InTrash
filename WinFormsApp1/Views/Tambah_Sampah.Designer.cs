namespace WinFormsApp1.Views
{
    partial class Tambah_Sampah
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
            btnSimpan = new Button();
            btnKembali = new Button();
            tbKuantitas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblInstruksi = new Label();
            comboBoxJenisSampah = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Anchor = AnchorStyles.None;
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Font = new Font("Palatino Linotype", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(517, 315);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnKembali
            // 
            btnKembali.Anchor = AnchorStyles.None;
            btnKembali.BackColor = Color.Red;
            btnKembali.Font = new Font("Palatino Linotype", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.Transparent;
            btnKembali.Location = new Point(11, 315);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // tbKuantitas
            // 
            tbKuantitas.Anchor = AnchorStyles.None;
            tbKuantitas.Location = new Point(294, 192);
            tbKuantitas.Name = "tbKuantitas";
            tbKuantitas.Size = new Size(150, 34);
            tbKuantitas.TabIndex = 10;
            tbKuantitas.KeyPress += tbKuantitas_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(150, 152);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 4;
            label1.Text = "Jenis Sampah";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(159, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 5;
            label2.Text = "Kuantitas";
            // 
            // lblInstruksi
            // 
            lblInstruksi.Anchor = AnchorStyles.Top;
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Palatino Linotype", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruksi.ForeColor = Color.Transparent;
            lblInstruksi.Location = new Point(20, 84);
            lblInstruksi.Margin = new Padding(4, 0, 4, 0);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(550, 26);
            lblInstruksi.TabIndex = 8;
            lblInstruksi.Text = "Masukkan jenis sampah yang ingin anda tambahkan kedalam list";
            // 
            // comboBoxJenisSampah
            // 
            comboBoxJenisSampah.Anchor = AnchorStyles.None;
            comboBoxJenisSampah.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJenisSampah.FormattingEnabled = true;
            comboBoxJenisSampah.Location = new Point(294, 150);
            comboBoxJenisSampah.Margin = new Padding(4);
            comboBoxJenisSampah.Name = "comboBoxJenisSampah";
            comboBoxJenisSampah.Size = new Size(150, 35);
            comboBoxJenisSampah.TabIndex = 9;
            comboBoxJenisSampah.SelectedIndexChanged += comboBoxJenisSampah_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(444, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 27);
            label3.TabIndex = 11;
            label3.Text = "KG";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(292, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 21);
            label4.TabIndex = 12;
            label4.Text = "*minimal 1 kilogram";
            // 
            // Tambah_Sampah
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxJenisSampah);
            Controls.Add(lblInstruksi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbKuantitas);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            MinimumSize = new Size(658, 407);
            Name = "Tambah_Sampah";
            Text = "InTrash";
            Load += Tambah_Sampah_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnKembali;
        private TextBox tbKuantitas;
        private Label label1;
        private Label label2;
        private Label lblInstruksi;
        private ComboBox comboBoxJenisSampah;
        private Label label3;
        private Label label4;
    }
}