using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array capacity:");

            TableClass array = new TableClass();
            array.setTabCapacity(askX(), askY());

            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Choose:");
                Console.WriteLine("1.Read");
                Console.WriteLine("2.Write");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1 | choice == 2)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Choose 1 or 2");
                    continue;
                }

                
            }



        }

        private static int askX()
        {
            Console.Write("X:");
            return Int32.Parse(Console.ReadLine());
        }

        private static int askY()
        {
            Console.Write("Y:");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
