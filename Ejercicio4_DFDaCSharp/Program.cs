using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Ejercicio4_DFDaCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title="CALCULADORA DE CONVERSIONES"; //lo que aparecerá en la barra superior de la ventana
            Console.SetWindowSize(75, 18); //establece columnas y filas

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Menu();
        }

        public static int Menu()
        {
            int opcion = 0;
            string n;
            bool esNumero = false;
            try
            {

                while (opcion < 1 | opcion > 3)
                {
                    //Console.WriteLine("                                                                           ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" _________________________________________________________________________ ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|--------------------SELECCIONE UNA DE LAS OPCIONES-----------------------|");
                    Console.WriteLine("|_________________________________________________________________________|");
                    Console.WriteLine("|_________________________________________________________________________|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|-------------------PRESIONE 1 PARA: DECIMAL a BINARIO--------------------|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|-------------------PRESIONE 2 PARA: DECIMAL a OCTAL----------------------|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|-------------------PRESIONE 3 PARA: DECIMAL a HEXADECIMAL----------------|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|_________________________________________________________________________|");
                    Console.WriteLine("                                                                           ");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out opcion);

                    if (opcion < 1 | opcion > 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" _________________________________________________________________________ ");
                        Console.WriteLine("|                                                                         |");
                        Console.WriteLine("|---------DATO INVÁLIDO. PRESIONE CUALQUIER TECLA PARA CONTINUAR----------|");
                        Console.WriteLine("|_________________________________________________________________________|");
                        Console.WriteLine("                                                                           ");
                        
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("                                                                           ");
                        Console.ReadKey();
                    }
                    else
                    {
                        CapturaDatos(opcion);
                    }

                }
                return opcion;
            }
            catch (Exception error)
            {
                Console.WriteLine("ALGO FALLÓ.", error);
                return opcion;
            }

        }

        public static void CapturaDatos(int tipoConversion)
        {
            string n = "";
            bool esNumero = false;
            int numero = 0;
            while (esNumero == false)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|---------------Introduzca el número que desea convertir:                 |");
                n = Console.ReadLine();
                esNumero = int.TryParse(n, out numero);
            }
            Console.WriteLine(numero.ToString());
           
            Conversiones(numero, tipoConversion);
            Console.ReadKey();
        }

        public static void Conversiones(int num, int tipoC)
        {
            if (tipoC == 1)
            {

            }
            else if (tipoC == 2)
            {

            }
            else if (tipoC == 3)
            {

            }
        }

        public static void MostrarResultado()
        {

        }

       
    }
}
