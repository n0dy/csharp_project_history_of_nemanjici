using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istorija
{
    public partial class Form6 : Form
    {
        public Form6(string Informacije, string Ime)
        {
            InitializeComponent();
            lblInfo.Text = Informacije;
            pBoxSlika.ImageLocation = "slike/" + Ime + ".png";
        }

        private void lblNazad_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            this.Hide();
            forma2.Show();
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
