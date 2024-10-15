namespace Tutorial3_1
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
            label4 = new Label();
            txtDayofWeek = new TextBox();
            txtday = new TextBox();
            txtmonth = new TextBox();
            txtyear = new TextBox();
            lblshow = new Label();
            btnshowdate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(100, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(124, 88);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(124, 154);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(124, 215);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtDayofWeek
            // 
            txtDayofWeek.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDayofWeek.Location = new Point(224, 19);
            txtDayofWeek.Name = "txtDayofWeek";
            txtDayofWeek.Size = new Size(247, 48);
            txtDayofWeek.TabIndex = 4;
            // 
            // txtday
            // 
            txtday.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtday.Location = new Point(224, 77);
            txtday.Name = "txtday";
            txtday.Size = new Size(247, 48);
            txtday.TabIndex = 5;
            // 
            // txtmonth
            // 
            txtmonth.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtmonth.Location = new Point(224, 143);
            txtmonth.Name = "txtmonth";
            txtmonth.Size = new Size(247, 48);
            txtmonth.TabIndex = 6;
            // 
            // txtyear
            // 
            txtyear.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtyear.Location = new Point(224, 204);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(247, 48);
            txtyear.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblshow.Location = new Point(100, 271);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(466, 93);
            lblshow.TabIndex = 8;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnshowdate
            // 
            btnshowdate.Location = new Point(100, 394);
            btnshowdate.Name = "btnshowdate";
            btnshowdate.Size = new Size(114, 44);
            btnshowdate.TabIndex = 9;
            btnshowdate.Text = "顯示完整日期";
            btnshowdate.UseVisualStyleBackColor = true;
            btnshowdate.Click += btnshowdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(278, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 44);
            btnClear.TabIndex = 10;
            btnClear.Text = "清空內容";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(452, 394);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 44);
            btnExit.TabIndex = 11;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(670, 558);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnshowdate);
            Controls.Add(lblshow);
            Controls.Add(txtyear);
            Controls.Add(txtmonth);
            Controls.Add(txtday);
            Controls.Add(txtDayofWeek);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtDayofWeek;
        private TextBox txtday;
        private TextBox txtmonth;
        private TextBox txtyear;
        private Label lblshow;
        private Button btnshowdate;
        private Button btnClear;
        private Button btnExit;
    }
}
