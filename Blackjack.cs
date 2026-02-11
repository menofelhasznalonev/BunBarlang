using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunBarlang
{
    internal class Blackjack
    {
        private List<Kartya> jatekosKeze = new List<Kartya>();
        private List<Kartya> hazKeze = new List<Kartya>();
        private Random r = new Random();

        internal List<Kartya> JatekosKeze { get => jatekosKeze; set => jatekosKeze = value; }
        internal List<Kartya> HazKeze { get => hazKeze; set => hazKeze = value; }

        public void JatekMenet(int tet)
        {
            Pakli pakli = new Pakli();
            int hanyadik = 0;
            string tobbet = "";
            int asz = 0;

            pakli.PakliFeltoltese(2);

            do
            {
                hanyadik = r.Next(pakli.List.Count - 1);
                jatekosKeze.Add(pakli.List[hanyadik]);
                pakli.List.RemoveAt(hanyadik);
                Console.WriteLine("Kártyái:");
                foreach (var item in  jatekosKeze)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Összértékük: {ErtekKiszamitasa(jatekosKeze)}");
                Console.WriteLine();
                do
                {
                    Console.Write("Kér még lapot? (I/N): ");
                    tobbet = Console.ReadLine().ToUpper();
                } while (tobbet != "N" && tobbet != "I");
               
                foreach (var item in jatekosKeze)
                {
                    asz++;
                }
                for (int i = 0; i < jatekosKeze.Count; i++)
                {
                    if(jatekosKeze[i].Ertek == 1 && asz > 0)
                    {
                        jatekosKeze.Add(jatekosKeze[i]);
                        jatekosKeze.RemoveAt(i);
                        i--;
                        asz--;
                    }

                }

            } while (tobbet != "N");

        }

        private int ErtekKiszamitasa(List<Kartya> kez)
        {
            int ertek = 0;
            int asz = 0;
            
            foreach (var item in kez)
            {
                if (item.Ertek == 1)
                {
                    asz++;
                }
            }

            foreach (var item in kez)
            {
                if (item.Ertek >= 10)
                {
                    ertek += 10;
                }
                else if (item.Ertek == 1)
                {

                    if (asz > 1)
                    {
                        ertek += 11;
                    }
                    else if (ertek + 11 > 21)
                    {
                        ertek += 1;
                    }
                    else
                    {
                        ertek += 11;
                    }
                }
                else
                {
                    ertek += item.Ertek;
                }
            }
            return ertek;
        }
    }
}
