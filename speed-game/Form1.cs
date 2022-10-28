using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication26
{
    public partial class Form1 : Form
    {
        bool ussouch;
        int userid,scoreuser;
       
        string connectionstring = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Negin_GameProject\\WindowsFormsApplication26\\usersdatabase.mdf;Integrated Security=True";
        SqlConnection cnn;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionstring);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblf1score.Text = "";
            lblsound.Text = "";
            lblusername.Text = "";
            lbllevel.Text = "";
            lbluserid.Text = "";

            
            // TODO: This line of code loads data into the 'usersdatabaseDataSet.tblusers' table. You can move, or remove it, as needed.
            this.tblusersTableAdapter.Fill(this.usersdatabaseDataSet.tblusers);
            axWindowsMediaPlayer1.URL = "Media\\30_Second-2020-05-27_-_Circus_Calliope_-_www.FesliyanStudios.com_Steve_Oxen.mp3";
            
        }

       

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
           ussouch = f2.cbf2;
            lblsound.Text = f2.cbf2.ToString();
            lbllevel.Text = f2.rbf2level;
            if (f2.cbf2 == true)
                axWindowsMediaPlayer1.URL = "Media\\30_Second-2020-05-27_-_Circus_Calliope_-_www.FesliyanStudios.com_Steve_Oxen.mp3";
            else   axWindowsMediaPlayer1.Ctlcontrols.stop();
            
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            button1.Visible = true;
            button1.Enabled = true;
            lblusername.Text = f3.newname;
            userid = f3.newid;
            lbluserid.Text = f3.newid.ToString();
            lblbcurBscore.Text =" 0";
            lblMcurscore.Text ="0";
            lblUcurscore.Text = "0";
        }

        private void exictingUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            lblusername.Text = f4.name;
            userid = f4.id;
            lbluserid.Text = f4.id.ToString();

            lblbcurBscore.Text = f4.curBscore.ToString();
            lblMcurscore.Text = f4.curMscore.ToString();
            lblUcurscore.Text = f4.curUscore.ToString();

            button1.Visible = true;
            button1.Enabled = true;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
             Form4 f4 = new Form4();
             axWindowsMediaPlayer1.close();
            Form5 f5 = new Form5( ussouch,lbllevel.Text ,lblusername.Text);
            f5.ShowDialog();
            

            scoreuser = f5.score;
           
            lblf1score.Text = f5.score.ToString();
            
            if(lbllevel.Text=="Beginner"){
                if (Convert.ToInt32(lblf1score.Text) >= Convert.ToInt32(lblbcurBscore.Text))
                {
                  
                    cnn.Open();
                    string sqlcmd = "UPDATE tblusers SET Beginner = " + "N\'" + lblf1score.Text + "\' ";
                    sqlcmd += "where ID = " + userid;
                    adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = new SqlCommand(sqlcmd, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.tblusersTableAdapter.Fill(this.usersdatabaseDataSet.tblusers);
                    cnn.Close();
                }

               }
            else if(lbllevel.Text=="Master"){
                if (Convert.ToInt32(lblf1score.Text) >= Convert.ToInt32(lblMcurscore.Text))
                {
                  
                    cnn.Open();
                    string sqlcmd = "UPDATE tblusers SET Master = " + "N\'" + lblf1score.Text + "\' ";
                    sqlcmd += "where ID = " + userid;
                    adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = new SqlCommand(sqlcmd, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.tblusersTableAdapter.Fill(this.usersdatabaseDataSet.tblusers);
                    cnn.Close();
                }
                }
            else if (lbllevel.Text == "Ultimate")
            {
                if (Convert.ToInt32(lblf1score.Text) >=Convert.ToInt32( lblUcurscore.Text))
                {
                   
                    cnn.Open();
                    string sqlcmd = "UPDATE tblusers SET Ultimate = " + "N\'" + lblf1score.Text + "\' ";
                    sqlcmd += "where ID = " + userid;
                    adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = new SqlCommand(sqlcmd, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.tblusersTableAdapter.Fill(this.usersdatabaseDataSet.tblusers);
                    cnn.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("DO you want to quit playing ? :(","Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            this.Close();

        }
    }
}
