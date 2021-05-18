using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Calculo
    {
        public void CalcImc() 
        {
            string nome;
            int peso;
            double altura;
            Console.WriteLine("Insira o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o seu peso");
            peso = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira a sua altura");
            altura = Double.Parse(Console.ReadLine());
            Func<int, double, double> IMC = (p, a) => p / (a * a);
            Console.WriteLine("Ola "+ nome +" Seu IMC é: " + IMC(peso, altura));
        }
        public void Media_DP() 
        {
            double a, b, c, m;
            Console.WriteLine("Insira do primeiro valor");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira do segundo valor");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira do terceiro valor");
            c = Double.Parse(Console.ReadLine());
            Func<double, double, double, double> Media = (v1, v2, v3) => (v1 + v2 + v3) / 3;
            Func<double, double, double, double, double> DP = (v1, v2, v3, media) => {

               return Math.Sqrt((Math.Pow((v1 - media), 2) + Math.Pow((v2 - media), 2) + Math.Pow((v3 - media), 2) / 2));
            };
            Console.WriteLine("A media é: " + Media(a, b, c) + " e o Desvio padrao é: " + DP(a,b,c, Media(a, b, c)));
        }
        public void AreaTrap ()
        {
            double bme, bma, a;
            Console.WriteLine("Insira o valor da base menor");
            bme = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da base maior");
            bma = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura");
            a = Double.Parse(Console.ReadLine());
            Func<double, double, double, double> AreaT = (baseMenor, baseMaior, altura) => ((baseMenor + baseMaior) * altura) / 2;
            Console.WriteLine("A area do trapezio é´: " + AreaT(bme, bma, a));
        }
        public void Conversor(int op) 
        {
            double tempc, tempf;
            
            if (op == 4)
            {
                Console.WriteLine("Insira a temperatura em graus Centígrados");
                tempc = Double.Parse(Console.ReadLine());
                Func<double, double> CemF = (c) => (9 * c + 160) / 5;
                Console.WriteLine("A temperatura em Fahrenheit é: " + CemF(tempc));
            }
            else 
            {
                Console.WriteLine("Insira a graus Fahrenheit");
                tempf = Double.Parse(Console.ReadLine());
                Func<double, double> FemC = (f) => (f - 32) * 5 / 9 ;
                Console.WriteLine("A temperatura em graus Centigrados é: " + FemC(tempf));
            }

        }
        public void CalcPrestacao() 
        {
            int temp;
            double tax, val;
            Console.WriteLine("Insira o valor");
            val = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da taxa em %");
            tax = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tempo ");
            temp = Int32.Parse(Console.ReadLine());
            Func<double, double, int, double> Prestacao = (valor, taxa, tempo) => valor + (valor * (taxa / 100) * tempo);
            Console.WriteLine("O valor da prestaçao é: " + Prestacao(val,tax,temp));
        }
        public void ExibeMensagem() 
        {
            DateTime data = DateTime.Now;
            string format = "HH", date;
            date = data.ToString(format);
            int horaint = Convert.ToInt32(date);
            Action<int> mensagem = (hora) => 
            {
                if (hora >= 6 && hora <12)
                { Console.WriteLine("Bom dia"); }
                else if (hora >= 12 && hora < 18)
                { Console.WriteLine("Boa tarde"); }
                else { Console.WriteLine("Boa noite"); }
            };
            mensagem(horaint);
        }
    }
}
