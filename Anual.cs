using System;

namespace Relatorio_POO
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório anual");
        }
        }
    }