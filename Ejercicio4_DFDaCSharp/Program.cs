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
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            
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
                        Console.Clear();
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
                Console.Clear();
                Console.WriteLine(" _________________________________________________________________________ ");
                Console.WriteLine("|---------------Introduzca el número que desea convertir:                 |");
                Console.Write(" ---------------Número: ");
                n = Console.ReadLine();
               
                Console.WriteLine("                                                                           ");
                esNumero = int.TryParse(n, out numero);
            }
            if (numero > 0)
            {
                Conversiones(numero, tipoConversion);
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" _________________________________________________________________________ ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|----NO PUEDE INGRESAR VALORES MENORES A CERO. PRESIONE PARA CONTINUAR----|");
                    Console.WriteLine("|_________________________________________________________________________|");
                    Console.WriteLine("                                                                           ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadKey();
                    Menu();
                }
            }
            //Console.WriteLine(numero.ToString()); //de prueba          
           
           
        }

        public static void Conversiones(int num, int tipoC)
        {
            String resultado = String.Empty;
            int numConvertir = num;
            if (tipoC == 1) //TIPO BINARIO
            {
                
                while (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }
                    num = (int)(num / 2);
                }
                
            }
            else if (tipoC == 2) //TIPO OCTAL
            {
                
                while (num > 0)
                {
                    int resto = num % 8;
                    num = num / 8;
                    resultado = resto.ToString() + resultado;
                }
                
            }
            else if (tipoC == 3) //TIPO HEXADECIMAL
            {
                switch (num)
                {
                   case 10: resultado= "A"; break;
                   case 11: resultado = "B"; break;
                   case 12: resultado = "C"; break;
                   case 13: resultado = "D"; break;
                   case 14: resultado = "E"; break;
                   case 15: resultado = "F"; break;
                }
                while (num > 0)
                {
                    int resto = num % 16;
                    num = num / 16;
                    resultado = resto.ToString() + resultado;
                }
            }

            MostrarResultado(resultado,numConvertir); //para mostrar el resultado
        }

        public static void MostrarResultado(string result, int NUM)
        {
            string respuesta = "";
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
           
            //aqui falta darle formato a la respuesta.
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("|-------------NÚMERO A CONVERTIR: "+NUM+"--------------------------------------|");
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("|                                                                         |");

            Console.WriteLine("| RESPUESTA: "+result+"                                                               ");
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine(result);//imprime el resultado
            while (respuesta != "s" && respuesta!="S" && respuesta!="N" && respuesta!= "n")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" _________________________________________________________________________ ");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|-------------¿DESEA VOLVER A UTILIZAR LA CALCULADORA? (S/N)--------------|");
                Console.WriteLine("|_________________________________________________________________________|");
                Console.WriteLine("                                                                           ");
                //Console.BackgroundColor = ConsoleColor.Black;
                //Console.ForegroundColor = ConsoleColor.White;
                Console.ResetColor();
                respuesta = Console.ReadLine();
            }
           
            
            if(respuesta=="s" | respuesta == "S")
            {
                Menu();
            }else if(respuesta=="N" | respuesta == "n")
            {
                Console.ReadKey();
            }else
            {
                
            }

        }

       
    }
}
