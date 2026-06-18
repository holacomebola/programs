using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N_1_ejercicios_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a,b,c=0,d;
            Console.WriteLine("---Menu---");
            Console.WriteLine("1.- Suma de dos numeros");
            Console.WriteLine("2.- Area de un triangulo");
            Console.WriteLine("3.- Conversor d moneda");
            Console.WriteLine("4.- Calculo IVA");
            Console.WriteLine("5.- Promedio simple");
            a=int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Ingrese un entero");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro");
                c = float.Parse(Console.ReadLine());
                Console.WriteLine("La suma es  " + (b + c));
            }
            else if (a == 2) 
            {
                Console.WriteLine("Ingrese la base");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura");
                c = float.Parse(Console.ReadLine());
                Console.WriteLine("El area es "+(b+c)/2);
            }
            else if (a == 3) 
            {
                Console.WriteLine("Ingrese el monto a cambiar");
                b = float.Parse(Console.ReadLine());
                d = (float)(b / 6.96);
                Console.WriteLine("El cambio es "+d);
            }
            else if (a == 4)
            {
                Console.WriteLine("Ingrese el precio del producto");
                b = float.Parse(Console.ReadLine());
                d = (float)(b*0.13);
                Console.WriteLine("El iba es "+d+" y el precio total es "+(b+d));
            }
            else if (a == 5)
            {
                for (int i=0; i < 3; i++)
                {
                Console.WriteLine("Ingrese una nota");
                b = float.Parse(Console.ReadLine());
                c = c + b;
                }
                Console.WriteLine("El promedio es "+(float)(c/3));
            }
            else
            {
               Console.WriteLine("Elija bien webon :)");
            }
        }
    }
}
