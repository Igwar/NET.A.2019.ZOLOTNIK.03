using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToIEEE754Lib
{
    public static class IEE754
    {
        /// <summary>
        /// The method of finding IEEE754 format for double variables
        /// </summary>
        /// <param name=" a">double variable</param>
        /// 
        public static string ConvertIEE754(this double a)
        {
            string str = "";
      
        
            if (a == 0)
                return "0000000000000000000000000000000000000000000000000000000000000000";
            

         
            if (a > 0)
                str = str + '0';
            else
                str = str + '1';
            String strin2 = convertto2(a);
            String[] strmas = strin2.Split('.');
            int g = 1023 + (strmas[0].Length - 1);
            string convertoto127 = convertto2(g);
            strmas = convertoto127.Split('.');
            str = str + strmas[0];
            for (int i = 1; i <= (8 - strmas[0].Length); i++)
            {
                str = str + "0";

            }
            strmas = strin2.Split('.');
            for (int i = 1; i <= strmas[0].Length - 1; i++)
            {

                str = str + strmas[0][i];
            }
            str = str + strmas[1];
            for (int i = 1; i <= (55- (strmas[0].Length + strmas[1].Length)); i++)
            {
                str = str + "0";

            }



            if (str.Length > 64)
            {
                str = str.Remove(63, str.Length - 64);
            }
            return str;

        }

         static String convertto2( double a)
        {
            String str = "";
            String str2 = "";
            if (a < 0)
            {
                a = a * -1;
            }
            string str1 = a.ToString();
            string[] strmas = str1.Split(',');
            double k = Convert.ToDouble(strmas[0]);
            double d = a - k;
            int g = 0;
            double f = Math.Pow(2, g);
            while (k > f)
            {
                g = g + 1;
                f = Math.Pow(2, g);
            }
            g--;
            for (int i = 0; i <= g; i++)
            {
                if ((int)k % 2 == 0)
                    str = str + '0';
                else
                    str = str + '1';
                k = k / 2;

            }
            for (int i = 0; i < 45; i++)
            {
                d = (d * 2);

                if ((int)d == 1)
                {
                    str2 = str2 + '1';
                    d = d - 1;
                }
                else
                    str2 = str2 + '0';

            }

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = new string(arr);

            str = str + "." + str2;
            return str;
        }
    }
}
