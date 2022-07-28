using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Src
{
    internal class Catarina
    {
        public Catarina(string cor, int tamanho, string tecido, string estampa)
        {
            Cor = cor;
            Tamanho = tamanho;
            Tecido = tecido;
            Estampa = estampa;
        }

        public string Cor { get; set; }

        public int Tamanho { get; set; }

        public string Tecido { get; set; }

        public string Estampa { get; set; }

        public virtual void Escolher() 
        {
            Console.WriteLine($"Acho que vou desenhar uma...{Estampa}");
        }
        public virtual void Vestir()
        {
            Console.WriteLine($"E vou pintar de...{Cor}");
        }

    }
}
