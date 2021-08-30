using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombres = new string[8];
            PopulateArray(nombres);
            PrintArray(nombres);
            ShowNamesStartsWith(nombres);
            Console.ReadLine();
        }

        private static void ShowNamesStartsWith(string[] nombres)
        {
            string letra;
            do
            {
                Console.Write("Ingrese una letra:");
                letra = Console.ReadLine();
                if (letra.Length>1 || !char.IsLetter(letra[0]))
                {
                    Console.WriteLine("Letra mal ingresada");
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"Nombres que comienzan con {letra}");
            foreach (var nombre in nombres)
            {
                if (nombre.StartsWith(letra))
                {
                    Console.WriteLine(nombre);
                }
            }
        }

        private static void PrintArray(string[] nombres)
        {
            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }

        private static void PopulateArray(string[] nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                do
                {
                    Console.Write("Ingrese un nombre:");
                    var nombreIngresado = Console.ReadLine();
                    if (ValidarNombre(nombreIngresado))
                    {
                        //Ver si el nombre esta repetido
                        if (Array.IndexOf(nombres,nombreIngresado)==-1)
                        {
                            nombres[i] = nombreIngresado;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nombre repetido!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nombre mal ingresado o no válido");
                    }
                } while (true);
            }
        }

        private static bool ValidarNombre(string nombreIngresado)
        {
            //veo si es nulo o mayor a 12 caracteres
            if (nombreIngresado.Length==0 || nombreIngresado.Length>12)
            {
                return false;
            }
            //Veo si hay algun caracter que no sea letra
            if (!nombreIngresado.All(char.IsLetter))
            {
                return false;
            }

            return true;
        }
    }
}
