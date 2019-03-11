using AvioPrevoznik.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvioPrevoznik
{
    public partial class OdaberiKlasu : Form
    {
        #region Atributi

        public List<Karta> karte; 
        public List<Let> letovi; //ako nije direktan let, imace ih vise, samim tim i vise karata
        int cena;

        #endregion

        #region Konstruktori

        public OdaberiKlasu()
        {
            InitializeComponent();
        }

        public OdaberiKlasu(List<Let> l, int cena)
        {
            this.cena = cena;
            this.karte = new List<Karta>();
            this.letovi = l;
            InitializeComponent();
        }

        #endregion

        #region Metode

        public int izracunajCenu(int c)
        {
            int tmp = c;

            if (cmbKlasa.SelectedIndex == 0)
                tmp *= (int)2.5;


             if (cmbPrtljag.SelectedIndex == 1)
                tmp += 20;
            else if (cmbPrtljag.SelectedIndex == 2)
                tmp += 50;

            return tmp;
        }

        #endregion

        #region Events

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (Let l in this.letovi) //u odnosu na informacije svakog posebnog leta, formira se lista karata sa odgovarajucim podacima
            {
                Karta karta = new Karta();

                karta.klasa = cmbKlasa.Text;
                karta.velicinaprtljaga = cmbPrtljag.Text;
                karta.brojsedista = l.brojsedista-1;
                karta.cena = izracunajCenu(l.osnovnacena);
                karta.let = l;

                this.karte.Add(karta);

                l.brojsedista -= 1; //smanjuje se kapacitet za 1
            }

            InformacijeKupca informacije = new InformacijeKupca(karte, this);
            informacije.ShowDialog();
        }

        private void OdaberiKlasu_Load(object sender, EventArgs e)
        {
            txtCena.Text = izracunajCenu(this.cena).ToString();       
            cmbKlasa.SelectedIndex = 1;
            cmbPrtljag.SelectedIndex = 0;
            foreach(Let l in this.letovi)
            {
                cmbCeneKarata.Items.Add(izracunajCenu(l.osnovnacena));
                cmbSedista.Items.Add(l.brojsedista - 1);
            }
            cmbSedista.SelectedIndex = 0;
            cmbCeneKarata.SelectedIndex = 0;
        }

        private void cmbKlasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCena.Text = izracunajCenu(this.cena).ToString();
            cmbCeneKarata.Items.Clear();

            foreach (Let l in this.letovi)
            {
                cmbCeneKarata.Items.Add(izracunajCenu(l.osnovnacena));
            }
            cmbCeneKarata.SelectedIndex = 0;
        }
    
        private void cmbPrtljag_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCena.Text = izracunajCenu(this.cena).ToString();
            cmbCeneKarata.Items.Clear();

            foreach (Let l in this.letovi)
            {
                cmbCeneKarata.Items.Add(izracunajCenu(l.osnovnacena));
            }
            cmbCeneKarata.SelectedIndex = 0;
        }

        #endregion
    }
}
