using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // 用來儲存利率。
            decimal balance; // 用來儲存起始餘額。
            int months; // 用來儲存月數。
            
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            { 
                // 使用迴圈計算每個月的餘額。
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    int count = 1; // 用來計算月份。
                    while (count <= months)
                    {
                        // 計算每個月的餘額。
                        balance = balance + (balance * INTEREST_RATE);
                        count += 1;
                    }

                    // 顯示最後的餘額
                    endingBalanceLabel.Text = balance.ToString("c");

                }
                else
                {
                    // 顯示錯誤訊息。
                    MessageBox.Show("輸入[月分數量]資料格式錯誤");
                }
            }
            else
            {
                
                // 顯示錯誤訊息。
                MessageBox.Show("輸入[起始餘額]資料格式錯誤");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
