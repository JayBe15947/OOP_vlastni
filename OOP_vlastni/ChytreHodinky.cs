using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_vlastni
{
    class ChytreHodinky :Hodinky
    {
        private string vydrzBaterie;
        private int pocetHod;
        public int PocetHod { get; set; }

        public ChytreHodinky(string znacka, string barva, string material, string vydrzBaterie, int pocetHod ): base(znacka, barva, material)
        {
            this.vydrzBaterie = vydrzBaterie;
            this.pocetHod = pocetHod;
        }
        public string GetVydrzBaterie()
        {
            return vydrzBaterie;
            
        }
        
        public void SetVydrzBaterie(string vydrzBaterie)
        {
            this.vydrzBaterie = vydrzBaterie;
        }
        public override void Cas()
        {
            cas = DateTime.UtcNow;
            MessageBox.Show("Světovy čas: " + cas);
            if (pocetHod >= -12 && pocetHod <= 14)
            {
                cas = DateTime.UtcNow.AddHours(pocetHod);
                MessageBox.Show("Světovy čas v zadaném pásmu: " + cas);
            }
            else MessageBox.Show("Takové pásmo neexistuje (Zadejte pásmo v rozmezí -12 až 14");

            
        }

        public override string ToString()
        {
            return base.ToString() + "\nVýdrž baterie: " + vydrzBaterie + " mAh";
        }
    }
}
