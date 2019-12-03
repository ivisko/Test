using System;
using System.IO;
using System.Text;
using System.Xml;

namespace EvidenciaHudobnychAlbumovIvanRajnic //
{
    public class SpravaSuborov
    {
        private static string cestaKuPriecinku = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
            "\\xml";
        public static string cestaKXMLSkladatelia = cestaKuPriecinku + "\\skupiny.xml";
        public static string cestaKXMLAlbumy = cestaKuPriecinku + "\\albumy.xml";
        public static void KontrolaPriecinka()
        {
            if (!Directory.Exists(cestaKuPriecinku)) Directory.CreateDirectory(cestaKuPriecinku);
        }
        public static void KontrolaSkladatelaXml()
        {
            if (!File.Exists(cestaKXMLSkladatelia))
            {
                XmlTextWriter writer = new XmlTextWriter(cestaKXMLSkladatelia, Encoding.UTF8);
                writer.WriteStartElement("Skupiny");
                writer.WriteEndElement();
                writer.Close();
            }
        }
        public static void KontrolaAlbumyXml()
        {
            if (!File.Exists(cestaKXMLAlbumy))
            {
                XmlTextWriter writer = new XmlTextWriter(cestaKXMLAlbumy, Encoding.UTF8);
                writer.WriteStartElement("Albumy");
                writer.WriteEndElement();
                writer.Close();
            }
        }
        public static void ZapisSkupinyXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(cestaKXMLSkladatelia);
            XmlNode xNode = doc.SelectSingleNode("Skupiny");
            xNode.RemoveAll();
            foreach (Skupina skupina in Skupina.zoznam)
            {
                XmlNode xTop = doc.CreateElement("Skupina");
                XmlNode xNazov = doc.CreateElement("Nazov");
                XmlNode xAgent = doc.CreateElement("Agent");
                XmlNode xDatumZalozenia = doc.CreateElement("DatumZalozenia");
                XmlNode xEmail = doc.CreateElement("Email");
                XmlNode xAdresa = doc.CreateElement("Adresa");
                XmlNode xInfo = doc.CreateElement("Info");
                xNazov.InnerText = skupina.Nazov;
                xAgent.InnerText = skupina.Agent;
                xDatumZalozenia.InnerText = skupina.DatumZalozenia.ToFileTime().ToString();
                xEmail.InnerText = skupina.Email;
                xAdresa.InnerText = skupina.Adresa;
                xInfo.InnerText = skupina.Info;
                xTop.AppendChild(xNazov);
                xTop.AppendChild(xAgent);
                xTop.AppendChild(xDatumZalozenia);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xAdresa);
                xTop.AppendChild(xInfo);
                XmlNode xAlbumy = doc.CreateElement("Albumy");
                xTop.AppendChild(xAlbumy);
                for (int i = 0; i < skupina.nahrateAlbumy.Count; i++)
                {
                    XmlNode xAlbum = doc.CreateElement("Album");
                    xAlbum.InnerText = skupina.nahrateAlbumy[i].Cislo.ToString();
                    xAlbumy.AppendChild(xAlbum);
                }
                doc.DocumentElement.AppendChild(xTop);
            }
            doc.Save(cestaKXMLSkladatelia);
        }
        public static void ZapisAlbumyXML() 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(cestaKXMLAlbumy);
            XmlNode xNode = doc.SelectSingleNode("Albumy");
            xNode.RemoveAll();
            foreach (Album album in Album.zoznam)
            {
                XmlNode xTop = doc.CreateElement("Album");
                XmlNode xNazov = doc.CreateElement("Nazov");
                XmlNode xCislo = doc.CreateElement("Cislo");
                XmlNode xDatum = doc.CreateElement("Datum");
                XmlNode xZaner = doc.CreateElement("Zaner");
                XmlNode xPopis = doc.CreateElement("Popis");
                xNazov.InnerText = album.Nazov;
                xCislo.InnerText = album.Cislo.ToString();
                xDatum.InnerText = album.Datum.ToFileTime().ToString();
                xZaner.InnerText = album.Zaner;
                xPopis.InnerText = album.Popis;
                xTop.AppendChild(xNazov);
                xTop.AppendChild(xCislo);
                xTop.AppendChild(xDatum);
                xTop.AppendChild(xZaner);
                xTop.AppendChild(xPopis);
                doc.DocumentElement.AppendChild(xTop);
            }
            doc.Save(cestaKXMLAlbumy);
        }
        public static void NacitanieSkupinZXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(cestaKXMLSkladatelia);
            foreach (XmlNode xNode in doc.SelectNodes("Skupiny/Skupina"))
            {
                Skupina skupina = new Skupina(
                    xNode.SelectSingleNode("Nazov").InnerText,
                    xNode.SelectSingleNode("Agent").InnerText,
                    DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("DatumZalozenia").InnerText)),
                    xNode.SelectSingleNode("Email").InnerText,
                    xNode.SelectSingleNode("Adresa").InnerText,
                    xNode.SelectSingleNode("Info").InnerText
                    );
                foreach (XmlNode pNode in xNode.SelectSingleNode("Albumy").ChildNodes)
                {
                    int cisloAlbumu = Convert.ToInt32(pNode.InnerText);
                    foreach (Album album in Album.zoznam)
                    {
                        if (album.Cislo  == cisloAlbumu)
                        {
                            skupina.nahrateAlbumy.Add(album);
                        }
                    }                    
                }
                skupina.PridajDoZoznamu();
            }
        }
        public static void NacitanieAlbumyZXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(cestaKXMLAlbumy);
            foreach (XmlNode xNode in doc.SelectNodes("Albumy/Album"))
            {
                Album album = new Album(
                    xNode.SelectSingleNode("Nazov").InnerText,
                    Convert.ToInt32(xNode.SelectSingleNode("Cislo").InnerText),
                    DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("Datum").InnerText)),
                    xNode.SelectSingleNode("Zaner").InnerText,
                    xNode.SelectSingleNode("Popis").InnerText
                    );
                album.PridajDoZoznamu();
            }
        }
    }
}
