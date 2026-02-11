using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BunBarlang
{
    internal class Pakli
    {
        private List<Kartya> list = new List<Kartya>();



        internal List<Kartya> List { get => list; set => list = value; }

        public void PakliFeltoltese(int pakliSzam)
        {
            for (int i = 0; i < pakliSzam; i++) 
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 13; k++)
                    {
                        Kartya kartya = new Kartya(j, k);
                        List.Add(kartya);
                    }
                }
            }
        }
    }
}
