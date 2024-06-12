namespace WinFormsApp1.Views
{
    partial class Form2
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
            dgvInformasiSampah = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MetodePencairan = new DataGridViewTextBoxColumn();
            RekeningTujuan = new DataGridViewTextBoxColumn();
            Nominal = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnKembali.AutoSize = true;
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(26, 316);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 32);
            btnKembali.TabIndex = 27;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // dgvInformasiSampah
            // 
            dgvInformasiSampah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformasiSampah.BackgroundColor = Color.Gainsboro;
            dgvInformasiSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformasiSampah.Columns.AddRange(new DataGridViewColumn[] { ID, MetodePencairan, RekeningTujuan, Nominal, Status });
            dgvInformasiSampah.Location = new Point(26, 24);
            dgvInformasiSampah.Margin = new Padding(2, 3, 2, 3);
            dgvInformasiSampah.Name = "dgvInformasiSampah";
            dgvInformasiSampah.RowHeadersWidth = 62;
            dgvInformasiSampah.Size = new Size(592, 260);
            dgvInformasiSampah.TabIndex = 28;
            dgvInformasiSampah.CellContentClick += dgvInformasiSampah_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // MetodePencairan
            // 
            MetodePencairan.HeaderText = "Metode Pencairan";
            MetodePencairan.MinimumWidth = 6;
            MetodePencairan.Name = "MetodePencairan";
            // 
            // RekeningTujuan
            // 
            RekeningTujuan.HeaderText = "Rekening Tujuan";
            RekeningTujuan.MinimumWidth = 6;
            RekeningTujuan.Name = "RekeningTujuan";
            RekeningTujuan.ReadOnly = true;
            // 
            // Nominal
            // 
            Nominal.HeaderText = "Nominal";
            Nominal.MinimumWidth = 6;
            Nominal.Name = "Nominal";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(640, 360);
            Controls.Add(dgvInformasiSampah);
            Controls.Add(btnKembali);
            Name = "Form2";
            Text = "InTrash";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private DataGridView dgvInformasiSampah;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MetodePencairan;
        private DataGridViewTextBoxColumn RekeningTujuan;
        private DataGridViewTextBoxColumn Nominal;
        private DataGridViewTextBoxColumn Status;
    }
}