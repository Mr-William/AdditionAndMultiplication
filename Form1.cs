using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionAndMultiplication
{
    public partial class frmAddMultiply : Form
    {
        public frmAddMultiply()
        {
            InitializeComponent();
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            result1TextBox.Text = (int.Parse(valueATextBox.Text) + (int.Parse(valueBTextBox.Text) * int.Parse(valueCTextBox.Text))).ToString(); 

        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(valueATextBox.Text) + int.Parse(valueBTextBox.Text);
            result2TextBox.Text = (sum * (int.Parse(valueCTextBox.Text))).ToString();
        }
    }
}
