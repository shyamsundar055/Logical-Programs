using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class LogicalProgramSolutions
    {
        /// <summary>
        /// Sum of integer
        /// </summary>
        /// <param name="input"></param>
        public static void SumOfInteger(int input)
        {
            string numStr = input.ToString();

            Console.WriteLine($"SumOfInteger : {numStr}");

            int output = 0;

            foreach (char ch in numStr)
            {
                //Option 1
                output += (ch - '0');

                //Option 2
                //output += (int)char.GetNumericValue(ch);

                //Option 3
                //output += int.Parse(ch.ToString());

                //Option 4
                //output += CharUnicodeInfo.GetDecimalDigitValue(ch);
            }

            Console.WriteLine($"Output : {output}\n");
        }

        /// <summary>
        /// Merge two arrays using generics
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        public static void MergeTwoArray<T>(T[] firstArray, T[] secondArray)
        {
            Console.WriteLine($"MergeTwoArray {typeof(T)} : First Array = {string.Join(" ", firstArray)} , Second Array = {string.Join(" ", secondArray)} ");

            T[] outputArray = new T[firstArray.Length + secondArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                outputArray[i] = firstArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                outputArray[firstArray.Length + i] = secondArray[i];
            }

            Console.WriteLine($"Output : {string.Join(" ", outputArray)}\n");
        }

        /// <summary>
        /// Sort an Integer Array
        /// </summary>
        /// <param name="inputArray"></param>
        public static void SortAnIntegerArray(int[] inputArray, string orderType)
        {
            Console.WriteLine($"SortAnArray - Order by {orderType}: {string.Join(" ", inputArray)}");

            for (int i = 0; i < inputArray.Length; i++)
            {

                int pickerValue = inputArray[i];

                int newPickerPosition = i;
                int newPickerValue = inputArray[i];

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    //TODO: Try delegate function for asc or desc comparison
                    if (orderType == "asc" && inputArray[j] < newPickerValue)
                    {
                        newPickerValue = inputArray[j];
                        newPickerPosition = j;
                    }
                    else if (orderType == "desc" && inputArray[j] > newPickerValue)
                    {
                        newPickerValue = inputArray[j];
                        newPickerPosition = j;
                    }
                }

                inputArray[i] = newPickerValue;
                inputArray[newPickerPosition] = pickerValue;
            }

            Console.WriteLine($"Output : {string.Join(" ", inputArray)}\n");
        }

        /// <summary>
        /// ReverseInput
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        public static void ReverseInput<T>(T input)
        {
            Console.WriteLine($"Reverse {typeof(T)} : {input.ToString()}");

            string inputValue = input.ToString();
            string output = "";

            for (int i = inputValue.Length - 1; i > -1; i--)
            {
                output += inputValue[i];
            }

            Console.WriteLine($"Output : {output}\n");
        }

        /// <summary>
        /// IdentifyDuplicateCharacters
        /// </summary>
        /// <param name="input"></param>
        public static void IdentifyDuplicateCharacters(string input)
        {
            Console.WriteLine($"IdentifyDuplicateCharacters with Dictionary : {input}");

            Dictionary<char, int> charDetails = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (charDetails.ContainsKey(character))
                {
                    charDetails[character] += 1;
                }
                else
                {
                    charDetails.Add(character, 1);
                }
            }

            Console.WriteLine($"Output :");
            foreach (var item in charDetails)
            {
                Console.WriteLine($"{item.Key} - {item.Value} ");
            }
        }

        /// <summary>
        /// IdentifyDuplicateCharactersWithIndex
        /// </summary>
        /// <param name="input"></param>
        public static void IdentifyDuplicateCharactersWithIndex(string input)
        {
            Console.WriteLine($"\nIdentifyDuplicateCharacters without Dictionary : {input}");

            var charList = input.ToCharArray();

            Console.WriteLine($"Output :");

            for (int i = 0; i < charList.Length; i++)
            {
                if (charList[i] != ' ')
                {
                    char character = charList[i];
                    int count = 1;
                    string indexPostitions = $"{i},";

                    for (int j = i + 1; j < charList.Length; j++)
                    {
                        if (charList[j] != ' ' && char.Equals(charList[i], charList[j]))
                        {
                            count++;
                            charList[j] = ' ';
                            indexPostitions += $"{j},";
                        }
                    }

                    Console.WriteLine($"{character} - count:{count},index positions:{indexPostitions} ");
                }
            }
        }

        /// <summary>
        /// IsPalindromeNumber
        /// </summary>
        /// <param name="input"></param>
        public static void IsPalindromeNumber(int input)
        {
            Console.WriteLine($"\nIsPalindromeNumber : {input}");

            int tempNumber = input;

            int remainder, reverseNumber = 0;

            while (input > 0)
            {
                remainder = input % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                input /= 10;
            }

            Console.WriteLine($"Given number is{(tempNumber == reverseNumber ? "" : "not")} a Palindrome");
        }
    }
}
