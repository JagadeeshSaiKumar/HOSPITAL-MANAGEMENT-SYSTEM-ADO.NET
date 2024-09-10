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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
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
            else if ((!re.IsMatch(f)) || f.Length == 10 || f != Form22.a)
            {
                textBox5.Text = "";
                MessageBox.Show("Provide a valid 'GMAIL-ID'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("update Patient set Name=@Name,Age=@Age,Gender=@Gender,Phone_Number=@Phone_Number,Gmail_Id=@Gmail_Id,Problem_of_Visit=@Problem_of_Visit,Password=@Password where Gmail_Id=@Gmail_Id", conn);
                cmd1.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd1.Parameters.AddWithValue("@Age", int.Parse(textBox2.Text));
                cmd1.Parameters.AddWithValue("@Gender", textBox3.Text);
                cmd1.Parameters.AddWithValue("@Phone_Number", textBox4.Text);
                cmd1.Parameters.AddWithValue("@Gmail_Id", textBox5.Text);
                cmd1.Parameters.AddWithValue("@Problem_of_Visit", textBox6.Text);
                cmd1.Parameters.AddWithValue("@Password", textBox7.Text);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Updated", "Updation Portal", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.ShowDialog();
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
            Form18 form18 = new Form18();
            form18.ShowDialog();
            this.Close();
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form18 form18 = new Form18();
            form18.ShowDialog();
            this.Close();
        }
    }
}
