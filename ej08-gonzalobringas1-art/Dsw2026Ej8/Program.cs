using SistemaProductos;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ProductHelper helper = new ProductHelper();
string etiqueta = helper.ObtenerEtiquetaProducto(10254, "Monitor Gamer 24'", 450000.50m);

Console.WriteLine(etiqueta); 
// Salida esperada: [10254] Monitor Gamer 24' - $450.000,50
        }
    }
}

