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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form19 f = new Form19();
            f.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form20 f = new Form20();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form22 f = new Form22();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 f = new Form24();
            f.ShowDialog();
            this.Close();
        }
    }
}
