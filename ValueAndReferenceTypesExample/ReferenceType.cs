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
    public partial class ReferenceType : Form
    {
        public ReferenceType()
        {
            InitializeComponent();
            //...
        }

        private void btnShowValue_Click(object sender, EventArgs e)
        {
            int[] number1 = new int[] { 1, 2, 3 };
            int[] number2 = new int[] { 4, 5, 6 };
            number1 = number2;
            number2[0] = 30;

            lblNumber1.Text = number1[0].ToString();
            lblNumber2.Text = number2[0].ToString();
        }
    }
}