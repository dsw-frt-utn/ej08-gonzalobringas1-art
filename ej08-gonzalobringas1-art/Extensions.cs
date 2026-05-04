
public static class Extensions
{
   
    public static string ToProductCode(this string code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            return "SIN-CODIGO";
        }

        return code
            .Trim()              
            .ToUpper()           
            .Replace(" ", "-");  
    }
}