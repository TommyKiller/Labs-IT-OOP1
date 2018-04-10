using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static char[] operands = { '+', '*', '/', '-' };
        static char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static string[] Parse(string instring, char[] separators)
        {
            string[] tempArray = instring.Split(separators);
            int counter = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] != "") counter++;
            }
            string[] resultArray = new string[counter];
            for (int i = 0, j = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] != "") resultArray[j++] = tempArray[i];
            }
            return resultArray;
        }

        static void Calculate(ref int result, string[] inOps, string[] inNums, int i = 0, int j = 1)
        {
            switch (inOps[i])
            {
                case "+":
                    result += Convert.ToInt32(inNums[j], 10);
                    break;
                case "-":
                    result -= Convert.ToInt32(inNums[j], 10);
                    break;
                case "*":
                    result *= Convert.ToInt32(inNums[j], 10);
                    break;
                case "/":
                    result /= Convert.ToInt32(inNums[j], 10);
                    break;
            }
            if (i < inOps.Length - 1)
            {
                Calculate(ref result, inOps, inNums, i + 1, j + 1);
            }
        }

        static void FullfillList(ref List<char> list, char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
        }

        static bool CheckInput(char[] array, char[] operands, char[] nums)
        {
            List<char> tempList = new List<char>();
            FullfillList(ref tempList, operands);
            FullfillList(ref tempList, nums);
            for (int i = 0; i < array.Length; i++)
            {
                if (!tempList.Contains(array[i])) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string userString;
            while (true)
            {
                Console.Write("Input the sequence: ");
                userString = Console.ReadLine();
                if (userString == "exit") break;
                if (CheckInput(userString.ToCharArray(), operands, nums))
                {
                    string[] inputNums = Parse(userString, operands);
                    string[] inputOperands = Parse(userString, nums);
                    int result = Convert.ToInt32(inputNums[0], 10);
                    Calculate(ref result, inputOperands, inputNums);
                    Console.WriteLine("Result is: " + result);
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }
        }
    }
}
