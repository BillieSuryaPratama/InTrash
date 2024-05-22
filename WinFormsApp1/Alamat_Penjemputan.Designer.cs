namespace WinFormsApp1
{
    partial class Alamat_Penjemputan
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
            dgvListAlamat = new DataGridView();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListAlamat).BeginInit();
            SuspendLayout();
            // 
            // dgvListAlamat
            // 
            dgvListAlamat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAlamat.Location = new Point(26, 23);
            dgvListAlamat.Name = "dgvListAlamat";
            dgvListAlamat.RowHeadersWidth = 51;
            dgvListAlamat.Size = new Size(583, 230);
            dgvListAlamat.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(11, 308);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 11;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // Alamat_Penjemputan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 346);
            Controls.Add(btnKembali);
            Controls.Add(dgvListAlamat);
            Name = "Alamat_Penjemputan";
            Text = "Alamat_Penjemputan";
            ((System.ComponentModel.ISupportInitialize)dgvListAlamat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListAlamat;
        private Button btnKembali;
    }
}