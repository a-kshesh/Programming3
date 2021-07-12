using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksheshAssignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (login1.UserName==null || login1.Password==null || login1.Email==null)
            {
                string s= "Please Enter Values";
                label1.Text = s;
                label2.Text ="";
                label3.Text = "";
            }
            else
            {
                label1.Text ="UserName: "+login1.UserName;
                label2.Text = "Password: " + login1.Password;
                label3.Text = "Email: " + login1.Email;
            }
        }
    }
}
