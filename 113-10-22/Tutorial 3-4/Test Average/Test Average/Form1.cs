using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal Test1;
            decimal Test2;
            decimal Test3;
            decimal average;
            try
            {
                Test1 = decimal.Parse(test1TextBox.Text);
                Test2 = decimal.Parse(test2TextBox.Text);
                Test3 = decimal.Parse(test3TextBox.Text);

                average = (Test1 + Test2 + Test3) / 3;
                averageLabel.Text = average.ToString("n1");
            }
            catch
            {
                MessageBox.Show("輸入資料格式錯誤");
            }
               
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }
    }
}
