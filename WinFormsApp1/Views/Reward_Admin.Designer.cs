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
            btnKonfirmasi = new Button();
            dgvListReward = new DataGridView();
            tbKonfirmasi = new TextBox();
            btnKembali = new Button();
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
            // 
            // dgvListReward
            // 
            dgvListReward.BackgroundColor = Color.Gainsboro;
            dgvListReward.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListReward.Location = new Point(35, 18);
            dgvListReward.Margin = new Padding(2);
            dgvListReward.Name = "dgvListReward";
            dgvListReward.RowHeadersWidth = 62;
            dgvListReward.Size = new Size(575, 225);
            dgvListReward.TabIndex = 32;
            // 
            // tbKonfirmasi
            // 
            tbKonfirmasi.Location = new Point(334, 265);
            tbKonfirmasi.Margin = new Padding(2);
            tbKonfirmasi.Name = "tbKonfirmasi";
            tbKonfirmasi.Size = new Size(166, 27);
            tbKonfirmasi.TabIndex = 34;
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
            // 
            // Reward_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
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