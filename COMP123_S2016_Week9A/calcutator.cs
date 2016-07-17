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

namespace COMP123_S2016_Week9A
{
    public partial class calcutator : Form
    {
        public calcutator()
        {
            InitializeComponent();
        }

   
      
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            //create a reference to the sender object
            // nad tell C sharp that it is a button
            Button buttonClicked = (Button)sender;
            Debug.WriteLine(buttonClicked.Text);

            // read the string in the TextBox
            string currentResult = ResultTextBox.Text;

            //add the text of the button in the textBox
            currentResult +=buttonClicked.Text;

            //update the ResultTextBox


            ResultTextBox.Text = currentResult;
        }
    }
}
