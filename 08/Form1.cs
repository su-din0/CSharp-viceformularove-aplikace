using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sirka = this.Width;
            int vyska = this.Height;

            Form2 form2 = new Form2();
            if (form2.ShowDialog() != DialogResult.OK) return;

            decimal sirkaNew = form2.numericUpDown1.Value;
            decimal vyskaNew = form2.numericUpDown2.Value;

            this.BackColor = form2.BackColor;

            this.Width = (int)sirkaNew;
            this.Height = (int)vyskaNew;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Opravdu chcete ukoncit aplikaci?", "Ukonceni aplikace", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) this.Close();
        }
    }
}
