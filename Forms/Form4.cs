using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoproject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = "@gmail.com$";
            Regex re = new Regex(mail);
            string a, b, c, d, j, f, g, h;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = textBox4.Text;
            f = textBox5.Text;
            g = textBox6.Text;
            h = textBox7.Text;
            j = textBox8.Text;
            if (a == "" || b == "" || c == "" || d == "" || f == "" || g == "" || h == "" || j == "")
            {
                MessageBox.Show("Please fill all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (h != j)
            {
                MessageBox.Show("Password not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Text = "";
                textBox8.Text = "";
            }
            else if (Convert.ToInt32(b) < 18 || Convert.ToInt32(b) > 100)
            {
                textBox2.Text = "";
                MessageBox.Show("Provide a valid 'AGE'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (c.ToUpper() != "MALE" && c.ToUpper() != "FEMALE" && c.ToUpper() != "TRANS")
            {
                textBox3.Text = "";
                MessageBox.Show("Provide a valid 'GENDER'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (d.Length != 10)
            {
                textBox4.Text = "";
                MessageBox.Show("Provide a valid 'Phone Number'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((!re.IsMatch(f)) || f.Length == 10)
            {
                textBox5.Text = "";
                MessageBox.Show("Provide a valid 'GMAIL-ID'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Doctor values(@Name,@Age,@Gender,@Phone_Number,@Specialization,@Gmail_Id,@Password)", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Gender", textBox3.Text);
                cmd.Parameters.AddWithValue("@Phone_Number",textBox4.Text);
                cmd.Parameters.AddWithValue("@Gmail_Id", textBox5.Text);
                cmd.Parameters.AddWithValue("@Specialization", textBox6.Text);
                cmd.Parameters.AddWithValue("@Password", textBox7.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Registered", "Registration Portal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

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
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
            this.Close();
        }
    }
}
