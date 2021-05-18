using System;

namespace ConsoleApp6
{
    class Program
    {
        delegate void DemoOp(); // declare delegate type
        static void Main(string[] args)
        {
            // cria algumas instâncias de MyClass
            Aluno aluno1 = new Aluno("Joao", 123456, "15/02/2009");
            Aluno aluno2 = new Aluno("Maria", 456789, "25/06/2008");
            DemoOp demo = null; // declara um delegate vazio
                                // adiciona métodos ao delegate
            demo += new DemoOp(aluno1.ShowStudentName);
            demo += new DemoOp(aluno1.ShowStudentNumber);
            demo += new DemoOp(aluno1.ShowStudentDateBirth);
            demo += new DemoOp(aluno2.ShowStudentName);
            demo += new DemoOp(aluno2.ShowStudentNumber);
            demo += new DemoOp(aluno2.ShowStudentDateBirth);
            demo(); // invoca o delegate
            Console.ReadKey();
        }
    }
}

