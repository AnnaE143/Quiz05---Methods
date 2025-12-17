namespace Quiz05___Methods
{
    public partial class Form1 : Form
    {
        int product;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            Random randNumber = new Random();
            int randomNumber;
            randomNumber = randNumber.Next(1, 11);
            outputLabel.Text = randomNumber.ToString();
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            productNumber();
            outputLabel.Text = product.ToString();
        }
        private int productNumber()
        {
            return product = 45 * 50;
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
