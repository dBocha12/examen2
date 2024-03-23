using System.Globalization;

namespace Examen2
{
    public class ClsArticulo
    {
        protected static string[] codigo = new string[5];
        protected static string[] nombre = new string[5];
        protected static double[] precio = new double[5];
        static int contador = 0;

        public ClsArticulo()
        {
        }

        public ClsArticulo(string[] codigos, string[] nombres, double[] precios)
        {
            if (codigos.Length <= 5 && nombres.Length <= 5 && precios.Length <= 5)
            {
                for (int i = 0; i < codigos.Length; i++)
                {
                    codigo[i] = codigos[i];
                    nombre[i] = nombres[i];
                    precio[i] = precios[i];
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("No se pueden ingresar más de 5 artículos.");
            }
        }

        public void AgregarArticulo()
        {
            Console.Clear();
            Console.WriteLine("======  AGREGAR ARTICULOS  ======");
            Console.WriteLine("");

            Console.WriteLine($"Agregando articulo {contador + 1} de 5 espacios disponibles...");
            Console.WriteLine("");

            bool salidaCodigo = false;
            string cod = "cod";

            while (salidaCodigo == false)
            {
                Console.WriteLine("Digite el codigo del articulo a agregar :");
                cod = Console.ReadLine().Trim();
                Console.WriteLine("");

                if (String.IsNullOrEmpty(cod))
                {
                    ClsMensajes.MessageLogger(2, $"El codigo parece ser nulo o estar en blanco, intenta de nuevo con otro codigo !");
                    continue;
                }

                bool codigoRepetido = false;

                for (int i = 0; i < contador; i++)
                {
                    if (cod == codigo[i])
                    {
                        ClsMensajes.MessageLogger(2, $"Ese codigo {cod} ya existe, intenta de nuevo con otro codigo !");
                        codigoRepetido = true;
                        break;
                    }
                }

                if (!codigoRepetido)
                {
                    salidaCodigo = true;
                }
            }

            Console.Clear();
            Console.WriteLine("======  AGREGAR ARTICULOS  ======");
            Console.WriteLine("");
            Console.WriteLine($"> Codigo del producto: {cod}");
            Console.WriteLine($"> Nombre del producto: X");
            Console.WriteLine($"> Precio del producto: X");
            Console.WriteLine("");
            Console.WriteLine("Digite el nombre del articulo a agregar :");
            string nom = Console.ReadLine();
            Console.WriteLine("");

            Console.Clear();
            Console.WriteLine("======  AGREGAR ARTICULOS  ======");
            Console.WriteLine("");
            Console.WriteLine($"> Codigo del producto: {cod}");
            Console.WriteLine($"> Nombre del producto: {nom}");
            Console.WriteLine($"> Precio del producto: X");
            Console.WriteLine("");
            Console.WriteLine("Digite el precio del articulo a agregar :");
            double pre = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Clear();
            Console.WriteLine("======  INFORMACION DE NUEVO ARTICULO  ======");
            Console.WriteLine("");
            Console.WriteLine($"> Codigo del producto: {cod}");
            Console.WriteLine($"> Nombre del producto: {nom}");
            Console.WriteLine($"> Precio del producto: {pre}");
            Console.WriteLine("");
            

            Console.WriteLine("Desea agregar este producto a la lista? (Si / No)");
            string opcion = Console.ReadLine().ToLower();

            if (opcion.Equals("si"))
            {
                if (contador < 5)
                {
                    codigo[contador] = cod;
                    nombre[contador] = nom;
                    precio[contador] = pre;
                    contador++;
                    ClsMensajes.MessageLogger(0, "Articulo agregado con exito !");
                }
                else
                {
                    ClsMensajes.MessageLogger(2, "No se pueden agregar mas articulos, limite alcanzado.");
                }
            }
            else {
                ClsMensajes.MessageLogger(0, "Decidiste no agregar el producto, articulo no agregado!");
            }

            
        }

        public void ConsultarArticulo()
        {
            Console.Clear();
            Console.WriteLine("======  CONSULTAR ARTICULOS  ======");
            Console.WriteLine("");

            Console.WriteLine("> Digite el codigo del producto a buscar en la lista:");
            string cod = Console.ReadLine();

            for (int i = 0; i < contador; i++)
            {
                if (codigo[i] == cod)
                {
                    Console.Clear();
                    Console.WriteLine("======  CONSULTAR ARTICULOS  ======");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"> Codigo del producto: {codigo[i]}");
                    Console.WriteLine($"> Nombre del producto: {nombre[i]}");
                    Console.WriteLine($"> Precio del producto: {precio[i]}");

                    Console.ReadKey();
                    return;
                }
            }
            ClsMensajes.MessageLogger(2, $"Producto no encontrado con ese codigo {cod}, intentalo de nuevo :(");
        }

        public static bool ValidarArticulo(string cod, out string nombre, out double precio)
        {
            for (int i = 0; i < contador; i++)
            {
                if (codigo[i] == cod)
                {
                    nombre = nombre[i];
                    precio = precio[i];
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"> Codigo del producto: {codigo[i]}");
                    Console.WriteLine($"> Nombre del producto: {nombre[i]}");
                    Console.WriteLine($"> Precio del producto: {precio[i]}");
                    return true;
                }
            }
            nombre = null;
            precio = 0;
            return false;
        }

        public void BorrarArticulo()
        {
            Console.Clear();
            Console.WriteLine("======  ELIMINAR ARTICULOS  ======");
            Console.WriteLine("");

            Console.WriteLine("> Digite el codigo del producto a eliminar de la lista:");
            string cod = Console.ReadLine();

            for (int i = 0; i < contador; i++)
            {
                if (codigo[i] == cod)
                {
                    codigo[i] = null;
                    nombre[i] = null;
                    precio[i] = 0;
                    ClsMensajes.MessageLogger(0, "Artículo borrado correctamente !");
                    return;
                }
            }
            ClsMensajes.MessageLogger(2, "Articulo no encontrado, prueba otro codigo !");
        }


        public string[] Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string[] Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double[] Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Contador
        {
            get { return contador; }
            set { contador = value; }
        }


    }
}
