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
        private void btnSubmitAge_Click(object sender, EventArgs e)
        {
            int age;                    

            if (Int32.TryParse(txtAge.Text, out age))
            {

                if (age < 5)
                {
                    lblStage.Text = ("infant");
                }
                else if (age < 11)
                {
                    lblStage.Text = ("Child");
                }
                else if (age < 13)
                {
                    lblStage.Text = ("Pre-Teen");
                }
                else if (age < 18)
                {
                    lblStage.Text = ("Teen Ager");
                }
                else if (age >= 18)
                {
                    lblStage.Text = ("adult");
                }
                else
                {

                }
            }
        }
    }

}
