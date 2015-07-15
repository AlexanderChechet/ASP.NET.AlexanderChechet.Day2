using System.Diagnostics;

namespace Task3
{
    public static class Gcd
    {
        #region Public Euclid methods
        public static int EuclidGcd(int a, int b)
        {
            return GetEuclidGcd(a, b);
        }

        public static int EuclidGcd(int a, int b, int c)
        {
            return GetEuclidGcd(GetEuclidGcd(a, b), c);
        }

        public static int EuclidGcd(params int[] args)
        {
            int result = args[0];
            for (int i = 1; i < args.Length; i++)
                result = EuclidGcd(result, args[i]);
            return result;
        }

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
        #endregion

        #region Public Stein methods
        public static int SteinGcd(int a, int b)
        {
            return GetSteinGcd(a, b);
        }

        public static int SteinGcd(int a, int b, int c)
        {
            return GetSteinGcd(GetSteinGcd(a, b), c);
        }

        public static int SteinGcd(params int[] args)
        {
            int result = args[0];
            for (int i = 1; i < args.Length; i++)
                result = SteinGcd(result, args[i]);
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
        #endregion

        #region Private methods
        private static int GetEuclidGcd(out long time, int a, int b)
        {
            var stopWatch = Stopwatch.StartNew();
            int result = GetEuclidGcd(a, b);
            time = stopWatch.ElapsedTicks;
            return result;
        }

        private static int GetEuclidGcd(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        private static int GetSteinGcd(out long time, int a, int b)
        {
            var stopWatch = Stopwatch.StartNew();
            int result = GetSteinGcd(a, b);
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return result;
        }

        private static int GetSteinGcd(int a, int b)
        {
            int shift;

            if (a == 0) return b;
            if (b == 0) return a;

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
            return a << shift;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
