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
    public partial class PregledajRadnike : Form
    {
        #region Konstruktori

        public PregledajRadnike()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode 

        public void PopuniRadnike()
        {
            listViewRadnici.Items.Clear();

            List<User> korisnici = DataManager.VratiSveRadnike();

            foreach (User u in korisnici)
            {
                if (u.a == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    u.id,
                    u.ime,
                    u.prezime,
                    u.korisnicko
                    });

                    listViewRadnici.Items.Add(item);
                }
            }
            listViewRadnici.Refresh();
        }

        #endregion

        #region Events

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOtpusti_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listViewRadnici.SelectedItems[0].SubItems[0].Text);
            User user = DataManager.VratiKorisnika(id);

            DataManager.OtpustiRadnika(user);

            PopuniRadnike();
        }

        private void PregledajRadnike_Load(object sender, EventArgs e)
        {
            PopuniRadnike();
        }
        #endregion


    }
}
