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
    public partial class Aerodromi : Form
    {

        #region Konstruktori

        public Aerodromi()
        {           
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void PopuniListView()
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
            listView1.Refresh();

        }

        #endregion

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            MAerodromi f = new MAerodromi();
            f.Tip = 0;
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
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

            Aerodrom aer = DataManager.GetAerodrom(id);

            MAerodromi f = new MAerodromi();
            f.Tip = 1;
            f.aerodrom = aer;

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

            DataManager.IzbrisiAerodrom(id);

            PopuniListView();

        }

        private void Aerodromi_Load(object sender, EventArgs e)
        {
            this.PopuniListView();
        }

        #endregion
    }
}
