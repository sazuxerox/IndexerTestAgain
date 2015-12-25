using System;

namespace IndexerTest2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var names = new IndexedNames();

            
            for (int i = 0; i < 10; i++)
            {
                names[i] = Console.ReadLine();
            }


            Console.WriteLine("Printing the names");

            //using the first indexer with the integer parameter

            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            //using the second indexer with the string parameter
            Console.WriteLine(names["Ahad"]);
            Console.ReadKey();
        }
    }
}
