using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();
            int op;

            carros.Add(new Carro("ABC1234", "Uno", "Preto", "1999"));
            carros.Add(new Carro("NAD7768", "Elan", "Cinza", "1995"));
            carros.Add(new Carro("LVG2275", "155 Super", "Prata", "1995"));
            carros.Add(new Carro("JBQ1850", "325i", "Bege", "2009"));
            carros.Add(new Carro("DGY6518", "Gol Quadrado", "Azul", "1985"));
            carros.Add(new Carro("ITU5732", "Picanto", "Rosa", "2007"));
            carros.Add(new Carro("DIH5516", "Idea", "Branco", "2011"));
            carros.Add(new Carro("KCW8101", "Hilux", "Prata", "1992"));
            carros.Add(new Carro("MRO5711", "C4 Competition ", "Cinza", "2014"));
            carros.Add(new Carro("MZG1979", "306 Si", "Cinza", "1997"));
            carros.Add(new Carro("JMB9682", "Civic Sedan", "Vermelho", "2001"));
            carros.Add(new Carro("GHS1146", "Vectra", "Vermelho", "2007"));
            carros.Add(new Carro("AOU4620", "Ranger XLT 2.5", "Prata", "2013"));
            carros.Add(new Carro("MNY8199", "Toro Opening Edition", "Branco", "2017"));
            carros.Add(new Carro("KAF5345", "Dakota Sport ", "Branco", "2001"));
            carros.Add(new Carro("NCH3505", "Tiggo 2.0", "Amarelo", "2013"));
            carros.Add(new Carro("NEX7674", "Gol 1.6 Mi", "Dourado", "2013"));
            carros.Add(new Carro("JSX2373", "Buggy Vip 1.8 8V", "Prata", "2006"));
            carros.Add(new Carro("NEZ9598", "J3 S 1.5 JET Flex", "Branco", "2013"));
            carros.Add(new Carro("GTA5231", "Uno", "Branco", "2010"));
            carros.Add(new Carro("DTS5231", "Palio", "Preto", "2012"));
            carros.Add(new Carro("QWE6511", "Gol Quadrado", "Preto", "1989"));

            Console.WriteLine("Questao 2");
            Console.WriteLine("Insira a operaçao a ser realizada \n1- Exibe todas as informações da lista de carros");
            Console.WriteLine("2- Exibe a quantidade de carros de um determinado modelo informado pelo usuário");
            Console.WriteLine("3- Exibe todas as informações dos carros que terminam a placa com o número 1 e possuem a cor preto.");
            Console.WriteLine("4- Exibe a quantidade de cada modelo, ordenando por modelo");
            Console.WriteLine("5- Exibe todas as informações dos carros que são do modelo que mais aparece na lista de carros");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    var query = from c in carros                        
                                select c;
                    foreach (var c in query) 
                    {
                        Console.WriteLine(c.Modelo + " - " + c.Placa +" - " + c.Cor+ " - "+c.Ano);
                    }
                    break;
                case 2:
                    Console.WriteLine("Insira a modelo do carro");
                    string modelo = Console.ReadLine();
                    query = from c in carros
                            where c.Modelo.StartsWith(modelo)
                            select c;
                    int nCarros = query.Count();
                    Console.WriteLine("O numero de carros é: " + nCarros);
                    break;
                case 3:
                    query = from c in carros
                            where c.Placa.EndsWith("1")&& c.Cor.StartsWith("Preto")
                            select c;
                    foreach (var c in query)
                    {
                        Console.WriteLine(c.Modelo + " - " + c.Placa + " - " + c.Cor + " - " + c.Ano);
                    }
                    break;
                case 4:

                    var query4 = from c in carros group c by new { c.Modelo } into CarrosAgrupados
                            select new
                            {
                                CarrosAgrupados.Key.Modelo,             
                                Qtd = CarrosAgrupados.Count()
                            };

                    var ordena = query4.OrderBy(c => c.Modelo);
                    foreach (var c in ordena)
                    {
                        Console.WriteLine(c.Modelo + " - " + c.Qtd);
                    }
                    break;
                case 5:
                  var query1 = from c in carros
                            group c by new { c.Modelo } into CarrosA
                            select new
                            {
                                CarrosA.Key.Modelo,
                                Qtd = CarrosA.Count()
                            };
                    var queryQtd = query1.Max(c => c.Qtd);
                    foreach (Carro car in carros) 
                    {
                        foreach (var carro in query1) 
                        {
                            if (carro.Qtd == queryQtd && car.Modelo == carro.Modelo) 
                            {
                                Console.WriteLine(car.Modelo + " - " + car.Placa + " - " + car.Cor + " - " + car.Ano);
                            }
                            
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Opçao invalida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
