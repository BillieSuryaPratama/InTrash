namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reward_Admin));
            btnKonfirmasi = new Button();
            dgvListReward = new DataGridView();
            tbKonfirmasi = new TextBox();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListReward).BeginInit();
            SuspendLayout();
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackgroundImage = (Image)resources.GetObject("btnKonfirmasi.BackgroundImage");
            btnKonfirmasi.ForeColor = Color.Transparent;
            btnKonfirmasi.Location = new Point(650, 331);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(112, 34);
            btnKonfirmasi.TabIndex = 33;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // dgvListReward
            // 
            dgvListReward.BackgroundColor = Color.CadetBlue;
            dgvListReward.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListReward.Location = new Point(44, 22);
            dgvListReward.Margin = new Padding(2);
            dgvListReward.Name = "dgvListReward";
            dgvListReward.RowHeadersWidth = 62;
            dgvListReward.Size = new Size(719, 281);
            dgvListReward.TabIndex = 32;
            // 
            // tbKonfirmasi
            // 
            tbKonfirmasi.Location = new Point(418, 331);
            tbKonfirmasi.Margin = new Padding(2);
            tbKonfirmasi.Name = "tbKonfirmasi";
            tbKonfirmasi.Size = new Size(206, 31);
            tbKonfirmasi.TabIndex = 34;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(12, 404);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 35;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // Reward_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(tbKonfirmasi);
            Controls.Add(btnKonfirmasi);
            Controls.Add(dgvListReward);
            Margin = new Padding(2);
            Name = "Reward_Admin";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvListReward).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKonfirmasi;
        private DataGridView dgvListReward;
        private TextBox tbKonfirmasi;
        private Button btnKembali;
    }
}