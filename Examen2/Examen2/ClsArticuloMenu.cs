using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    internal class ClsArticuloMenu
    {
        public static void SubmenuArticulo()
        {
            ClsArticulo articulo = new ClsArticulo();
            bool salir = false;
            while (salir == false)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("======  MENU ARTICULOS  ======");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("A) Agregar");
                    Console.WriteLine("B) Borrar");
                    Console.WriteLine("C) Consultar");
                    Console.WriteLine("D) Volver al menu principal");
                    Console.WriteLine("");
                    Console.WriteLine("Escoja la opcion para continuar");
                    string opcion = Console.ReadLine().ToUpper();

                    switch (opcion.ToUpper())
                    {
                        case "A":
                            articulo.AgregarArticulo();
                            break;
                        case "B":
                            articulo.BorrarArticulo();
                            break;
                        case "C":
                            articulo.ConsultarArticulo();
                            break;
                        case "D":
                            Console.Clear();
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
            ClsMenu.MostrarMenu();
        }

    }
}
