using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example30May
{
    internal class Task1
    {
        public static void ExampleDigitsofNumber(int num)
        {
            int number = 0;
            int sum = 0;
            int count = 0;
            while (num != 0)
            {
                number = num % 10;
                num = num / 10;
                sum = sum + number;
                count++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
        }
        static void ExampleArrayMaxMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) { max = arr[i]; }
                if (arr[i] < min) { min = arr[i]; }
            }
            Console.WriteLine("Maks" + max);
            Console.WriteLine("Min" + min);
        }
        static void ExampleOddOrEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) { Console.WriteLine("Ədəd cütdür " + arr[i]); }
                else { Console.WriteLine("Ədəd təkdir " + arr[i]); }
            }
        }
    }
}
