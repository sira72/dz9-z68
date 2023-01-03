// Задача 66. Найти сумму нат.элементов от М до N.

// M=1; N=10 ->120
// M=4; N=9 ->30

int SumNaturalNums(int n, int m)
{
    if (n>m) return 0;
    else return n+SumNaturalNums(n+1,m);
}
