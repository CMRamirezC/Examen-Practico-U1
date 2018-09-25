﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Archivos_ED
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v = true;
            string opcion;
            int Opcion, Tamaño, lastindex, firstindex;
            do
            {
                try
                {
                    Console.Title = " Examen practico Unidad 1 Estructura de Datos ";
                    Console.Write(" Elige el ejercicio que deseas revisar (1-8): ");
                    Opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (Opcion)
                    {
                        case 1:
                            Console.WriteLine("\" 1.- Un algoritmo cuya salida sea el valor menor y mayor en la sucesion S1,...,Sn.\"");
                            Console.Write("\n Introduce de que tamaño es la sucesion: ");
                            Tamaño = int.Parse(Console.ReadLine());
                            int[] ArraySucesion1 = new int[Tamaño];
                            for (int i = 0; i < ArraySucesion1.Length; i++)
                            {
                                Console.Write(" Valor de la posicion {0} de la sucesion: ", i + 1);
                                ArraySucesion1[i] = int.Parse(Console.ReadLine());
                            }
                            Array.Sort(ArraySucesion1);
                            Console.WriteLine(" El valor menor de la sucesion es {0} y el valor mayor es {1}. ", ArraySucesion1[0], ArraySucesion1[ArraySucesion1.Length - 1]);
                            break;
                        case 2:
                            Console.WriteLine("\" 2.- Un algoritmo que invierta la sucesion s1,...,sn. \"");
                            Console.Write("\n Introduce de que tamaño es la sucesion: ");
                            Tamaño = int.Parse(Console.ReadLine());
                            string[] ArraySucesion2 = new string[Tamaño];
                            for (int i = 0; i < ArraySucesion2.Length; i++)
                            {
                                Console.Write(" Elemento o cadena de la posicion {0} de la sucesion: ", i + 1);
                                ArraySucesion2[i] = Console.ReadLine();
                            }
                            Console.WriteLine("\n Sucesion introducida: ");
                            foreach (string n in ArraySucesion2)
                            {
                                Console.Write(" " + n);
                            }
                            Array.Reverse(ArraySucesion2);
                            Console.WriteLine("\n Sucesion invertida: ");
                            foreach (string n in ArraySucesion2)
                            {
                                Console.Write(" " + n);
                            }
                            break;
                        case 3:
                            Console.WriteLine("\" 3.- Un algoritmo que regrese el indice de la ultima ocurrencia del elemento mas grande en la sucesion S1,...,Sn. \"");
                            Console.Write("\n Introduce de que tamaño es la sucesion: ");
                            Tamaño = int.Parse(Console.ReadLine());
                            float[] ArraySucesion3 = new float[Tamaño];
                            for (int i = 0; i < ArraySucesion3.Length; i++)
                            {
                                Console.Write(" Valor de la posicion {0} de la sucesion: ", i + 1);
                                ArraySucesion3[i] = float.Parse(Console.ReadLine());
                            }
                            lastindex = Array.FindLastIndex(ArraySucesion3, item => item == ArraySucesion3.Max());
                            Console.WriteLine(" El indice de la ultima ocurrencia del elemento mas grande es: {0}", lastindex + 1);
                            break;
                        case 4:
                            Console.WriteLine("\" 4.- Un algoritmo que encuentre el elemento menor entre a, b y c. \"");
                            Console.Write(" Introduce el valor para a: ");
                            decimal a = decimal.Parse(Console.ReadLine());
                            Console.Write(" Introduce el valor para b: ");
                            decimal b = decimal.Parse(Console.ReadLine());
                            Console.Write(" Introduce el valor para c: ");
                            decimal c = decimal.Parse(Console.ReadLine());
                            decimal menor = a;
                            if (b < menor)
                            {
                                menor = b;
                            }
                            if (c < menor)
                            {
                                menor = c;
                            }
                            Console.WriteLine(" El numero menor es: {0}", menor);
                            break;
                        case 5:
                            Console.WriteLine("\" 5.- Un algoritmo que regrese el indice de la primera ocurrencia del elemento mas grande en la sucesion S1,...,Sn. \"");
                            Console.Write("\n Introduce de que tamaño es la sucesion: ");
                            Tamaño = int.Parse(Console.ReadLine());
                            float[] ArraySucesion5 = new float[Tamaño];
                            for (int i = 0; i < ArraySucesion5.Length; i++)
                            {
                                Console.Write(" Valor de la posicion {0} de la sucesion: ", i + 1);
                                ArraySucesion5[i] = float.Parse(Console.ReadLine());
                            }
                            firstindex = Array.FindIndex(ArraySucesion5, item => item == ArraySucesion5.Max());
                            Console.WriteLine(" El indice de la ultima ocurrencia del elemento mas grande es: {0}", firstindex + 1);
                            break;
                        case 6:
                            Console.WriteLine("\" 6.- Un algoritmo que regrese el indice del primer elemento que es mayor que su predecesor en la sucesion S1,...,Sn. Si 'S' esta en orden no decreciente, el algoritmo regresa el valor 0. \"");
                            Console.Write("\n Introduce de que tamaño es la sucesion: ");
                            Tamaño = int.Parse(Console.ReadLine());
                            string[] ArraySucesion6 = new string[Tamaño];
                            for (int i = 0; i < ArraySucesion6.Length; i++)
                            {
                                Console.Write(" Elemento o cadena de la posicion {0} de la sucesion: ", i + 1);
                                ArraySucesion6[i] = Console.ReadLine();
                            }
                            for (int i = 0; i < ArraySucesion6.Length; i++)
                            {
                                if (i >= 1)
                                {
                                    if (ArraySucesion6[i].Length > ArraySucesion6[i - 1].Length)
                                    {
                                        Console.WriteLine(" El indice del primer elemento mayor a su predecesor es: {0} ", i + 1);
                                        i = ArraySucesion6.Length;
                                    }
                                    else
                                    {
                                        Console.WriteLine(" Valor 0 ");
                                        i = ArraySucesion6.Length;
                                    }
                                }
                            }
                            break;
                        case 7:
                            Console.WriteLine("\" 7.- De una lista de numeros random del 1 al 100 se ordenen en orden no decreciente. Mostrando los numeros random y los numeros ya ordenados. \"");
                            Random numerorandom = new Random();
                            List<int> NumerosRandom = new List<int>();
                            for (int i = 1; i <= 10; i++)
                            {
                                NumerosRandom.Add(numerorandom.Next(1, 100));
                            }
                            Console.WriteLine(" Lista de numero random no ordenados: ");
                            foreach (int n in NumerosRandom)
                            {
                                Console.WriteLine(" " + n);
                            }
                            Console.WriteLine(" Lista de numero random ordenados: ");
                            NumerosRandom.Sort();
                            foreach (int numeros in NumerosRandom)
                            {
                                Console.WriteLine(" " + numeros);
                            }
                            break;
                        case 8:
                            bool condicionE8 = true;
                            do
                            {
                                Console.Clear();
                                try
                                {
                                    Console.WriteLine("\" 8.- Una aplicacion que lea un entero de 5 digitos y determine si es palindromo. \"\n Nota: Un palindromo es una secuencia de caracteres que se lee igual de derecho y al reves.");
                                    Console.Write(" Introduce un numero entero de 5 digitos: ");
                                    int numero = int.Parse(Console.ReadLine());
                                    if (numero.ToString().Length == 5)
                                    {
                                        if (numero.ToString()[0] == numero.ToString()[4] && numero.ToString()[1] == numero.ToString()[3])
                                        {
                                            Console.WriteLine(" El numero entero es palindromo! ");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" El numero entero no es palindromo! ");
                                        }
                                        condicionE8 = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine(" Introduciste mas o menos de 5 digitos! Presiona cualquier tecla para continuar... ");
                                        Console.ReadKey();
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            } while (condicionE8 == true);
                            break;
                    }
                    Console.Write(" Desea volver a revisar otro ejercicio? (Si o No) ");
                    opcion = Console.ReadLine();
                    if (opcion.ToUpper() == "SI")
                    {
                        v = true;
                    }
                    if (opcion.ToUpper() == "NO")
                    {
                        Console.WriteLine(" Presione cualquier tecla para continuar... ");
                        v = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (v == true);
        }
    }
}
