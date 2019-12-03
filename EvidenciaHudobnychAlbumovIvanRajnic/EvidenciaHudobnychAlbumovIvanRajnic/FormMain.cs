using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EvidenciaHudobnychAlbumovIvanRajnic
{
    public partial class FormHlavna : Form
    {
        public FormHlavna()
        {
            InitializeComponent();
        }

        private void pictureBoxSkupina_Click(object sender, EventArgs e)
        {
            FormSkupina formSkupina = new FormSkupina();
            formSkupina.Show();
        }

        private void picBoxAlbum_Click(object sender, EventArgs e)
        {
            FormAlbum formAlbum = new FormAlbum();
            formAlbum.Show();
        }

        private void picBoxPriradenie_Click(object sender, EventArgs e)
        {
            FormPrepojenie formPrepojenie = new FormPrepojenie();
            formPrepojenie.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SpravaSuborov.KontrolaPriecinka();
            SpravaSuborov.KontrolaSkladatelaXml();
            SpravaSuborov.KontrolaAlbumyXml();
            SpravaSuborov.NacitanieAlbumyZXML();
            SpravaSuborov.NacitanieSkupinZXML();
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpravaSuborov.ZapisAlbumyXML();
            SpravaSuborov.ZapisSkupinyXML();
            
        }
    }
}
