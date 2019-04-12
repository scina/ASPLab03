using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLab03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            

            //Task 1 - Towar
            Towar towar = new Towar("Mikasa MCV200", 199.99, 2, "Piłka do siatkówki");
            System.Console.Write(towar);
            System.Console.WriteLine();

            towar.Brutto = 250;            
            System.Console.Write(towar);
            System.Console.WriteLine();

            Console.ReadKey();

            //Task 2 - Swap
            Task2 task2 = new Task2();
            int a = 5;
            int b = 10;
            
            System.Console.Write("before swap: " + a + " | " + b);
            System.Console.WriteLine();
            task2.Swap(ref a, ref b);
            System.Console.Write("after swap: " + a + " | " + b);
            System.Console.WriteLine();

            Console.ReadKey();

            //Task 2 - Average
            System.Console.Write("Average: " + task2.Average(1, 3, 5, 7, 9, 11));
            System.Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
