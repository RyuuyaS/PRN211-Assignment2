namespace Assignment2
{
    partial class frmMain
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
            rbLion = new RadioButton();
            rbTottenham = new RadioButton();
            rbArsenal = new RadioButton();
            rbFullham = new RadioButton();
            rbMu = new RadioButton();
            pic1 = new PictureBox();
            rbAleticoMadrid = new RadioButton();
            rbRealMandrid = new RadioButton();
            rbBarcenola = new RadioButton();
            rbInterMilan = new RadioButton();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 13);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 0;
            label1.Text = "Logo các câu lạc bộ bóng đá nổi tiếng";
            // 
            // rbLion
            // 
            rbLion.AutoSize = true;
            rbLion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbLion.Location = new Point(54, 73);
            rbLion.Name = "rbLion";
            rbLion.Size = new Size(60, 24);
            rbLion.TabIndex = 1;
            rbLion.TabStop = true;
            rbLion.Text = "Lion";
            rbLion.UseVisualStyleBackColor = true;
            rbLion.CheckedChanged += rbLion_CheckedChanged;
            // 
            // rbTottenham
            // 
            rbTottenham.AutoSize = true;
            rbTottenham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbTottenham.Location = new Point(54, 163);
            rbTottenham.Name = "rbTottenham";
            rbTottenham.Size = new Size(107, 24);
            rbTottenham.TabIndex = 2;
            rbTottenham.TabStop = true;
            rbTottenham.Text = "Tottenham";
            rbTottenham.UseVisualStyleBackColor = true;
            rbTottenham.CheckedChanged += rbTottenham_CheckedChanged;
            // 
            // rbArsenal
            // 
            rbArsenal.AutoSize = true;
            rbArsenal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbArsenal.Location = new Point(54, 133);
            rbArsenal.Name = "rbArsenal";
            rbArsenal.Size = new Size(83, 24);
            rbArsenal.TabIndex = 3;
            rbArsenal.TabStop = true;
            rbArsenal.Text = "Arsenal";
            rbArsenal.UseVisualStyleBackColor = true;
            rbArsenal.CheckedChanged += rbArsenal_CheckedChanged;
            // 
            // rbFullham
            // 
            rbFullham.AutoSize = true;
            rbFullham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbFullham.Location = new Point(54, 103);
            rbFullham.Name = "rbFullham";
            rbFullham.Size = new Size(86, 24);
            rbFullham.TabIndex = 4;
            rbFullham.TabStop = true;
            rbFullham.Text = "Fullham";
            rbFullham.UseVisualStyleBackColor = true;
            rbFullham.CheckedChanged += rbFullham_CheckedChanged;
            // 
            // rbMu
            // 
            rbMu.AutoSize = true;
            rbMu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbMu.Location = new Point(54, 193);
            rbMu.Name = "rbMu";
            rbMu.Size = new Size(163, 24);
            rbMu.TabIndex = 5;
            rbMu.TabStop = true;
            rbMu.Text = "Manchester United";
            rbMu.UseVisualStyleBackColor = true;
            rbMu.CheckedChanged += rbMu_CheckedChanged;
            // 
            // pic1
            // 
            pic1.ErrorImage = Properties.Resources.error;
            pic1.InitialImage = null;
            pic1.Location = new Point(474, 73);
            pic1.Name = "pic1";
            pic1.Size = new Size(200, 144);
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.TabIndex = 6;
            pic1.TabStop = false;
            // 
            // rbAleticoMadrid
            // 
            rbAleticoMadrid.AutoSize = true;
            rbAleticoMadrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbAleticoMadrid.Location = new Point(474, 257);
            rbAleticoMadrid.Name = "rbAleticoMadrid";
            rbAleticoMadrid.Size = new Size(133, 24);
            rbAleticoMadrid.TabIndex = 7;
            rbAleticoMadrid.TabStop = true;
            rbAleticoMadrid.Text = "Aletico Madrid";
            rbAleticoMadrid.UseVisualStyleBackColor = true;
            rbAleticoMadrid.CheckedChanged += rbAleticoMadrid_CheckedChanged;
            // 
            // rbRealMandrid
            // 
            rbRealMandrid.AutoSize = true;
            rbRealMandrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbRealMandrid.Location = new Point(474, 287);
            rbRealMandrid.Name = "rbRealMandrid";
            rbRealMandrid.Size = new Size(114, 24);
            rbRealMandrid.TabIndex = 8;
            rbRealMandrid.TabStop = true;
            rbRealMandrid.Text = "Real Madrid";
            rbRealMandrid.UseVisualStyleBackColor = true;
            rbRealMandrid.CheckedChanged += rbRealMandrid_CheckedChanged;
            // 
            // rbBarcenola
            // 
            rbBarcenola.AutoSize = true;
            rbBarcenola.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbBarcenola.Location = new Point(474, 317);
            rbBarcenola.Name = "rbBarcenola";
            rbBarcenola.Size = new Size(99, 24);
            rbBarcenola.TabIndex = 9;
            rbBarcenola.TabStop = true;
            rbBarcenola.Text = "Barcenola";
            rbBarcenola.UseVisualStyleBackColor = true;
            rbBarcenola.CheckedChanged += rbBarcenola_CheckedChanged;
            // 
            // rbInterMilan
            // 
            rbInterMilan.AutoSize = true;
            rbInterMilan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbInterMilan.Location = new Point(474, 347);
            rbInterMilan.Name = "rbInterMilan";
            rbInterMilan.Size = new Size(107, 24);
            rbInterMilan.TabIndex = 10;
            rbInterMilan.TabStop = true;
            rbInterMilan.Text = "Inter Milan";
            rbInterMilan.UseVisualStyleBackColor = true;
            rbInterMilan.CheckedChanged += rbInterMilan_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(105, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 44);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2022_08_17_210516;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(rbInterMilan);
            Controls.Add(rbBarcenola);
            Controls.Add(rbRealMandrid);
            Controls.Add(rbAleticoMadrid);
            Controls.Add(pic1);
            Controls.Add(rbMu);
            Controls.Add(rbFullham);
            Controls.Add(rbArsenal);
            Controls.Add(rbTottenham);
            Controls.Add(rbLion);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbLion;
        private RadioButton rbTottenham;
        private RadioButton rbArsenal;
        private RadioButton rbFullham;
        private RadioButton rbMu;
        private PictureBox pic1;
        private RadioButton rbAleticoMadrid;
        private RadioButton rbRealMandrid;
        private RadioButton rbBarcenola;
        private RadioButton rbInterMilan;
        private Button btnExit;
    }
}