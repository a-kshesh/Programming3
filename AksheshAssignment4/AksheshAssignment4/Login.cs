using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AksheshAssignment4
{
    public partial class Login : UserControl
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void passwordText(object sender, EventArgs e)
        {
            Password = tbPassword.Text;
            tbPassword.PasswordChar = '*';
        }

        private void Username(object sender, EventArgs e)
        {
            UserName = tbName.Text;
        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            Email = tbEmail.Text;
        }
    }
}
