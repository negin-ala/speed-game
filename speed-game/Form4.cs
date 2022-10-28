using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication26
{
    public partial class Form4 : Form
    {
        public string chosenusername;
        string connectionstring = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Negin_GameProject\\WindowsFormsApplication26\\usersdatabase.mdf;Integrated Security=True";
        SqlConnection cnn;

        SqlDataAdapter adapter;
       public string name, lastname;
      public  int id, age, curBscore, curMscore, curUscore,selrowind;

        public Form4()
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionstring);
        }

        public Form4(string usscore)
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionstring);
            //txtscore.Text = usscore;
            //dataGridView1.Rows[selrowind].Cells[5].Value = usscore;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersdatabaseDataSet.tblusers' table. You can move, or remove it, as needed.
            this.tblusersTableAdapter.Fill(this.usersdatabaseDataSet.tblusers);

        }

        private void btnf4okay_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(richTextBox1.Text + "    is the chosen user", "chosen user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            else
            {
                chosenusername=name;
                this.Close();
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tblusersTableAdapter.Update(this.usersdatabaseDataSet.tblusers);

        }

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lastname=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            age = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            if (dataGridView1.CurrentRow.Cells[4].Value != DBNull.Value)
                curBscore = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            else
                curBscore = 0;
              if (dataGridView1.CurrentRow.Cells[5].Value != DBNull.Value)
            curMscore = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            else
                curMscore = 0;
              if (dataGridView1.CurrentRow.Cells[6].Value != DBNull.Value)
            curUscore = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            else
                curUscore = 0;
            selrowind = dataGridView1.CurrentRow.Index;
             
            richTextBox1.Text = "name is:" + "  " + name + "\n" + "last name is:" + "  " + lastname +
                "\n" + "age is:" + "  " + age.ToString() + "\n" + "id is:" + "  " + id.ToString()+"\n"+"Beginner score is :"+"  "+curBscore.ToString()
                +"\n"+"Master score is :"+"  "+curMscore.ToString()+"\n"+"Ultimate score is :"+"  "+curUscore.ToString();
            
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(richTextBox1.Text + "    do you want to delet this player", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            else
            {
                cnn.Open();
                string sqlcmd = "DELETE tblusers where Name = " + "N\'" + name + "\' ";
                //sqlcmd += "where Name = " + lblusername.Text;
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = new SqlCommand(sqlcmd, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                this.tblusersTableAdapter.Fill(this.usersdatabaseDataSet.tblusers);
                cnn.Close();
                
            }
        }
    }
}
