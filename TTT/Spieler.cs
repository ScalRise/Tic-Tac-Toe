using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    public class Spieler
    {
        public string Name;
        public string Symbol;
        public Color Farbe;

        public Spieler(string name, string symbol, Color farbe)
        {
            Name = name;
            Symbol = symbol;
            Farbe = farbe;
        }
    }
}
