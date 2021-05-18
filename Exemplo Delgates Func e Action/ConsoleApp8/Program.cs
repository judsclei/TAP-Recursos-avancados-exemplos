using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Calculo c = new Calculo();
            Console.WriteLine("Questao 4");
            Console.WriteLine("Insira a operaçao a ser realizada \n1- Calcular o índice de massa corporal de uma pessoa");
            Console.WriteLine("2- Calcular a média e o desvio padrão de três números");
            Console.WriteLine("3- Calcular e mostrar a área de um trapézio");
            Console.WriteLine("4- Calcular a conversão de uma temperatura em graus Centígrados convertida em graus Fahrenheit.");
            Console.WriteLine("5- Calcular a conversão de uma temperatura em graus Fahrenheit convertida em graus Centígrados ");
            Console.WriteLine("6- Calcular o valor de uma prestação em atraso");
            Console.WriteLine("7- Exibir uma mensagem de Bom dia, Boa Tarde ou Boa Noite dependendo do horário do dia");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    c.CalcImc();
                    break;
                case 2:
                    c.Media_DP();
                    break;
                case 3:
                    c.AreaTrap();
                    break;
                case 4:
                    c.Conversor(op);
                    break;
                case 5:
                    c.Conversor(op);
                    break;
                case 6:
                    c.CalcPrestacao();
                    break;
                case 7:
                    c.ExibeMensagem();
                    break;
                default:
                    Console.WriteLine("Opçao invalida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
