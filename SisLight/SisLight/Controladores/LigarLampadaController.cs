using System;
using System.Collections.Generic;

class LigarLampadaController
{
    public static void LigarLampada(List<Lampada> lampadas)
    {
        Console.WriteLine("Ligar Lâmpada");
        Console.WriteLine("----------------------");

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
            if (lampada.Acesa)
            {
                Console.WriteLine("Lâmpada {0} já está ligada!", codigo);
            }
            else
            {
                lampada.Acesa = true;
                Console.WriteLine("Lâmpada {0} ligada com sucesso!", codigo);
            }
        }
        else
        {
            Console.WriteLine("Lâmpada com código {0} não encontrada!", codigo);
        }

        Console.ReadKey();
    }
}
