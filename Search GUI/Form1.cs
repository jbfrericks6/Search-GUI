using System;
using System.Windows.Forms;

namespace Search_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  WebClient wb = new WebClient();
            int x = 2;
            x =+ 4;
            Console.WriteLine(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SearchTextBox.Text);
            this.Hide();
            SecondPage secondPage = new SecondPage();
            secondPage.Show();

        }
    }
}
