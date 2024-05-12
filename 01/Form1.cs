using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] cisla;
        private void button1_Click(object sender, EventArgs e)
        {
            cisla = new int[textBox1.Lines.Count()];

            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                cisla[i] = int.Parse(textBox1.Lines[i]);
                listBox1.Items.Add(cisla[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            foreach (int cislo in cisla)
            {
                form2.listBox1.Items.Add(cislo);
            }

            if (form2.ShowDialog() != DialogResult.OK) return;

            
            for (int i = 0; i < form2.listBox1.SelectedIndices.Count; i++)
            {
                cisla[form2.listBox1.SelectedIndices[i]] = 0;
            }

            
            listBox1.Items.Clear();
            foreach (int cislo in cisla)
            {
                listBox1.Items.Add(cislo);
            }
        }
    }
}
