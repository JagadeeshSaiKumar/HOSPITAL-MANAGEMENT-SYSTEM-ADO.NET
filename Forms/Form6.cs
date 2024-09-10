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

namespace adoproject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public static string a, b;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fill all the details", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                a = textBox1.Text; b = textBox2.Text;
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Doctor where Gmail_Id=@Gmail_Id AND Password=@Password", conn);
                cmd.Parameters.AddWithValue("@Gmail_Id", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully Logged in ...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form7 f = new Form7();
                    f.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Incorrect Id or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
    }
}
