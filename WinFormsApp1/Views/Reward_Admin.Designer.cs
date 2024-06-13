namespace WinFormsApp1.Views
{
    partial class Reward_Admin
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
            btnKonfirmasi = new Button();
            dgvListReward = new DataGridView();
            id_pencairan = new DataGridViewTextBoxColumn();
            rekening_tujuan = new DataGridViewTextBoxColumn();
            nominal = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Metode = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            btnKembali = new Button();
            cbKonfirmasi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListReward).BeginInit();
            SuspendLayout();
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnKonfirmasi.ForeColor = Color.Black;
            btnKonfirmasi.Location = new Point(520, 265);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(90, 27);
            btnKonfirmasi.TabIndex = 33;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // dgvListReward
            // 
            dgvListReward.BackgroundColor = Color.Gainsboro;
            dgvListReward.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListReward.Columns.AddRange(new DataGridViewColumn[] { id_pencairan, rekening_tujuan, nominal, Status, Metode, customer });
            dgvListReward.Location = new Point(35, 18);
            dgvListReward.Margin = new Padding(2);
            dgvListReward.Name = "dgvListReward";
            dgvListReward.RowHeadersWidth = 62;
            dgvListReward.Size = new Size(575, 225);
            dgvListReward.TabIndex = 32;
            // 
            // id_pencairan
            // 
            id_pencairan.HeaderText = "ID";
            id_pencairan.MinimumWidth = 6;
            id_pencairan.Name = "id_pencairan";
            id_pencairan.Width = 40;
            // 
            // rekening_tujuan
            // 
            rekening_tujuan.HeaderText = "Rekening Tujuan";
            rekening_tujuan.MinimumWidth = 6;
            rekening_tujuan.Name = "rekening_tujuan";
            rekening_tujuan.Width = 125;
            // 
            // nominal
            // 
            nominal.HeaderText = "Nominal Pencairan";
            nominal.MinimumWidth = 6;
            nominal.Name = "nominal";
            nominal.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Metode
            // 
            Metode.HeaderText = "Metode Pencairan";
            Metode.MinimumWidth = 6;
            Metode.Name = "Metode";
            Metode.Width = 125;
            // 
            // customer
            // 
            customer.HeaderText = "Nasabah";
            customer.MinimumWidth = 6;
            customer.Name = "customer";
            customer.Width = 125;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.Location = new Point(10, 323);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 35;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // cbKonfirmasi
            // 
            cbKonfirmasi.FormattingEnabled = true;
            cbKonfirmasi.Location = new Point(461, 265);
            cbKonfirmasi.Name = "cbKonfirmasi";
            cbKonfirmasi.Size = new Size(54, 28);
            cbKonfirmasi.TabIndex = 36;
            // 
            // Reward_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(cbKonfirmasi);
            Controls.Add(btnKembali);
            Controls.Add(btnKonfirmasi);
            Controls.Add(dgvListReward);
            Margin = new Padding(2);
            Name = "Reward_Admin";
            Text = "InTrash";
            Load += Reward_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListReward).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKonfirmasi;
        private DataGridView dgvListReward;
        private Button btnKembali;
        private ComboBox cbKonfirmasi;
        private DataGridViewTextBoxColumn id_pencairan;
        private DataGridViewTextBoxColumn rekening_tujuan;
        private DataGridViewTextBoxColumn nominal;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Metode;
        private DataGridViewTextBoxColumn customer;
    }
}