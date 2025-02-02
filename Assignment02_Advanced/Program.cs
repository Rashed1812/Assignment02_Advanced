using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Assignment02_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Reverse ArrayList
            //ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine("Array List Befor Reverse:");
            //foreach (var item in arrayList)
            //{
            //    Console.Write($"{item} ");
            //}
            //ReverseArrayList(arrayList);
            //Console.WriteLine("\nArray List After Reverse:");
            //foreach (var item in arrayList)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region 2.You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list

            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("List Befor Get Even Numbers:");
            //PrintList(list);

            //List<int> list1 = GetEvenNumbers(list);
            //Console.WriteLine("\nList After Get Even Numbers:");
            //PrintList(list1);

            #endregion

            #region 3.implement a custom list called FixedSizeList<T> 

            //FixedSizeList<int> list1 = new FixedSizeList<int>(4);
            //list1.Add(10);
            //list1.Add(20);
            //list1.Add(30);
            //list1.Add(40);
            //Console.WriteLine($"Elemnet Of Index 1 Is: {list1.Get(1)}");
            //list1.Add(50);
            //Console.WriteLine($"Elemnet Of Index 1 Is: {list1.Get(6)}"); 

            #endregion

            #region 4.Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1.

            //Console.WriteLine("Enter the string:");
            //string input = Console.ReadLine();

            //int index = RepeatedChar(input);

            //Console.WriteLine("Index Of First Non Repeated Char: " + index);

            #endregion

            #region 5.Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X..

            //int[] Items = { 11, 5, 3 };
            //int Nums = 3;
            //Checker(Items, Nums); 
            #endregion

            #region 6.Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //Console.WriteLine("Enter The Size Of The Array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine("Enter The Elements Of The Array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //if (Palindrome(arr))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //} 

            #endregion

            #region 7.Given an array, implement a function to remove duplicate elements from an array.

            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter the elements of the array:");
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}


            //int[] ArrayWithoutDup = RemoveDup(arr);

            //Console.WriteLine("Array without duplicate");
            //foreach (var item in ArrayWithoutDup)
            //{
            //    Console.Write($"{item} ");
            //} 

            #endregion

            #region 8. Given an array list , implement a function to remove all odd numbers from it.

            //Console.WriteLine("Enter the size of the ArrayList:");
            //int n = int.Parse(Console.ReadLine());

            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine("Enter the elements of the ArrayList:");
            //for (int i = 0; i < n; i++)
            //{
            //    arrayList.Add(int.Parse(Console.ReadLine()));
            //}
            //RemoveOddNums(arrayList);

            //Console.Write("ArrayList After Removing odd nums: ");
            //foreach (int item in arrayList)
            //{
            //    Console.Write($"{item} ");
            //} 

            #endregion

        }

        #region 1.Reverse ArrayList
        //static void ReverseArrayList(ArrayList arrayList)
        //{
        //    int start = 0;
        //    int end = arrayList.Count -1;

        //    while (start < end)
        //    {
        //        var temp = arrayList[start];
        //        arrayList[start] = arrayList[end];
        //        arrayList[end] = temp;

        //        start++;
        //        end--;
        //    }

        //} 
        #endregion

        #region 2.You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list

        //static List<int> GetEvenNumbers(List<int> list1)
        //{
        //    for (int i = 0; i < list1.Count; i++)
        //    {
        //        if (list1[i] % 2 != 0)
        //        {
        //            list1.RemoveAt(i);
        //        }
        //    }
        //    return list1;
        //}

        //static void PrintList(List<int> list1)
        //{
        //    foreach (int item in list1)
        //        Console.Write($"{item} ");
        //} 

        #endregion

        #region 4.Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1.
        static int RepeatedChar(string s)
        {
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                bool IsRepeated = false;


                for (int j = 0; j < n; j++)
                {
                    if (i != j && s[i] == s[j])
                    {
                        IsRepeated = true;
                        break; 
                    }
                }
                if (!IsRepeated)
                {
                    return i; 
                }
            }
            return -1;
        }

        #endregion

        #region 5.Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X..

        public static void Checker(int[] arr, int NumsOfQueries)
        {
            for (int i = 0; i < NumsOfQueries; i++)
            {
                Console.WriteLine("Enter Number X to Check If Number Is Greater Than Nums Of Array: ");
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    int counter = 0;
                    foreach (int num in arr)
                    {
                        if (num > x)
                            counter++;
                    }
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

        }

        #endregion

        #region 6.Given a number N and an array of N numbers. Determine if it's palindrome or not.
        static bool Palindrome(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                if (arr[left] != arr[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        #endregion

        #region 7.Given an array, implement a function to remove duplicate elements from an array.
        static int[] RemoveDup(int[] arr)
        {
            HashSet<int> NewArr = new HashSet<int>(arr);
            return NewArr.ToArray();
        }

        #endregion

        #region 8. Given an array list , implement a function to remove all odd numbers from it.
        static void RemoveOddNums(ArrayList list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if ((int)list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        } 

        #endregion

    }
}
