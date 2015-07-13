using System;

namespace Task3
{
    public static class Gcd
    {
        public static int GetEuclidGcd(out TimeSpan time, int a, int b)
        {
            var start = DateTime.Now;
            if (a == 1 || b == 1)
            {
                time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
                return 1;
            }

            while (b != 0)
            {
                int t = b;
                b = a%b;
                a = t;
            }
            time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            return a;
        }

        public static int GetEuclidGcd(out TimeSpan time, int a, int b, int c)
        {
            var start = DateTime.Now;
            if (a == 1 || b == 1 || c == 1)
            {
                time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
                return 1;
            }
            var timeSpan = new TimeSpan();
            int result = GetEuclidGcd(out timeSpan, a, b);
            result = GetEuclidGcd(out timeSpan , result, c);
            time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            return result;
        }

        public static int GetEuclidGcd(out TimeSpan time, params int[] args)
        {
            var start = DateTime.Now;
            int result = args[0];
            var timeSpan = new TimeSpan();
            for (int i = 1; i < args.Length; i++)
            {
                result = GetEuclidGcd(out timeSpan, result, args[i]);
                if (result == 1)
                {
                    time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
                    return 1;
                }
            }
            time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            return result;
        }

        public static int GetBinaryGcd(out TimeSpan timeSpan, int a, int b)
        {
            var start = DateTime.Now;
            int shift;


            if (a == 0)
            {
                timeSpan = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
                return b;
            }
            if (b == 0)
            {
                timeSpan = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
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
            timeSpan = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            return a << shift;
        }

        public static int GetBinaryGcd(out TimeSpan time, int a, int b, int c)
        {
            var start = DateTime.Now;
            if (a == 0 || b == 0 || c == 0)
                throw new ArgumentException();
            if (a == 1 || b == 1 || c == 0)
            {
                time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
                return 1;
            }
            var timeSpan = new TimeSpan();
            int result = GetBinaryGcd(out timeSpan, a, b);
            result = GetBinaryGcd(out timeSpan, result, c);
            time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            return result;
        }

        public static int GetBinaryGcd(out TimeSpan time, params int[] args)
        {
            var start = DateTime.Now;
            int result = args[0];
            var timeSpan = new TimeSpan();
            for (int i = 1; i < args.Length; i++)
            {
                result = GetBinaryGcd(out timeSpan, result, args[i]);
                if (result == 1)
                {
                    time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
                    return 1;
                }
            }
            time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
