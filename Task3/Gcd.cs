using System;
using System.Diagnostics;

namespace Task3
{
    public static class Gcd
    {
        public static int EuclidGcd(out long time, int a, int b)
        {
            return GetEuclidGcd(out time, a, b);
        }

        public static int EuclidGcd(int a, int b, int c, out long time)
        {
            return GetEuclidGcd(out time, GetEuclidGcd(out time, a, b), c);
        }

        public static int EuclidGcd(out long time, params int[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            int result = args[0];
            for (int i = 1; i < args.Length; i++)
                result = EuclidGcd(out time, result, args[i]);
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return result;
        }

        public static int SteinGcd(out long time, int a, int b)
        {
            return GetSteinGcd(out time, a, b);
        }

        public static int SteinGcd(out long time, int a, int b, int c)
        {
            return GetSteinGcd(out time, GetSteinGcd(out time, a, b), c);
        }

        public static int SteinGcd(out long time, params int[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            int result = args[0];
            for (int i = 1; i < args.Length; i++)
                result = SteinGcd(out time, result, args[i]);
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return result;
        }

        private static int GetEuclidGcd(out long time, int a, int b)
        {
            var stopWatch = Stopwatch.StartNew();
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return a;
        }

        private static int GetSteinGcd(out long time, int a, int b)
        {
            var stopWatch = Stopwatch.StartNew();
            int shift;

            if (a == 0)
            {
                stopWatch.Stop();
                time = stopWatch.ElapsedTicks;
                return b;
            }
            if (b == 0)
            {
                stopWatch.Stop();
                time = stopWatch.ElapsedTicks;
                return a;
            }

            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
                a >>= 1;

            do
            {
                while ((b & 1) == 0)
                {
                    b >>= 1;
                }

                if (a > b)
                {
                    Swap(ref a, ref b);
                }
                b = b - a;
            } while (b != 0);
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return a << shift;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
