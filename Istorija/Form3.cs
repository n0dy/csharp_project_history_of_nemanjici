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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        struct Pitanja
        {
            public string Pitanje;
            public int Odgovor;
            public string Odg1;
            public string Odg2;
            public string Odg3;
            public string Odg4;
            public bool Bilo;
        }

        Pitanja[] pitanja;

        private void lblNazad_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1(true);
            forma1.Show();
            this.Close();
        }

        private void NadjiPitanje()
        {
            bool BiloPitanje = false;
            sec = 0;
            if(ukupnoPitanja != 20)
            {
                while (!BiloPitanje)
                {
                    Random r = new Random();
                    RandomPitanje = r.Next(brPitanja);
                    if (pitanja[RandomPitanje].Bilo == false)
                    {
                        lblPitanje.Text = pitanja[RandomPitanje].Pitanje;
                        lblOdg1.Text = pitanja[RandomPitanje].Odg1;
                        lblOdg2.Text = pitanja[RandomPitanje].Odg2;
                        lblOdg3.Text = pitanja[RandomPitanje].Odg3;
                        lblOdg4.Text = pitanja[RandomPitanje].Odg4;
                        pitanja[RandomPitanje].Bilo = true;
                        ukupnoPitanja++;
                        BiloPitanje = true;
                    }
                }
                lblRezultati.Text = string.Format("Ukupno pitanja {0} ||| Tacnih pitanja {1} ", ukupnoPitanja, tacnihPitanja, ProsecnoVreme);
                timerPitanja.Start();
            }
            else
            {
                timerPitanja.Stop();
                timerBrojac.Stop();
                lblInfo.Text = "Zavrseno!";
                lblPitanje.Text = "Pitanje";
                lblOdg1.Text = "Odgovor";
                lblOdg2.Text = "Odgovor";
                lblOdg3.Text = "Odgovor";
                lblOdg4.Text = "Odgovor";
                ProsecnoVreme /= ukupnoPitanja;
                lblRezultati.Text = string.Format("Ukupno pitanja {0} ||| Tacnih pitanja {1} \n Prosecno Vreme odgovaranja na pitanje: {2} sekundi. ", ukupnoPitanja, tacnihPitanja, ProsecnoVreme);
            }
        }

        int brPitanja, RandomPitanje, ukupnoPitanja, tacnihPitanja;

        private void lblOdg3_Click(object sender, EventArgs e)
        {
            if (pitanja[RandomPitanje].Odgovor == 3)
            {
                lblInfo.Text = "Tacan odgovor!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Netacan odgovor!"; }
            timerPitanja.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void lblOdg4_Click(object sender, EventArgs e)
        {
            if (pitanja[RandomPitanje].Odgovor == 4)
            {
                lblInfo.Text = "Tacan odgovor!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Netacan odgovor!"; }
            timerPitanja.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void timerPitanja_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "Isteklo vreme!";
            timerPitanja.Stop();
            NadjiPitanje();
        }

        int sec = 0; double ProsecnoVreme = 0;

        private void timerBrojac_Tick(object sender, EventArgs e)
        {
            sec++;
            lblInfo.Text = sec.ToString();
        }

        private void lblOdg2_Click(object sender, EventArgs e)
        {
            if (pitanja[RandomPitanje].Odgovor == 2)
            {
                lblInfo.Text = "Tacan odgovor!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Netacan odgovor!"; }
            timerPitanja.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void lblOdg1_Click(object sender, EventArgs e)
        {
            if(pitanja[RandomPitanje].Odgovor == 1)
            {
                lblInfo.Text = "Tacan odgovor!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Netacan odgovor!"; }
            timerPitanja.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Pitanja.txt");
            brPitanja = Convert.ToInt32(sr.ReadLine());
            pitanja = new Pitanja[brPitanja];
            for(int i = 0; i < brPitanja; i++)
            {
                pitanja[i].Pitanje = sr.ReadLine();
                pitanja[i].Odgovor = Convert.ToInt32(sr.ReadLine());
                pitanja[i].Odg1 = sr.ReadLine();
                pitanja[i].Odg2 = sr.ReadLine();
                pitanja[i].Odg3 = sr.ReadLine();
                pitanja[i].Odg4 = sr.ReadLine();
                pitanja[i].Bilo = false;
            }

            NadjiPitanje();
        }
    }
}
