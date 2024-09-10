using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoproject
{
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form28 form27 = new Form28();
            form27.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form27 form28 = new Form27();
            form28.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form29 form28 = new Form29();
            form28.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}
