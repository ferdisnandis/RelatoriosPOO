using System;

namespace Relatorio_POO
{
    public class Relatorio
    {
        public DateTime date;
        public int resposta; 
        public virtual void MostrarRelatorio(){
            Console.WriteLine("Mostrar relatório geral");
        }

    }
}