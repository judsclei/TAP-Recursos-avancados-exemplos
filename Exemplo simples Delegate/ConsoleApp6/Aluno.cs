using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Aluno
    {
        private string name;
        private int number;
        private string date;
        public Aluno(string name, int number, string date )
        {
            this.name = name;
            this.number = number;
            this.date = date;
        }
        public void ShowStudentName()
        {
            Console.WriteLine( "The Student name is: " +this.name);
        }
        public void ShowStudentNumber()
        {
            Console.WriteLine( "The Student number is: " +this.number);
        }
        public void ShowStudentDateBirth() 
        {
            Console.WriteLine("The Student date of birth is: " + this.date);
        }
    }
}
