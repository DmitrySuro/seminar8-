/*
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

System.Console.Clear();

void OutputNaturalNumbers(int n,int m)
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

int n = 4;
System.Console.WriteLine($"числа от 1 до {n}"); 
OutputNaturalNumbers(n,1);