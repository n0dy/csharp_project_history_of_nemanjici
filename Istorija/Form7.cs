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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("AdminInfo.txt");
            AdminUsername = sr.ReadLine();
            AdminPassword = sr.ReadLine();
            sr.Close();
        }

        string AdminUsername, AdminPassword;

        private void lblNazad_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1(false);
            this.Hide();
            forma1.Show();
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPrijaviSe_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == AdminPassword && txtUsername.Text == AdminUsername)
            {
                Form4 forma4 = new Form4();
                this.Hide();
                forma4.Show();
            }
            else
            {
                MessageBox.Show("Uneti podaci nisu tačni!");
            }
        }
    }
}
