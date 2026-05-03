public class Product
{
    public string Description { get; private set; }
        public Product(string description)
    {
        Description = description;
    }
    public void ModificarDescripcion(string nuevaDescripcion)
    {
        Description = nuevaDescripcion;
    }
}

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        int valorCopia = originalValue;  
        valorCopia++;
        Product productoCopia = product;
        productoCopia.ModificarDescripcion("Descripción Modificada");
        return $"{originalValue}-{valorCopia}-{product.Description}";
    }
}