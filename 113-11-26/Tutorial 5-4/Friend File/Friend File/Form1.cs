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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個 StreamWriter 物件，用來寫入檔案。
                StreamWriter outputFile;

                // 開啟 Friends.txt 檔案，如果檔案不存在，則建立檔案。
                outputFile = File.AppendText(@"C:\Users\shu\Desktop\Friends.txt");

                // 將名字寫入檔案。
                outputFile.WriteLine(nameTextBox.Text);

                // 關閉檔案。
                outputFile.Close();

                // 清除文字方塊。
                nameTextBox.Text = "";

                // 顯示訊息。
                MessageBox.Show("名字已經寫入檔案。");
            }
           
            catch(Exception ex)
            {
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
