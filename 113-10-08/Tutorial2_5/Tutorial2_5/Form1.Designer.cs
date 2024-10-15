namespace Tutorial2_5
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
            ptxBack = new PictureBox();
            ptxFront = new PictureBox();
            btnShowBack = new Button();
            btnShowFront = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(27, 37);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(167, 234);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            // 
            // ptxFront
            // 
            ptxFront.Image = Properties.Resources.Ace_Spades;
            ptxFront.Location = new Point(232, 37);
            ptxFront.Name = "ptxFront";
            ptxFront.Size = new Size(167, 234);
            ptxFront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFront.TabIndex = 1;
            ptxFront.TabStop = false;
            ptxFront.Visible = false;
            // 
            // btnShowBack
            // 
            btnShowBack.Location = new Point(47, 308);
            btnShowBack.Name = "btnShowBack";
            btnShowBack.Size = new Size(132, 63);
            btnShowBack.TabIndex = 2;
            btnShowBack.Text = "背面";
            btnShowBack.UseVisualStyleBackColor = true;
            btnShowBack.Click += btnShowBack_Click;
            // 
            // btnShowFront
            // 
            btnShowFront.Location = new Point(247, 308);
            btnShowFront.Name = "btnShowFront";
            btnShowFront.Size = new Size(132, 63);
            btnShowFront.TabIndex = 3;
            btnShowFront.Text = "正面";
            btnShowFront.UseVisualStyleBackColor = true;
            btnShowFront.Click += btnShowFront_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(56, 399);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(323, 52);
            btnExit.TabIndex = 4;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 478);
            Controls.Add(btnExit);
            Controls.Add(btnShowFront);
            Controls.Add(btnShowBack);
            Controls.Add(ptxFront);
            Controls.Add(ptxBack);
            Font = new Font("Microsoft JhengHei UI", 16F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxFront;
        private Button btnShowBack;
        private Button btnShowFront;
        private Button btnExit;
    }
}
