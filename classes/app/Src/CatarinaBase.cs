using System;

namespace app.Src
{
    internal class CatarinaBase
    {

        public string Cor { get; set; }

        public string Tamanho { get; set; }

        public string Tecido { get; set; }

        public string Estampa { get; set; }

        public virtual void Escolher()
        {
            Console.WriteLine($"{Estampa} Florida");
        }
        public virtual void Vestir()
        {
            Console.WriteLine($"{Cor} Vermelho");
        }
    }
}