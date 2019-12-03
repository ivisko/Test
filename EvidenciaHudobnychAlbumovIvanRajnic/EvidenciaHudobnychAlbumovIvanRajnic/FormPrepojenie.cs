using System;
using System.Windows.Forms;

namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    public partial class FormPrepojenie : Form
    {
        public FormPrepojenie()
        {
            InitializeComponent();
            reloadComboBoxovSkupiny();
            reloadComboBoxovAlbumy();
            reloadComboBoxovZobrazenia();
            reloadComboZobrazeniaAlbumu();
        }
        private void reloadComboBoxovSkupiny()
        {
            comboBoxSkupina.Text = "Vyber skupinu";
            foreach (Skupina skupina in Skupina.zoznam)
            {
                comboBoxSkupina.Items.Add(skupina.Nazov + " | " + skupina.Agent);
            }
        }
        private void reloadComboBoxovZobrazenia()
        {
            comBoZobrazAlbumyPreSkupinu.Text = "Vyber skupinu";
            foreach (Skupina skupina in Skupina.zoznam)
            {
                comBoZobrazAlbumyPreSkupinu.Items.Add(skupina.Nazov + " " + skupina.Agent);
            }
        }
        private void reloadComboBoxovAlbumy()
        {
            comboBoxAlbum.Text = "Vyber album";
            foreach (Album album in Album.zoznam)
            {
                comboBoxAlbum.Items.Add(album.Cislo.ToString() + " " + album.Nazov);
            }
        }
        private void reloadComboZobrazeniaAlbumu()
        {
            comBoZobrazSkupinyPreAlbum.Text = "Vyber album";
            foreach (Album album in Album.zoznam)
            {
                comBoZobrazSkupinyPreAlbum.Items.Add(album.Cislo.ToString() + " " + album.Nazov);
            }
        }
        private void reloadListBoxZobrazeniaAlbumovPreSkupiny()
        {
            listBoxSkupinyPreAlbumy.Items.Clear();
            int index = comBoZobrazSkupinyPreAlbum.SelectedIndex;
            foreach (Skupina skupina in Skupina.zoznam)
            {
                if (skupina.nahrateAlbumy.Contains(Album.zoznam[index]))
                {
                    listBoxSkupinyPreAlbumy.Items.Add(skupina.Nazov + " | " + skupina.Agent);
                }
            }
        }
        private void buttonPrirad_Click(object sender, EventArgs e)
        {
            int indexVybranejSkupiny = comboBoxSkupina.SelectedIndex;
            int indexVybranehoAlbumu = comboBoxAlbum.SelectedIndex;
            if (indexVybranejSkupiny == -1 || indexVybranehoAlbumu == -1)
            {
                MessageBox.Show("Zle vybrana kapela alebo album", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Skupina.zoznam[indexVybranejSkupiny].nahrateAlbumy.Contains(Album.zoznam[indexVybranehoAlbumu]))
            {
                MessageBox.Show("Skupina uz tento album prideleny ma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Skupina.zoznam[indexVybranejSkupiny].nahrateAlbumy.Add(Album.zoznam[indexVybranehoAlbumu]);
            MessageBox.Show("Album prideleny", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reloadListBoxZobrazeniaSkupinPreAlbumy();
            reloadListBoxZobrazeniaAlbumovPreSkupiny();
        }
        private void reloadListBoxZobrazeniaSkupinPreAlbumy()
        {
            listBoxAlbumyPreSkupinu.Items.Clear();
            int index = comBoZobrazAlbumyPreSkupinu.SelectedIndex;
            foreach (Album album in Skupina.zoznam[index].nahrateAlbumy)
            {
                listBoxAlbumyPreSkupinu.Items.Add(album.Cislo + " " + album.Nazov);
            }
        }
        private void comboBoxBoZobraz_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadListBoxZobrazeniaSkupinPreAlbumy();
        }
        private void comboBoxZobrazAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadListBoxZobrazeniaAlbumovPreSkupiny();
        }
        private void buttonZmazPridelenyAlbum_Click(object sender, EventArgs e)
        {
            int indexVybranejSkupiny = comboBoxSkupina.SelectedIndex;
            int indexVybranehoAlbumu = comboBoxAlbum.SelectedIndex;
            if (indexVybranejSkupiny == -1 || indexVybranehoAlbumu == -1)
            {
                MessageBox.Show("Zle vybrana skupina alebo album", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Skupina.zoznam[indexVybranejSkupiny].nahrateAlbumy.Contains(Album.zoznam[indexVybranehoAlbumu]))
            {
                MessageBox.Show("Skupina tento album nema prideleny.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Skupina.zoznam[indexVybranejSkupiny].nahrateAlbumy.Remove(Album.zoznam[indexVybranehoAlbumu]);
            MessageBox.Show("Album zmazany", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reloadListBoxZobrazeniaSkupinPreAlbumy();
            reloadListBoxZobrazeniaAlbumovPreSkupiny();
        }
        private void comboBoxSkupina_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoZobrazAlbumyPreSkupinu.SelectedIndex = comboBoxSkupina.SelectedIndex;
        }
        private void comboBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBoZobrazSkupinyPreAlbum.SelectedIndex = comboBoxAlbum.SelectedIndex;
        }
    }
}
