

namespace EjercicioListasDiccionarios
{
    class Program

    {
        static void Main(string[] args)
        {
            List<Producto> listaProductos = new List<Producto>();

            // Llenar la lista con 10 productos
            for (int i = 1; i <= 10; i++)
            {
                listaProductos.Add(new Producto { Id = i, Nombre = $"Producto {i}" });
            }

            // Agregar un nuevo producto en el índice 3
            listaProductos.Insert(3, new Producto { Id = 11, Nombre = "Producto 11" });

            // Remover el último elemento de la lista
            listaProductos.RemoveAt(listaProductos.Count - 1);

            // Mostrar la lista en la consola
            Console.WriteLine("Lista de productos:");
            foreach (Producto producto in listaProductos)
            {
                Console.WriteLine($"{producto.Id}. {producto.Nombre}");
            }

            Dictionary<string, Departamento> diccionarioDepartamentos = new Dictionary<string, Departamento>();

            // Agregar 2 departamentos al diccionario
            diccionarioDepartamentos.Add("Departamento1", new Departamento { Nombre = "Departamento 1", Cabecera = "Cabecera 1", Superficie = 100, Poblacion = 1000 });
            diccionarioDepartamentos.Add("Departamento2", new Departamento { Nombre = "Departamento 2", Cabecera = "Cabecera 2", Superficie = 200, Poblacion = 2000 });

            // Mostrar en la consola el diccionario con su respectiva llave y valor
            Console.WriteLine("\nLista de departamentos:");
            foreach (KeyValuePair<string, Departamento> entry in diccionarioDepartamentos)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value.Nombre}");
            }

            Console.ReadLine();
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Departamento
    {
        public string Nombre { get; set; }
        public string Cabecera { get; set; }
        public int Superficie { get; set; }
        public int Poblacion { get; set; }
    }
}


