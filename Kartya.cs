using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunBarlang
{
    internal class Kartya
    {

        private int ertek;
        private int jel;

        public Kartya(int ertek, int jel)
        {
            this.Ertek = ertek;
            this.Jel = jel;
        }

        public int Ertek { get => ertek; set => ertek = value; }
        public int Jel { get => jel; set => jel = value; }
    }
}
