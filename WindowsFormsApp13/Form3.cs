using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp13
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private readonly SqlConnection conn;
        public Form3()
        {
            InitializeComponent();
              con = new SqlConnection("Data Source=.;Initial Catalog=company;Integrated Security=True");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into RoomMst values("
             + textBox1.Text + ", "
             + textBox2.Text + ","
             + textBox3.Text + ","
             + textBox4.Text + "," + ");", conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
