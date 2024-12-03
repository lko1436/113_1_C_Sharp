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
        private SaveFileDialog saveFile; // 新增 SaveFileDialog 變數

        public Form1()
        {
            InitializeComponent();
            saveFile = new SaveFileDialog(); // 初始化 SaveFileDialog
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            // 這裡是寫入名字的按鈕點擊事件處理程式
            try
            {
                StreamWriter outputFile;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.AppendText(saveFile.FileName);
                    outputFile.WriteLine(nameTextBox.Text);
                    outputFile.Close();
                    MessageBox.Show("名字已經寫入檔案");
                }
                else
                {
                    MessageBox.Show("使用者取消了操作");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}