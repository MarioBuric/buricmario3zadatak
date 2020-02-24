using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricmarioProvjeraZnanjaZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi rijec: ");
            string text = Console.ReadLine();

            for (int n = 1; n <= text.Length; n++)
            {
                for (int j = text.Length - n; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(text.Substring(text.Length - n));
                Console.WriteLine();
            }
            Console.ReadKey();


        
        }
    }
}