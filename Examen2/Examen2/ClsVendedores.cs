using System;
using System.Collections.Generic;

namespace Examen2
{
    internal class ClsVendedores
    {
        private Dictionary<string, string> vendedores;

        public ClsVendedores()
        {
            vendedores = new Dictionary<string, string>();
        }

        public void AgregarVendedor(string codigo, string nombre)
        {
            vendedores.Add(codigo, nombre);
        }

        public Dictionary<string, string> ListadoVendedores()
        {
            return vendedores;
        }

        public string ObtenerNombreVendedor(string codigo)
        {
            if (vendedores.ContainsKey(codigo))
            {
                return vendedores[codigo];
            }
            else
            {
                return "Vendedor no encontrado";
            }
        }

        public static string ListarTodosLosVendedores()
        {
            string listaVendedores = "Lista de Vendedores:\n";
            foreach (var vendedor in vendedores)
            {
                listaVendedores += $"Código: {vendedor.Key}, Nombre: {vendedor.Value}\n";
            }
            return listaVendedores;
        }
    }

    internal class Vendedor1 : IVendedor1
    {
        public string Nombre { get; }

        public Vendedor1(string nombre)
        {
            Nombre = nombre;
        }

    }

    internal class Vendedor2 : IVendedor2
    {
        public string Nombre { get; }

        public Vendedor2(string nombre)
        {
            Nombre = nombre;
        }

    }

    internal interface IVendedor1
    {
        string Nombre { get; }
    }

    internal interface IVendedor2
    {
        string Nombre { get; }
    }
}
