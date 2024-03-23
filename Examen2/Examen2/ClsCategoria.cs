using System;
using System.Collections.Generic;

namespace Examen2
{
    internal class ClsCategoria
    {
        public virtual void Promocion()
        {
            Console.WriteLine("Descuentos y promociones");
        }

        public static List<ClsCategoria> ListaCategorias = new List<ClsCategoria>();

        public static void ListadoCategorias()
        {
            int contador = 0;

            ClsCategoria.iniciarCategorias();
            Console.WriteLine("Categorias disponibles:");
            foreach (var categoriaSingular in ListaCategorias)
            {
                contador++;
                Console.Write(contador + ") " );
                categoriaSingular.Promocion();
            }
        }

        internal static bool CategoriaExiste<T>() where T : ClsCategoria
        {
            foreach (var categoria in ListaCategorias)
            {
                if (categoria.GetType() == typeof(T))
                {
                    return true;
                }
            }
            return false;
        }

        public static void iniciarCategorias() {
            ClsCategoria.ListaCategorias.Add(new Categoria1());
            ClsCategoria.ListaCategorias.Add(new Categoria2());
            ClsCategoria.ListaCategorias.Add(new Categoria3());
        }

    }

    internal class Categoria1 : ClsCategoria
    {
        public override void Promocion()
        {
            Console.WriteLine("Descuento de 15%");
        }
    }

    internal class Categoria2 : ClsCategoria
    {
        public override void Promocion()
        {
            Console.WriteLine("Promoción dos por 1");
        }
    }

    internal class Categoria3 : ClsCategoria
    {
        public override void Promocion()
        {
            Console.WriteLine("Todo a mitad de precio");
        }
    }
}
