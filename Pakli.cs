using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunBarlang
{
    internal class Pakli
    {
        List<Kartya> list;

        public Pakli(List<Kartya> list)
        {
            this.List = list;
        }

        internal List<Kartya> List { get => list; set => list = value; }

        private void PakliFeltoltese(int pakliSzam)
        {
            for (int i = 0; i < pakliSzam; i++) 
            {
                for (int j = 1; j <= 4; i++)
                {
                    for (int k = 1; k <= 13; i++)
                    {
                        Kartya kartya = new Kartya(j, k);
                        list.Add(kartya);
                    }
                }
            }
        }

    }
}
