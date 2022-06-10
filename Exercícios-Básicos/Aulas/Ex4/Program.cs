/*
Objetivo: Escreva um programa C# que leva quatro números como entrada para calcular e imprimir a média.
Output: A média de 10 + 15 + 20 + 30 é: 18 
*/

int numberOne, numberTwo, numberThree, numberFour, dividedNumber = 4, result;

//Entrada
Console.WriteLine("===== Dados de Teste =====");
Console.Write("Insira o primeiro número: ");
numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o segundo número: ");
numberTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o terceiro número: ");
numberThree = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o quarto número: ");
numberFour = Convert.ToInt32(Console.ReadLine());

//Lógica
result = (numberOne + numberTwo + numberThree + numberFour) / dividedNumber;
Console.WriteLine($"A média de {numberOne} + {numberTwo} + {numberThree} + {numberFour} é: {result}");