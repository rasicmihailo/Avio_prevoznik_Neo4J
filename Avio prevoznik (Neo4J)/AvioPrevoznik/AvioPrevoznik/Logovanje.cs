using AvioPrevoznik.DomainModel;
using Neo4jClient;
using Neo4jClient.Cypher;
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
    public partial class Logovanje : Form
    {

        #region Constructors

        public Logovanje()
        {
            InitializeComponent();
            txtKorisnicko.Focus();
        }

        #endregion

        #region Methods

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(txtKorisnicko.Text))
            {
                MessageBox.Show("Morate uneti korisnicko ime!");
                txtKorisnicko.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show("Morate uneti sifru!");
                txtSifra.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region Handlers
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            String korisnicko = txtKorisnicko.Text;
            String sifra = txtSifra.Text;

            if (Validacija())
            {
                User korisnik = DataManager.VratiKorisnika(korisnicko, sifra);

                if (korisnik == null)
                {
                    MessageBox.Show("Ne postoji takav korisnik!");
                    txtKorisnicko.Focus();
                } 
               else if (korisnik.a == 0) //radnik 
                {
                    DodajKartu dodajKartu = new DodajKartu();
                    dodajKartu.korisnicko = txtKorisnicko.Text;
                    dodajKartu.sifra = txtSifra.Text;
                    dodajKartu.ShowDialog();
                }
                else //admin
                {
                    Letovi podaciKompanije = new Letovi();
                    podaciKompanije.ShowDialog();
                }
            }
        }
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.admin = 1; //registruje se kao admin
            registracija.izmena = 0;
            registracija.ShowDialog();
        }
        #endregion

        #region Povezivanje
        private void Logovanje_Load(object sender, EventArgs e)
        {
            txtKorisnicko.Focus();
            DataManager.Povezivanje();       
        }
        #endregion

       
    }
}
