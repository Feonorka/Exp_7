﻿// Сумма чисел от 1 до n
int SumFor(int n)
{
    int res = 0;
    for (int i = 1; i <= n; i++) res +=i;
    return res;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));