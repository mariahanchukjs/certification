// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string msg)
{
    System.Console.Write(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNaturalNumbersInRange (int M, int N)
{
    if (M==N)
    {
        return M;
    }
    return M + SumNaturalNumbersInRange(M+1, N);
}

int M=ReadInt("Введите первое число: ");
int N=ReadInt("Введите второе число: ");
System.Console.WriteLine(SumNaturalNumbersInRange(M,N));