using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class DivideTest
    {
        [TestMethod]
        public void Should_Result_3()
        {
            Assert.AreEqual(3, Divide(10, 3));
            Assert.AreEqual(-2, Divide(7, -3));
            Assert.AreEqual(-1073741824, Divide(-2147483648, 2));

        }

        [TestMethod]
        public void Should_Result_0()
        {
            Assert.AreEqual(0, Divide(0, 3));
        }


        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0)
            {
                return 0;
            }

            if (divisor == 1)
            {
                return dividend;
            }

            if (divisor == -1)
            {
                if (dividend > int.MinValue)
                {
                    return -dividend;
                }

                return int.MaxValue;
            }

            var symbol = 1;

            if (dividend > 0 && divisor < 0
                || dividend < 0 && divisor > 0)
            {
                symbol = -1;
            }

            long dividend1 = Math.Abs((long)dividend);
            long divisor1 = Math.Abs((long)divisor);

            long result = Div(dividend1, divisor1);
            if ( symbol >0)
            {
                return result > int.MaxValue? int.MaxValue: (int)result;
            }
            
            return -(int)result;
        }

        private static long Div(long dividend, long divisor)
        {
            if (divisor > dividend)
            {
                return 0;
            }

            int count = 1;
            long backDivisor = divisor;
            while (backDivisor + backDivisor <= dividend)
            {
                count += count;
                backDivisor += backDivisor;
            }

            return count + Div(dividend - backDivisor, divisor);
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Introduction()
        {
            Console.WriteLine($"I am {Name}, Age:{Age}!");
        }
    }

    public class Student : Person {}
    
    public class Teacher : Person{}
}