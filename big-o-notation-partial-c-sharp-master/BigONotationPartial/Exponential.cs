using System;
using System.Diagnostics;

namespace BigONotationPartial
{
    class Exponential
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonacci;

            //se incializa variables
            int anterior1 = 1, anterior2 = 1;
            int fibonacci = 1;
            // se imprime el primer valor de fibonacci
            Console.WriteLine("fibonacci {0} = {1}", 1, fibonacci);

            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonacci:
                    int n = 40; //8 40 80

                    // la variable i comienza de 2
                    for (int i = 2; i <= n; i++)
                    {
                        //long fibonacci = exponential.Fibonacci(i);
                        Console.WriteLine("fibonacci {0} = {1}", i, fibonacci);

                        // se usa variable  que guarda los dos valores anterior
                        fibonacci = anterior1 + anterior2;
                        anterior1 = anterior2;
                        anterior2 = fibonacci;
                    }
                    break;
            }
            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        /// Complexity: O(2^N)
        //internal int Fibonacci(long n)
        //{
        //    if (n < 0)
        //    {
        //        throw new Exception("n can not be less than zero");
        //    }
        //    if (n <= 2)
        //    {
        //        return 1;
        //    }
        //    return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}
    }
}
