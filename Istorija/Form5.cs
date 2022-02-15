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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Ziča")
            {
                pBoxSlika.ImageLocation = "slike/Zica.png";
                lblText.Text = "Manastir Žiča se nalazi u blizini Kraljeva, datira iz XIII veka kao zadužbina srpskog kralja Stefana Prvovenčanog. U izgradnji ovog pravoslavnog hrama učestvovao je i Rastko Nemanjić poznatiji kao Sveti Sava. Unutrašnjost crkve tj. njeni zidovi čuvaju pravo kulturno - istorijsko blago u dva sloja fresaka: prvi i stariji sloj, nastao oko 1220. godine svrstava se u takozvano Zlatno doba srpskog slikarstva a drugi, mlađi sloj, živopisan, nastao za vreme kralja Milutina, naslikan je pod uticajem Renesanse Paleologa, a po mišljenju mnogih stručnjaka Žiča je bila uzor  u graditeljstvu tokom srednjeg veka.";
            }
            else if(comboBox1.Text == "Đurđevi Stupovi")
            {
                pBoxSlika.ImageLocation = "slike/DjurdjeviStupovi.png";
                lblText.Text = "Đurđeve Stupove podigao je u drugoj polovini XII veka veliki župan Stefan Nemanja, neposredno po njegovom preuzimanju prestola i posvetio ih svetom Đorđu.Manastir je deo Svetske kulturne baštine i pod zaštitom je UNESCO - a.Ovo zdanje značajno je i po svojoj arhitekturi za koju se smatra da je bila uzor u građevinarstvu na području tadašnje Srbije i Balkana.Po svedočenju Stefana Prvovenčanog, sina i biografa župana Stefana Nemanje, njegov se otac zavetovao, prilikom svog utamničenja u jednoj pećini, da će kada se domogne slobode i prestola sagraditi manastir i posvetiti ga svetom Đorđu.";
            }
            else if (comboBox1.Text == "Gračanica")
            {
                pBoxSlika.ImageLocation = "slike/Gracanica.png";
                lblText.Text = "Manastir Gračanica nalazi se na levoj obali reke Gračanke u istoimenom naselju u neposrednoj blizini Prištine. Podignut je početkom XIV veka i zadužbina je kralja Miilutina. Prema narodnom predanju kralj je baš ovde zaspao uoči bitke i sanjao anđela koji mu je predskazao da će bitku dobiti, ali da u znak zahvalnosti mora da podigne manastir na tom mestu, što je on i učinio. Pomenuti hram predstavlja izuzetan primer arhitekture. Gračanica kao verski lokalitet čuva i umetničko blago srednjeg veka. Freske na unutrašnjim zidovima crkve predstavljaju najveće dostignuće dvorske slikarske škole kralja Milutina.";
            }
            else if (comboBox1.Text == "Mileševa")
            {
                pBoxSlika.ImageLocation = "slike/Mileseva.png";
                lblText.Text = "Manastir Mileševa jedan je od najpoznatijih srednjevekovnih manastira u Srbiji,  potiče iz prve polovine XIII veka. Zadužbina je kralja Vladislava, najpoznatija je po freski Beli anđeo koja se i danas tamo nalazi. Mileševska crkva posvećena je prazniku Vaznesenja Gospodnjeg, sagrađena je u raškom stilu, po ugledu na vladarske zadužbine podignute pre nje, Studenicu i Žiču. Pored svog izuzetnog duhovnog značaja, manastir Mileševa, zahvaljujući svojim freskama, jedan je od prvih spomenika mlade srpske umetnosti. Romanski stil u kome je Mileševa sagrađena bio je karakterističan za područje tadašnjeg sprskog primorja a prilagođen je potrebama Pravoslavne crkve. Jednostavna, ozidana sigom, crkva je prvobitno imala samo jednu kupolu da bi prilikom restauracija dobila još jednu.";
            }
            else if (comboBox1.Text == "Sopoćani")
            {
                pBoxSlika.ImageLocation = "slike/Sopocani.png";
                lblText.Text = "Manastir Sopoćani potiče iz prve polovine XIII veka, zadužbina je trećeg  sina Stefana Prvovenčanog, kralja Stefana Uroša Prvog. Hram nastao u blizni Novog Pazara, na mestu gde se oformila srednjevekovna srpska država, posvećen je Svetoj Trojici.  Lepota kojom je zasenio ostale verske zadužbine služila ga je i vekovima kasnije i donela mu je svetsku slavu.  Kralj Stefan Uroš je za živopisanje unutrašnjosti crkve unajmio neke od najboljih carigradskih umetnika, koji je tada važio za kulturnu prestonicu sveta. Na oslikavanju je bio angažovan veći broj umetnika od kojih su dvoje ponajboljih oslikavali oltarski prostor i naos.";
            }
            else if (comboBox1.Text == "Studenica")
            {
                pBoxSlika.ImageLocation = "slike/Studenica.png";
                lblText.Text = "Manastir Studenica uništavana je nekoliko puta, ali bez obzira na to još uvek čuva bogatu riznicu fresaka XIII i XIV veka. Osnovao ju je Stefan Nemanja u XII veku, a njegove mošti se i danas nalaze u tom zdanju.  Manastir se nalazi pod zaštitom UNESCO-a. Iako jedan od najzančajnijih hramova Srpske Pravoslavne Crkve, Studenica je važno  kulturno dobro zbog radova koji svedoče o srednjevekovnoj umetnosti koji su poznati stručnoj javnosti iz celog sveta.  Manastirski kompleks čine četiri crkve:  Bogorodična, Kraljeva, crkva Nikoljača i još jedna crkva koja je očuvana u temeljima. Impresivna zadužbina oblikovana vizantijsko - raškim stilom, posvećena Uspenju presvete Bogordice, pretrpela je značajna oštećenja tokom turske vladavine i od 14 crkava u manastirskom kopleksu danas su sačuvane tri. Početkom XVII veka nekadašnjii duhovni politički i kulturni centar je izgubio dobar deo istorijskih spisa i umetničkih dobara u požaru i zemljotresu.";
            }
            else if (comboBox1.Text == "Hilandar")
            {
                pBoxSlika.ImageLocation = "slike/Hilandar.png";
                lblText.Text = "Manastir Hilandar možda je i najpoznatija zadužbina Nemanjića, nalazi se na Svetoj gori (Atos), na istočnom kraku grčkog poluostrva Halkidiki. Ova autonomna monaška zajednica je četvrta po redu u hijerarhiji svetogorskih manastira i broji oko pedeset monaha koji i danas žive tipiku koji je odredio Sveti Sava.  Ovo je jedan od najpoznatijih manastira - zadužbina u našem narodu, baš zato što su ga zajedno podigli župan Stefan Nemanja i njegov najmlađi sin Rastko Nemanjić – Sveti Sava 1198.godine, sa 30 metara visokim bedemima kako bi ga zaštitili od gusara i njihovih pljačkaških pohoda. Manastirski kompleks je podignut na ruševinama jednog starog manastira, a njegov uticaj ne samo na religiju već i na kulturu Srbije bio je osetan kroz celu istoriju.";
            }
        }
    }
}
