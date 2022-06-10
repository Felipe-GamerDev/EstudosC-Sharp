/*
Objetivo: Escrever um programa C# para trocar dois números.
*/

int firstNumber, secondNumber;

//Entrada
Console.Write("Insira o primeiro número: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o segundo número: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("===== Após a Troca =====");

//Lógica
if( firstNumber < secondNumber)
    Console.WriteLine($"Primeiro Número: {secondNumber}\nSegundo Número: {firstNumber}");
else
    Console.WriteLine($"Primeiro Número: {secondNumber}\nSegundo Número: {firstNumber}");