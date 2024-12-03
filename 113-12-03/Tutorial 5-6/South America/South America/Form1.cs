using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 這裡是取得國家按鈕的點擊事件處理程式。
            try
            {
                // 建立 StreamReader 物件，用來讀取國家清單。
                StreamReader inputFile;
                inputFile = File.OpenText("Countries.txt");
                countriesListBox.Items.Clear();

                // 讀取檔案，直到檔案結尾。
                while (!inputFile.EndOfStream)
                {
                    // 讀取檔案中的一行。
                    countriesListBox.Items.Add(inputFile.ReadLine());
                }

                // 關閉檔案。
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
