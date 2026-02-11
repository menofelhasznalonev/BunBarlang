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

            do
            {
                Console.Write("Mennyi pénzt tesz fel: ");
                if (int.TryParse(Console.ReadLine(), out tet))
                {
                    mehet = true;
                }
            } while (!mehet || tet < 0 || tet >= penz);
            penz += blackjack.JatekMenet(tet, 2);





        }
    }
}
