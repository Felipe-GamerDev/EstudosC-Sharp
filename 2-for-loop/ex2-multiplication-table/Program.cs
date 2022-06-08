/*
Objetivo: Escreva um programa em C# para exibir a tabela de multiplicação de um determinado inteiro.
*/

//entrada
int number, repeat = 0, multiplyResult, limitRepeat = 10;
Console.WriteLine("===== Tabela de Multiplicação =====");

Console.Write("Insira o número: ");
number = Convert.ToInt32(Console.ReadLine());

//lógica
for (repeat = 1; repeat <= limitRepeat; repeat++)
{
    multiplyResult = number * repeat;
    Console.WriteLine($"{number} X {repeat} = {multiplyResult}");
}