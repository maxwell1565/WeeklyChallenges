﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           var arrayLength = vals.Length;
           if (arrayLength % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
               return Enumerable.Sum(numbers);
            }
            return 0;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;

            }
            return numbers.Where(nums => nums % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            return (numbers.Sum() % 2 != 0);
        }

        public double CountOfPositiveOddsBelowNumber(long number)
        {

            if (number <= null)
            {
                return 0;
            }

            int count = 0;

            for (int i = 1; i < number; i++)
            {

                if (i % 2 != 0 && i > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
