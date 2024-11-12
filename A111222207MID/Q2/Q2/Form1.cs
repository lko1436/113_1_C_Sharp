namespace Q2
{
    public partial class Form1 : Form
    {
        const double BANANA = 115;
        const double APPLE = 80;
        const double ORANGE = 90;
        const double PEAR = 120;

        Boolean bananaClicked = false;
        Boolean appleClicked = false;
        Boolean orangeClicked = false;
        Boolean pearClicked = false;

        private double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (bananaClicked)
            {
                bananaClicked = false;
                total -= BANANA;
            }
            else
            {
                bananaClicked = true;
                total += BANANA;
            }


            label2.Text = "Total: " + total.ToString();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {


            if (appleClicked)
            {
                appleClicked = false;
                total -= APPLE;
            }
            else
            {
                appleClicked = true;
                total += APPLE;
            }

            label2.Text = "Total: " + total.ToString();



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (orangeClicked)
            {
                orangeClicked = false;
                total -= ORANGE;
            }
            else
            {
                orangeClicked = true;
                total += ORANGE;
            }

            label2.Text = "Total: " + total.ToString();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pearClicked)
            {
                pearClicked = false;
                total -= PEAR;
            }
            else
            {
                pearClicked = true;
                total += PEAR;
            }

            label2.Text = "Total: " + total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            label2.Text = "Total: " + total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

