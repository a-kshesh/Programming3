using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InheritedForm
{
    public partial class Form2 : BaseFormLibrary.Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(int.Parse(textBox4.Text) - int.Parse(textBox3.Text));
        }
    }
}
