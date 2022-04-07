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

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form1()
        {

            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=company;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from userss";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (textBox1.Text.Equals(dr["user"].ToString()) && textBox2.Text.Equals(dr["password"].ToString()))
                {
                    MessageBox.Show("كلمة المرور صحيحة");
                }
                else
                {
                    MessageBox.Show("كلمة المرور غير صحيحة ");
                }
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
