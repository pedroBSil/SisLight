using System;
using System.Collections.Generic;

class SisLight
{
    private static List<Lampada> lampadas = new List<Lampada>();

    public static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("SisLight - Gerenciamento de Lâmpadas");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Cadastrar Lâmpadas");
            Console.WriteLine("2. Ligar Lâmpada");
            Console.WriteLine("3. Desligar Lâmpada");
            Console.WriteLine("4. Consultar Potência Utilizada");
            Console.WriteLine("5. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    LampadaController.CadastrarLampadas(lampadas);
                    break;
                case 2:
                    LigarLampadaController.LigarLampada(lampadas);
                    break;
                case 3:
                    DesligarLampadaController.DesligarLampada(lampadas);
                    break;
                case 4:
                    ConsultarPotenciaUtilizadaController.ConsultarPotenciaUtilizada(lampadas);
                    break;
                case 5:
                    Console.WriteLine("Saindo do SisLight...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 5);
    }
}
