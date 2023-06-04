namespace Assignment2
{
    partial class StartUp
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
            components = new System.ComponentModel.Container();
            pgbLoad = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pgbLoad
            // 
            pgbLoad.Location = new Point(324, 352);
            pgbLoad.Name = "pgbLoad";
            pgbLoad.Size = new Size(445, 29);
            pgbLoad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 48);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Đón xem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(324, 79);
            label2.Name = "label2";
            label2.Size = new Size(303, 20);
            label2.TabIndex = 2;
            label2.Text = "Giới thiệu các câu lạc bộ bóng đá nổi tiếng";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.error;
            pictureBox1.Image = Properties.Resources.UEFA_Champions_League_svg;
            pictureBox1.InitialImage = Properties.Resources.UEFA_Champions_League_svg;
            pictureBox1.Location = new Point(69, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Bisque;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(324, 180);
            label3.Name = "label3";
            label3.Size = new Size(445, 20);
            label3.TabIndex = 4;
            label3.Text = "Với nhiều logo đẹp và ấn tượng về các câu lạc bộ bạn yêu thích";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.error;
            pictureBox2.Image = Properties.Resources.combined_ball_image;
            pictureBox2.InitialImage = Properties.Resources.combined_ball_image;
            pictureBox2.Location = new Point(69, 319);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.theme1;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pgbLoad);
            Name = "StartUp";
            Text = "EXERCISE3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgbLoad;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}