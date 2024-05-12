using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nováToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormObjednavka objednavka = new FormObjednavka();
            objednavka.MdiParent = this;
            objednavka.Show();
        }

        private void vymazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;

            foreach (Control control in ActiveMdiChild.Controls)
            {
                if (control is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }
        }

        private void vymazatVšeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                foreach (Control ctrl in form.Controls)
                {
                    if (ctrl is CheckBox cb)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void konecAplikaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
