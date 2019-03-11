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
    public partial class MLetovi : Form
    {
        #region Atributi

        public Let let;

        public int Tip; //0-dodaj, 1-azuriraj

        #endregion

        #region Konstruktori

        public MLetovi()
        {
            let = new Let();
            InitializeComponent();
        }

        #endregion

        #region Metode

        private void RetrieveInfo(Let let)
        {
            textBoxVremeLetenja.Text = let.vremeletenja;
            textBoxVremePolaska.Text = let.vremepolaska;
            textBoxCena.Text = let.osnovnacena.ToString();

        }

        public bool validacija()
        {
            if (string.IsNullOrEmpty(textBoxVremePolaska.Text) && string.IsNullOrEmpty(textBoxVremeLetenja.Text)
               && string.IsNullOrEmpty(textBoxCena.Text))
            {
                MessageBox.Show("Morate uneti podatke!");
                textBoxVremePolaska.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxVremePolaska.Text))
            {
                MessageBox.Show("Morate uneti vreme polaska!");
                textBoxVremePolaska.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxVremeLetenja.Text))
            {
                MessageBox.Show("Morate uneti vreme letenja!");
                textBoxVremeLetenja.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxCena.Text))
            {
                MessageBox.Show("Morate uneti cenu leta!");
                textBoxCena.Focus();
                return false;
            }
            if(listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Morate odabrate mesto polaska!");               
                return false;
            }
            if (listView2.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Morate uneti destinaciju!");
                textBoxVremeLetenja.Focus();
                return false;
            }
            if (listView3.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Morate uneti avion letenja!");
                textBoxCena.Focus();
                return false;
            }

            return true;
        }

        private void PopuniListe()
        {
            List<Aerodrom> aero = DataManager.VratiSveAerodrome();

            foreach (Aerodrom a in aero)
            {
                ListViewItem item = new ListViewItem(new string[]
               {
                    a.id,
                    a.mesto,
                    a.kapacitet,
               });
                listView1.Items.Add(item);
                //listView2.Items.Add(item);
            }
            listView1.Refresh();

            foreach (Aerodrom a in aero)
            {
                ListViewItem item = new ListViewItem(new string[]
               {
                    a.id,
                    a.mesto,
                    a.kapacitet,
               });    
                
              listView2.Items.Add(item);
            }
            listView2.Refresh();

            List<Avion> avioni = DataManager.VratiSveAvione();

            foreach (Avion a in avioni)
            {
                ListViewItem item = new ListViewItem(new string[]
               {
                    a.id,
                    a.marka,
                    a.brojsedista.ToString()
               });

                listView3.Items.Add(item);
            }
            listView3.Refresh();
        } 
        #endregion

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                if (listView1.SelectedItems.Count == 0 || listView2.SelectedItems.Count == 0 || listView3.SelectedItems.Count == 0)
                {
                    //return;
                }
                DateTime dateTime = dateTimePicker1.Value;
                String dan = dateTime.Day.ToString();
                String mesec = dateTime.Month.ToString();
                String godina = dateTime.Year.ToString();
                String datumPolaska = dan + "." + mesec + "." + godina;

                let.datumpolaska = datumPolaska;
                let.vremepolaska = textBoxVremePolaska.Text;
                let.vremeletenja = textBoxVremeLetenja.Text;
                let.osnovnacena = Int32.Parse(textBoxCena.Text);
                int noviId = Int32.Parse(DataManager.getMaxId()) + 1;
                let.id = noviId.ToString();


                //odakle polazi
                int id1 = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                Aerodrom polazni = DataManager.GetAerodrom(id1);
                let.polazniaerodrom = polazni;

                //gde ide
                int id2 = Int32.Parse(listView2.SelectedItems[0].SubItems[0].Text);
                Aerodrom destinacija = DataManager.GetAerodrom(id2);
                let.odredisniaerodrom = destinacija;

                //kojim avionom putuje
                int id3 = Int32.Parse(listView3.SelectedItems[0].SubItems[0].Text);
                Avion avion = DataManager.GetAvion(id3);
                let.avion = avion;

                let.brojsedista = avion.brojsedista;
                if (Tip == 0)//dodaj
                {

                    DataManager.DodajLet(let);

                }
                else if (Tip == 1)//azuriraj
                {
                    DataManager.AzurirajLet(let);
                }

                this.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MLetovi_Load(object sender, EventArgs e)
        {
            this.PopuniListe();

            if (Tip == 0)//dodaj
            {
                
            }
            else if (Tip == 1)//azuriraj
            {
                this.RetrieveInfo(let);
                
            }
        }

        #endregion
    }
}
