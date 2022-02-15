using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Istorija
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("Pitanja.txt");
            while(!sr.EndOfStream)
            {
                rBoxPitanja.Text += sr.ReadLine() + "\n";
            }
            sr.Close();
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSacuvajPitanja_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Pitanja.txt");
            for (int i = 0; i < rBoxPitanja.Lines.Length; i++)
            {
                sw.WriteLine(rBoxPitanja.Lines[i]);
            }
            sw.Flush();
            sw.Close();
        }

        private void lblNazad_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1(true);
            forma1.Show();
            this.Close();
        }

        private void lblUpustvo_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Pitanje \nBroj tačnog odgovora \nOdgovor 1 \nOdgovor 2 \nOdgovor 3 \nOdgovor 4";
        }
    }
}
