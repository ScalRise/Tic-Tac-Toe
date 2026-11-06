using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form1 : Form
    {
        // Spieler und Buttons anlegen
        Spieler[] spieler = new Spieler[] { new Spieler("", "X", Color.Red), new Spieler("", "O", Color.Blue) };
        Button[] spielfeld = new Button[9];

       // aktueller Spieler
        int aktuellerSpieler = 0;

        // Spielfeld Aktivierung
        bool deaktiviert = false;

        // Spielstand
        public bool PruefeAufGewinn()
        {
            string z = spieler[aktuellerSpieler].Symbol;

            // horizontal
            if (spielfeld[0].Text == z && spielfeld[1].Text == z && spielfeld[2].Text == z) { HebeFelderHervor(0, 1, 2); return true; }
            if (spielfeld[3].Text == z && spielfeld[4].Text == z && spielfeld[5].Text == z) { HebeFelderHervor(3, 4, 5); return true; }
            if (spielfeld[6].Text == z && spielfeld[7].Text == z && spielfeld[8].Text == z) { HebeFelderHervor(6, 7, 8); return true; }

            // vertikal
            if (spielfeld[0].Text == z && spielfeld[3].Text == z && spielfeld[6].Text == z) { HebeFelderHervor(0, 3, 6); return true; }
            if (spielfeld[1].Text == z && spielfeld[4].Text == z && spielfeld[7].Text == z) { HebeFelderHervor(1, 4, 7); return true; }
            if (spielfeld[2].Text == z && spielfeld[5].Text == z && spielfeld[8].Text == z) { HebeFelderHervor(2, 5, 8); return true; }

            // diagonal
            if (spielfeld[0].Text == z && spielfeld[4].Text == z && spielfeld[8].Text == z) { HebeFelderHervor(0, 4, 8); return true; }
            if (spielfeld[6].Text == z && spielfeld[4].Text == z && spielfeld[2].Text == z) { HebeFelderHervor(6, 4, 2); return true; }

            return false;
        }


        void HebeFelderHervor(int a, int b, int c)
        {
            // Berechnet automatisch eine hellere Version der aktuellen Spielerfarbe
            Color helleSpielerFarbe = ControlPaint.LightLight(spieler[aktuellerSpieler].Farbe);

            // Die drei Gewinnfelder einfärben
            spielfeld[a].BackColor = helleSpielerFarbe;
            spielfeld[b].BackColor = helleSpielerFarbe;
            spielfeld[c].BackColor = helleSpielerFarbe;

            spielfeld[a].ForeColor = spieler[aktuellerSpieler].Farbe;
            spielfeld[b].ForeColor = spieler[aktuellerSpieler].Farbe;
            spielfeld[c].ForeColor = spieler[aktuellerSpieler].Farbe;
        }




        bool PruefeAufUnentschieden() 
        {
            for (int i = 0; i < spielfeld.Length; i++)
            {
                // Ist der Button noch klickbar?
                if (string.IsNullOrEmpty(spielfeld[i].Text))
                {
                    return false; // Mindestens ein freies Feld gefunden
                }
            }
            // Kein freies Feld mehr vorhanden
            return true;
        }

        void SpielfeldDeaktivieren()
        {
            for (int i = 0; i < spielfeld.Length; i++)
            {
                spielfeld[i].Enabled = false;
            }
            deaktiviert = true;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        // Spiel starten
        private void BtnStarten_Click(object sender, EventArgs e)
        {
            if (LblBegruessung.Visible)
            {
                TxtSpieler1.Visible = true;
                TxtSpieler2.Visible = true;
                LblBegruessung.Visible = false;
            }

            else
                if (!deaktiviert)
            {
                spieler[0].Name = TxtSpieler1.Text;
                spieler[1].Name = TxtSpieler2.Text;

                TxtSpieler1.ReadOnly = true;
                TxtSpieler2.ReadOnly = true;
                TxtSpieler1.Visible = false;
                TxtSpieler2.Visible = false;

                // Feld Buttons als ein Spielfeld Array zusammenfügen
                spielfeld = new Button[] { Btn0, Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8 };

                // Spielfeld sichtbar machen
                for (int i = 0; i < spielfeld.Length; i++)
                {
                    spielfeld[i].Text = "";
                    spielfeld[i].BackColor = DefaultBackColor;
                    spielfeld[i].Visible = true;
                }

                LblStatus.Text = $"{spieler[0].Name} ist am Zug ({spieler[0].Symbol})";
                LblStatus.Visible = true;
                BtnStarten.Visible = false;
            }
            else
            {
                for (int i = 0; i < spielfeld.Length; i++)
                {
                    spielfeld[i].Enabled = true;
                    spielfeld[i].Text = "";
                    spielfeld[i].BackColor = DefaultBackColor;

                }
                aktuellerSpieler = 0;
                LblStatus.Text = $"{spieler[0].Name} ist am Zug ({spieler[0].Symbol})";
                LblStatus.Visible = true;
                BtnStarten.Visible = false;
            }

        }
        // Symbole setzen
        private void Btn_Click(object sender, EventArgs e)
        {
            Button BtnClick = sender as Button;
            int i = int.Parse(BtnClick.Name.Substring(3));
            if (!string.IsNullOrEmpty(spielfeld[i].Text))
            {
                return;
            }
            spielfeld[i].ForeColor = spieler[aktuellerSpieler].Farbe;
            spielfeld[i].Text = spieler[aktuellerSpieler].Symbol.ToString();
           

            // Spielende überprüfen
            if (PruefeAufGewinn() == true)
            {
                LblStatus.Text = $"{spieler[aktuellerSpieler].Name} hat gewonnen!";
                SpielfeldDeaktivieren();
            }

            else if (PruefeAufUnentschieden())
            {
                LblStatus.Text = "Unentschieden! Das Spiel ist vorbei.";
            }
            else
            {
                // Spielerwechsel
                aktuellerSpieler = aktuellerSpieler == 0 ? 1 : 0;
                LblStatus.Text = $"{spieler[aktuellerSpieler].Name} ist am Zug ({spieler[aktuellerSpieler].Symbol})";
            }

            
            
        }
    }
}
