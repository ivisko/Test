using System;
using System.Windows.Forms;

namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();
            reloadListuAlbumov();
        }

        private void buttonPridaj_Click(object sender, EventArgs e)
        {
            FormSpravaAlbumu formSpravaAlbumu = new FormSpravaAlbumu();
            formSpravaAlbumu.ShowDialog();
            reloadListuAlbumov();
        }
        private void reloadListuAlbumov()
        {
            listViewAlbumy.Items.Clear();
            foreach (Album album in Album.zoznam)
            {
                ListViewItem listItem = new ListViewItem(album.Cislo.ToString());
                listItem.SubItems.Add(album.Nazov);
                listItem.SubItems.Add(album.Datum.ToString("dd.MM.yyyy"));
                listItem.SubItems.Add(album.Zaner);
                listItem.SubItems.Add(album.Popis);                
                listViewAlbumy.Items.Add(listItem);
            }
        }
        private void buttonUprav_Click(object sender, EventArgs e)
        {
            if (listViewAlbumy.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vyber album na upravu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = listViewAlbumy.SelectedItems[0].Index;
            FormSpravaAlbumu formSpravaAlbumu = new FormSpravaAlbumu(index);
            formSpravaAlbumu.ShowDialog();
            reloadListuAlbumov();
        }
        private void buttonZmaz_Click(object sender, EventArgs e)
        {
            if (listViewAlbumy.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vyber album na zmazanie", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = listViewAlbumy.SelectedItems[0].Index;
            Album.zoznam.RemoveAt(index); 
            reloadListuAlbumov();
        }
        private void buttonTriedenieNazov_Click(object sender, EventArgs e)
        {
            Album.zoznam.Sort();
            reloadListuAlbumov();
        }
        private void buttonTriedenieDatum_Click(object sender, EventArgs e)
        {
            SortByDatum sortByDatum = new SortByDatum();
            Album.zoznam.Sort(sortByDatum);
            reloadListuAlbumov();
        }
        private void buttonTriedenieCislo_Click(object sender, EventArgs e)
        {
            SortByCislo sortByCislo = new SortByCislo();
            Album.zoznam.Sort(sortByCislo);
            reloadListuAlbumov();
        }
        private void buttonHladaj_Click(object sender, EventArgs e)
        {
            {
                listViewAlbumy.SelectedItems.Clear();
                for (int i = listViewAlbumy.Items.Count - 1; i >= 0; i--)
                {
                    if (listViewAlbumy.Items[i].SubItems[1].Text.ToLower().Contains(textBoxHladaj.Text))
                    {
                        listViewAlbumy.Items[i].Selected = true;
                    }
                }
                listViewAlbumy.Select();
            }
        }
    }
}
