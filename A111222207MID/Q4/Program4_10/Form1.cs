using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory; //熱量(卡路里)
            double gram;   //克數(脂肪重量)


            if (double.TryParse(textBox1.Text, out calory) & double.TryParse(textBox2.Text, out gram))
            {
                double fat = gram * 9; 
                double percent = fat / calory * 100;

                label3.Text = "The number of calories from fat is " + fat.ToString("")  + "\n" +
                              "The percentage of calories from fat is " + percent.ToString("") + "%." + "\n"+
                              "The food is considened low fat.";

            }
            else
            {
                MessageBox.Show("輸入不正確");
            }

            //以下作答，必須使用double.TryParse()方法
        }
    }
}
