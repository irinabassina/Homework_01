// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(firstNumber > secondNumber)
{
    max = firstNumber; 
}
else
{
    max = secondNumber;   
}

if(firstNumber == secondNumber)
{ 
    Console.WriteLine($"max = min = {max}");
}
else
{
  Console.WriteLine($"max = {max}");  
}