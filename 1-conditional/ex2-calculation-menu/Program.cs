/*
 Objetivo: Escrever um programa em C# Orientado pelo Menu para realizar um cálculo simples.
 Escolha: 3-Multiplicação.
 Output: A multiplicação de 5 e 2: 10.
*/

bool repeat = true;
int firstNumber, secondNumber, choice;

while (repeat) //logica de repetição
{
    if(repeat == false) 
        break;
    
    //entrada
    Console.Write("Digite o primeiro número: ");//5;
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo número: ");//2;
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Aqui estão as opções:\n1-Adição.\n2-Subtração.\n3-Multiplicação.\n4-Divisão.\n5-Exit.");
    choice = Convert.ToInt32(Console.ReadLine());

    //lógica
    switch (choice)
        {
    case 1:
        Console.WriteLine("=====================");
        Console.WriteLine($"A adição de {firstNumber} e {secondNumber}: {firstNumber + secondNumber}");
        Console.WriteLine("=====================");
    break;
    case 2:
        Console.WriteLine("========================");
        Console.WriteLine($"A subtração de {firstNumber} e {secondNumber}: {firstNumber - secondNumber}");
        Console.WriteLine("========================");
    break;
    case 3:
        Console.WriteLine("=============================");
        Console.WriteLine($"A multiplicação de {firstNumber} e {secondNumber}: {firstNumber * secondNumber}");
        Console.WriteLine("=============================");
    break;
    case 4:
        if(secondNumber == 0){
            Console.WriteLine("====================================");
            Console.WriteLine("Erro! Evite o 0 no segundo número.");
            Console.WriteLine("====================================");
        }
        else
        {
            Console.WriteLine("======================");            
            Console.WriteLine($"A divisão de {firstNumber} e {secondNumber}: {firstNumber / secondNumber}");
            Console.WriteLine("======================");
        }
            
    break;
    case 5:
        repeat = false;
        break;
    default:
        Console.WriteLine("================");
        Console.WriteLine("Opção incorreta!");
        Console.WriteLine("================");
    break;
    }   
}
