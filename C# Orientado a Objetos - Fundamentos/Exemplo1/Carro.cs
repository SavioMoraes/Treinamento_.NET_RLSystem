using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1 // namespace - um pacote onde certas Classes estejam!
{
    // internal class Carro
    class Carro
    {
        // Atributos -> Características
        public string modelo = "";

        // Métodos -> Ações
        public void ligar()
        {
            Console.WriteLine("Ligou " + this.modelo);
            // this -> sempre que quiser referenciar um atributo ou método dentro da classe
            // this -> como se fosse ele mesmo - Objeto se chamando!
        }
    }
}
