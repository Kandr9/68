// 68








int AckermannFunction( int M,  int N)
{
    if (M == 0)
        return N + 1;
    else if (M > 0 && N == 0)
        return AckermannFunction( M  - 1, 1);
    else
        return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
}


Console.Write("Введите первое число (M):   " );
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число (N): " );
int n = Convert.ToInt32(Console.ReadLine());

int ackermannResult = AckermannFunction(m, n);

Console.WriteLine($"A({m}, {n})  =  {ackermannResult}");