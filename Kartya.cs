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
        

        public Kartya(int jel, int ertek)
        {
            this.Jel = jel;
            this.Ertek = ertek;
       
        }

        public int Jel { get => jel; set => jel = value; }
        public int Ertek { get => ertek; set => ertek = value; }


        public override string ToString()
        {
            switch (jel) 
            {
                case 1: return $@"
┌─────────────┐
│{ertek}            │
│      /\     │
│     /  \    │
│    /    \   │
│    \    /   │
│     \__/    │
│      ||     │
│      ||    {ertek}│
└─────────────┘              
                                    ";break;
                case 2: return $@"
┌─────────────┐
│{ertek}            │
│     /\  /\  │
│    /  \/  \ │
│    \      / │
│     \    /  │
│      \  /   │
│       \/    │
│            {ertek}│
└─────────────┘         
                                    "; break;
                case 3: return $@"
┌─────────────┐
|{ertek}            |
│     / \     │
│    /   \    │
│   /     \   │
│   \     /   │
│    \   /    │
│     \ /     │
│            {ertek}│
└─────────────┘          
                                    "; break;
                case 4: return $@"
┌─────────────┐
│{ertek}     __     │
│     /  \    │
│   _|____|_  │
│  /   /\   \ │
│  \___\/___/ │
│      ||     │
│      ||     │
│             │
│            {ertek}│
└─────────────┘             
                                    "; break;
                default: return "hiba"; break;
            }

        }
    }
}
