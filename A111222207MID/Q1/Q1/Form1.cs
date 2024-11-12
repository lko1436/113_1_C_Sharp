using static System.Net.Mime.MediaTypeNames;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal Length;
            decimal Width;
            decimal UnitPrice;
            decimal TotalPrice;
            try
            {
                Length = decimal.Parse(LengthBox.Text);
                Width = decimal.Parse(WidthBox.Text);
                UnitPrice = decimal.Parse(UnitCostBox.Text);
                TotalPrice = UnitPrice *2 *  (Length + Width);

                TotalCostLab.Text = TotalPrice.ToString("C");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
