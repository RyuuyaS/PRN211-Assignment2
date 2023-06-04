namespace Assignment2
{
    partial class Lunar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbCalendar = new TextBox();
            tbLunar = new TextBox();
            btnView = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 58);
            label1.Name = "label1";
            label1.Size = new Size(332, 20);
            label1.TabIndex = 0;
            label1.Text = "Chương trình đổi năm dương lịch sang âm lịch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(271, 119);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Năm dương lịch: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(271, 172);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Năm âm lịch: ";
            // 
            // tbCalendar
            // 
            tbCalendar.Location = new Point(447, 119);
            tbCalendar.Name = "tbCalendar";
            tbCalendar.Size = new Size(125, 27);
            tbCalendar.TabIndex = 3;
            tbCalendar.Enter += tbCalendar_Enter;
            tbCalendar.Leave += tbCalendar_Leave;
            // 
            // tbLunar
            // 
            tbLunar.Location = new Point(447, 172);
            tbLunar.Name = "tbLunar";
            tbLunar.Size = new Size(125, 27);
            tbLunar.TabIndex = 4;
            tbLunar.Enter += tbLunar_Enter;
            tbLunar.Leave += tbLunar_Leave;
            // 
            // btnView
            // 
            btnView.Location = new Point(276, 245);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 5;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(447, 245);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Lunar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnView);
            Controls.Add(tbLunar);
            Controls.Add(tbCalendar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lunar";
            Text = "Calendar -> Lunar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbCalendar;
        private TextBox tbLunar;
        private Button btnView;
        private Button btnExit;
    }
}