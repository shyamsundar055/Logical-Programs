using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum of integer
            LogicalProgramSolutions.SumOfInteger(1234);


            //Merge Two String Arrays
            string[] firstStrArray = { "a", "b", "c" };
            string[] secondStrArray = { "d", "e", "f","g","h"};
            LogicalProgramSolutions.MergeTwoArrays(firstStrArray, secondStrArray);


            //Merge Two Int Arrays
            int[] firstIntArray = { 1, 2, 3 };
            int[] secondIntArray = { 4,5,6,7,8,9,10 };
            LogicalProgramSolutions.MergeTwoArrays(firstIntArray, secondIntArray);



            //Sort an Int Array ascending
            int[] inputArray = { 4, 7, 1, 3, 2, 4, 5, 6, 0, 2, 9, 11, 100 };
            LogicalProgramSolutions.SortAnIntegerArray(inputArray,"asc");



            //Sort an Int Array ascending 
            LogicalProgramSolutions.SortAnIntegerArray(inputArray, "desc");



            //Reverse Int
            LogicalProgramSolutions.ReverseInput(1234559833644);



            //Reverse String
             LogicalProgramSolutions.ReverseInput("Shyam Sundar");



            //Identify Duplicate characters in a string with No.of occurances (case sensitive not handled) - using dictionary
            LogicalProgramSolutions.IdentifyDuplicateCharacters("shyam sundar");



            //Identify Duplicate characters in a string with No.of occurances,index postitions (case sensitive not handled)  - without dictionary
            LogicalProgramSolutions.IdentifyDuplicateCharactersWithIndex("shyam sundar");



            //Is Palindrome Number
            LogicalProgramSolutions.IsPalindromeNumber(1001);



            //Multiply Array Data
            int[] inputArrayForMultiply = { 1, 2, 3 };
            LogicalProgramSolutions.MultiplyArrayData(inputArrayForMultiply,5);

            

            //Rotate Array to right by K steps
            int[] inputRotateRightArray = { 1, 2,3,4,5,6,7 };
            LogicalProgramSolutions.RotateArrayToRight(inputRotateRightArray, 3);



            //Rotate Array to left by K steps
            int[] inputRotateLeftArray = { 1, 2, 3, 4, 5, 6, 7 };
            LogicalProgramSolutions.RotateArrayToLeft(inputRotateLeftArray, 3);
        }

        
    }
}