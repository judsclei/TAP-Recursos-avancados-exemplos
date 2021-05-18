using System;

namespace ConsoleApp9
{
    class Program
    {
        static Action NumerosP() 
        {
            int n = 1;

            Action primo = () => 
            {
                if (n <= 3) { Console.WriteLine(n); n++; }

                else if (n % 2 == 0 || n % 3 == 0 || n % 7 == 0 )
                {
                    n++;
                }
                else
                {
                    Console.WriteLine(n);
                    n++;
                }

            };

            return primo;
        }
        static void Main(string[] args)
        {
            Action sequenciaPrimo = NumerosP();
            int i=0;
            while (i < 10) 
            {
                sequenciaPrimo();
                i++;
            }
            Console.ReadKey();
        }
    }
}
