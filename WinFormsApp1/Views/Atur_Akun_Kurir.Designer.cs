namespace WinFormsApp1.Views
{
    partial class Atur_Akun_Kurir
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
            tbEdit = new TextBox();
            btnEditAkun = new Button();
            dgvListKurir = new DataGridView();
            btnHapusAkun = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(32, 248);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 37);
            btnKembali.TabIndex = 43;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // tbEdit
            // 
            tbEdit.BackColor = Color.Gainsboro;
            tbEdit.Location = new Point(332, 258);
            tbEdit.Margin = new Padding(2);
            tbEdit.Name = "tbEdit";
            tbEdit.Size = new Size(166, 27);
            tbEdit.TabIndex = 42;
            // 
            // btnEditAkun
            // 
            btnEditAkun.BackColor = Color.MediumTurquoise;
            btnEditAkun.BackgroundImage = Properties.Resources.Wireframe___56;
            btnEditAkun.ForeColor = Color.Black;
            btnEditAkun.Location = new Point(502, 258);
            btnEditAkun.Margin = new Padding(2);
            btnEditAkun.Name = "btnEditAkun";
            btnEditAkun.Size = new Size(106, 27);
            btnEditAkun.TabIndex = 41;
            btnEditAkun.Text = "Edit Akun";
            btnEditAkun.UseVisualStyleBackColor = false;
            // 
            // dgvListKurir
            // 
            dgvListKurir.BackgroundColor = Color.Gainsboro;
            dgvListKurir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListKurir.Location = new Point(33, 11);
            dgvListKurir.Margin = new Padding(2);
            dgvListKurir.Name = "dgvListKurir";
            dgvListKurir.RowHeadersWidth = 62;
            dgvListKurir.Size = new Size(575, 225);
            dgvListKurir.TabIndex = 40;
            // 
            // btnHapusAkun
            // 
            btnHapusAkun.BackColor = Color.MediumTurquoise;
            btnHapusAkun.BackgroundImage = Properties.Resources.Wireframe___56;
            btnHapusAkun.Location = new Point(502, 299);
            btnHapusAkun.Margin = new Padding(2);
            btnHapusAkun.Name = "btnHapusAkun";
            btnHapusAkun.Size = new Size(106, 27);
            btnHapusAkun.TabIndex = 45;
            btnHapusAkun.Text = "Hapus Akun";
            btnHapusAkun.UseVisualStyleBackColor = false;
            // 
            // Atur_Akun_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(637, 350);
            Controls.Add(btnHapusAkun);
            Controls.Add(btnKembali);
            Controls.Add(tbEdit);
            Controls.Add(btnEditAkun);
            Controls.Add(dgvListKurir);
            Name = "Atur_Akun_Kurir";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private TextBox tbEdit;
        private Button btnEditAkun;
        private DataGridView dgvListKurir;
        private Button btnHapusAkun;
    }
}