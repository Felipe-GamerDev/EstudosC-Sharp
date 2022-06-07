/*
Objetivo: Escreva um programa em C# para ler 10 números do teclado e encontrar sua soma e média.
Output:A soma dos 10 valores é: 110 / A média de 110 é: 11
*/

int testNumber, repeatEntry, limitEntry = 10, testSum = 0;
double testAverage, limitAverange = 10.0;

//entrada
Console.WriteLine("===== Dados do Teste =====");
Console.WriteLine("Insira os 10 números: ");

//lógica
for(repeatEntry = 1; repeatEntry <= limitEntry; repeatEntry++)
{
    Console.Write($"Número-{repeatEntry}: ");
    testNumber = Convert.ToInt32(Console.ReadLine()); //2,4,6,8,10,12,14,16,18,20
    testSum += testNumber;
}

testAverage = testSum / limitAverange;
Console.WriteLine($"A soma dos 10 valores é: {testSum}");
Console.WriteLine($"A média de {testSum} é: {testAverage}");