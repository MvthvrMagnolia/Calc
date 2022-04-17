using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fvknCal
{
    public partial class Form1 : Form
    {

        String operation = "";
        Double firstnum, secondnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form(object sender, EventArgs e)
        {

        }

        private void ClearClick(object sender, EventArgs e)
        {
            textdisplay.Text = "0";
        }

        private void clearEve(object sender, EventArgs e)
        {
            textdisplay.Text = "0";

            String f, s;
            s = Convert.ToString(secondnum);
            f = Convert.ToString(firstnum);

            s = "";
            f = "";
        }

        private void Operational_func(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstnum = Double.Parse(textdisplay.Text);
            operation = b.Text;
            textdisplay.Text = "";
        }

        private void BSClick(object sender, EventArgs e)
        {
            if (textdisplay.Text.Length > 0)
            {
                textdisplay.Text = textdisplay.Text.Remove(textdisplay.Text.Length - 1, 1);
            }

            if (textdisplay.Text.Length == 0)
            {
                textdisplay.Text = "0";
            }
        }
         
        private void plusMinus(object sender, EventArgs e)
        {
            if (textdisplay.Text.Contains("."))
            {
                // textdisplay.Text = textdisplay.Text.Remove(0, 1);
                textdisplay.Text = "-" + textdisplay.Text;
            }

            else
            {
                textdisplay.Text = "-" + textdisplay.Text;
            }
            
        }

        private void equal(object sender, EventArgs e)
        {
            secondnum = Double.Parse(textdisplay.Text);

            switch(operation)
            {
                case "+":
                    textdisplay.Text = Convert.ToString(firstnum + secondnum);
                    break;
               
                case "-":
                    textdisplay.Text = Convert.ToString(firstnum - secondnum);
                    break;

                case "*":
                    textdisplay.Text = Convert.ToString(firstnum * secondnum);
                    break;

                case "/":
                    textdisplay.Text = Convert.ToString(firstnum / secondnum);
                    break;
                    
                    default:
                    break;
            }
        }

        private void numericalValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (textdisplay.Text == "0")
                textdisplay.Text = "";

            if (b.Text == ".")
            {
                if (!textdisplay.Text.Contains("."))
                    textdisplay.Text = textdisplay.Text + b.Text;
            }

            else
            {
                textdisplay.Text = textdisplay.Text + b.Text;
            }
        }
    }
}
    
