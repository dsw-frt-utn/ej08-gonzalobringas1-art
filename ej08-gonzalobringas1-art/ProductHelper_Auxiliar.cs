public partial class ProductHelper
{
    
    private string FormatearPrecio(decimal price)
    {
        
        return price.ToString("C"); 
    }
}