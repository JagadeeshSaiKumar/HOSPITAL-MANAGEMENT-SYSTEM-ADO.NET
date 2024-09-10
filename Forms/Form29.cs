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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adoproject
{
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form26 form26 = new Form26();
            form26.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from med where Name=@Name", conn);
                
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("delete med where Name=@Name", conn);
                    
                    cmd1.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Deleted", "Deletion Portal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("Invalid Details", "Medical Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Invalid Details ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "";
                
            }

        }
    }
}
