using System;
using System.Windows.Forms;

namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    public partial class FormSpravaSkupiny : Form
    {
        private int index = -1;

        public FormSpravaSkupiny()
        {
            InitializeComponent();
        }
        public FormSpravaSkupiny(int index)
        {
            InitializeComponent();
            this.index = index;
        }
        private void btnUloz_Click(object sender, EventArgs e)
        {
            if (textBoxNazov.Text.Length <= 1 || textBoxNazov.Text.Length >= 35)
            {
                MessageBox.Show("Zle zadany nazov", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxAgent.Text.Length <= 2 || textBoxAgent.Text.Length >=20)
            {
                MessageBox.Show("Zle zadane agent", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Skupina skupina = new Skupina(
                textBoxNazov.Text, textBoxAgent.Text, dateTimePickerDatumZalozenia.Value, textBoxEmail.Text, textBoxAdresa.Text, textInfo.Text
                );
            if (index==-1)
            {
                skupina.PridajDoZoznamu();
            }
            else
            {
                skupina.UpravDoZoznamu(index);
            }
            this.Close();
        }
        private void FormPridanieSkupiny_Load(object sender, EventArgs e)
        {
            if (index!=-1)
            {
                textBoxNazov.Text = Skupina.zoznam[index].Nazov;
                textBoxAgent.Text = Skupina.zoznam[index].Agent;
                dateTimePickerDatumZalozenia.Value = Skupina.zoznam[index].DatumZalozenia;
                textBoxEmail.Text = Skupina.zoznam[index].Email;
                textBoxAdresa.Text = Skupina.zoznam[index].Adresa;
                textInfo.Text = Skupina.zoznam[index].Info;
            }
        }
    }
}
