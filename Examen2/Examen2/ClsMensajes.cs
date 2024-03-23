using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    internal class ClsMensajes
    {
        public static void MessageLogger(int nivel, string args)
        {
            Console.Clear();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("");
            Console.WriteLine("");

            ConsoleColor colorTitulo = ConsoleColor.White;
            ConsoleColor colorMensaje = ConsoleColor.Gray;

            switch (nivel)
            {
                case 0: // Informacion
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("INFORMACION :");
                    break;
                case 1: // Warning
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ADVERTENCIA :");
                    break;
                case 2: // Error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR :");
                    break;
                case 3: // Fatal
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ERROR CRITICO :");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("MENSAJE :");
                    break;
            }
            Console.ForegroundColor = colorMensaje;

            Console.WriteLine(args);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
