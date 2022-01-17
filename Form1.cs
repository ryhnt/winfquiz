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

namespace winfquiz
{
    
    public partial class Form1 : Form
    {
        int sa = 1;
        int sb = 0;
        int dogru ;
        int yanlis ;
      
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection voconn = new SqlConnection("Data Source=LAPTOP-9U5K7JLD\\SQLEXPRESS;Initial Catalog=QuizDB;Integrated Security=True");
        public void Form1_Load(object sender, EventArgs e)
        {
            

         
            SqlCommand vs_command =new SqlCommand("Select Qtext from Questions where QID='"+sa+"'", voconn);
            voconn.Open();
            SqlDataReader dr = vs_command.ExecuteReader();
            if (dr.Read())
            {
                label1.Text =sa+") "+ dr["QText"].ToString();
            }
            voconn.Close();

          

            sb = sb + 1;

            SqlCommand vs_comman = new SqlCommand("Select Atext from Answers where AID='" + sb + "'", voconn);
                voconn.Open();
                SqlDataReader dr2 = vs_comman.ExecuteReader();
            if (dr2.Read())
            {
                a.Text = dr2["Atext"].ToString();
            }
            voconn.Close();
             sb ++;

            SqlCommand vs_comma = new SqlCommand("Select Atext from Answers where AID='" + sb + "'", voconn);
            voconn.Open();
            SqlDataReader dr3 = vs_comma.ExecuteReader();
            if (dr3.Read())
            {
                b.Text = dr3["Atext"].ToString();
            }
            voconn.Close();
            sb ++;
            SqlCommand vs_comm = new SqlCommand("Select Atext from Answers where AID='" + sb + "'", voconn);
            voconn.Open();
            SqlDataReader dr4 = vs_comm.ExecuteReader();
            if (dr4.Read())
            {
                c.Text = dr4["Atext"].ToString();
            }
            voconn.Close();
             sb ++;
            SqlCommand vs_com = new SqlCommand("Select Atext from Answers where AID='" + sb + "'", voconn);
            voconn.Open();
            SqlDataReader dr5 = vs_com.ExecuteReader();
            if (dr5.Read())
            {
                d.Text = dr5["Atext"].ToString();
            }
            voconn.Close();

         





        }

        private void answer_Click(object sender, EventArgs e)
        {
            
        }

        public void pass_Click(object sender, EventArgs e)
        {
           


            SqlCommand vs_comman = new SqlCommand("select atext from answers " +
"inner join RightAnswers on RightAnswers.AID = Answers.AID "+
"inner join questions on questions.QID = Answers.QID where questions.QID="+sa+";", voconn);
            voconn.Open();
            string cevap = vs_comman.ExecuteScalar().ToString();

            if (cevap == a.Text && a.Checked == true)
            {
                dogru++;
                
            }
            else if (cevap == b.Text && b.Checked == true)
            {
                dogru++;

            }
            else if (cevap == c.Text && c.Checked == true)
            {
                dogru++;

            }
            else if (cevap == d.Text && d.Checked == true)
            {
                dogru++;

            }

            else
            { yanlis++;
                MessageBox.Show("Doğru cevap: " + cevap);
            }
            voconn.Close();

            sa = sa + 1;

            if (sa==17)
            {
                
                MessageBox.Show("Yarışma bitmiştir.\nSoru sayısı:16\nDoğru sayınız: " + dogru + "\nYanlış sayınız: " + yanlis+"\nÇıkmak için sayfadaki exit tuşuna basınız.");
                label1.Visible = false;
                pass.Enabled = false;
                group.Enabled = false;

            }
            Form1_Load(null, null);

        }

       
    }
    }

