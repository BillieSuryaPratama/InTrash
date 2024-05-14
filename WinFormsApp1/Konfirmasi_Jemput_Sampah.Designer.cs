namespace WinFormsApp1
{
    partial class Konfirmasi_Jemput_Sampah
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
            button1 = new Button();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(300, 267);
            button1.Name = "button1";
            button1.Size = new Size(230, 34);
            button1.TabIndex = 59;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(368, 226);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 57;
            label10.Text = "label10";
            label10.Click += this.label10_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(300, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(230, 124);
            dataGridView1.TabIndex = 56;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 60);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 52;
            label6.Text = "label6";
            label6.Click += this.label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 35);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 50;
            label4.Text = "label4";
            label4.Click += this.label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 48;
            label1.Text = "label1";
            label1.Click += this.label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 404);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 66;
            button2.Text = "kembali";
            button2.UseVisualStyleBackColor = true;
            // 
            // Konfirmasi_Jemput_Sampah
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Konfirmasi_Jemput_Sampah";
            Text = "Form17";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label10;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label4;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
    }
}