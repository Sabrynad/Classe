using app.Src;
using System;

namespace app
{
    class Program
    {
        static void main(string[] args)
        {
            Catarina Blusa1 = new Blusa("Vermelha", 8, "Algodão", "Dinossauro");
            Catarina Blusa2 = new Blusa("Roxo", 4, "Malha", "Florida");
            Catarina Blusa3 = new Blusa("Amarelo", 6, "Linho", "Listras");
            Catarina Blusa4 = new Blusa("Azul", 10, "Algodão", "Bolinhas");

            Blusa1.Escolher();
            Blusa2.Vestir();
            Blusa3.Vestir();

            Console.WriteLine(Blusa3.ToString());
        }


    }
}
