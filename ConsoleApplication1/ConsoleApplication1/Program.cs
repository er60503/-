using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bloods = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };

            int countA = 0;

            int countB = 0;

            int countAB = 0;

            int countO = 0;

            for (int i = 0; i < bloods.Length; i++) 
            {
                if (bloods[i] == "A") 
                {
                    countA++;
                }

                if (bloods[i] == "B")
                {
                    countB++;
                }

                if (bloods[i] == "AB")
                {
                    countAB++;
                }

                if (bloods[i] == "O")
                {
                    countO++;
                }
            }
            Console.WriteLine("A血型有:" + countA);

            Console.WriteLine("B血型有:" + countB);

            Console.WriteLine("AB血型有:" + countAB);

            Console.WriteLine("O血型有:" + countO);

            Console.ReadKey(); 
        }
    }
}
