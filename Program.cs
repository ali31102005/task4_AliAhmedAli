using System;
using System.Buffers.Text;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp2
{
    class Program
    {
        enum DayOfWeek
        {Monday = 1, Tuesday, Wednesday,Thursday, Friday, Saturday, Sunday}
        static void Main(string[] args)
        {
            #region p1
            //int[] arr1 = new int[5];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = i + 1;
            //}
            //int[] arr2 = new int[] { 1,2,3,4,5 };
            //int[] arr3 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("arr1:");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            //Console.WriteLine("\narr2:");

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            //Console.WriteLine("\narr3:");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}
            //Console.WriteLine(arr3[5]); //IndexOutOfRangeException
            //Question: What is the default value assigned to array elements in C#? Zero
            #endregion

            #region p2

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            #region shallow copy
            //int[] arr2 = arr1;
            //Console.WriteLine("arr1:");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            //for(int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] *= 10;
            //}
            //Console.WriteLine("arr1:");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            #endregion
            #region deep copy

            //int[] arr3 = (int[]) arr1.Clone();
            //Console.WriteLine("arr1 before:");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    arr3[i] *= 10;
            //}
            //Console.WriteLine("arr1 after:");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            #endregion
            //Question: What is the difference between Array.Clone() and Array.Copy() ?
            //Clone() is a method on the array itself that creates a new array with the same contents.
            //Array.Copy() is a static method that copies elements between arrays.

            #endregion

            #region p3
            //int[][] grades = new int[3][] { new int[3], new int[3], new int[3] };
            //bool T;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine($"Enter student{i + 1} grades:");
            //    for (int j = 0; j < grades[i].Length; j++)
            //    {
            //        do
            //        {
            //            Console.Write($"subject{j + 1}: ");
            //            T = int.TryParse(Console.ReadLine(), out int g);
            //            grades[i][j] = g;
            //            if (!T) Console.WriteLine("Error, invalid input.");
            //        } while (!T);
            //    }
            //}
            //for(int i = 0; i< grades.Length;i++)
            //{
            //    Console.WriteLine($"\nStudent{i+1} grades:");
            //    for(int j = 0; j < grades[i].Length; j++)
            //    {
            //        Console.WriteLine($"subject{j+1} : {grades[i][j]}");
            //    }
            //}

            // What is the difference between GetLength() and Length for multi
            // dimensional arrays ?
            // GetLength : is a function returns the number of elements in a specific dimension of the array
            // and work for only multidimensionl arrays (rectangular array not jagged array)
            // Length: is a property returns the total number of elements in the array
            // and work for multidimensional and single dimensional arrays
            #endregion

            #region p4
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("before:");
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("after reverse:");
            //Array.Reverse(arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("after sort:");
            //Array.Sort(arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\nIndexof() output: " + Array.IndexOf(arr,5) + "\n"); // returns the index of element passed as arg to function
            //                                                                // and -1 if it is not exist



            //int[] arr2 = new int[arr.Length];
            //Array.Copy(arr, arr2, arr.Length);
            //Console.WriteLine("array2 after copy:");
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine(i);
            //}

            //Array.Clear(arr2,0,arr2.Length); // it resets elements to the default values, value types: numbers to zero,
            //                                 // boolean to false and null for reference types
            //Console.WriteLine("array2 after clear:");
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine(i);
            //}
            //What is the difference between Array.Copy() and Array.ConstrainedCopy() ?
            //copy: may leave the destination array in a partially updated state if an exception occurs during the copy
            //ConstrainedCopy: ensures that the destination array remains unmodified
            //if any part of the copy operation fails.
            #endregion

            #region p5
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr1.Length; i++) Console.WriteLine(arr1[i]);
            //Console.WriteLine();
            //foreach (int i in arr) Console.WriteLine(i);
            //int x = arr.Length - 1;
            //Console.WriteLine();
            //while (x >= 0) { Console.WriteLine(arr[x]); x--; }

            //Why is foreach preferred for read - only operations on arrays ?
            //because it is designed to iterate over elements safely and efficiently,
            //ensuring simplicity and readability while preventing accidental modification of the collection
            #endregion

            #region p6

            //int x, y = 0;
            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    int.TryParse(Console.ReadLine(), out x);
            //    y++;
            //    if (x < 0 || x % 2 == 0) Console.WriteLine("\aError,invalid input.");
            //} while (x < 0 || x % 2 == 0);

            //if (y == 1)
            //    Console.WriteLine("GOOD BOY");

            //Why is input validation important when working with user inputs? 
            // because it ensures that user inputs are correct, safe, and meet
            // the application's requirements and prevents errors
            #endregion
            #region p7
            //int[][] array = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        Console.Write(array[i][j] + "   ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion




            #region p8
            //Console.Write("Enter a month number (1-12): ");

            //int month = int.Parse(Console.ReadLine());

            //// Using if-else statement
            //string monthName;
            //if (month == 1) monthName = "January";
            //else if (month == 2) monthName = "February";
            //else if (month == 3) monthName = "March";
            //else if (month == 4) monthName = "April";
            //else if (month == 5) monthName = "May";
            //else if (month == 6) monthName = "June";
            //else if (month == 7) monthName = "July";
            //else if (month == 8) monthName = "August";
            //else if (month == 9) monthName = "September";
            //else if (month == 10) monthName = "October";
            //else if (month == 11) monthName = "November";
            //else if (month == 12) monthName = "December";
            //else monthName = "invalid input";
            //Console.WriteLine(monthName);


            //switch(month)
            //{
            //    case 1: Console.WriteLine("January");break;
            //    case 2: Console.WriteLine("February");break;
            //    case 3:
            //        Console.WriteLine("March");break;
            //    case 4:
            //        Console.WriteLine("April");break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6:
            //        Console.WriteLine("June");break;
            //    case 7:
            //        Console.WriteLine("July");break;
            //    case 8:
            //        Console.WriteLine("August");break;
            //    case 9:
            //        Console.WriteLine("September");break;
            //    case 10:
            //        Console.WriteLine("October");break;
            //    case 11:
            //        Console.WriteLine("November");break;
            //    case 12:
            //        Console.WriteLine("December");break;
            //    default: Console.WriteLine("invalid input");break;
            //};
            //Use switch when comparing a single variable against multiple constant values,
            //especially for enums or fixed sets, as it improves readability and can be more efficient.
            //Use if-else for complex, dynamic, or range - based conditions(like: <, >, <=, >=).

            #endregion

            #region p9

            //int[] arra = { 5, 3, 4, 1, 2 };
            //Array.Sort(arra);
            //Console.WriteLine("index of number 5: " + Array.IndexOf(arra, 5));
            //Question: What is the time complexity of Array.Sort() ?  O(n log n)

            #endregion
            #region p10
            //int[] a = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum += a[i];   
            //}
            //Console.WriteLine(sum);
            //sum = 0;
            //foreach (int i in a)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //Which loop(for or foreach) is more efficient for calculating the sum of an
            //array, and why ?
            //in a for loop elements are accessed directly using indices which is faster for arrays
            //because there’s no overhead of creating an enumerator.
            #endregion

            #region p11
            Console.Write("Enter a day number(1:7): ");

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            Console.WriteLine(day);
            #endregion






        }


    }
}
