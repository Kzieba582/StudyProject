using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj\n\n 1. Zgadnij liczbe \n 2. Wyjdz\n");
        Wybor:
            int opcja = Convert.ToInt16(Console.ReadLine());

            switch (opcja)
            {
                case 1:
                    Console.WriteLine("Zgadnij liczbe!\n");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Do zobaczenia.\n");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Brak opcji.\n");
                    goto Wybor;
            }
        }
    }
}
