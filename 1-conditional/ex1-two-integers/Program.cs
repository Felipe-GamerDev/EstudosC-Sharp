/*
Objetivo: Escrever um programa C# para aceitar dois inteiros e verificar se eles são iguais ou não.
Output: 5 e 5 são iguais!
*/

//entrada
Console.Write("1° número: "); // 5;
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("2° número: "); // 5;
int secondNumber = Convert.ToInt32(Console.ReadLine());

//logica
if ( firstNumber == secondNumber)
    Console.WriteLine($"{firstNumber} e {secondNumber} são iguais!");
else
    Console.WriteLine($"{firstNumber} e {secondNumber} não são iguais!");
