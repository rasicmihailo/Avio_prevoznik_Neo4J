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
    public partial class InformacijeKupca : Form
    {
        #region Atributi

        public Putnik putnik;
        public List<Karta> karte;
        public OdaberiKlasu odaberi;

        #endregion

        #region Konstruktori

        public InformacijeKupca()
        {
            InitializeComponent();
        }
        public InformacijeKupca(List<Karta> k, OdaberiKlasu odaberi)
        {
            this.odaberi = odaberi;
            this.karte = k;
            InitializeComponent();
        }

        #endregion

        #region Metode

        public bool validacija()
        {
            if (string.IsNullOrEmpty(txtImeKupca.Text) && string.IsNullOrEmpty(txtPrezimeKupca.Text)
               && string.IsNullOrEmpty(txtPasos.Text))
            {
                MessageBox.Show("Morate uneti podatke!");
                txtImeKupca.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtImeKupca.Text))
            {
                MessageBox.Show("Morate uneti ime putnika!");
                txtImeKupca.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrezimeKupca.Text))
            {
                MessageBox.Show("Morate uneti prezime putnika!");
                txtPrezimeKupca.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPasos.Text))
            {
                MessageBox.Show("Morate uneti broj pasosa!");
                txtPasos.Focus();
                return false;
            }
         
            return true;
        }

        public int nadjiID()
        {
            string maxId = DataManager.getMaxId();
            int id = Int32.Parse(maxId);

            return ++id;
        }

        #endregion

        #region Events

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                //vrsi se dodavanje putnika
                putnik = new Putnik();
                putnik.ime = txtImeKupca.Text;
                putnik.pasos = txtPasos.Text;
                putnik.prezime = txtPrezimeKupca.Text;
                putnik.id = nadjiID().ToString();

                DataManager.DodajPutnika(putnik);

                //pa dodavanje karte u bazu          

                foreach (Karta karta in this.karte)
                {

                    karta.id = nadjiID().ToString();

                    DataManager.DodajKartu(karta);

                    // pravi se veza izmedju njih

                    DataManager.VezaKartaPutnik(karta, putnik);

                    DataManager.VezaKartaLet(karta, karta.let);

                    DataManager.AzurirajBrojPutnikaLeta(karta.let);
                }

                this.Close();
                odaberi.Close();
            }
        }

        #endregion

        private void InformacijeKupca_Load(object sender, EventArgs e)
        {
          
        }
    }
}
