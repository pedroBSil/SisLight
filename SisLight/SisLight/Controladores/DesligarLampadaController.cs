using System;
using System.Collections.Generic;

class DesligarLampadaController
{
    public static void DesligarLampada(List<Lampada> lampadas)
    {
        Console.WriteLine("Desligar Lâmpada");
        Console.WriteLine("------------------------");

        if (lampadas.Count == 0)
        {
            Console.WriteLine("Nenhuma lâmpada cadastrada!");
            Console.ReadKey();
            return;
        }

        Console.Write("Informe o código da lâmpada: ");
        int codigo = int.Parse(Console.ReadLine());

        Lampada lampada = lampadas.Find(l => l.Codigo == codigo);

        if (lampada != null)
        {
            if (!lampada.Acesa)
            {
                Console.WriteLine("Lâmpada {0} já está desligada!", codigo);
            }
            else
            {
                lampada.Acesa = false;
                Console.WriteLine("Lâmpada {0} desligada com sucesso!", codigo);
            }
        }
        else
        {
            Console.WriteLine("Lâmpada com código {0} não encontrada!", codigo);
        }

        Console.ReadKey();
    }
}
