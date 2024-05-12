using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form2 : Form
    {
        public Form2(TextBox tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        TextBox tb;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tb.Text = textBox1.Text;
        }
    }
}
