using System;

namespace K60._1_Bartłomiej_Misiak_1
{

    class Program
    {
        static int a, b, c;
        static void licz()
        {
            int a, b, c, o;
            Console.Write("Podaj a: ");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 1 || a > 1000)
                Console.WriteLine("Błędny wybór 1-1000");
            Console.Write("Podaj b: ");
            while (!int.TryParse(Console.ReadLine(), out b) || b < 1 || b > 1000)
                Console.WriteLine("Błędny wybór 1-1000");
            Console.Write("Podaj c: ");
            while (!int.TryParse(Console.ReadLine(), out c) || c < 1 || c > 1000)
                Console.WriteLine("Błędny wybór 1-1000");
            
            if(a+b<c || a+c<b || c+b<a)
            {
                Console.WriteLine("Długości nie spełniają długości zbudowania trójkąta");
            }
            else
            {
                o = a + b + c;
                Console.WriteLine("Obwód trójkąta to " + o);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program liczy obwód trójkąta:\n");
            Program.licz();
        }
    }
}
