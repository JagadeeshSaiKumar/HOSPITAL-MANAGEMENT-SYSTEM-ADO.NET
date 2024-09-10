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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 form11= new Form11();
            form11.ShowDialog();
            this.Close();
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

                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from RTable where Gmail_Id=@Gmail_Id AND Password=@Password", conn);
                cmd.Parameters.AddWithValue("@Gmail_Id", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("delete RTable where Gmail_Id=@Gmail_Id AND Password=@Password", conn);
                    cmd1.Parameters.AddWithValue("@Gmail_Id", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@Password", textBox2.Text);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Deleted", "Deletion Portal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form5 f = new Form5();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
            this.Close();

        }
    }
}
