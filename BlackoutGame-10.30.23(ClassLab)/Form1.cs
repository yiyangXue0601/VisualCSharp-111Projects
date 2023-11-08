using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackoutGame_10._30._23_ClassLab_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global variable
        int movesCounters = 0;

        //when game first started, btns are randomized.
        private void Form1_Load(object sender, EventArgs e)
        {
            GameSetup();
        }//void Form1_Load

        // when user clicks reset, btns are randomized.
        private void btnReset_Click(object sender, EventArgs e)
        {
            GameSetup();
            EnableBtns();

        }//void btnReset_Click

        ////New Function
        void swap(ref Button myButton) //orginal needs to be changed, methods can pass any date type of the arguments.
        {
            if (myButton.BackColor.Equals(Color.Red))
            {
                
                myButton.BackColor = Color.White;
                
            }
            else
            {
                myButton.BackColor = Color.Red;
            }
        }//void swap

        ////New Function
        void GameSetup()
        {

            Random randomGenrator = new Random();
            

            //Randomize btn1
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn1.BackColor = Color.Red;
            }
            else
            {
                btn1.BackColor = Color.White;
            }

            //Randomize btn2
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn2.BackColor = Color.Red;
            }
            else
            {
                btn2.BackColor = Color.White;
            }

            //Randomize btn3
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn3.BackColor = Color.Red;
            }
            else
            {
                btn3.BackColor = Color.White;
            }

            //Randomize btn4
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn4.BackColor = Color.Red;
            }
            else
            {
                btn4.BackColor = Color.White;
            }

            //Randomize btn5
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn5.BackColor = Color.Red;
            }
            else
            {
                btn5.BackColor = Color.White;
            }

            //Randomize btn6
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn6.BackColor = Color.Red;
            }
            else
            {
                btn6.BackColor = Color.White;
            }

            //Randomize btn7
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn7.BackColor = Color.Red;
            }
            else
            {
                btn7.BackColor = Color.White;
            }

            //Randomize btn8
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn8.BackColor = Color.Red;
            }
            else
            {
                btn8.BackColor = Color.White;
            }

            //Randomize btn9
            if (randomGenrator.Next(0, 2) == 0)
            {
                btn9.BackColor = Color.Red;
            }
            else
            {
                btn9.BackColor = Color.White;
            }

            movesCounters = 0;
            lblMoves.Text = movesCounters.ToString();

        }//void GameSetup

        //if game is won. btns need to be disabled
        private void DisableBtns()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        //if game reset, all btns need to be enabled
        private void EnableBtns()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        //Check if user wins
        private void CheckForWin()
        {
            //if all background colors are the same, user wins
            if (btn1.BackColor == btn2.BackColor &&
                btn1.BackColor == btn3.BackColor &&
                btn1.BackColor == btn4.BackColor &&
                btn1.BackColor == btn5.BackColor &&
                btn1.BackColor == btn6.BackColor &&
                btn1.BackColor == btn7.BackColor &&
                btn1.BackColor == btn8.BackColor &&
                btn1.BackColor == btn9.BackColor)
            {
                DisableBtns();
            }
        }

        //everytime users clicks a btn, move += 1, then print move, and check if they win
        private void IncrementMovesNCheckWin()
        {
            //moves = moves + 1;
            movesCounters += 1;
            lblMoves.Text = movesCounters.ToString();

            //when user clicks each btn, check if they win or not
            CheckForWin();
        }

        //when user clicks btn1, what btns swaps
        ////ANYTHING that is rewritten or reused CAN be written as a method
        private void btn1_Click(object sender, EventArgs e)
        {
            //1,2,4
            swap(ref btn1);
            swap(ref btn2);
            swap(ref btn4);

            IncrementMovesNCheckWin();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //1,2,3,5
            swap(ref btn1);
            swap(ref btn2);
            swap(ref btn3);
            swap(ref btn5);

            IncrementMovesNCheckWin();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //2,3,6
            swap(ref btn2);
            swap(ref btn3);
            swap(ref btn6);

            IncrementMovesNCheckWin();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //1,4,5,7
            swap(ref btn1);
            swap(ref btn4);
            swap(ref btn5);
            swap(ref btn7);

            IncrementMovesNCheckWin();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //2,4,5,6,8
            swap(ref btn2);
            swap(ref btn4);
            swap(ref btn5);
            swap(ref btn6);
            swap(ref btn8);

            IncrementMovesNCheckWin();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //3,5,6,9
            swap(ref btn3);
            swap(ref btn5);
            swap(ref btn6);
            swap(ref btn9);

            IncrementMovesNCheckWin();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //4,7,8
            swap(ref btn4);
            swap(ref btn7);
            swap(ref btn8);

            IncrementMovesNCheckWin();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //5,7,8,9
            swap(ref btn5);
            swap(ref btn7);
            swap(ref btn8);
            swap(ref btn9);

            IncrementMovesNCheckWin();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //6,8,9
            swap(ref btn6);
            swap(ref btn8);
            swap(ref btn9);

            IncrementMovesNCheckWin();
        }
    }
}
