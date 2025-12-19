using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal workingMemory = 0;
        string opr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((tbDisplay.Text == "0") || (opr != "" && workingMemory != 0 && tbDisplay.Text == workingMemory.ToString()))
                tbDisplay.Clear();

            tbDisplay.Text += bt.Text;
        }

        private void btOperator_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            opr = bt.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);
            decimal result = 0;

            switch (opr)
            {
                case "+": result = workingMemory + secondValue; break;
                case "-": result = workingMemory - secondValue; break;
                case "*": result = workingMemory * secondValue; break;
                case "/":
                    if (secondValue != 0) result = workingMemory / secondValue;
                    break;
            }
            tbDisplay.Text = result.ToString();
            workingMemory = 0;
            opr = "";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            workingMemory = 0;
            opr = "";
            tbDisplay.Clear();
            tbDisplay.Text = "0";
        }
    }
}