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
    }
}
