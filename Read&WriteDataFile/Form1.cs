using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;

namespace Read_WriteDataFile
{
    public partial class Form1 : Form
    {
        //global variables
        string favFood;
        string favDrink;
        string favColor;
        string favAnimal;

        string fileName;
        string deliminitedText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //get user input
            favFood = txtFavFood.Text;
            favDrink = txtFavDrink.Text;
            favColor = txtFavColor.Text;
            favAnimal = txtFavAnimal.Text;

            deliminitedText = favFood + "," + favDrink + "," + favColor + "," + favAnimal;

            //show dialog
            if (saveFD.ShowDialog() == DialogResult.Cancel)
            {
                txtFavAnimal.Clear();
                txtFavColor.Clear();
                txtFavDrink.Clear();
                txtFavFood.Clear();
                txtFavFood.Focus();
                return;
            }
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFD.FileName;
                

                //save data
                StreamWriter saveData;
                saveData = File.CreateText("My Favorite.txt");
                saveData.WriteLine(deliminitedText);

            }

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
