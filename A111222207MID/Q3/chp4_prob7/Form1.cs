using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
            decimal netIncome; //淨收




            //以下作答
            income = decimal.Parse(incomeTextBox.Text);

            if (income <= 590000 )
            {         
                taxrate = 0.05m;
            }
            else if (income <= 1330000 & income >= 590001 )
            {
                taxrate = 0.12m;
            }
            else if (income <= 2660000 & income >= 1330001)
            {
                taxrate = 0.20m;
            }
            else if (income <= 4980000 & income >= 2660001 )
            {
                taxrate = 0.30m;
            }
            else
            {
                taxrate = 0.40m;
            }

            payable = income * taxrate;
            netIncome = income - payable;

            taxPayableLabel.Text = payable.ToString("c");
            netIncomeLabel.Text = netIncome.ToString("c");


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
