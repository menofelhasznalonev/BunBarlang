namespace BunBarlang
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pakli pakli = new Pakli();


            pakli.PakliFeltoltese(2);

            foreach (var item in pakli.List)
            {
                Console.WriteLine(item);
            }

            
            
        }
    }
}
