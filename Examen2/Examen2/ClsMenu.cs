using System;

namespace Examen2
{
    internal static class ClsMenu
    {
            public static void MostrarMenu()
            {
            bool salir = false;
            while (salir == false)
            {
                try
                {
                   
                    Console.WriteLine("======  MENU PRINCIPAL  ======");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("A) Articulos");
                    Console.WriteLine("B) Facturacion");
                    Console.WriteLine("C) Reporte");
                    Console.WriteLine("D) Salir del programa");
                    Console.WriteLine("");
                    Console.WriteLine("Escoja la opcion para continuar");
                    string opcion = Console.ReadLine().ToUpper();
                    Console.WriteLine(opcion);

                    switch (opcion.ToUpper())
                    {
                        case "A":
                            Console.Clear();
                            ClsArticuloMenu.SubmenuArticulo();
                            break;
                        case "B":
                            Console.Clear();
                            ClsFacturacion.Facturacion();
                            break;
                        case "C":
                            break;
                        case "D":
                            salir = true;
                            break;
                        default:
                            Console.Clear();
                            ClsMensajes.MessageLogger(3, "La opcion digitada no parece ser valida");
                            break;

                    }

                }
                catch
                {
                    Console.Clear();
                    ClsMensajes.MessageLogger(3, "La opcion digitada no parece ser valida");
                }
            }
        }

    }
}
