﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2(textBox1);
            form2.textBox1.Text = this.textBox1.Text;
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (form2 != null) form2.textBox1.Text = this.textBox1.Text;
        }
    }
}
