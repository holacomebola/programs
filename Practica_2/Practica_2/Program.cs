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
            float a, b, c = 0, d;
            Console.WriteLine("---Menu---");
            Console.WriteLine("1.- Determinacion de paridad");
            Console.WriteLine("2.- El mayor de tres");
            Console.WriteLine("3.- Sistema de clasificacion americana");
            Console.WriteLine("4.- Calculadora de operaciones");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Ingrese un numero");
                b = float.Parse(Console.ReadLine());
                if (b%2 == 1)
                {
                    Console.WriteLine("El numero es impar");
                }
                else
                {
                    Console.WriteLine("El numero es par");
                }
            }
            else if (a == 2)
            {
                Console.WriteLine("Ingrese el primer numero");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                c = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                d = float.Parse(Console.ReadLine());
                if ((b > c) && (b > d))
                {
                    Console.WriteLine("El mayor es "+b);
                }
                else if ((c > d) && (c > b)) 
                {
                    Console.WriteLine("El mayor es "+c);
                }
                else
                {
                    Console.WriteLine("El mayor es "+d);
                }
            }
            else if (a == 3)
            {
                Console.WriteLine("Ingrese el monto a cambiar");
                b = float.Parse(Console.ReadLine());
                if ((b >= 90) && (b <= 100))
                {
                    Console.WriteLine("Usted tiene una A");
                }
                else if ((b >= 80) && (b <= 89))
                {
                    Console.WriteLine("Usted tiene una B");
                }
                else if ((b >=70)&&(b <= 79))
                {
                    Console.WriteLine("Usted tiene una C");
                }
                else if ((b >=60)&&(b <=69))
                {
                    Console.WriteLine("Usted tiene una D");
                }
                else if (b <=60)
                {
                    Console.WriteLine("Usted tiene una F");
                }
                else
                {
                    Console.WriteLine("Usted no tiene nota");
                }
            }
            else if (a == 4)
            {
                Console.WriteLine("Ingrese un numero");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                c = float.Parse(Console.ReadLine());
                Console.WriteLine("La operacion que quiera usar");
                Console.WriteLine("1.- Suma");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplicion");
                Console.WriteLine("4.- Division");
                a = float.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("El resutado es"+(b+c));
                        break;
                    case 2:
                        Console.WriteLine("El resultado es "+(b-c));
                        break;
                    case 3:
                        Console.WriteLine("El resultado es " + (b - c));
                        break;
                    case 4:
                        if (c == 0)
                        {
                            Console.WriteLine("No se puede dividir entre cero");
                        }
                        else
                        {
                            Console.WriteLine("El resultado es " + (b / c));
                        }
                        break;
                    default:
                        Console.WriteLine("El resultado es " + (b / c));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Elija bien webon :)");
            }
        }
    }
}
