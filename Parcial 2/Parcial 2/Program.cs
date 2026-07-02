using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0,b=0,c=4321;
            Console.WriteLine("ejercicio 1");
            Console.WriteLine("Ingrese un numero entero posistivo");
            a=int.Parse(Console.ReadLine());
            if (a>0){
                for (int i = 0; i <= a; i+=2)
                {
                    Console.WriteLine(b+"+"+i+"="+(b+i));
                    b = b + i;
                }
                Console.WriteLine("la suma es de todos los numeros pares es "+b);b = 0;
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("ejercicio 2");
            int m=0, n=0;
            int[] d = {12,45,7,89,23,56,4,31};
            for (int i = 0; i < 8; i++)
            {
                if (m > d[i])
                {
                    m = d[i];
                }
                if (n > d[i]) 
                {
                    n = d[i];
                }
            }
            Console.WriteLine("El mayor es " + m);
            Console.WriteLine("El menor es " + n);
            Console.WriteLine("no se como usar los vectores :b");
            Console.WriteLine("ejercicio 3");

            do
            {
                Console.WriteLine("Ingrese su pin de 4 digitos");
                a = int.Parse(Console.ReadLine());
                if (a==c)
                {
                    Console.WriteLine("Acceso concedido.Bienvenido a su banca virtual");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                }
                b ++;
                Console.WriteLine("Usted tiene "+(3-b)+" intentos");
                if (b==3)
                {
                    Console.WriteLine("Tarjeta bloqueada, Comuniquese con su banco");
                    break;
                }
            }
            while (true);
            Console.WriteLine("Comodin");
            Console.WriteLine();
        }
    }
}
