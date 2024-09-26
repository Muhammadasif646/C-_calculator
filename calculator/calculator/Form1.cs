namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 + num2;


            res.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            res.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 - num2;


            res.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 * num2;


            res.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 / num2;


            res.Text = result.ToString();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
