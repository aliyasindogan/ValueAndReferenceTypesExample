using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueAndReferenceTypesExample
{
    public partial class ValueType : Form
    {
        public ValueType()
        {
            InitializeComponent();
        }

        private void btnShowValue_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            int number2 = 2;
            number1 = number2;
            number2 = 99;

            lblNumber1.Text = number1.ToString();
            lblNumber2.Text = number2.ToString();
        }
    }
}