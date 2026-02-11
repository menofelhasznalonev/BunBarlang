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
                Console.WriteLine("Összértékük: TBA");
                Console.WriteLine();
                do
                {
                    Console.Write("Kér még lapot? (I/N)");
                    tobbet = Console.ReadLine().ToUpper();
                } while (tobbet != "N" && tobbet != "I");
               
            } while (tobbet != "N");

        }

        private void ErtekKiszamitasa(List<Kartya> kez)
        {
            int ertek = 0;
            foreach (var item in kez)
            {
                if (item.Ertek >= 10)
                {
                    ertek += 10;
                } 
                else if (item.Ertek == 1)
                {
                    if (ertek+11 > 21)
                    {
                        ertek += 1;
                    } else
                    {
                        ertek += 11;
                    }
                }
                else
                {
                    ertek += item.Ertek;
                }
            }
    }
}
