using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_DFDaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Menu();
           //int op= Menu();
            string l = (" _________________________________________________________________________ ".PadLeft(50));
            Console.Write(l);
            Console.ReadKey();
            //CapturaDatos(op);
        }

        public static int Menu()
        {
            int opcion = 0;
            string n;
            bool esNumero=false;
            try
            {

                
                //do
                //{
                //    Console.WriteLine("--------------------Seleccione una de las opciones----------------------- \n");
                //    Console.WriteLine("---------------PRESIONE 1 PARA: DECIMAL a BINARIO------------------------ \n");
                //    Console.WriteLine("---------------PRESIONE 2 PARA: DECIMAL a OCTAL-------------------------- \n");
                //    Console.WriteLine("---------------PRESIONE 3 PARA: DECIMAL a HEXADECIMAL-------------------- \n");
                //    n = Console.ReadLine();
                //    /* Si es número correcto retornará true y saldrá
                //       *  del Ciclo*/
                //    esNumero = int.TryParse(n, out opcion);
                //    Console.ReadKey();
                //}
                //while (!esNumero);
                while (!esNumero)
                {
                    string l=(" _________________________________________________________________________ ".PadLeft(10));
                    //Console.WriteLine("\n");
                    //Console.BackgroundColor = ConsoleColor.Blue;
                    //Console.ForegroundColor = ConsoleColor.White;                    
                    Console.WriteLine(l);
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|-----------------SELECCIONE UNA DE LAS OPCIONES--------------------------|");
                    Console.WriteLine("|_________________________________________________________________________|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|---------------PRESIONE 1 PARA: DECIMAL a BINARIO------------------------|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|---------------PRESIONE 2 PARA: DECIMAL a OCTAL--------------------------|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|---------------PRESIONE 3 PARA: DECIMAL a HEXADECIMAL--------------------|");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|_________________________________________________________________________|");
                    n = Console.ReadLine();
                    esNumero = int.TryParse(n, out opcion);
                    if (opcion < 1 | opcion > 3)
                    {
                    Console.WriteLine("-----SELECCIÓN INVÁLIDA. INTENTE NUEVAMENTE---- \n");
                    }else
                    {
                        CapturaDatos(opcion);
                    }
                    //opcion = int.Parse(Console.ReadLine());

                    Console.ReadKey();

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
            Console.WriteLine("--------------------DATO VÁLIDO----------------------- \n");
            Console.ReadKey();
        }

        public static void Conversiones()
        {

        }

        public static void MostrarResultado()
        {

        }
    }
}
