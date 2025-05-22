using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Produktliste
{
    public class Produktliste
    {
        private int artNr;
        private string artBezeichnung;
        private double artPreis;
        private string artKategorie;
        private int artLagerbestand;

        public int ArtNr { get => artNr; set => artNr = value; }
        public string ArtBezeichnung { get => artBezeichnung; set => artBezeichnung = value; }
        public double ArtPreis { get => artPreis; set => artPreis = value; }
        public string ArtKategorie { get => artKategorie; set => artKategorie = value; }
        public int ArtLagerbestand { get => artLagerbestand; set => artLagerbestand = value; }




        public Produktliste(int nr, string ab, double ap, string ak, int al)
        {
            artNr = nr;
            artBezeichnung = ab;
            artPreis = ap;
            artKategorie = ak;
            artLagerbestand = al;

        }

        public override string ToString()
        {
            return $" {artNr},{ArtBezeichnung}, {artPreis}, {artKategorie}, {artLagerbestand}";
        }

        public string toCSV()
        {
            return artNr+ ";" + ArtBezeichnung + ";" + artPreis + ";" + artKategorie + ";" + artLagerbestand ;
        }
    }
}
