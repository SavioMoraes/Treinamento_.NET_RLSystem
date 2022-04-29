using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância da Classe Carro
            Carro car = new Carro();
            car.modelo = "BMW X1";
            car.ligar();

            Carro car2 = new Carro();
            car2.modelo = "Fuscão Preto";
            car2.ligar();
        }
    }
}