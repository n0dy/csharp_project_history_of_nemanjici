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
    public partial class Form1 : Form
    {
        bool PogledaoNemanjice;

        public Form1(bool PN)
        {
            InitializeComponent();
            PogledaoNemanjice = PN;
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNemanjicii_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            this.Hide();
            forma2.Show();
        }

        private void lblKviz_Click(object sender, EventArgs e)
        {
            if(!PogledaoNemanjice)
            {
                MessageBox.Show("Morate pogledati Nemanjiće kako biste mogli pokrenuti kviz!!!");
            }
            else
            {
                Form3 forma3 = new Form3();
                this.Hide();
                forma3.Show();
            }
        }

        private void lblAdminPanel_Click(object sender, EventArgs e)
        {
            Form7 forma7 = new Form7();
            this.Hide();
            forma7.Show();
        }

        private void lblZaduzbine_Click(object sender, EventArgs e)
        {
            Form5 forma5 = new Form5();
            this.Hide();
            forma5.Show();
        }
    }
}
