using System;
using System.Windows.Forms;

namespace Chris_sCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My first message", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }

        private void Divide_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Message_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey sweetheart. Have a wonderful day at work! We love you!\r\nCant wait to see you when you get home!");
        }

    }
}
