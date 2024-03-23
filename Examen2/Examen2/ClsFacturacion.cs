using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    internal class ClsFacturacion
    {

        public static void Facturacion()
        {
            int categoriaSeleccionada = 0;
            string nombreProducto;
            double precioProducto;

            Console.Clear();
            Console.WriteLine("======  FACTURAR ARTICULOS  ======");
            Console.WriteLine("");
            Console.WriteLine("> Digite el codigo del producto a facturar:");
            string cod = Console.ReadLine();

            bool existe = ClsArticulo.ValidarArticulo(cod, out nombreProducto, out precioProducto);
            if (existe)
            {
                Console.WriteLine("> Digite la categoria a aplicar:");
                Console.WriteLine("");

                while (categoriaSeleccionada == 0) 
                {
                ClsCategoria.ListadoCategorias();
                int categoria = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                    switch (categoria)
                    {
                        case 1:
                            categoria = 1;
                            double descuento15 = precioProducto * 0.15;
                            double precioConDescuento15 = precioProducto - descuento15;
                            break;
                        case 2:
                            categoria = 2;
                            break;
                        case 3:
                            categoria = 3;
                            double descuento50 = precioProducto * 0.50;
                            double precioConDescuento50 = precioProducto - descuento50;
                            break;
                        default: 
                            ClsMensajes.MessageLogger(2, $"Esa cateogr"); 
                            break;
                    }
                }

                Console.WriteLine("> Digite el vendedor:");
                Console.WriteLine("");

                ClsVendedores.ListarTodosLosVendedores();
                Console.ReadKey();

                }
            else
            {
                ClsMensajes.MessageLogger(2, $"Producto no encontrado con ese codigo {cod}, intentalo de nuevo :(");
            }
        }
    }
}
