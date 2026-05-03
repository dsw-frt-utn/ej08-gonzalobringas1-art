

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





