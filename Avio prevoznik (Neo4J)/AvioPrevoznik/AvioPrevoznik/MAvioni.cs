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
    public partial class MAvioni : Form
    {
        #region Atributi

        public Avion avion;

        public int Tip; //0-dodaj, 1-azuriraj

        #endregion

        #region Konstruktori

        public MAvioni()
        {
            avion = new Avion();
            InitializeComponent();
        }

        #endregion

        #region Metode

        private void RetrieveInfo(Avion avion)
        {
            textBoxMarka.Text = avion.marka;
            textBoxBrojSedista.Text = avion.brojsedista.ToString();
            textBoxGodinaProizvodnje.Text = avion.godinaproizvodnje;


        }

        public bool validacija()
        {
            if (string.IsNullOrEmpty(textBoxMarka.Text) && string.IsNullOrEmpty(textBoxGodinaProizvodnje.Text)
               && string.IsNullOrEmpty(textBoxBrojSedista.Text))
            {
                MessageBox.Show("Morate uneti podatke!");
                textBoxMarka.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxMarka.Text))
            {
                MessageBox.Show("Morate uneti marku aviona!");
                textBoxMarka.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxBrojSedista.Text))
            {
                MessageBox.Show("Morate uneti kapacitet aviona!");
                textBoxBrojSedista.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxGodinaProizvodnje.Text))
            {
                MessageBox.Show("Morate uneti godinu proizvodnje!");
                textBoxGodinaProizvodnje.Focus();
                return false;
            }
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Morate uneti avion letenja!");
                return false;
            }

            return true;
        }

        private void PrikaziAerodrome()
        {
            listView1.Items.Clear();
            List<Aerodrom> lista = DataManager.VratiSveAerodrome();
            foreach (Aerodrom a in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.id,
                    a.mesto,
                    a.kapacitet,
                });

                listView1.Items.Add(item);
            }

            if (avion.aerodrom != null)
            {
                foreach (ListViewItem i in listView1.Items)
                {
                    if (i.SubItems[0].Text == avion.aerodrom.id)
                    {
                        i.Selected = true;
                        listView1.Select();
                    }
                }
            }

            listView1.Refresh();
        }

        #endregion

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    return;
                }

                avion.marka = textBoxMarka.Text;
                avion.godinaproizvodnje = textBoxGodinaProizvodnje.Text;
                avion.brojsedista = Int32.Parse(textBoxBrojSedista.Text);


                int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                Aerodrom aer = DataManager.GetAerodrom(id);
                avion.aerodrom = aer;



                if (Tip == 0)//dodaj
                {

                    DataManager.DodajAvion(avion);

                }
                else if (Tip == 1)//azuriraj
                {
                    DataManager.AzurirajAvion(avion);
                }

                this.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAvioni_Load(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
            {
                this.PrikaziAerodrome();
            }
            else if (Tip == 1)//azuriraj
            {
                this.RetrieveInfo(avion);
                this.PrikaziAerodrome();
            }
        }

        #endregion
    }
}
