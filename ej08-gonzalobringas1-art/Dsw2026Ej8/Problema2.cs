using System;
public class Problema2
{
    public String CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice) 
    {
        decimal totalCalculado = quantity > 0 ? quantity * unitPrice : 0;
        var resumen = new
        {
            code = productCode,
            Descripcion = productDescription,
            Quantity = quantity,
            Total = totalCalculado
        };
        return $"{resumen.code}-{resumen.Descripcion}-{resumen.Total}";
    }
}
