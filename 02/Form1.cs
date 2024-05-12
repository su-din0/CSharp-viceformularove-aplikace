using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cena = int.Parse(textBox1.Text);
            int pocetDni = int.Parse(textBox2.Text);

            FormVyber formVyber = new FormVyber();
            int baseX = 93;
            int baseY = 12;
            for (int i = 0; i < pocetDni; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(baseX, baseY);
                checkBox.Text = $"Strava {i + 1}. den";
                formVyber.Controls.Add(checkBox);
                baseY += 20;
            }

            if (formVyber.ShowDialog() != DialogResult.OK)
            {
                textBox2.Text = "";
                label1.Text = "";
                return;
            }
            
            int count = 0;
            foreach (Control control in formVyber.Controls)
            {
                if (control is CheckBox cb && cb.Checked)
                {
                    ++count;
                }
            }
            int sum = count * cena;
            label1.Text = $"Výsledná cena je {sum}";
        }
    }
}
