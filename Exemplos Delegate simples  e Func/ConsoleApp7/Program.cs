using System;

namespace ConsoleApp7
{
    class Program
    {
        delegate int Calculador(int a, int b);
        public static int Somar(int value1, int value2)
        {
            return value1 + value2;
        }
        public int Subtrair(int value1, int value2)
        {
            return value1 - value2;
        }
        public int Multiplicar(int value1, int value2)
        {
            return value1 * value2;
        }
        public int Dividir(int value1, int value2)
        {
            if (value2 <= 0)
            {
                return -1;
            }
            else return value1 / value2;
        }
        static void Main(string[] args)
        {
            int a = 0, b = 0, op=0;
            Calculador calc = null;
            Console.WriteLine("insira o primeiro valor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insira o segundo valor valor");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insira a operaçao");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op) 
            {
                case 1:
                    Calculador calcula = new Calculador (Somar);
                    Console.WriteLine("o resultado e: {0}", calcula(a,b));
                    break;
                case 2:
                   Calculador calcula = new Calculador (Somar);
                    Console.WriteLine("o resultado e: {0}", calcula(a,b));
                    break;
                case 3:
                    Func<int, int, int> del = Multiplicar;
                    Console.WriteLine("o resultado e: {0}", del(a, b));
                    break;

                default:
                    Func<int, int, int> del = Dividir;
                    Console.WriteLine("o resultado e: {0}", del(a, b));
                    break;
            }
        }
    }
}
