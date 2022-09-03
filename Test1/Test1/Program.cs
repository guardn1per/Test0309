using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Integer8(int A)
        {
            var firstNum = A / 10;
            var secondNum = A % 10;
            return secondNum*10 + firstNum;
        }

        public static int Integer27(int Day)
        {
            //for easier calculations I moved the days numeration to 0-6

            Day--;
            int firstJan = 5;
            return (Day + firstJan)%7 + 1;
        }


       public static int Array47(int[] array)
       {
            Array.Sort(array);

            int res = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    res++;
                }
            }
            return res;
       }

        public static int Array28(int[] array)
        {
            int min = array[1];
            for (int i = 1; i < array.Length; i += 2)
            {
                if (min > array[i])
                    min = array[i];
            }
            return min;
        }

        public static int If18((int a, int b, int c) nums)
        {
            if (nums.a == nums.b)
                return 3;
            if (nums.a == nums.c)
                return 2;
            return 1;
        }

        public static int If27(double x)
        {
            if (x < 0)
                return 0;
            if (Math.Truncate(x) % 2 == 0)
                return 1;
            return -1;
        }

        public static double For10(double N)
        {
            double result = 0;
            for (double i = 1; i <= N; i++)
            {
                result += 1 / i;
            }
            return result;
        }

        public static int While10(int N)
        {
            int res = 0;
            int Pow3 = 1;
            while(Pow3 < N)
            {
                Pow3 *= 3;
                res++;
            }
            return res;
        }
    }
}
