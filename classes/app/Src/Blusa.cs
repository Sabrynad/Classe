using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Src
{
    internal class Blusa : Catarina
    {
        public Blusa(string cor, int tamanho, string tecido, string estampa) : base(cor, tamanho, tecido, estampa)
        {
        }

        public override void Escolher()
        {
           Console.WriteLine($"{Estampa} Florida");
        }

        public override void Vestir()
        {
          Console.WriteLine($"{Cor} Vermelho"); 
        }
    }
}
