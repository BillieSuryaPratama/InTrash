namespace WinFormsApp1.Views
{
    partial class Setor_Sampah
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
            textBoxNamaBank = new TextBox();
            dateTimePickerSetorSampah = new DateTimePicker();
            btnKonfirmasi = new Button();
            button4 = new Button();
            dataGridViewSetorSampah = new DataGridView();
            JenisSampah = new DataGridViewTextBoxColumn();
            Bobot = new DataGridViewTextBoxColumn();
            btnKembali = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxLokasiBank = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSetorSampah).BeginInit();
            SuspendLayout();
            // 
            // textBoxNamaBank
            // 
            textBoxNamaBank.Anchor = AnchorStyles.None;
            textBoxNamaBank.Location = new Point(255, 104);
            textBoxNamaBank.Margin = new Padding(2);
            textBoxNamaBank.Name = "textBoxNamaBank";
            textBoxNamaBank.ReadOnly = true;
            textBoxNamaBank.Size = new Size(261, 27);
            textBoxNamaBank.TabIndex = 19;
            textBoxNamaBank.TextChanged += textBoxNamaBank_TextChanged;
            // 
            // dateTimePickerSetorSampah
            // 
            dateTimePickerSetorSampah.Anchor = AnchorStyles.None;
            dateTimePickerSetorSampah.Location = new Point(255, 24);
            dateTimePickerSetorSampah.Margin = new Padding(2);
            dateTimePickerSetorSampah.Name = "dateTimePickerSetorSampah";
            dateTimePickerSetorSampah.Size = new Size(261, 27);
            dateTimePickerSetorSampah.TabIndex = 37;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Anchor = AnchorStyles.None;
            btnKonfirmasi.AutoSize = true;
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.Location = new Point(539, 322);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(90, 30);
            btnKonfirmasi.TabIndex = 40;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = Color.LightSeaGreen;
            button4.BackgroundImage = Properties.Resources.Wireframe___56;
            button4.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(382, 154);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(138, 31);
            button4.TabIndex = 42;
            button4.Text = "Tambah Sampah";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridViewSetorSampah
            // 
            dataGridViewSetorSampah.Anchor = AnchorStyles.None;
            dataGridViewSetorSampah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSetorSampah.BackgroundColor = Color.Gainsboro;
            dataGridViewSetorSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSetorSampah.Columns.AddRange(new DataGridViewColumn[] { JenisSampah, Bobot });
            dataGridViewSetorSampah.Location = new Point(70, 190);
            dataGridViewSetorSampah.Margin = new Padding(2);
            dataGridViewSetorSampah.Name = "dataGridViewSetorSampah";
            dataGridViewSetorSampah.RowHeadersWidth = 62;
            dataGridViewSetorSampah.Size = new Size(500, 120);
            dataGridViewSetorSampah.TabIndex = 43;
            // 
            // JenisSampah
            // 
            JenisSampah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            JenisSampah.HeaderText = "Jenis Sampah";
            JenisSampah.MinimumWidth = 6;
            JenisSampah.Name = "JenisSampah";
            JenisSampah.ReadOnly = true;
            // 
            // Bobot
            // 
            Bobot.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Bobot.HeaderText = "Bobot";
            Bobot.MinimumWidth = 6;
            Bobot.Name = "Bobot";
            Bobot.ReadOnly = true;
            // 
            // btnKembali
            // 
            btnKembali.Anchor = AnchorStyles.None;
            btnKembali.AutoSize = true;
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(11, 322);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 30);
            btnKembali.TabIndex = 44;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(119, 22);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 45;
            label2.Text = "Tanggal";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(119, 64);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 46;
            label3.Text = "Lokasi Bank";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(119, 104);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 47;
            label4.Text = "Deskripsi";
            // 
            // comboBoxLokasiBank
            // 
            comboBoxLokasiBank.Anchor = AnchorStyles.None;
            comboBoxLokasiBank.FormattingEnabled = true;
            comboBoxLokasiBank.Location = new Point(255, 63);
            comboBoxLokasiBank.Margin = new Padding(2);
            comboBoxLokasiBank.Name = "comboBoxLokasiBank";
            comboBoxLokasiBank.Size = new Size(261, 28);
            comboBoxLokasiBank.TabIndex = 49;
            comboBoxLokasiBank.SelectedIndexChanged += comboBoxLokasiBank_SelectedIndexChanged;
            // 
            // Setor_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(comboBoxLokasiBank);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnKembali);
            Controls.Add(dataGridViewSetorSampah);
            Controls.Add(button4);
            Controls.Add(btnKonfirmasi);
            Controls.Add(dateTimePickerSetorSampah);
            Controls.Add(textBoxNamaBank);
            Margin = new Padding(2);
            MinimumSize = new Size(658, 407);
            Name = "Setor_Sampah";
            Text = "InTrash";
            Load += SetorSampah_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSetorSampah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxNamaBank;
        private DateTimePicker dateTimePickerSetorSampah;
        private Button btnKonfirmasi;
        private Button button4;
        private DataGridView dataGridViewSetorSampah;
        private Button btnKembali;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxLokasiBank;
        private DataGridViewTextBoxColumn JenisSampah;
        private DataGridViewTextBoxColumn Bobot;
    }
}