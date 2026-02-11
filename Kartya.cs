using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunBarlang
{
    internal class Kartya
    {

        private int jel;
        private int ertek;
        

        public Kartya(int ertek, int jel)
        {
            this.Jel = jel;
            this.Ertek = ertek;
       
        }

        public int Jel { get => jel; set => jel = value; }
        public int Ertek { get => ertek; set => ertek = value; }
        
    }
}
