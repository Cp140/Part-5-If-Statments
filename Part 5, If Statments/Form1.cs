using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5__If_Statments
{
    public partial class IfStatments : Form
    {
        public IfStatments()
        {
            InitializeComponent();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            if (age < 5)
            {
                
            }
            else if (age < 10)
            {
                
            }
            else if (age < 12)
            {
                
            }
            else if (age < 18
            {

            }
            else
            {
                
            }
        }
    }
}
