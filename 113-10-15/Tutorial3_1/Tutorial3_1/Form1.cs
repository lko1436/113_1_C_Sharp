namespace Tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            string output;
            output = "����" + txtyear.Text + "�~" + txtmonth.Text + "��" + txtday.Text + "��" + "�P��" + txtDayofWeek.Text;

            lblshow.Text = output;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDayofWeek.Text = "";
            txtday.Text = "";
            txtmonth.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
