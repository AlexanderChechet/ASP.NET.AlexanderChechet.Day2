using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class TypeWithGCD
    {
        public static int GetGcd(out TimeSpan time, int a, int b)
        {
            var start = DateTime.Now;
            if (a == 0 || b == 0)
                throw new ArgumentException();
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

        public static int GetGcd(out TimeSpan time, int a, int b, int c)
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
            int result = GetGcd(out timeSpan, a, b);
            result = GetGcd(out timeSpan , result, c);
            time = new TimeSpan(DateTime.Now.Ticks - start.Ticks);
            return result;
        }

        public static int GetGcd(out TimeSpan time, params int[] args)
        {
            var start = DateTime.Now;
            int result = args[0];
            var timeSpan = new TimeSpan();
            for (int i = 1; i < args.Length; i++)
            {
                result = GetGcd(out timeSpan, result, args[i]);
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
