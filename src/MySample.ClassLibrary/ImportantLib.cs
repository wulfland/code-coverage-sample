using System;

namespace MySample.ClassLibrary
{
    public class ImportantLib
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static int PartiallyTestedCode(int x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return x * -1;
            }
        }
    }
}
