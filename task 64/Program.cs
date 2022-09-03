//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.

//M = 1; N = 5. -> ""5, 4, 3, 2, 1""

//M = 4; N = 8. -> ""8, 7, 6, 5, 4""

Console.WriteLine("Введите число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int firstNumber, int secondNumber)
{
    if(firstNumber < secondNumber)
    { 
        return $"{secondNumber} " + NumbersRec(firstNumber, secondNumber - 1);
    }
    else
    { 
         return $"{firstNumber} ";
    }
}

Console.WriteLine(NumbersRec(firstNumber, secondNumber));
