using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_vlastni
{
    class Hodinky
    {
        protected string znacka;
        protected string barva;
        protected string material;
        protected DateTime spusteniStopek;
        protected TimeSpan dobaOdSpusteniStopek;
        protected DateTime cas;
        public string Znacka
        {
            get
            {
                return znacka;
            }
            set
            {
                string z = value;
                z = Char.ToUpper(z[0]) + z.Substring(1);
                znacka = z;
            }
        }
        
        public Hodinky(string znacka, string barva, string material)
        {
            Znacka = znacka;
            this.barva = barva;
            this.material = material;
            dobaOdSpusteniStopek = new TimeSpan(0);
        }
        public void Spust()
        {
            spusteniStopek = DateTime.Now;
            MessageBox.Show("Stopky se spustily");
        }
        public void Zastav()
        {
            dobaOdSpusteniStopek = DateTime.Now - spusteniStopek;
            MessageBox.Show("Doba od spusteni:" + dobaOdSpusteniStopek.TotalSeconds + " sekund");
        }
        public void Cas()
        {
            cas = DateTime.Now;
            MessageBox.Show("Datum a Čas: " + cas);
        }
        public override string ToString()
        {
            string s = "Značka: " + znacka
                     + "\nBarva řemínku: " + barva
                     + "\nMateriál řemínku: " + material;
            return s;
        }
    }
}
