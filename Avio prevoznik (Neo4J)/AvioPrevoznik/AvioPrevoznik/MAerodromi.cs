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
    public partial class MAerodromi : Form
    {
        #region Atributi

        public Aerodrom aerodrom;

        public int Tip; //0-dodaj, 1-azuriraj

        #endregion

        #region Konstruktori

        public MAerodromi()
        {
            InitializeComponent();
            aerodrom = new Aerodrom();
        }

        #endregion

        #region Metode

        private void RetrieveInfo(Aerodrom aerodrom)
        {
            textBoxMesto.Text = aerodrom.mesto;
            textBoxKapacitet.Text = aerodrom.kapacitet;

            //foreach (LinijskiObjekat se in Povrsinski.Lista_Linijskih_objekata)
            //{
            //    try
            //    {
            //        LinijskiObjekat lin = DTOManager.GetLinijskiObjekat(se.Id);

            //        ListViewItem item = new ListViewItem(new string[] { lin.Id.ToString(), lin.Naziv, lin.Duzina, lin.Tip_Objekta, lin.Opis_Objekta });
            //        listViewLinijskihObjekata.Items.Add(item);
            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show(e.Message);
            //    }

            //}
            //listViewLinijskihObjekata.Refresh();


        }

        public bool validacija()
        {
            if (string.IsNullOrEmpty(textBoxMesto.Text) 
               && string.IsNullOrEmpty(textBoxKapacitet.Text))
            {
                MessageBox.Show("Morate uneti podatke!");
                textBoxMesto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxMesto.Text))
            {
                MessageBox.Show("Morate uneti lokaciju aerodroma!");
                textBoxMesto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxKapacitet.Text))
            {
                MessageBox.Show("Morate uneti kapacitet aerodroma!");
                textBoxKapacitet.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                aerodrom.mesto = textBoxMesto.Text;
                aerodrom.kapacitet = textBoxKapacitet.Text;

                if (Tip == 0)//dodaj
                {

                    DataManager.DodajAerodrom(aerodrom);

                }
                else if (Tip == 1)//azuriraj
                {
                    DataManager.AzurirajAerodrom(aerodrom);
                }

                this.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAerodromi_Load(object sender, EventArgs e)
        {
            if (Tip == 0)//dodaj
            {
                //this.PrikaziSveLinijske();
            }
            else if (Tip == 1)//azuriraj
            {
                this.RetrieveInfo(aerodrom);
                //this.PrikaziSveLinijske();
            }
        }

        #endregion
    }
}
