using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Session_04_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 straight line

            /*
            int x1, y1, x2, y2, x3, y3;

            Console.WriteLine("Please Enter first point");
            Console.WriteLine($"x{1} = ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"y{1} = ");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter second point");
            Console.WriteLine($"x{2} = ");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"y{2} = ");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter third point");
            Console.WriteLine($"x{3} = ");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"y{3} = ");
            y3 = int.Parse(Console.ReadLine());

            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y1) / (x3 - x1);
            if (slope1 == slope2)
                Console.WriteLine("lie on a single straight line");
            else
                Console.WriteLine("Not lie on a single straight line");
            */
            #endregion
            #region Q2 efficiency of a worker

            /*
            double duration;
            Console.WriteLine("Please Enter Duration to complete task : ");
            duration = double.Parse(Console.ReadLine());
            if (duration >= 2 && duration < 3)
                Console.WriteLine("highly efficient");
            else if (duration >= 3 && duration < 4)
                Console.WriteLine("instructed to increase their speed");
            else if (duration >= 4 && duration < 5)
                Console.WriteLine("provided with training to enhance their speed");
            else if (duration >= 5)
                Console.WriteLine("required to leave the company");
            */
            #endregion
            #region Q3 identity matrix 

            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
                #endregion
            }
            */
            #endregion
            #region Q20 sum of all elements

            /*
            int n;
            Console.WriteLine("Enter Size of the array : ");
            Console.Write("size = ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i+1}'s element : ");
                arr[i] = int.Parse(Console.ReadLine()) ;
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
               sum += arr[i] ;  
            }
            Console.WriteLine($"The sum of the array elements = {sum}");
            */
            #endregion
            #region Q21 merge 

            /*
            Console.Write("Enter the size of the arrays: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            Console.WriteLine("\nEnter elements of the first array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1}'s element : ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEnter elements of the second array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1}'s element : ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] mergedArr = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                mergedArr[i] = arr1[i];
            }
            for (int i = 0; i < n; i++)
            {
                mergedArr[n + i] = arr2[i];
            }
            Array.Sort(mergedArr);

            foreach (int num in mergedArr)
            {
                Console.Write(num + " ");
            }
            */
            #endregion
            #region Q23 maximum and minimum element 
            /*
            int n;
            Console.WriteLine("Enter Size of the array : ");
            Console.Write("size = ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[10];
            int max = -1;
            int min = 999999999;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1}'s element : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"Max element in the array =  {max}");
            Console.WriteLine($"Min element in the array =  {min}");
            */
            #endregion
            #region Q24 second largest element 
            /*
            int n;
            Console.WriteLine("Enter Size of the array : ");
            Console.Write("size = ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[10];
            int max = -1;
            int secondLargest = -1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1}'s element : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    secondLargest = max;
                    max = arr[i];
                }
                   
                
            }
            Console.WriteLine($"Max element in the array =  {max}");
            Console.WriteLine($"Second Largest element in the array =  {secondLargest}");
            */
            #endregion
            #region Q25
            #endregion
            #region Q26 reverse the order of words
            /*
            string s = Console.ReadLine();
            string[] words =s.Split(" ");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
            */
            #endregion
            #region Q27 
            /*
            int rows, columns;
            Console.Write("number of rows =");
            rows = int.Parse(Console.ReadLine());

            Console.Write("number of columns =");
            columns = int.Parse(Console.ReadLine());

            int[,] arr1 = new int[rows, columns];
            int[,] arr2 = new int[rows, columns];

            Console.WriteLine("\nEnter values for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter value for [{i},{j}]: ");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr2[i, j] = arr1[i, j];
                }
            }
            Console.WriteLine("\nElements of the second array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region Q28 Reverse Array
            /*
            int n;
            Console.WriteLine("Enter Size of the array : ");
            Console.Write("size = ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i + 1}'s element :");
                arr[i] = int.Parse(Console.ReadLine());
            }


            static int [] reverseArray(int[] arr)
            {
                int [] ReversedArray = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                   ReversedArray[arr.Length-i-1] = arr[i];
                }

                return ReversedArray;
            }

            int[] ReversedArray = reverseArray(arr);
            Console.WriteLine($"Array After Reversing : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ReversedArray[i]} ");
            }
            */
            #endregion
            /*------------------------------------------- Functions -----------------------------------------------------*/
            #region Q1
            /*
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            static void PassByValue(int x)
            {
                x = 20;
            }

            static void PassByReference(ref int x)
            {
                x = 20;
            }
            Console.WriteLine($"a before pass by value = {a}");
            PassByValue(a);
            Console.WriteLine($"a after pass by value = {a}");

            Console.WriteLine($"a before pass by reference = {a}");
            PassByReference(ref a);
            Console.WriteLine($"a after pass by reference = {a}");
            */
            #endregion
            #region Q2
            /*
            Console.Write("Name = ");
            string name =Console.ReadLine();

            static void PassByValue(string x)
            {
                x = "Ahmed";
            }

            static void PassByReference(ref string x)
            {
                x = "Ahmed";
            }
            Console.WriteLine($"name before pass by value = {name}");
            PassByValue(name);
            Console.WriteLine($"a after pass by value = {name}");

            Console.WriteLine($"a before pass by reference = {name}");
            PassByReference(ref name);
            Console.WriteLine($"a after pass by reference = {name}");

            #endregion
            #region Q3 Summation_And_Subtraction
            /*
            Console.Write("Enter the first number: ");
            int num1 =int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum, difference;
            static void calculate(int num1, int num2, out int sum, out int difference)
            {
                sum = num1 + num2;
                difference = num1 - num2;
            }
            calculate(num1, num2, out sum, out difference);

            Console.WriteLine($"Summation = {sum}");
            Console.WriteLine($"Difference = {difference}");
            */
            #endregion
            #region Q4 DigitSum
            /*
            int n;
            Console.Write("Number = ");
            n = int.Parse(Console.ReadLine());


            static int DigitSum(int n)
            {
                int sum = 0;
                string str = n.ToString();

                for (int i = 0; i < str.Length; i++)
                {
                    sum += (n % 10);
                    n /= 10;

                }
                return sum;
            }
            int sum = DigitSum(n);
            Console.WriteLine($"The sum of digits of number {n} = {sum}");
            */
            #endregion
            #region Q5 IsPrime
            /*
            int n;
            Console.Write("Number = ");
            n = int.Parse(Console.ReadLine());


            static bool IsPrime(int n)
            {
                bool isPrime = true;
                for (int i = 2; i < n; i++)
                {
                    if (n%i==0)
                    { 
                        isPrime = false;
                        break;
                    }

                }
                return isPrime;
            }
            if(IsPrime(n)) 
                Console.WriteLine($"{n} is prime number");
            else
                Console.WriteLine($"{n} is not prime number");
            */
            #endregion
            #region Q6 MinMaxArray
            /*
            int n;
            Console.WriteLine("Enter Size of the array : ");
            Console.Write("size = ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1}'s element : ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            static void MinMaxArray(ref int[] arr,ref int min , ref int max)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                        max = arr[i];
                    else if (arr[i] < min)
                        min = arr[i];

                }

                return ;
            }
            int min = 99999999;
            int max = 0;
            MinMaxArray(ref arr,ref min, ref max);
            Console.WriteLine($"Max element in the array =  {max}");
            Console.WriteLine($"Min element in the array =  {min}");
            */
            #endregion
            #region Q7 Factorial
            /*
            int number = 0;
            Console.WriteLine("Enter number you want to claculate factorial of :");
            Console.Write("number = ");
            number = int.Parse(Console.ReadLine());
            static int Calcfactorial (int number)
            {
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
            int factorial = Calcfactorial(number);
            Console.WriteLine($"Factorial of number {number} = {factorial}");
            */
            #endregion
            #region Q8 ChangeChar
            /*
            Console.Write("Enter String you want to modify: ");
            string oldStr = Console.ReadLine();

            int position;
            Console.Write("Enter position of char you want to modify: ");
            position = int.Parse(Console.ReadLine());

            char newChar;
            Console.Write("Enter new char: ");
            newChar = char.Parse(Console.ReadLine());

            static string ChangeChar(string s, int position, char newChar)
            {
                char[] charArray = s.ToCharArray();

                if (position >= 0 && position < charArray.Length)
                {
                    charArray[position] = newChar; 
                }
                else
                {
                    Console.WriteLine(" position out of index");
                }
                return   new string(charArray);
            }

            string newStr = ChangeChar(oldStr, position, newChar);
            Console.WriteLine($"New String is: {newStr}");
            */
            #endregion
        }
    }
}