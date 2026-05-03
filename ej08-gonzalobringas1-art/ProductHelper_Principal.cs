public partial class ProductHelper
{
    public string ObtenerEtiquetaProducto(long code, string description, decimal price)
    {
        
        string precioFormateado = FormatearPrecio(price);
        
        return $"[{code}] {description} - {precioFormateado}";
    }
}