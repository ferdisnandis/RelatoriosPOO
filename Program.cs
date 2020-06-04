using System;

namespace Relatorio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio();
            Console.WriteLine("Digite a data separando por vírgula: ");
            relatorio.date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(relatorio.date.ToString("dd'/'MM'/'yyyy"));

            Console.WriteLine("Digite:\n 1 - Geral\n 2 - Mensal \n 3 - Anual");
            relatorio.resposta = Int32.Parse(Console.ReadLine());

            switch (relatorio.resposta)
            {
                case 1:
                Console.WriteLine( "Mostrando relatório geral" );
                break;

                case 2:
                Console.WriteLine ( "Mostrando relatório mensal" );
                break;
                
                case 3:
                Console.WriteLine( "Mostrando relatório anual" );
                break;

                default:
                Console.WriteLine("Valor inválido");
                break;
            }

        }
    }
}
