/*
Objetivo: Escreva um programa C# para imprimir na tela a saída somar, subtrair, multiplicar e dividir dois números que serão inseridos pelo usuário.
*/

int numberOne, numberTwo;

//Entrada
Console.WriteLine("===== Dados de Teste =====");
Console.Write("Insira o primeiro número: ");
numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o segundo número: ");
numberTwo = Convert.ToInt32(Console.ReadLine());

//Lógica
Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");