using System;
using System.Collections.Generic;

class ConsultarPotenciaUtilizadaController
{
    public static void ConsultarPotenciaUtilizada(List<Lampada> lampadas)
    {
        Console.WriteLine("Consultar Potência Utilizada");
        Console.WriteLine("----------------------------------");

        if (lampadas.Count == 0)
        {
            Console.WriteLine("Nenhuma lâmpada cadastrada!");
            Console.ReadKey();
            return;
        }

        int potenciaTotal = 0;

        foreach (var lampada in lampadas)
        {
            if (lampada.Acesa)
            {
                potenciaTotal += lampada.Potencia;
            }
        }

        Console.WriteLine("Potência Total Utilizada: {0}W", potenciaTotal);
        Console.ReadKey();
    }
}
