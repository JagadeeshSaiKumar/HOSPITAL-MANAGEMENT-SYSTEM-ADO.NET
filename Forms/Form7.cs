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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string c = "", ee = "", g = "", h = "", i = "", f = "";int d = 0;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Doctor where Gmail_Id=@Gmail_Id AND Password=@Password", conn);
            cmd.Parameters.AddWithValue("@Gmail_Id", Form6.a);
            cmd.Parameters.AddWithValue("@Password", Form6.b);
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
            label15.Text = g;
            label14.Text = h;
            label16.Text = i;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Name,Age,Gender,Phone_Number,Gmail_Id,Problem_of_Visit from Patient where Problem_of_Visit=@Problem_of_Visit", conn);
            cmd.Parameters.AddWithValue("@Problem_of_Visit",label15.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView1.DataSource=dt1;
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f =new Form5();
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
