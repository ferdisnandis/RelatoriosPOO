using System;

namespace Relatorio_POO
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório mensal");
        }
    }
}