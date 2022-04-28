using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variáveis
            string nome = "Sávio";
            string app = "Calculadora";
            Console.WriteLine(nome + " " + app);
            int valor1 = 10;
            int valor2 = 5;
            int soma = valor1 + valor2;
            int subtracao = valor1 - valor2;
            int multiplicacao = valor1 * valor2;
            int divisao = valor1 / valor2;
            Console.WriteLine("A soma de 10 com o 5 é : " + soma);
            Console.WriteLine("A subtração de 10 menos o 5 é : " + subtracao);
            Console.WriteLine("A multiplicação de 10 com o 5 é : " + multiplicacao);
            Console.WriteLine("A divisão de 10 por 5 é : " + divisao);

            // Escreve texto na tela
            //Console.WriteLine("----Calculadora----");
            //Console.WriteLine("Digite o primeiro valor");
            //Console.ReadLine();
            //Console.WriteLine("Digite o segundo valor");
            //Console.ReadLine();
            //Console.ReadLine();
            /* 
             Para comentários maiores,
             demais de uma linha...
            */
        }
    }
}
