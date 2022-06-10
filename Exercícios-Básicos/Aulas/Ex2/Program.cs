/*
Objetivo: Escrever um programa C# para imprimir a saída de multiplicação de três números que serão inseridos pelo usuário.
*/

int numberOne, numberTwo, numberThree, result;

//Entrada
Console.WriteLine("===== Dados do Teste =====");
Console.Write("Primeiro número a multiplicar: ");
numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Segundo número a multiplicar: ");
numberTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Terceiro número a multiplicar: ");
numberThree = Convert.ToInt32(Console.ReadLine());

//Lógica
result = numberOne * numberTwo * numberThree;
Console.WriteLine($"{numberOne} X {numberTwo} X {numberThree} = {result}");