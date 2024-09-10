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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            string c = "", ee = "", g = "", h = "", i = "", f = ""; int d = 0;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from RTable where Gmail_Id=@Gmail_Id AND Password=@Password", conn);
            cmd.Parameters.AddWithValue("@Gmail_Id", Form13.a);
            cmd.Parameters.AddWithValue("@Password", Form13.b);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DA.Fill(dt);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                c = r[0] as string;
                d = (int)r[1];
                ee = r[2] as string;
                f = r[3] as string;
                g = r[4] as string;
                h = r[5] as string;
                i = r[6] as string;
            }
            label10.Text = c;
            label11.Text = d.ToString();
            label12.Text = ee;
            label13.Text = f;
            label14.Text = g;
            label15.Text = h;
            label16.Text = i;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name,Age,Gender,Phone_Number,Gmail_Id,Specialization from Doctor ", conn);
            cmd.Parameters.AddWithValue("@Problem_of_Visit", label15.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name,Age,Gender,Phone_Number,Gmail_Id,Problem_of_Visit from Patient", conn);
            cmd.Parameters.AddWithValue("@Problem_of_Visit", label15.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView2.DataSource = dt1;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
            this.Close();

        }
    }
}
