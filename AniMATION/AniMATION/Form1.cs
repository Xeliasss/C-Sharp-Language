using Microsoft.VisualBasic;

namespace AniMATION
{
    public partial class Form1 : Form
    {
        private int geschwindigkeit = 10;
        private int ampelPhase = 0;
        private PictureBox[] Ampel = new PictureBox[4];
        private PictureBox[] Ampel2 = new PictureBox[4];

        public Form1()
        {
            InitializeComponent();
            Ampel[0] = pictureBoxRot;
            Ampel[1] = pictureBoxGelb;
            Ampel[2] = pictureBoxGruen;
            Ampel[3] = pictureBoxGelb;

            Ampel2[0] = pictureBoxRot2;
            Ampel2[1] = pictureBoxGelb2;
            Ampel2[2] = pictureBoxGruen2;
            Ampel2[3] = pictureBoxGelb2;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Wenn die Ampel rot ist und das Auto sich vor der Ampel befindet
            if (!(ampelPhase == 1 && pictureBox1.Location.X >= 190 && pictureBox1.Location.X < 343))
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - geschwindigkeit, pictureBox1.Location.Y);

                if (pictureBox1.Location.X < -pictureBox1.Width)
                {


                    pictureBox1.Location =
                    new Point(this.Width, pictureBox1.Location.Y);

                }
            }



            // Wenn die Ampel rot ist und das Auto sich vor der Ampel befindet
            if (!(ampelPhase == 1 && pictureBox2.Location.X <= 539 && pictureBox2.Location.X > 329))
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + geschwindigkeit, pictureBox2.Location.Y);

                if (pictureBox2.Location.X   > this.Width)
                {


                    pictureBox2.Location =
                    new Point(0,pictureBox2.Location.Y);

                }
            }



        }

        private void numspeed_ValueChanged(object sender, EventArgs e)
        {
            int neueGeschwindigkeit = (int)numspeed.Value;

            // Beispiel: Einen Timer mit neuer Geschwindigkeit anpassen
            timer1.Interval = 1000 / neueGeschwindigkeit;
        }

        private void notbremse_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void enginestart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ampeltimer_Tick(object sender, EventArgs e)
        {
            // Alle Ampelbilder unsichtbar machen



            foreach (var pic in Ampel)
            {
                pic.Visible = false;
            }

            foreach (var pic in Ampel2)
            {
                pic.Visible = false;
            }
            // Ampel-Phase basierend auf der aktuellen Phase wechseln



            switch (ampelPhase)
            {
                case 0: // Rot
                    Ampel[0].Visible = true;  // Bild für Rot
                    Ampel2[0].Visible = true;  // Bild für Rot
                    ampelPhase = 1;  // Weiter zu Gelb
                    break;

                case 1: // Gelb
                    Ampel[1].Visible = true;  // Bild für Gelb
                    Ampel2[1].Visible = true;  
                    ampelPhase = 2;  // Weiter zu Grün
                    geschwindigkeit = 2;
                    break;

                case 2: // Grün
                    Ampel[2].Visible = true;  // Bild für Grün
                    Ampel2[2].Visible = true;  // Bild für Grün
                    ampelPhase = 3;  // Weiter zu Gelb
                    geschwindigkeit = 10;
                    break;

                case 3: // Gelb (nach Grün)
                    Ampel[3].Visible = true;  // Bild für Gelb
                    Ampel2[3].Visible = true;  // Bild für Gelb
                    ampelPhase = 0;  // Weiter zu Rot
                    geschwindigkeit = 3;

                    break;
            }

            // Alle Ampelbilder unsichtbar machen





            }
        }


    }

