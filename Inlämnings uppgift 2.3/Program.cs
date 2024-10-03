using System;

namespace inlämnings_._uppgift_._2_._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur dagar ska du använda bilen?");
            int dagar= int.Parse(Console.ReadLine());
            int Dag1 = 300;
            int Övrigadagar = 500;
            Console.WriteLine("Hur många kilometer ska du köra bilen?");
            int kilometer= int.Parse(Console.ReadLine());
            int sum= Dag1 + dagar*Övrigadagar + kilometer;
            Console.WriteLine(sum);





        }
    }
}