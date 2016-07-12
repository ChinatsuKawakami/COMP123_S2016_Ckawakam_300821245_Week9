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
    public partial class LoginForm : Form
    {
        /**
         * <summary>
         * This is Form to input Password U
         * </summary>
         *@constructor: LoginForm
         *
         */
        public LoginForm()
        {
            InitializeComponent();
        }

        // PROVATE METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method clears the UsernameTextBox and the PasswordTextBox
         * </summary>
         * @private 
         * @method _clearForm
         * @returns{void}
         */
        private void _clearForm()
        {
            //UsernametextBox.Text = "";
           // PasswordtextBox.Text = "";
            UsernametextBox.Clear();
            PasswordtextBox.Clear();
        }
      /**
       * <summary>
       * This is the LoginButton Click event handler 
       * </summary>
       *@method: LoginBotton_Click
        @param {object} sender
        @param {EventArgs} e
        @returns{void}
       *
       */
        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Username:"+UsernametextBox.Text);
            Debug.WriteLine("Password:"+PasswordtextBox.Text);
            this._clearForm();

        }

        private void UsernametextBox_Leave(object sender, EventArgs e)
        {
            if(UsernametextBox.Text.Length < 6)
            {
                UsernametextBox.Focus();
                UsernametextBox.SelectAll();
                label1.Text = "UserName too short!";
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = "Please login";
                label1.ForeColor = Color.Black;
            }
        }

        private void PasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text.Length < 6)
            {
                PasswordtextBox.Focus();
                PasswordtextBox.SelectAll();
                label1.Text = "Password too short!";
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = "Please login";
                label1.ForeColor = Color.Black;
                button1.Enabled = true;
            }
          
        }
    }
}
