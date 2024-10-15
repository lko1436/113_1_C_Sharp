namespace Tutorial3_2
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
            lblKM = new Label();
            label2 = new Label();
            label3 = new Label();
            txbKM = new TextBox();
            txbliter = new TextBox();
            lblShow = new Label();
            btnExit = new Button();
            btncalculate = new Button();
            SuspendLayout();
            // 
            // lblKM
            // 
            lblKM.AutoSize = true;
            lblKM.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblKM.Location = new Point(58, 38);
            lblKM.Name = "lblKM";
            lblKM.Size = new Size(114, 41);
            lblKM.TabIndex = 0;
            lblKM.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(58, 123);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(58, 242);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // txbKM
            // 
            txbKM.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbKM.Location = new Point(256, 40);
            txbKM.Name = "txbKM";
            txbKM.Size = new Size(268, 42);
            txbKM.TabIndex = 3;
            // 
            // txbliter
            // 
            txbliter.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txbliter.Location = new Point(256, 124);
            txbliter.Name = "txbliter";
            txbliter.Size = new Size(268, 42);
            txbliter.TabIndex = 4;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblShow.Location = new Point(256, 242);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(273, 49);
            lblShow.TabIndex = 5;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            lblShow.UseWaitCursor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(352, 331);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 67);
            btnExit.TabIndex = 6;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(81, 331);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(158, 67);
            btncalculate.TabIndex = 7;
            btncalculate.Text = "計算";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncalculate);
            Controls.Add(btnExit);
            Controls.Add(lblShow);
            Controls.Add(txbliter);
            Controls.Add(txbKM);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblKM);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKM;
        private Label label2;
        private Label label3;
        private TextBox txbKM;
        private TextBox txbliter;
        private Label lblShow;
        private Button btnExit;
        private Button btncalculate;
    }
}
