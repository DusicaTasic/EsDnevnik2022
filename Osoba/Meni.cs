using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoba
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba formaOsoba = new Osoba();
            formaOsoba.Show();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela formaRaspodela = new Raspodela();
            formaRaspodela.Show();
        }
    }
}
