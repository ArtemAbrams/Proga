namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = textBox1.Text;
            if (ans == "")
            {
                MessageBox.Show("You have not entered anything");
                return;
            }
            if(int.TryParse(ans, out int n))
            {
                MessageBox.Show("You are enter "  + ans);
            }
            else
             {
                MessageBox.Show("Wrong value");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}