namespace Q1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LengthBox = new TextBox();
            WidthBox = new TextBox();
            UnitCostBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            TotalLab = new Label();
            TotalCostLab = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 68);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Length of the Field";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 108);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Width of the Field";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 149);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 2;
            label3.Text = "UnitCost OF Fencing";
            // 
            // LengthBox
            // 
            LengthBox.Location = new Point(176, 60);
            LengthBox.Name = "LengthBox";
            LengthBox.Size = new Size(100, 23);
            LengthBox.TabIndex = 3;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(176, 100);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(100, 23);
            WidthBox.TabIndex = 4;
            // 
            // UnitCostBox
            // 
            UnitCostBox.Location = new Point(176, 141);
            UnitCostBox.Name = "UnitCostBox";
            UnitCostBox.Size = new Size(100, 23);
            UnitCostBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(26, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Area";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(128, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Bundary";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(232, 264);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Cost";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(336, 264);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // TotalLab
            // 
            TotalLab.AutoSize = true;
            TotalLab.Location = new Point(59, 204);
            TotalLab.Name = "TotalLab";
            TotalLab.Size = new Size(0, 15);
            TotalLab.TabIndex = 10;
            // 
            // TotalCostLab
            // 
            TotalCostLab.BorderStyle = BorderStyle.FixedSingle;
            TotalCostLab.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TotalCostLab.Location = new Point(40, 196);
            TotalCostLab.Name = "TotalCostLab";
            TotalCostLab.Size = new Size(150, 33);
            TotalCostLab.TabIndex = 5;
            TotalCostLab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 332);
            Controls.Add(TotalCostLab);
            Controls.Add(TotalLab);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UnitCostBox);
            Controls.Add(WidthBox);
            Controls.Add(LengthBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LengthBox;
        private TextBox WidthBox;
        private TextBox UnitCostBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label TotalLab;
        private Label TotalCostLab;
    }
}
