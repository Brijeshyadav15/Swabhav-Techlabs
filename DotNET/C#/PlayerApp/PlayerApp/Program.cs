using System;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //case1();
            Player p1 = new Player(101, "A", 20);
            Player p2 = new Player(101, "A", 20);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Id.Equals(p2.Id));

        }

        private static void case1()
        {
            Player sachin = new Player(101, "Sachin", 45);
            Player virat = new Player(102, "Virat");

            Console.WriteLine(sachin.Id);
            Console.WriteLine(virat.Id);

            Console.WriteLine(sachin.Name);
            Console.WriteLine(virat.Name);

            Console.WriteLine(sachin.Age);
            Console.WriteLine(virat.Age);

            Console.WriteLine(sachin);
            Console.WriteLine(sachin.ToString());

            Player elder = sachin.whoIsElder(virat);
            Console.WriteLine("Elder player is :" + elder.Name);
        }
    }
}
