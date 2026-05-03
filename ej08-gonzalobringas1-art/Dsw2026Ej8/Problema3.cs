public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        int copiaValor = originalValue;
        copiaValor++;
        Product copiaProducto = product;
        copiaProducto.SetDescripcion("Nueva Descripción");
        return $"{originalValue}-{copiaValor}-{product.GetDescripcion()}";
    }
}


public class Product
{
    private string descripcion;

    public void SetDescripcion(string desc) => descripcion = desc;
    public string GetDescripcion() => descripcion;
}