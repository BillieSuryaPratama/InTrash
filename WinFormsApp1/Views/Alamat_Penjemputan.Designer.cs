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
            dgvListAlamat.BackgroundColor = Color.Gainsboro;
            dgvListAlamat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAlamat.Location = new Point(26, 23);
            dgvListAlamat.Name = "dgvListAlamat";
            dgvListAlamat.RowHeadersWidth = 51;
            dgvListAlamat.Size = new Size(583, 230);
            dgvListAlamat.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(26, 272);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 36);
            btnKembali.TabIndex = 11;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // Alamat_Penjemputan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
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