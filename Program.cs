namespace BunBarlang
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Pakli pakli = new Pakli();
            Blackjack blackjack = new Blackjack();
            int penz = 10000;
            int tet = 0;
            bool mehet = false;
            string megegy = "";
            int paklik = 0;

            do
            {
                Console.Clear();
                mehet = false;
                do
                {
                    Console.Write("hány paklival szeretne játszani? (1-10): ");
                    if (int.TryParse(Console.ReadLine(), out paklik))
                    {
                        mehet = true;
                    }
                } while (!mehet || paklik < 0 || tet >= 10);
                mehet = false;
                do
                {
                    Console.Write($"Mennyi pénzt tesz fel (most van {penz} Ft-ja) : ");
                    if (int.TryParse(Console.ReadLine(), out tet))
                    {
                        mehet = true;
                    }
                } while (!mehet || tet < 0 || tet >= penz);
                penz += blackjack.JatekMenet(tet, 2);

                if (penz > 0)
                {
                    do
                    {
                        Console.Write("Szeretne mégegy kört? (I/N): ");
                        megegy = Console.ReadLine().ToUpper();
                    } while (megegy != "N" && megegy != "I");
                }

            } while (megegy != "N" && penz > 0);

            if (penz == 0)
            {
                Console.Clear();
                Console.WriteLine("Elszerencsejátékoztad minden pénzed, kirúgtak a kaszinóból");
            } else
            {
                Console.Clear();
                Console.WriteLine($"{penz} Ft-tal távoztál a kaszinónól");
            }
        }
    }
}
