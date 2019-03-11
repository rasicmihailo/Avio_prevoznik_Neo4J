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
    public partial class Letovi : Form
    {
        public Let let;

        #region Konstruktori

        public Letovi()
        {
            let = new Let();
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void PopuniListView()
        {
            listView1.Items.Clear();
            List<Let> lista = DataManager.VratiSveLetove();
            Aerodrom pol;
            Aerodrom dest;
            foreach (Let a in lista)
            {
                pol = DataManager.VratiPolazniAerodromLeta(a);
                dest = DataManager.VratiDestinacijuLeta(a);
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.id,
                    pol.mesto, //mesto polaska
                    dest.mesto,//mesto destinacije
                    a.datumpolaska,
                    a.vremepolaska + "h"
                });

                listView1.Items.Add(item);
            }
            listView1.Refresh();

        }

        #endregion

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            MLetovi f = new MLetovi();
            f.Tip = 0;

            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                this.let = f.let;
                DataManager.VezaLetAerodromPolazni(f.let, f.let.polazniaerodrom);
                DataManager.VezaLetAerodromOdredisni(f.let, f.let.odredisniaerodrom);
                DataManager.VezaLetAerodromAvion(f.let, f.let.avion);
                PopuniListView();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            Let let = DataManager.GetLet(id);

            MLetovi f = new MLetovi();
            f.Tip = 1;
            f.let = let;

            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PopuniListView();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DataManager.IzbrisiLet(id);

            PopuniListView();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Aerodromi f = new Aerodromi();

            f.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Avioni f = new Avioni();

            f.Show();
        }
        private void Letovi_Load(object sender, EventArgs e)
        {
            this.PopuniListView();
        }
        private void btnDodajRadnike_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.admin = 0;
            registracija.izmena = 0;
            registracija.ShowDialog();
        }
        private void btnPregledajRadnike_Click(object sender, EventArgs e)
        {
            //otvara se nova forma koja sadrzi informacije o radnicima 

            PregledajRadnike pregledaj = new PregledajRadnike();
            pregledaj.ShowDialog();
        }
        private void btnPregledajLet_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) 
            {
                int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                Let l = DataManager.GetLet(id);

                PregledajPutnike pregledaj = new PregledajPutnike();
                pregledaj.let = l;
                pregledaj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati let!");
            }
        }

        #endregion


    }
}
