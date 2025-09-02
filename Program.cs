using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, nota3;
            double Peso1, Peso2, Peso3;
            double Notaponderada1, Notaponderada2, Notaponderada3, PromedioFinal;

            Console.WriteLine("Ingresar nota 1: ");
            nota1 = double.Parse (Console.ReadLine());
            Console.WriteLine("Ingresar peso de la nota 1: ");
            Peso1= double.Parse (Console.ReadLine());   

            Console.WriteLine("Ingresar nota 2: ");
            nota2 = double.Parse (Console.ReadLine());
            Console.WriteLine("Ingresar peso de la nota 2: ");
            Peso2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Ingresar nota 3: ");
            nota3 = double.Parse (Console.ReadLine());
            Console.WriteLine("Ingresar peso de la nota 3: ");
            Peso3 = double.Parse(Console.ReadLine());

            //Desarrollo

            Notaponderada1 = nota1 * (Peso1 / 100);
            Notaponderada2 = nota2 * (Peso2 / 100);
            Notaponderada3 = nota3 * (Peso3 / 100);

            PromedioFinal = Notaponderada1 + Notaponderada2 + Notaponderada3;

            Console.WriteLine("el promedio final del estudiante es: "+ PromedioFinal);


        }
    }
}
