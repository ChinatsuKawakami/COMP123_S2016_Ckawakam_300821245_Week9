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

        public string ActiveOperator { get; set; }
        public string FirstOperand { get; set; }
        public string SecondOperand { get; set; }
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
            //check to see if ResultTextBox a 0 in it
            if(String.Equals(ResultTextBox.Text,"0"))
            {
                ResultTextBox.Clear();
            }
            // read the string in the TextBox
            string currentResult = ResultTextBox.Text;

            //add the text of the button in the textBox
            currentResult +=buttonClicked.Text;

            //update the ResultTextBox


            ResultTextBox.Text = currentResult;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text ="0";
            this.FirstOperand = "0";
            this.SecondOperand = "0";
           // Debug.WriteLine(this.ActiveOperator);
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button operatorClicked = (Button)sender;
            this.ActiveOperator = operatorClicked.Text;

            if(String.IsNullOrEmpty(this.FirstOperand))
            {
                this.FirstOperand = ResultTextBox.Text;
            }if(String.IsNullOrEmpty(this.SecondOperand))
            {
                this.SecondOperand = ResultTextBox.Text;
            }
            ResultTextBox.Clear();

            //Debug.WriteLine(this.ActiveOperator);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            int FirstNumber=0;
            int SecondNumber=0;
            int result = 0;

            if(String.IsNullOrEmpty(this.FirstOperand))
            {
                FirstNumber = Convert.ToInt32(this.FirstOperand);

            }
            if(String.IsNullOrEmpty(this.SecondOperand))
            {
                SecondNumber = Convert.ToInt32(this.SecondOperand);

            }
            
            switch(ActiveOperator)
            {
                case "+":
                    result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    result = FirstNumber - SecondNumber;
                    break;
                case "x":
                    result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    result = FirstNumber / SecondNumber;
                    break;
                    
            }
            ResultTextBox.Text = result.ToString();
        }

        

     
  



       
    }
}
