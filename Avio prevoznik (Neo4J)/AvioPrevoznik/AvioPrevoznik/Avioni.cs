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
    public partial class Avioni : Form
    {
        #region Konstruktori

        public Avioni()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void PopuniListView()
        {
            listView1.Items.Clear();
            List<Avion> lista = DataManager.VratiSveAvione();
            foreach (Avion a in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    a.id,
                    a.marka,
                    a.brojsedista.ToString(),
                });

                listView1.Items.Add(item);
            }
            listView1.Refresh();

        }

        #endregion

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            MAvioni f = new MAvioni();
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

            Avion av = DataManager.GetAvion(id);

            MAvioni f = new MAvioni();
            f.Tip = 1;
            f.avion = av;

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

            DataManager.IzbrisiAvion(id);

            PopuniListView();
        }

        private void Avioni_Load(object sender, EventArgs e)
        {
            this.PopuniListView();
        }

        #endregion
    }
}
