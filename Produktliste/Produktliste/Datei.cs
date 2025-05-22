using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktliste
{
    internal class Datei
    {
        private string datei = @"c:\\C#datei\\Produktliste.csv";

        private FileStream stream;

        public void schreibeCSV(List<Produktliste> listBoxArtikel)
        {
            stream = new FileStream(datei, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(stream);

            foreach (Produktliste k in listBoxArtikel)
            {
                sr.WriteLine(k.toCSV());


            }
            sr.Close();
            stream.Close();
        }


        public List<Produktliste> liesCSV()
        {
            List<Produktliste> listBoxArtikel = new List<Produktliste>();
            string s;
            string[] arrstr;


            stream = new FileStream(datei, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);


            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                arrstr = s.Split(';');

                listBoxArtikel.Add(new Produktliste(int.Parse(arrstr[0]), arrstr[1], double.Parse(arrstr[2]), arrstr[3], int.Parse(arrstr[4])));


            }
            sr.Close();
            stream.Close();
            return listBoxArtikel;

        }

        public void aendereProdukt(int artNr, Produktliste geaendertesProdukt)
        {
            List<Produktliste> produkte = liesCSV();
            bool produktGefunden = false;

            // Suche nach dem Produkt und Update der Werte
            for (int i = 0; i < produkte.Count; i++)
            {
                if (produkte[i].ArtNr == artNr)
                {
                    produkte[i] = geaendertesProdukt; // Ersetze das Produkt durch das geänderte
                    produktGefunden = true;
                    break;
                }
            }

            // Wenn Produkt gefunden, schreibe die geänderte Liste zurück in die Datei
            if (produktGefunden)
            {
                schreibeCSV(produkte);
            }
            else
            {
                Console.WriteLine("Produkt mit der angegebenen ArtNr nicht gefunden.");
            }
        }

        // Methode zum Löschen eines Produkts aus der CSV-Datei
        public void loescheProdukt(int artNr)
        {
            List<Produktliste> produkte = liesCSV();
            Produktliste produktZuLoeschen = produkte.FirstOrDefault(p => p.ArtNr == artNr);

            if (produktZuLoeschen != null)
            {
                produkte.Remove(produktZuLoeschen); // Entferne das Produkt
                schreibeCSV(produkte); // Speichere die Liste ohne das gelöschte Produkt zurück in die Datei
                Console.WriteLine($"Produkt mit der ArtNr {artNr} wurde gelöscht.");
            }
            else
            {
                Console.WriteLine("Produkt mit der angegebenen ArtNr nicht gefunden.");
            }
        }
    }
}
    

