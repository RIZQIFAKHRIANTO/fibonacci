using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan jumlah bilangan Fibonacci yang ingin ditampilkan: ");
        int n = int.Parse(Console.ReadLine());

        // Memanggil fungsi Fibonacci untuk menampilkan deret
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    // Fungsi rekursif untuk menghitung Fibonacci
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}