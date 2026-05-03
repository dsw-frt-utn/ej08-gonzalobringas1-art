
public class Sale
{
    public decimal BaseAmount { get; set; }

    
    public virtual decimal CalculateTotal()
    {
        return BaseAmount;
    }
}

public class RetailSale : Sale
{
    public override decimal CalculateTotal()
    {
        return BaseAmount;
    }
}

public class WholesaleSale : Sale
{
    public override decimal CalculateTotal()
    {
        return BaseAmount * 0.90m;
    }
}


public class Problema5
{
    public decimal ObtenerImporteFinal(Sale sale)
    {
        return sale.CalculateTotal();
    }
}