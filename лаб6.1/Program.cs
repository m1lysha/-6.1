using System;

class Program
{
    static void Main(string[] args)
    {
        double[] A = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        int N = A.Length;
Console.WriteLine("Исходный массив:");
        PrintArray(A);

        for (int i = 0; i < 5; i++)
        {
            Smooth(A, N);
            Console.WriteLine($"Результат сглаживания {i + 1}:");
            PrintArray(A);
        }
    }

    static void Smooth(double[] A, int N)
    {
        double[] temp = new double[N];

        for (int i = 0; i < N; i++)
        {
            if (i == 0) 
            {
                temp[i] = (A[i] + A[i + 1]) / 2;
            }
            else if (i == N - 1) 
            {
                temp[i] = (A[i - 1] + A[i]) / 2;
            }
            else 
            {
                temp[i] = (A[i - 1] + A[i] + A[i + 1]) / 3;
            }
        }
        Array.Copy(temp, A, N);
    }

    static void PrintArray(double[] A)
    {
        Console.WriteLine(string.Join(", ", A));
    }
}

