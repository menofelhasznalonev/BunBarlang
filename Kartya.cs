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
        private string kiirtErtek;


        public Kartya(int jel, int ertek)
        {
            this.Jel = jel;
            this.Ertek = ertek;
       
        }

        public int Jel { get => jel; set => jel = value; }
        public int Ertek { get => ertek; set => ertek = value; }

        private void Stringge()
        {
            
            if (ertek > 10)
            {
                switch (ertek)
                {
                    case 11: kiirtErtek = "J"; break;
                    case 12: kiirtErtek = "Q"; break;
                    case 13: kiirtErtek = "K"; break;
                }
            } else if (ertek == 1)
            {
                kiirtErtek = "A";
            } else
            {
                kiirtErtek = ertek.ToString();
            }
        }

        public override string ToString()
        {
            Stringge();

            if (ertek == 10)
            {
                switch (jel)
                {
                    case 1: return $@"
┌─────────────┐
│{kiirtErtek}           │
│     / \     │
│    /   \    │
│   /     \   │
│   \     /   │
│    \___/    │
│     | |     │
│     | |   {kiirtErtek}│
└─────────────┘               
                                    "; break;
                        
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        return $@"
┌─────────────┐
│{kiirtErtek}           │
│   /\   /\   │
│  /  \ /  \  │
│  \       /  │
│   \     /   │
│    \   /    │
│     \ /     │
│           {kiirtErtek}│
└─────────────┘         
                                    ";
                        
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        return $@"
┌─────────────┐
|{kiirtErtek}           |
│     / \     │
│    /   \    │
│   /     \   │
│   \     /   │
│    \   /    │
│     \ /     │
│           {kiirtErtek}│
└─────────────┘          
                                    ";
                        
                        break;
                    case 4: return $@"
┌─────────────┐
│{kiirtErtek}    __     │
│     /  \    │
│   _|____|_  │
│  /   /\   \ │
│  \___\/___/ │
│      ||     │
│      ||     │
│             │
│           {kiirtErtek}│
└─────────────┘             
                                    "; break;
                    default: return "hiba"; break;
                }
            } else
            {
                switch (jel)
                {
                    case 1: return $@"
┌─────────────┐
│{kiirtErtek}            │
│     / \     │
│    /   \    │
│   /     \   │
│   \     /   │
│    \___/    │
│     | |     │
│     | |    {kiirtErtek}│
└─────────────┘              
                                    "; break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        return $@"
┌─────────────┐
│{kiirtErtek}            │
│   /\   /\   │
│  /  \ /  \  │
│  \       /  │
│   \     /   │
│    \   /    │
│     \ /     │
│            {kiirtErtek}│
└─────────────┘       
                                    ";
                        
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        return $@"
┌─────────────┐
|{kiirtErtek}            |
│     / \     │
│    /   \    │
│   /     \   │
│   \     /   │
│    \   /    │
│     \ /     │
│            {kiirtErtek}│
└─────────────┘          
                                    ";
                        
                        break;
                    case 4: return $@"
┌─────────────┐
│{kiirtErtek}     __     │
│     /  \    │
│   _|____|_  │
│  /   /\   \ │
│  \___\/___/ │
│      ||     │
│      ||     │
│             │
│            {kiirtErtek}│
└─────────────┘             
                                    "; break;
                    default: return "hiba"; break;
                }
            }
        }
    }
}
