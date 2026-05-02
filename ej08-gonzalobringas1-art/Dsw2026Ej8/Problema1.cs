/*Crear un método público ObtenerEtiquetaProducto dentro de una clase parcial
ProductHelper.
El método debe recibir:
● long code
● string description
● decimal price
Debe retornar una cadena con el formato:
[code] description - price
El precio debe mostrarse en formato moneda.
Condiciones:
● La clase ProductHelper debe estar dividida en dos archivos usando partial.
● En un archivo debe ubicarse el método ObtenerEtiquetaProducto.
 ● En el otro archivo debe ubicarse al menos otro método auxiliar o constante utilizada
por el método principal. */

namespace SistemaProductos
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
           
            return $"[{code}] {description} - {price:C}";
        }
    }
}

//todos los que no son string son struct 

namespace SistemaProductos
{
    public partial class ProductHelper
    {
        // Una constante o método auxiliar como pide la consigna
        public const string VersionHerramienta = "1.0.0";

        public void MostrarMensajeDeSistema()
        {
            Console.WriteLine("Generando etiqueta...");
        }
    }
}

//ProductHelper helper = new ProductHelper();
//string etiqueta = helper.ObtenerEtiquetaProducto(10254, "Monitor Gamer 24'", 450000.50m);

//Console.WriteLine(etiqueta); 



