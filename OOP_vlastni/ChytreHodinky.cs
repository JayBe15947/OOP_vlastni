using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vlastni
{
    class ChytreHodinky :Hodinky
    {
        private string vydrzBaterie;

        public ChytreHodinky(string znacka, string barva, string material, string vydrzBaterie) : base(znacka, barva, material)
        {
            this.vydrzBaterie = vydrzBaterie;
        }
        public string GetVydrzBaterie()
        {
            return vydrzBaterie;
            
        }

    }
}
