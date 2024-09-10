using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoproject
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            string c = "", ee = "", g = "", h = "", i = "", f = ""; int d = 0;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\HMS.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Patient where Gmail_Id=@Gmail_Id AND Password=@Password", conn);
            cmd.Parameters.AddWithValue("@Gmail_Id", Form20.a);
            cmd.Parameters.AddWithValue("@Password", Form20.b);
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
            SqlCommand cmd = new SqlCommand("select * from med where Purpose=@Purpose", conn);
            cmd.Parameters.AddWithValue("@Purpose", label15.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 f = new Form18();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                PrintDialog printDlg = new PrintDialog();
                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Print Document";
                printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDlg.Document = printDoc;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog() == DialogResult.OK)
                    printDoc.Print();        

        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
            {
                // Define some font and brush
                Font printFont = new Font("Arial", 12);
                Brush printBrush = Brushes.Black;

                // Define margins and position
                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;

                // Print the title
                e.Graphics.DrawString("Patient Bill", new Font("Arial", 16, FontStyle.Bold), printBrush, leftMargin, topMargin);
                topMargin += 30;

                // Print patient details
                e.Graphics.DrawString($"Name: {label10.Text}", printFont, printBrush, leftMargin, topMargin);
                topMargin += 20;
                e.Graphics.DrawString($"Age: {label11.Text}", printFont, printBrush, leftMargin, topMargin);
                topMargin += 20;
                e.Graphics.DrawString($"Email: {label12.Text}", printFont, printBrush, leftMargin, topMargin);
                topMargin += 20;
                e.Graphics.DrawString($"Gender: {label13.Text}", printFont, printBrush, leftMargin, topMargin);
                topMargin += 20;
                e.Graphics.DrawString($"Address: {label14.Text}", printFont, printBrush, leftMargin, topMargin);
                topMargin += 20;
                e.Graphics.DrawString($"Purpose: {label15.Text}", printFont, printBrush, leftMargin, topMargin);
                topMargin += 30;

                
                e.Graphics.DrawString("Medication Details:", new Font("Arial", 14, FontStyle.Bold), printBrush, leftMargin, topMargin);
                topMargin += 20;

                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string rowData = string.Join(", ", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? ""));
                    e.Graphics.DrawString(rowData, printFont, printBrush, leftMargin, topMargin);
                    topMargin += 20;
                }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form18 f = new Form18();
            f.ShowDialog();
            this.Close();

        }
    }
}
