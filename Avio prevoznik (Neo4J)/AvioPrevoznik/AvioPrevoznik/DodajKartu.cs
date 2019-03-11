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
    public partial class DodajKartu : Form
    {
        #region Atributi

        public List<Let> putanjaLetova;
        public String korisnicko = "";
        public String sifra = "";

        #endregion

        #region Konstruktori

        public DodajKartu()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void popuniLetove()
        {
            if (Validacija())
            {
                listViewLetovi.Items.Clear();

                DateTime dateTime = datePolazak.Value;

                String dan = dateTime.Day.ToString();
                String mesec = dateTime.Month.ToString();
                String godina = dateTime.Year.ToString();

                //na osnovu datuma polaska, mesta polaska i destinacije ce se ucitati potrebni letovi
                String datumPolaska = dan + "." + mesec + "." + godina;
                String mestoPolaska = txtPolazak.Text;
                String destinacija = txtOdrediste.Text;

                List<Let> letovi = DataManager.VratiLetove(datumPolaska, mestoPolaska, destinacija);

                foreach (Let l in letovi)
                {
                    ListViewItem item = new ListViewItem(new string[]
                                                   {
                            l.id,
                            l.datumpolaska,
                            l.vremepolaska,
                            l.vremeletenja + "h",
                            mestoPolaska, //mesto polaska
                            destinacija, //mesto destinacije
                            "DA"
                                                   });
                    listViewLetovi.Items.Add(item);
                }
                listViewLetovi.Refresh();
            }

            //List<Let> letovi = DataManager.PronadjiLetove(datumPolaska); //prvo se traze svi letovi zeljenog datuma

            //Aerodrom pol;
            //String polazak = "";
            //Aerodrom dest;
            //String odrediste = "";
            //String direktan = "";

            //int vremeLeta = 0;

            ////letovi => svi letovi unetog datuma
            //foreach (Let l in letovi) 
            //{
            //    //onda se za svaki moguci let odabranog datuma proverava da li je direktan ili ima vise letova
            //    putanjaLetova = DataManager.VratiPutanjeLeta(mestoPolaska, destinacija);


            //    pol = DataManager.VratiPolazniAerodromLeta(l);

            //    if ((putanjaLetova.Count == 1 || letovi.Count==1) && pol.mesto==txtPolazak.Text)//znaci da je direktan let
            //    {
            //        dest = DataManager.VratiDestinacijuLeta(l);
            //        polazak = pol.mesto;
            //        odrediste = dest.mesto;
            //        direktan = "DA";

            //        ListViewItem item = new ListViewItem(new string[]
            //                               {
            //                l.id,
            //                l.datumpolaska,
            //                l.vremepolaska,
            //                l.vremeletenja + "h",
            //                polazak, //mesto polaska
            //                odrediste, //mesto destinacije
            //                direktan
            //                               });
            //        listViewLetovi.Items.Add(item);
            //    }
            //    else if(txtPolazak.Text==pol.mesto)//nije direktan let
            //    {
            //       direktan = "NE";
            //       polazak = txtPolazak.Text;
            //       odrediste = txtOdrediste.Text;
            //        foreach (Let l1 in putanjaLetova)
            //        {
            //            if(l1.datumpolaska == datumPolaska)
            //            vremeLeta += Int32.Parse(l1.vremeletenja);
            //        }

            //        ListViewItem item = new ListViewItem(new string[]
            //            {
            //                l.id,
            //                l.datumpolaska,
            //                l.vremepolaska,
            //                vremeLeta + "h",
            //                polazak, //mesto polaska
            //                odrediste, //mesto destinacije
            //                direktan
            //            });
            //        listViewLetovi.Items.Add(item);
            //    }

            //}
            //listViewLetovi.Refresh();


        }

        public void prikaziPutanje(Let l)
        {

            Aerodrom pol;
            Aerodrom dest;

            pol = DataManager.VratiPolazniAerodromLeta(l);
            dest = DataManager.VratiDestinacijuLeta(l);
            ListViewItem item = new ListViewItem(new string[]
            {
                l.id,
                l.datumpolaska,
                l.vremepolaska,
                l.vremeletenja + "h",
                pol.mesto, //mesto polaska
                dest.mesto //mesto destinacije
            });
            listViewPresedanja.Items.Add(item);
            
            listViewPresedanja.Refresh();
        }

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(txtPolazak.Text))
            {
                MessageBox.Show("Morate uneti mesto polaska!");
                txtPolazak.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtOdrediste.Text))
            {
                MessageBox.Show("Morate uneti zeljenu destinaciju!");
                txtOdrediste.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region Events
        private void btnPronadji_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                popuniLetove();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewLetovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //List<Let> tmp = DataManager.VratiPutanjeLeta(listViewLetovi.SelectedItems[0].SubItems[4].Text, //polazak
            //                                             listViewLetovi.SelectedItems[0].SubItems[5].Text); //odrediste

            //int cenaKarte = 0;

            //List<Let> izabraniLetovi = new List<Let>();
            //foreach (Let l in tmp)
            //{
            //    if (l.datumpolaska == listViewLetovi.SelectedItems[0].SubItems[1].Text)
            //    {
            //        cenaKarte += l.osnovnacena;
            //        izabraniLetovi.Add(l);
            //    }
            //}

            //ne radi lepo fja za putanje, ovo je samo za direktne letove
            Let l = DataManager.GetLet(Int32.Parse(listViewLetovi.SelectedItems[0].SubItems[0].Text));
            List<Let> l1 = new List<Let>(); 
            l1.Add(l);

            OdaberiKlasu odaberi = new OdaberiKlasu(l1, l.osnovnacena);
            odaberi.ShowDialog();
        }

        private void listViewLetovi_MouseClick(object sender, MouseEventArgs e)
        {
            //List<Let> letovi = DataManager.VratiPutanjeLeta(listViewLetovi.SelectedItems[0].SubItems[4].Text, //polazak
            //                                     listViewLetovi.SelectedItems[0].SubItems[5].Text); //destinacija

            
            //listViewPresedanja.Items.Clear();
            //foreach (Let let in letovi)
            //{
            //    if(let.datumpolaska == listViewLetovi.SelectedItems[0].SubItems[1].Text)
            //       prikaziPutanje(let);
            //}


        }

        private void btnIzmeniPodatke_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            //registracija.admin = 1; //registruje se kao admin
            registracija.izmena = 1; //ovde se vrsi azuriranje
            registracija.izmenaK = this.korisnicko;
            registracija.izmenaS = this.sifra;

            if (registracija.ShowDialog() == DialogResult.OK)
                this.Close();
            
        }

        #endregion


    }
}
