using System;
using System.Windows.Forms;

namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    public partial class FormSpravaAlbumu : Form
    {
        private int index = -1;
        public FormSpravaAlbumu()
        {
            InitializeComponent();
        }
        public FormSpravaAlbumu(int index)
        {
            InitializeComponent();
            this.index = index;
        }
        private void buttonUloz_Click(object sender, EventArgs e) //
        {
            if (!IsCisloOK(textBoxCislo.Text))
            {
                MessageBox.Show("Zle zadane evidenne cislo albumu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (index == -1)
            {
                if (!JeCisloOriginalne(Convert.ToInt32(textBoxCislo.Text)))
                {
                    MessageBox.Show("Cislo albumu musi byt originalne!", "Zle cislo albumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (Convert.ToInt32(textBoxCislo.Text) != Album.zoznam[index].Cislo)
                {
                    if ((!JeCisloOriginalne(Convert.ToInt32(textBoxCislo.Text))))
                    {
                        MessageBox.Show("Cislo albumu musi byt originalne!", "Zle cislo albumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (!(textBoxNazov.Text.Length >= 2 && textBoxNazov.Text.Length <= 20))
            {
                MessageBox.Show("Zle zadany nazov albumu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Album album = new Album(
                textBoxNazov.Text,Convert.ToInt32(textBoxCislo.Text), dateTimePickerDatum.Value, textBoxSpolocnost.Text, textBoxPopis.Text
                );
            if (index == -1)
            {
                album.PridajDoZoznamu();
            }
            else
            {
                album.UpravDoZoznamu(index);
            }
            this.Close();
        }
        private void FormSpravaAlbumu_Load(object sender, EventArgs e)
        {
            if (index != -1)
            {
                textBoxCislo.Text = Album.zoznam[index].Cislo.ToString();
                textBoxNazov.Text = Album.zoznam[index].Nazov;
                dateTimePickerDatum.Value = Album.zoznam[index].Datum;
                textBoxSpolocnost.Text = Album.zoznam[index].Zaner;
                textBoxPopis.Text = Album.zoznam[index].Popis;
            }
        }
        public static bool JeCisloOriginalne(int cislo)
        {
            foreach (Album album in Album.zoznam)
            {
                if (album.Cislo == cislo)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsCisloOK(string cislo)
        {
            int cisloInt;
            bool jeCislo = Int32.TryParse(cislo, out cisloInt);
            return (jeCislo && cisloInt > 0) ? true : false;
        }
    }
}
