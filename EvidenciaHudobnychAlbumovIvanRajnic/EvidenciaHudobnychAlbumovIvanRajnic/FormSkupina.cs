using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenciaHudobnychAlbumovIvanRajnic //
{
    public partial class FormSkupina : Form
    {
        public FormSkupina()
        {
            InitializeComponent();
            reloadListuSkupin();
        }

        private void buttonPridaj_Click(object sender, EventArgs e)
        {

            FormSpravaSkupiny formSravaSkupiny = new FormSpravaSkupiny();
            formSravaSkupiny.ShowDialog();
            reloadListuSkupin();



        }
        private void reloadListuSkupin()
        {
            listViewSkupiny.Items.Clear();
            foreach (Skupina skupina in Skupina.zoznam)
            {
                ListViewItem listViewItem = new ListViewItem(skupina.Nazov);
                listViewItem.SubItems.Add(skupina.Agent);
                listViewItem.SubItems.Add(skupina.DatumZalozenia.ToString("dd/MM/yyyy"));              
                listViewItem.SubItems.Add(skupina.Email);
                listViewItem.SubItems.Add(skupina.Adresa);
                listViewItem.SubItems.Add(skupina.Info);
                listViewSkupiny.Items.Add(listViewItem);
            }
        }

        private void buttonUprav_Click(object sender, EventArgs e)
        {
            if (listViewSkupiny.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vyber skupinu na upravu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = listViewSkupiny.SelectedItems[0].Index;
            FormSpravaSkupiny formSpravaSkupiny = new FormSpravaSkupiny(index);
            formSpravaSkupiny.ShowDialog();
            reloadListuSkupin();
        }

        private void buttonZmaz_Click(object sender, EventArgs e)
        {
            if (listViewSkupiny.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vyber kapelu na zmazanie", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = listViewSkupiny.SelectedItems[0].Index;
            Skupina.zoznam.RemoveAt(index);
            reloadListuSkupin();
        }

        private void buttonTriedenieNazov_Click(object sender, EventArgs e)
        {
            Skupina.zoznam.Sort();
            reloadListuSkupin();
        }

        private void buttonTriedenieNarodenie_Click(object sender, EventArgs e)
        {
            SortByDatumZalozenia sortByZalozenia = new SortByDatumZalozenia();
            Skupina.zoznam.Sort(sortByZalozenia);
            reloadListuSkupin();
        }

        private void btnTriedenieEmail_Click(object sender, EventArgs e)
        {
            SortByEmail sortByEmail = new SortByEmail();
            Skupina.zoznam.Sort(sortByEmail);
            reloadListuSkupin();
        }

        private void buttonHladaj_Click(object sender, EventArgs e)
        {
            //listViewSkupiny.SelectedItems.Clear();
            //for (int i = listViewSkupiny.Items.Count - 1; i >= 0; i--)
            //{
            //    if (listViewSkupiny.Items[i].SubItems[0].Text.ToLower().Contains(textBoxHladaj.Text))
            //    {
            //        listViewSkupiny.Items[i].Selected = true;
            //    }
            //}
            //listViewSkupiny.Select();

            listViewSkupiny.SelectedItems.Clear();

            for (int i = 0; i < Skupina.zoznam.Count; i++)
            {
                if (Skupina.zoznam[i].Nazov.Contains(textBoxHladaj.Text))
                {
                    listViewSkupiny.Items[i].Selected = true;
                }
            }
            listViewSkupiny.Select();
        }
    }
}
