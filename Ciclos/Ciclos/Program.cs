using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d=0;
            Console.WriteLine("---Menu---");
            Console.WriteLine("1.- Generador de tablas");
            Console.WriteLine("2.- Acumulador de ventas");
            Console.WriteLine("3.- Validacion de PIN");
            Console.WriteLine("4.- Contador de pares e impares");
            Console.WriteLine("5.- Calculo factorial");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Ingrese un numero");
                    b= int.Parse(Console.ReadLine());
                    for (int i = 1; i <= 12; i++)
                        Console.WriteLine("La multiplicacion entre "+b+ "x"+i+"="+b*i);
                    break;
                case 2:
                    Console.WriteLine("Ingrese las ventas si quiere terminar solo ingrese 0");
                    b = int.Parse(Console.ReadLine());
                    while (b!=0)
                    {
                        Console.WriteLine("Ingrese la venta");
                        b = int.Parse(Console.ReadLine());
                        if (b < 0)
                        {
                            Console.WriteLine("El monto no puede ser negativo");
                        }
                        else
                        {
                            d = d + b;
                        }

                    }
                    Console.WriteLine("El total de la venta es "+d);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el PIN");
                    b = int.Parse(Console.ReadLine());
                    while (b!=4560)
                    {
                        Console.WriteLine("Error. Intente de numero");
                        b = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Bienvenido");
                    break;
                case 4:
                    c = 0;
                    Console.WriteLine("Ingresara 10 numeros  ");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("Ingrese el numero ");
                        b = int.Parse(Console.ReadLine());
                        if (b % 2 == 0)
                        {
                            c = c+1;
                        }

                        else
                        {
                            d = d+1;
                        }
                    }
                    Console.WriteLine("Los numero pares son " + c);
                    Console.WriteLine("Los numero pares son " + d);
                    break;
                case 5:
                    c = 1;
                    Console.WriteLine("Ingrese un numero");
                    b = int.Parse(Console.ReadLine());
                    for (int i = 1; i < b; i++)
                    {
                        c = c * i;
                    }
                    Console.WriteLine("el factorial del numero es "+c*b);
                    break;
                default:
                    Console.WriteLine("Error intente de nuevo");
                    break;
            }
        }
    }
}
