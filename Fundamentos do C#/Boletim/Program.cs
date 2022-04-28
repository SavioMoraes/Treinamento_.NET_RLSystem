double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double nota4 = 0;
double media = 0;
string nome_do_aluno = "";
string materia = "";
string caderno = "";
Console.WriteLine("----- Boletim -----");
Console.WriteLine("Digite o nome do aluno");
nome_do_aluno = Console.ReadLine();
Console.WriteLine("Agora informe a disciplina:");
materia = Console.ReadLine();
Console.WriteLine(nome_do_aluno + " você mostrou o caderno?");
caderno = Console.ReadLine();
Console.WriteLine("Informe a primeira nota: ");
nota1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a segunda nota: ");
nota2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a terceira nota: ");
nota3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe a quarta nota: ");
nota4 = Convert.ToInt32(Console.ReadLine());
// media = (double)(nota1 + nota2 + nota3 + nota4) / 4; // (double) -> utilização de Type Casting!!! quando as quatro notas foram declaradas como int
if (caderno == "sim" || caderno == "Sim" || caderno == "SIM")
{
    media = (nota1 + nota2 + nota3 + nota4) / 4 + 1;
} else
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;
}
if (media >= 7)
{
    Console.WriteLine("A média do aluno: " + nome_do_aluno + ", na Matéria: " + materia + " é: " + media);
    Console.WriteLine(nome_do_aluno + " está Aprovado");
} else if (media >= 5)
{
    Console.WriteLine("A média do aluno: " + nome_do_aluno + ", na Matéria: " + materia + " é: " + media);
    Console.WriteLine(nome_do_aluno + " está em Recuperação");
} else
{
    Console.WriteLine("A média do aluno: " + nome_do_aluno + ", na Matéria: " + materia + " é: " + media);
    Console.WriteLine(nome_do_aluno + " está Reprovado");
}
