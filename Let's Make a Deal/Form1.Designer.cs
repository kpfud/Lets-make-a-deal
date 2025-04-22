namespace LetsMakeADeal
{
    partial class Form1
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
            btnDoor1 = new Button();
            btnDoor2 = new Button();
            btnDoor3 = new Button();
            label1 = new Label();
            lblMontyHall = new Label();
            btnYes = new Button();
            btnNo = new Button();
            lblPrize = new Label();
            SuspendLayout();
            // 
            // btnDoor1
            // 
            btnDoor1.Location = new Point(105, 114);
            btnDoor1.Name = "btnDoor1";
            btnDoor1.Size = new Size(70, 36);
            btnDoor1.TabIndex = 0;
            btnDoor1.Text = "1";
            btnDoor1.UseVisualStyleBackColor = true;
            // 
            // btnDoor2
            // 
            btnDoor2.Location = new Point(215, 114);
            btnDoor2.Name = "btnDoor2";
            btnDoor2.Size = new Size(70, 36);
            btnDoor2.TabIndex = 1;
            btnDoor2.Text = "2";
            btnDoor2.UseVisualStyleBackColor = true;
            // 
            // btnDoor3
            // 
            btnDoor3.Location = new Point(319, 114);
            btnDoor3.Name = "btnDoor3";
            btnDoor3.Size = new Size(70, 36);
            btnDoor3.TabIndex = 2;
            btnDoor3.Text = "3";
            btnDoor3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 43);
            label1.Name = "label1";
            label1.Size = new Size(320, 32);
            label1.TabIndex = 3;
            label1.Text = "Choose Door #1, #2, or #3.";
            // 
            // lblMontyHall
            // 
            lblMontyHall.BackColor = SystemColors.ControlLight;
            lblMontyHall.BorderStyle = BorderStyle.Fixed3D;
            lblMontyHall.Location = new Point(122, 174);
            lblMontyHall.Name = "lblMontyHall";
            lblMontyHall.Size = new Size(243, 87);
            lblMontyHall.TabIndex = 4;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(122, 295);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 29);
            btnYes.TabIndex = 5;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(258, 295);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 6;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // lblPrize
            // 
            lblPrize.BorderStyle = BorderStyle.FixedSingle;
            lblPrize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrize.Location = new Point(90, 348);
            lblPrize.Name = "lblPrize";
            lblPrize.Size = new Size(299, 46);
            lblPrize.TabIndex = 7;
            lblPrize.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 450);
            Controls.Add(lblPrize);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblMontyHall);
            Controls.Add(label1);
            Controls.Add(btnDoor3);
            Controls.Add(btnDoor2);
            Controls.Add(btnDoor1);
            Name = "Form1";
            Text = "Let's Make a Deal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoor1;
        private Button btnDoor2;
        private Button btnDoor3;
        private Label label1;
        private Label lblMontyHall;
        private Button btnYes;
        private Button btnNo;
        private Label lblPrize;
    }
}