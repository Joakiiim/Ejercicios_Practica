using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int n = int.Parse(input[2]);

            if(a == 0 && b == 0 && n == 0) break;

            Console.WriteLine(SecuenciaFibos(a, b, n));

        }
    }

    const int mod = 1000000007;
    static long SecuenciaFibonacci(int n)
    {
        if(n == 0) return 0;
        if(n == 1) return 1;

        long a = 0;
        long b = 1;
        for(int i = 2; i <= n; i++)
        {
            long c = a + b % mod;
            a = b;
            b = c;
        }
        return b;
    }

    static long SecuenciaFibos(int a, int b, int n)
    {
        long suma = 0;
        for(int i = 0; i < n; i++)
        {
            long fibosA = SecuenciaFibonacci(a+i);
            long fibosB = SecuenciaFibonacci(b+i);
            suma = (suma + (fibosA * fibosB)) % mod;
        }
        return suma;
    }
}