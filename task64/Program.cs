// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg)
{
    System.Console.Write(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintEvenNaturalNumbers (int M, int N)
{
    if (M % 2 !=0)
    {
        M++;
    }
    if (M>N)
    {
        return;
    }
    System.Console.Write($"{M}\t");
    PrintEvenNaturalNumbers(M+2, N);
}
int M=ReadInt("Введите первое число: ");
int N=ReadInt("Введите второе число: ");
PrintEvenNaturalNumbers(M,N);