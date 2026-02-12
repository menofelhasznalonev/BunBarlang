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

        public int JatekMenet(int tet, int pakliSzam)
        {

            

            Pakli pakli = new Pakli();
            int hanyadik = 0;
            string tobbet = "I";

            jatekosKeze.Clear();
            hazKeze.Clear();
            pakli.PakliFeltoltese(pakliSzam);

            Console.Clear();

            hanyadik = r.Next(pakli.List.Count - 1);
            jatekosKeze.Add(pakli.List[hanyadik]);
            pakli.List.RemoveAt(hanyadik);
            Console.WriteLine($"Kártyái:\t {jatekosKeze[0]}");
            Console.ResetColor();
            Console.WriteLine($"Összértékük: {ErtekKiszamitasa(jatekosKeze)}");

            Console.WriteLine();
            do
            {
                Console.Write("Kérsz még lapot? (I/N): ");
                tobbet = Console.ReadLine().ToUpper();
            } while (tobbet != "N" && tobbet != "I");

            while (tobbet != "N" && ErtekKiszamitasa(jatekosKeze) <= 21)
            {
                Console.Clear();
                aszElore(jatekosKeze);

                hanyadik = r.Next(pakli.List.Count - 1);
                jatekosKeze.Add(pakli.List[hanyadik]);
                pakli.List.RemoveAt(hanyadik);
                Console.WriteLine("Kártyáid:");
                foreach (var item in jatekosKeze)
                {
                    Console.WriteLine(item);
                    Console.ResetColor();
                }
                Console.WriteLine($"Összértékük: {ErtekKiszamitasa(jatekosKeze)}");

                if (ErtekKiszamitasa(jatekosKeze)  < 21)
                {
                    Console.WriteLine();
                    do
                    {
                        Console.Write("Kérsz még lapot? (I/N): ");
                        tobbet = Console.ReadLine().ToUpper();
                    } while (tobbet != "N" && tobbet != "I");
                }
            }

            if (ErtekKiszamitasa(jatekosKeze) == 21)
            {
                Console.WriteLine($"Gratulálok, 21 lett a végeredmény, nyertél {tet*3} Ft-ot");
                tet = tet * 3;
                return tet;
            } else if (ErtekKiszamitasa(jatekosKeze) > 21)
            {
                Console.WriteLine($"Vesztettél {tet} Ft-ot");
                tet = tet * -1;
                return tet;
            } else
            {
                bool mehet = true;
                Console.WriteLine("Áz osztó kártyái: ");

                while (mehet)
                {

                    aszElore(hazKeze);

                    hanyadik = r.Next(pakli.List.Count - 1);
                    if (ErtekKiszamitasa(HazKeze) + pakli.List[hanyadik].Ertek <= 21)
                    {
                        hazKeze.Add(pakli.List[hanyadik]);
                        pakli.List.RemoveAt(hanyadik);
                    }
                    else
                    {
                        mehet = false;
                    }

                }
                foreach (var item in hazKeze)
                {
                    Console.WriteLine(item);
                    Console.ResetColor();
                }
                Console.WriteLine($"Az osztó kártyáinak összértéke: {ErtekKiszamitasa(hazKeze)}, A te kártyáid összértéke: {ErtekKiszamitasa(jatekosKeze)}");
                if (ErtekKiszamitasa(hazKeze) > ErtekKiszamitasa(jatekosKeze))
                {
                    Console.WriteLine($"Vesztettél {tet} Ft-ot");
                    tet = tet * -1;
                    return tet;
                }
                else if (ErtekKiszamitasa(hazKeze) < ErtekKiszamitasa(jatekosKeze))
                {
                    Console.WriteLine($"Gratulálok, nyertél {tet * 2} Ft-ot");
                    tet = tet * 2;
                    return tet;
                } else
                {
                    Console.WriteLine("Döntetlen, visszakaptad a téted");
                    return tet;
                }

            }

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

        private void aszElore(List<Kartya> kez)
        {
            int asz = 0;

            foreach (var item in kez)
            {
                asz++;
            }
            for (int i = 0; i < kez.Count; i++)
            {
                if (kez[i].Ertek == 1 && asz > 0)
                {
                    kez.Add(kez[i]);
                    kez.RemoveAt(i);
                    i--;
                    asz--;
                }

            }
        }
    }
}
