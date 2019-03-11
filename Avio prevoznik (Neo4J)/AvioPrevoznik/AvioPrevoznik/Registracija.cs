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
    public partial class Registracija : Form
    {
        #region Atributi

        public int admin;
        public int izmena = 0;
        public String izmenaK = "";
        public String izmenaS = "";

        #endregion

        #region Konstruktori

        public Registracija()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode

        public bool Validacija()
        {           
            if(string.IsNullOrEmpty(txtIme.Text) && string.IsNullOrEmpty(txtPrezime.Text)
                && string.IsNullOrEmpty(txtKorisnicko.Text) && string.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show("Morate uneti podatke!");
                txtIme.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Morate uneti ime!");
                txtIme.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Morate uneti prezime!");
                txtPrezime.Focus();
                return false;
            }
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
            if (DataManager.PostojiKorisnik(txtKorisnicko.Text))
            {
                MessageBox.Show("Korisnicko ime vec postoji!");
                txtKorisnicko.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region Events

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                if (izmena == 0) { //nije izmena podataka, nego dodavanje
                    User user = new User();
                    user.ime = txtIme.Text;
                    user.prezime = txtPrezime.Text;
                    user.korisnicko = txtKorisnicko.Text;
                    user.sifra = txtSifra.Text;
                    user.a = admin; //zato sto se registruje samo admin, on ce dodati radnike

                     String maxId = DataManager.getMaxId();                   
                      int mID = Int32.Parse(maxId);
                     user.id = (mID + 1).ToString();
                 

                    DataManager.DodajKorisnika(user);

                    if (admin == 1)
                    {
                        Letovi letovi = new Letovi();
                        MessageBox.Show("Uspesno ste dodali admina!");
                        letovi.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Uspesno ste dodali radnika!");
                        this.Close();
                    }
                }
                else //izmena == 1, vrsi se azuriranje
                {
                    User user = DataManager.VratiKorisnika(this.izmenaK, this.izmenaS);
                    //ovde se upisuju u lokalni objekat promene
                    user.ime = txtIme.Text;
                    user.prezime = txtPrezime.Text;
                    user.korisnicko = txtKorisnicko.Text;
                    user.sifra = txtSifra.Text;


                    //ovde se upisuju izmene u bazu
                    DataManager.AzurirajKorisnika(user);
                    MessageBox.Show("Uspesno ste promenili podatke!");
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            if (izmena == 1)
            {
                User user = DataManager.VratiKorisnika(this.izmenaK, this.izmenaS);
                //ovde se prikazuju trenutne vrednosti korisnika
                txtIme.Text = user.ime;
                txtPrezime.Text = user.prezime;
                txtKorisnicko.Text = user.korisnicko;
                txtSifra.Text = user.sifra;
            }
        }

        #endregion

    }
}
