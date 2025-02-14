using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

           // int result = numbers.Where(x => x % 2 ==0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
           // return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0) return false; // Handle edge cases
        
            int nullCount = objs.Count(obj => obj == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0; // Handle edge cases

            var evens = numbers.Where(n => n % 2 == 0);

            return evens.Any() ? evens.Average() : 0; // Compute average or return 0 if no evens
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be non-negative.");

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
