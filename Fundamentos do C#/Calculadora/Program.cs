Console.WriteLine("----Calculadora----");
int n1 = 0; // por boa prática de programação! -> inicializar uma variável com um valor!
int n2; // também pode-se iniciar uma variável sem valor, mas não é boa prática de programação!
//string value = "+";
//Console.WriteLine("Qual operação deseja fazer?");
//Console.WriteLine("Digite + para adição");
//Console.WriteLine("Digite - para adição");
//Console.WriteLine("Digite * para adição");
//Console.WriteLine("Digite / para adição");

//if (value = "+")
//{

//}


Console.WriteLine("Digite o primeiro valor: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
n2 = Convert.ToInt32(Console.ReadLine());
int soma = n1 + n2;
int subtracao = n1 - n2;
int multiplicacao = n1 * n2;
int divisao = n1 / n2;
Console.WriteLine("Resultado: ");
Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtracao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão: " + divisao);
