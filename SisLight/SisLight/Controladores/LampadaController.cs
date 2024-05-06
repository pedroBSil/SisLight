using System;
using System.Collections.Generic;

class LampadaController
{
    public static void CadastrarLampadas(List<Lampada> lampadas)
    {
        Console.WriteLine("Cadastro de Lâmpadas");
        Console.WriteLine("--------------------------------");

        int quantidadeLampadas;

        do
        {
            Console.Write("Informe a quantidade de lâmpadas a cadastrar: ");
            quantidadeLampadas = int.Parse(Console.ReadLine());
        } while (quantidadeLampadas <= 0);

        for (int i = 0; i < quantidadeLampadas; i++)
        {
            Console.Write("Informe a potência da lâmpada {0}: ", i + 1);
            int potencia = int.Parse(Console.ReadLine());

            Lampada lampada = new Lampada(potencia);
            lampadas.Add(lampada);

            Console.WriteLine("Lâmpada cadastrada com sucesso!");
            Console.WriteLine("Código: {0}", lampada.Codigo);
            Console.WriteLine("Potência: {0}W", lampada.Potencia);
            Console.WriteLine("Status: {0}", lampada.Acesa ? "Acesa" : "Apagada");
            Console.WriteLine();
        }

        Console.WriteLine("Cadastro finalizado!");
        Console.ReadKey();
    }
}
