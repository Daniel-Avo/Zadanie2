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

            while (true)
            {
                int choice = askChoice();

                if (choice == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Insert table place you want to read:");
                    Console.WriteLine(array[askX(), askY()]);
                    
                }
                else if(choice == 2)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Choose 1 or 2");
                    continue;
                }

                
            }



        }

        private static int askX()
        {
            while (true)
            {
                try
                {
                    Console.Write("X:");
                    return Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Choose integer");
                    continue;
                }
            }
        }

        private static int askY()
        {
            while (true)
            {
                try
                {
                    Console.Write("Y:");
                    return Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Choose integer");
                    continue;
                }
            }
        }

        private static int askChoice()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Choose:");
                    Console.WriteLine("1.Read");
                    Console.WriteLine("2.Write");
                    return Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Choose integer");
                    continue;
                }
            }
        }
    }
}
