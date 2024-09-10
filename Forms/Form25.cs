using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace adoproject
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&& textBox2.Text!= ""&&textBox3.Text!=""&&textBox4.Text!="")
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into med values(@Purpose,@Name,@Quantity,@Price)",conn);
                cmd.Parameters.AddWithValue("@Purpose",textBox1.Text);
                cmd.Parameters.AddWithValue("@Name",textBox2.Text);
                cmd.Parameters.AddWithValue("@Quantity",Convert.ToInt32(textBox3.Text));
                cmd.Parameters.AddWithValue("@Price",Convert.ToSingle(textBox4.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Added", "Medical Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Details ...","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
