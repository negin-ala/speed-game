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
    public partial class Form3 : Form
    {
        public string newname;
        public int newid;
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersdatabaseDataSet.tblusers' table. You can move, or remove it, as needed.
            this.tblusersTableAdapter.Fill(this.usersdatabaseDataSet.tblusers);

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            newname = tbname.Text;
           newid = Convert.ToInt32(tbid.Text);
            this.tblusersTableAdapter.Update(this.usersdatabaseDataSet.tblusers);
        }

        private void btnf3okay_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
          dr=  MessageBox.Show(tbname.Text+"   "+"is the new user","new user",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          if (dr == DialogResult.No)
              return;
            this.Close();
        }
    }
}
