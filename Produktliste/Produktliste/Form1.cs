using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Produktliste
{
    public partial class Form1 : Form
    {
        List<Produktliste> list = new List<Produktliste>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datei dt = new Datei();
            list = dt.liesCSV();
            // Lade die Produkte aus der CSV-Datei
           

            // Zeige die Produkte in der ListBox an
            listBoxArtikel.Items.Clear(); // Leere vorherige Items, falls vorhanden
            foreach (var produkt in list)
            {
                listBoxArtikel.Items.Add(produkt.ToString());  // Hier wird die ToString-Methode von Produktliste verwendet
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (listBoxArtikel.SelectedIndex == -1)
            {


                int artNr;
                double artPreis;
                int artLagerbestand;
                int.TryParse(textBoxArtNr.Text.Trim(), out artNr);
                string artBezeichnung = textBoxArtBezeichnung.Text.Trim();
                double.TryParse(textBoxArtPreis.Text.Trim(), out artPreis);
                string artKategorie = textBoxArtKategorie.Text.Trim();
                int.TryParse(textBoxArtLagerbestand.Text.Trim(), out artLagerbestand);




                Produktliste neueProdukt = new Produktliste
                    (
                    artNr,
                    artBezeichnung,
                    artPreis,
                    artKategorie,
                    artLagerbestand
                    );

                list.Add(neueProdukt);

                listBoxArtikel.Items.Clear();
                foreach (Produktliste Produktliste in list)
                {
                    listBoxArtikel.Items.Add(Produktliste);
                }

                // Felder leeren nach dem Hinzufügen
                textBoxArtNr.Clear();
                textBoxArtBezeichnung.Clear();
                textBoxArtPreis.Clear();
                textBoxArtKategorie.Clear();
                textBoxArtLagerbestand.Clear();

                

            }
            else
            {
                int index = listBoxArtikel.SelectedIndex;

                list[index].ArtNr = int.Parse(textBoxArtNr.Text);
                list[index].ArtBezeichnung = textBoxArtBezeichnung.Text;
                list[index].ArtPreis = double.Parse(textBoxArtPreis.Text);
                list[index].ArtKategorie = textBoxArtKategorie.Text;
                list[index].ArtLagerbestand = int.Parse(textBoxArtLagerbestand.Text);

                listBoxArtikel.Items[index] = list[index];
            }

        }

        private void listBoxArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = listBoxArtikel.SelectedIndex;


            // Kontakt mit neuen Werten aktualisieren

            textBoxArtNr.Text   = list[index].ArtNr.ToString();
            textBoxArtBezeichnung.Text = list[index].ArtBezeichnung;
            textBoxArtPreis.Text = list[index].ArtPreis.ToString("F2");
            textBoxArtKategorie.Text = list[index].ArtKategorie;
            textBoxArtLagerbestand.Text = list[index].ArtLagerbestand.ToString();

        }

        private void buttonCsv_Click(object sender, EventArgs e)
        {
            Datei dt = new Datei();
            dt.schreibeCSV(list);
        }

        private void buttonloeschen_Click(object sender, EventArgs e)
        {
            Datei dt = new Datei();
            

            if (listBoxArtikel.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie ein Produkt zum Löschen aus.");
                return;
            }

            int selectedIndex = listBoxArtikel.SelectedIndex;
            Produktliste produktZuLoeschen = list[selectedIndex];

            // Lösche das Produkt aus der Liste
            list.Remove(produktZuLoeschen);

            // Aktualisiere die ListBox
            listBoxArtikel.Items.Clear();
            foreach (Produktliste produkt in list)
            {
                listBoxArtikel.Items.Add(produkt.ToString());
            }

            // Speichere die geänderte Liste zurück in die CSV-Datei
            dt.schreibeCSV(list);

            MessageBox.Show($"Produkt '{produktZuLoeschen.ArtBezeichnung}' wurde gelöscht.");
        }
    }
}
