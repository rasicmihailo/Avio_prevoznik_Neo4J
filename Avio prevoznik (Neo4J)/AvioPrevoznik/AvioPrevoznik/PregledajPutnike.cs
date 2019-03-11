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
    public partial class PregledajPutnike : Form
    {
        #region Atributi

        public Let let;

        #endregion

        #region Konstruktori

        public PregledajPutnike()
        {
            let = new Let();
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void popuniListu()
        {
            //ova fja treba da se proveri, VratiPutnikeLeta, zato sto ako ne postoje
            //putnici, mora da se vidi sta vraca, da ne pravi gresku
            List<Putnik> putnici = DataManager.VratiPutnikeLeta(this.let);
            
            if(putnici.Count > 0) //postoje putnici na letu
            {
                listViewPutnici.Items.Clear();

                foreach(Putnik p in putnici)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        p.id,
                        p.ime,
                        p.prezime
                    });
                    listViewPutnici.Items.Add(item);
                }
                listViewPutnici.Refresh();
            }
            else
            {
                MessageBox.Show("Ne postoje putnici na ovom letu!");
                this.Close();
            }
        }

        #endregion

        #region Events

        private void btnIzbrisiPutnika_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listViewPutnici.SelectedItems[0].SubItems[0].Text);
            Putnik p = DataManager.VratiPutnika(id);

            DataManager.IzbrisiPutnika(p);

            popuniListu();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PregledajPutnike_Load(object sender, EventArgs e)
        {
            popuniListu();
        }

        #endregion
    }
}
