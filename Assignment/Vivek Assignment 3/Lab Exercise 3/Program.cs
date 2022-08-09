using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    int[] arr = new int[10];
            //    int i;
            //    Console.WriteLine("-----Read and Print elements of an array:-------");
            //    Console.WriteLine("-----------------------------------------");

            //    Console.WriteLine("Input 10 elements in the array : ");
            //    for (i = 0; i < 10; i++)
            //    {
            //        Console.Write("element -> {0} : ", i);
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.Write("\nElements in array are: ");
            //    for (i = 0; i < 10; i++)
            //    {
            //        Console.Write("{0}  ", arr[i]);
            //    }
            //    Console.Write("\n");
            //Console.ReadLine();

            //Console.WriteLine("Enter length of number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter value at index " + i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Entered Array: ");
            //foreach (int a in arr)
            //{
            //    Console.Write(a + " ");
            //}
            //Console.WriteLine("\nReversed Array: ");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.ReadLine();

            //Console.WriteLine("Enter length of number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter value at index " + i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Entred Array");
            //foreach (int a in arr)
            //{
            //    Console.Write(a + " ");
            //    sum = sum + a;
            //}
            //Console.WriteLine("\nSum of Array= " + sum);
            //Console.ReadLine();

            //int[] arr = new int[5] { 11, 21, 35, 47, 54 };
            //int[] arr2 = new int[arr.Length];
            //Console.WriteLine("Given Array= ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //    arr2[i] = arr[i];
            //}
            //Console.WriteLine("\nCopied Array");
            //foreach (int a in arr2)
            //{
            //    Console.Write(a + " ");
            //}
            //Console.ReadLine();

            //int[,] arr = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Enter the value of arr[" + i + "][" + j + "] - ");
            //        arr[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.Write("Array----");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("\nValue of array[" + i + "][" + j + "] = " + arr[i, j]);
            //    }
            //}
            //Console.ReadLine();

            //int[,,] arr = new int[2, 2, 2] { { { 12, 19 }, { 33, 42 } }, { { 59, 63 }, { 72, 85 } }, };
            //Console.Write("------Array----");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            Console.WriteLine("\nValue of array=> [" + i + "," + j + "," + k + "] = " + arr[i, j, k]);
            //        }
            //    }
            //}
            //Console.ReadLine();

            int n = 2;
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter the size of array at index " + i + " in jagged array! - ");
                int k = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[k];
                for (int j = 0; j < k; j++)
                {
                    Console.Write("Enter the value of arr[" + i + "][" + j + "] - ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("-------Array----");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {

                    Console.WriteLine("\nValue of array[" + i + "," + j + "] => " + arr[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
