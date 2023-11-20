﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string msg)
{
    System.Console.Write(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int AckermannFunction (int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    else if (n==0)
    {
        return AckermannFunction(m-1,1);
    }
    return AckermannFunction(m-1,AckermannFunction(m,n-1));
}

System.Console.WriteLine(AckermannFunction(ReadInt("Введите m: "), ReadInt("Введите n: ")));