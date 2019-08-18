using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDLib
{
    public static class GCD
    {
        /// <summary>
        /// The method of finding the GCD of several numbers by the Euclidean algorithm
        /// </summary>
        /// <param name="time">The time taken for the method to work</param>
        /// <param name="a">several numbers</param>
        public static int GCDEuclidean(out long time,params int[] a)
        {
            time = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            List<int> b = a.ToList();
            for (int i = 0; i < b.Count; i++)
            {

                if (b[i] < 0)
                    b[i] = b[i] * -1;
                if (b[i] == 0)
                    b.Remove(b[i]);

            }
            a = b.ToArray();
            if (a.Length == 0) {

                throw new Exception("In array was only 0");
            }
            for (int i = 0; i <= a.Length - 2; i++)
            {

                while (a[i] != a[i + 1])
                {
                    if (a[i] > a[i + 1])
                    {
                        a[i] = a[i] - a[i + 1];
                    }
                    else
                    {
                        a[i + 1] = a[i + 1] - a[i];
                    }
                }

            }
            watch.Stop();
            time = watch.ElapsedMilliseconds;
            return a[a.Length - 1];

        }
        /// <summary>
        /// The method of finding the GCD of several numbers by the Stein algorithm
        /// </summary>
        /// <param name="time">The time taken for the method to work</param>
        /// <param name="a">several numbers</param>
        public static int SteinGCD(out long time,params int[] a)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            int gcd = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                gcd = SteinGCDfor2(gcd, a[i + 1]);
            }
            watch.Stop();
            time = watch.ElapsedMilliseconds;
            return gcd;
        }
        private static int SteinGCDfor2(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else if (b == 0)
            {
                return a;
            }

            int k = 1;
            a = Math.Abs(a);
            b = Math.Abs(b);
            while ((a != 0) && (b != 0))
            {
                while ((a % 2 == 0) && (b % 2 == 0))
                {
                    a /= 2;
                    b /= 2;
                    k *= 2;
                }

                while (a % 2 == 0)
                {
                    a /= 2;
                }

                while (b % 2 == 0)
                {
                    b /= 2;
                }

                if (a >= b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return b * k;
        }
    }
}
