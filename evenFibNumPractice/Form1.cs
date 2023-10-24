using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evenFibNumPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declaration
            //get user input
            int.TryParse(txtUserNum.Text, out int totalNum);
            int counter;
            int firstNum = 0;
            int secondNum = 1;
            int thirdNum;
            string output = "";

            //calculation
            counter = 0;
            while (counter < totalNum)
            {
                if (firstNum % 2 == 0)
                {
                    output = output + " " + Convert.ToString(firstNum);
                    counter++;
                }
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;

            }

            //output
            lblResult.Text = output;


        }
    }
}
