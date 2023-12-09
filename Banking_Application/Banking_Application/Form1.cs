namespace Banking_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            d.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f =new Form4();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }
    }
}