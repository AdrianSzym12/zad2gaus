using System;
using System.Diagnostics;

namespace BigONotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj potęge 10: ");
            int potega = int.Parse(Console.ReadLine());
            double n = Math.Pow(10, potega);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long suma = 0;
            for(int i=1; i <= n; i++)
            {
                suma += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Suma= " + suma);
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Console.WriteLine("Suma Gausa ");
            double wynikGausa = Gauss(n);
            stopwatch2.Stop();
            Console.WriteLine("Suma Gaussa= " + wynikGausa);
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch2.ElapsedMilliseconds);
        }
        static double Gauss(double n)
        {
            double wynik = ((n + 1) / 2) * n;
            return wynik;
        }
    }
}
