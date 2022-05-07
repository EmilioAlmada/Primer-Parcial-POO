using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Biblioteca
{
    public sealed class Presentacion
    {
        public Presentacion()
        {
            RutaPresentacion = "./presentacion.csv";
        }

        public string RutaPresentacion { get; }

        public void IniciarPresentacion()
        {
            Console.WriteLine($"Iniciando...");
            try
            {
                string[] lineaCsv = File.ReadLines(RutaPresentacion).ToArray();
                Console.ForegroundColor = ConsoleColor.Blue; 
                foreach (string linea in lineaCsv)
                {
                    Console.WriteLine($"{linea}");
                }
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine($"  ");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No se pudo leer el arcivo");
                Console.WriteLine($"/*----------------------------------------------------*/");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"El error que ocurrio fue:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No se encontro el archivo de presentacion.");
                Console.WriteLine($"/*----------------------------------------------------*/");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Iniciando presentacion por defecto:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Primer Parcial Emilio Almada");
                Console.WriteLine("----Ejercicio - Gimnacio----");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}