using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasNumber = password.Any(char.IsDigit);

            if (hasUpper == true && hasLower == true && hasNumber == true)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            var end = val.Length - 1;
            var lastLetter = val[end];
            return (char)lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {

            if (divisor == 0)
            {
                return 0;
            }

            var quotent = dividend / divisor;

            return quotent;

        }

        public int LastMinusFirst(int[] nums)
        {
            var firstNumber = nums[0];
            var end = nums.Length - 1;
            var lastNumber = nums[end];
            return lastNumber - firstNumber;

        }

        public int[] GetOddsBelow100()
        {
            int[] oddNumbers = new int[50];
            int number = 0;

            for (int i = 1; i < 100; i += 2)
            {
                oddNumbers[number] = i;
                number++;  
            }
            return oddNumbers;
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            return words;

        }
    }

}
