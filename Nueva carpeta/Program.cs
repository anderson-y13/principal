using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la Máquina Expendedora");

            Console.WriteLine("Seleccione una categoría:");

            Console.WriteLine("1. Snacks");

            Console.WriteLine("2. Bebidas");

            Console.WriteLine("3. Dulces");

            Console.Write("Opción: ");

            int opcionPrincipal = int.Parse(Console.ReadLine());

            double precio = 0.0;

            switch (opcionPrincipal)

            {
                case 1:

                    Console.WriteLine("Seleccione un snack:");

                    Console.WriteLine("1. Papas fritas ($3.00)");

                    Console.WriteLine("2. Galletas ($2.50)");

                    Console.Write("Opción: ");

                    int opcionSnack = int.Parse(Console.ReadLine());

                    if (opcionSnack == 1)

                        precio = 3.00;

                    else if (opcionSnack == 2)

                        precio = 2.50;

                    else

                        Console.WriteLine("Opción inválida en snacks");

                    break;

                case 2:

                    Console.WriteLine("Seleccione una bebida:");

                    Console.WriteLine("1. Agua ($1.50)");

                    Console.WriteLine("2. Refresco ($2.00)");

                    Console.Write("Opción: ");

                    int opcionBebida = int.Parse(Console.ReadLine());

                    if (opcionBebida == 1)

                        precio = 1.50;

                    else if (opcionBebida == 2)

                        precio = 2.00;

                    else

                        Console.WriteLine("Opción inválida en bebidas");

                    break;

                case 3:

                    Console.WriteLine("Seleccione un dulce:");

                    Console.WriteLine("1. Chocolates ($1.00)");

                    Console.WriteLine("2. Caramelos ($0.75)");

                    Console.Write("Opción: ");

                    int opcionDulce = int.Parse(Console.ReadLine());

                    if (opcionDulce == 1)

                        precio = 1.00;

                    else if (opcionDulce == 2)

                        precio = 0.75;

                    else

                        Console.WriteLine("Opción inválida en dulces");

                    break;

                default:

                    Console.WriteLine("Opción inválida en menú principal");

                    break;

            }

            if (precio > 0)

                Console.WriteLine("El precio de su producto es: $" + precio);

            Console.WriteLine("Gracias por su compra!");
        }
    }
}
