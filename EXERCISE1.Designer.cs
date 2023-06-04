namespace Assignment2
{
    partial class EXERCISE1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            chkClean = new CheckBox();
            chkWhitening = new CheckBox();
            chkXRay = new CheckBox();
            lblCleanCost = new Label();
            lblWhiteningCost = new Label();
            lblXRayCost = new Label();
            lblFilling = new Label();
            numFilling = new NumericUpDown();
            lblFillCost = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnExit = new Button();
            btnCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(273, 62);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(266, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(126, 133);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            txtName.Location = new Point(348, 130);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 27);
            txtName.TabIndex = 2;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(131, 193);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(81, 24);
            chkClean.TabIndex = 3;
            chkClean.Text = "Cạo vôi";
            chkClean.UseVisualStyleBackColor = true;
            chkClean.CheckedChanged += chkClean_CheckedChanged;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(131, 240);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(93, 24);
            chkWhitening.TabIndex = 4;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            chkWhitening.CheckedChanged += chkWhitening_CheckedChanged;
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Location = new Point(131, 285);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(131, 24);
            chkXRay.TabIndex = 5;
            chkXRay.Text = "Chụp hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            chkXRay.CheckedChanged += chkXRay_CheckedChanged;
            // 
            // lblCleanCost
            // 
            lblCleanCost.AutoSize = true;
            lblCleanCost.Location = new Point(615, 193);
            lblCleanCost.Name = "lblCleanCost";
            lblCleanCost.Size = new Size(68, 20);
            lblCleanCost.TabIndex = 6;
            lblCleanCost.Text = "$100.000";
            // 
            // lblWhiteningCost
            // 
            lblWhiteningCost.AutoSize = true;
            lblWhiteningCost.Location = new Point(604, 240);
            lblWhiteningCost.Name = "lblWhiteningCost";
            lblWhiteningCost.Size = new Size(79, 20);
            lblWhiteningCost.TabIndex = 7;
            lblWhiteningCost.Text = "$1.200.000";
            // 
            // lblXRayCost
            // 
            lblXRayCost.AutoSize = true;
            lblXRayCost.Location = new Point(615, 289);
            lblXRayCost.Name = "lblXRayCost";
            lblXRayCost.Size = new Size(68, 20);
            lblXRayCost.TabIndex = 8;
            lblXRayCost.Text = "$200.000";
            // 
            // lblFilling
            // 
            lblFilling.AutoSize = true;
            lblFilling.Location = new Point(131, 340);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(76, 20);
            lblFilling.TabIndex = 9;
            lblFilling.Text = "Trảm răng";
            // 
            // numFilling
            // 
            numFilling.Location = new Point(230, 340);
            numFilling.Name = "numFilling";
            numFilling.Size = new Size(77, 27);
            numFilling.TabIndex = 10;
            // 
            // lblFillCost
            // 
            lblFillCost.AutoSize = true;
            lblFillCost.Location = new Point(598, 340);
            lblFillCost.Name = "lblFillCost";
            lblFillCost.Size = new Size(85, 20);
            lblFillCost.TabIndex = 11;
            lblFillCost.Text = "$80.000/cái";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(390, 388);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(474, 385);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(209, 27);
            txtTotal.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(180, 441);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(589, 441);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 29);
            btnCalc.TabIndex = 15;
            btnCalc.Text = "Tính tiền";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblFillCost);
            Controls.Add(numFilling);
            Controls.Add(lblFilling);
            Controls.Add(lblXRayCost);
            Controls.Add(lblWhiteningCost);
            Controls.Add(lblCleanCost);
            Controls.Add(chkXRay);
            Controls.Add(chkWhitening);
            Controls.Add(chkClean);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private CheckBox chkClean;
        private CheckBox chkWhitening;
        private CheckBox chkXRay;
        private Label lblCleanCost;
        private Label lblWhiteningCost;
        private Label lblXRayCost;
        private Label lblFilling;
        private NumericUpDown numFilling;
        private Label lblFillCost;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnExit;
        private Button btnCalc;
    }
}