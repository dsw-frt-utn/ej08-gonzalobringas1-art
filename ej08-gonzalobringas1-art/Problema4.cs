using System.Collections.Generic;
using System.Linq;

public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {

        int?[] notas = { nota1, nota2, nota3 };

        List<int> notasValidas = notas
            .Where(n => n.HasValue && n.Value >= 0 && n.Value <= 10)
            .Select(n => n.Value)
            .ToList();

        if (notasValidas.Count == 0)
        {
            return 0;
        }

        return notasValidas.Average();
    }
}