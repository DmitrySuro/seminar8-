/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/


System.Console.Clear();

void OutputNaturalNumbers(int n,int m = 1)
{
    
    if (m > n)
    {
        System.Console.WriteLine();
        return;   
    }
    System.Console.Write(m + " ");
    OutputNaturalNumbers(n,m+1);
    return;
}

OutputNaturalNumbers(4);