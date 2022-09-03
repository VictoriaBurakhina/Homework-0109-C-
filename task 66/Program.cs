//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 56
//M = 4; N = 8. -> 18

Console.WriteLine("Введите число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber % 2 != 0)
{
    firstNumber++; 
}

int SumEvenNumbers(int firstNumber, int secondNumber)
{
    if(firstNumber <= secondNumber)
    { 
        return firstNumber + SumEvenNumbers(firstNumber + 2, secondNumber);
    }
    else
    { 
         return 0;
    }
}

Console.WriteLine(SumEvenNumbers(firstNumber, secondNumber));