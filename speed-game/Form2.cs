using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication26
{
    public partial class Form2 : Form
    {
        public  bool cbf2;
       public string rbf2level;
        public Form2()
        {
            InitializeComponent();
        }


        private void btnf2okay_Click(object sender, EventArgs e)
        {
            cbf2 = chbf2sound.Checked;
            if (rbf2beginner.Checked == true)
                rbf2level = rbf2beginner.Text;
            else   if (rbf2master.Checked == true)
                rbf2level = rbf2master.Text;

            else   if (rbf2ultimate.Checked == true)
                rbf2level = rbf2ultimate.Text;
        }
    }
}
