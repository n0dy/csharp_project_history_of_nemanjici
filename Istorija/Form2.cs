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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string Informacije;

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNazad_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1(true);
            forma1.Show();
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void lblStefanNemanja_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1113. godine, a umro 13. februara 1200.\nZadužbine: Presveta Bogorodica, Sveti Nikola, Đurđevi Stupovi, Studenica.\nVeliki Župan 1166 - 1196";
            Form6 forma6 = new Form6(Informacije, "StefanNemanja2");
            this.Hide();
            forma6.Show();
        }

        private void lblVukan_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1165. godine, a umro 1208. godine.\nZadužbine: //.\nVeliki Župan 1202 - 1205.";
            Form6 forma6 = new Form6(Informacije, "Vukan");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanPrvovencani_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1166. godine, a umro 24.septembar.1227.\nZadužbine: Žiča.\nKralj 1196 - 1227";
            Form6 forma6 = new Form6(Informacije, "StefanPrvovencani");
            this.Hide();
            forma6.Show();
        }

        private void lblSvetiSava_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1175. godine, a umro 14.januar.1236.\nZadužbine: Hilandar.";
            Form6 forma6 = new Form6(Informacije, "SvetiSava");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanRadoslav_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1192. godine, a umro 1235. godine.\nZadužbine: Hilandar.\nKralj 1227 - 1234";
            Form6 forma6 = new Form6(Informacije, "StefanRadoslav");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanVladislav_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1198. godine, a umro 1.novembar.1267.\nZadužbine: Mileševa.\nKralj 1234 - 1243";
            Form6 forma6 = new Form6(Informacije, "StefanVladislav");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanUros1_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1223. godine, a umro 1.maj.1277.\nZadužbine: Sopoćani.\nKralj 1243 - 1276";
            Form6 forma6 = new Form6(Informacije, "StefanUros1");
            this.Hide();
            forma6.Show();
        }

        private void lblPredislav_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1200. godine, a umro 1271.\nZadužbine: //.";
            Form6 forma6 = new Form6(Informacije, "Predislav");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanDragutin_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1253. godine, a umro 12.mart.1316.\nZadužbine: //.\nKralj 1276 - 1282";
            Form6 forma6 = new Form6(Informacije, "StefanDragutin");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanMilutinUros2_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1253. godine, a umro 29.oktobar.1321.\nZadužbine: //.\nKralj 1282 - 1321";
            Form6 forma6 = new Form6(Informacije, "StefanMilutinUros2");
            this.Hide();
            forma6.Show();
        }

        private void lblVladislav2_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1280. godine, a umro 1326.godine\nZadužbine: //.";
            Form6 forma6 = new Form6(Informacije, "Vladislav2");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanUros3_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1276. godine, a umro 11.novembar.1331.\nZadužbine: Dečani.\nKralj 1321 - 1331";
            Form6 forma6 = new Form6(Informacije, "StefanUros3");
            this.Hide();
            forma6.Show();
        }

        private void lblKonstantin_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1283.godine, a umro 1322.godine.\nZadužbine: //.\nKralj 1321 - 1322";
            Form6 forma6 = new Form6(Informacije, "Konstantin");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanUrosDusan4_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1309. godine, a umro 20.decembar.1355.\nZadužbine: Dečani.\nCar 1331 - 1355";
            Form6 forma6 = new Form6(Informacije, "StefanUrosDusan4");
            this.Hide();
            forma6.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1326. godine, a umro 1370. godine.\nZadužbine: //.";
            Form6 forma6 = new Form6(Informacije, "SimeonSinisa");
            this.Hide();
            forma6.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1336. godine, a umro 4.decembar.1371.\nZadužbine: //.\nCar 1355 - 1371";
            Form6 forma6 = new Form6(Informacije, "StefanUros5");
            this.Hide();
            forma6.Show();
        }

        private void lblJovanUros_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen 1350. godine, a umro 1422. godine..\nZadužbine: //.";
            Form6 forma6 = new Form6(Informacije, "JovanUros");
            this.Hide();
            forma6.Show();
        }

        private void lblStefanDuka_Click(object sender, EventArgs e)
        {
            Informacije = "Rođen xxxx. godine, a umro xxxx. godine.\nZadužbine: //.";
            Form6 forma6 = new Form6(Informacije, "StefanDuka");
            this.Hide();
            forma6.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
