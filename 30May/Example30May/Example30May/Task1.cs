using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example30May
{
    internal class Task1
    {
        public static void ExampleWhile()
        {
            Console.WriteLine("1 ile 6 arasinda reqem daxil edin");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count >= 1 && count <= 6)
            {
                int[] array = new int[0];
                int random = Random.Shared.Next(1, 49);
                while (count != 0)
                {
                    while (array.Contains(random))
                    {
                        random = Random.Shared.Next(1, 49);

                    }
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = random;
                    count--;
                }
                Console.WriteLine(string.Join(' ', array));
            }
            else
            {
                Console.WriteLine("Dogru sayi daxil etmediniz ");

            }
        }
        public static void ExampleDoWhile(string UserName, string Password)
        {
            Console.Write("UserName daxil ediniz : ");
            string userName = Console.ReadLine();
            Console.Write("Password daxil ediniz : ");
            string password = Console.ReadLine();
            do
            {
                if (userName != UserName || password != Password)
                {
                    Console.WriteLine("Yanlis password yada UserName");
                }
                else
                {
                    Console.WriteLine("Daxil oldunuz");
                    break;
                }


            } while (userName != UserName && password != Password);
        }
        public static void ExampleForeach(int[] arr)
        {
            int[] evenArr = new int[0];
            int[] anotherNumbersArr = new int[0];
            int count = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 0 || item % 3 == 0)
                {
                    count++;
                }
                if (item % 2 == 0)
                {
                    Array.Resize(ref evenArr, evenArr.Length + 1);
                    evenArr[evenArr.Length - 1] = item;
                }
                else
                {
                    Array.Resize(ref anotherNumbersArr, anotherNumbersArr.Length + 1);
                    anotherNumbersArr[anotherNumbersArr.Length - 1] = item;
                }
            }
            Console.WriteLine("2 və 3ə bölünənlərin sayısı :" + count);
            Console.WriteLine($"Diger reqemler {string.Join(',', anotherNumbersArr)} || Cut reqemler {string.Join(',', evenArr)}");

        }
        public static void ExampleSquare(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(new string('x', num));
            }
        }
        public static void ExampleTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(new string('x', i));
            }
        }

        public static void ExampleMultiplication()
        {
            int sum = 1;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    sum = i * j;
                    Console.WriteLine($"{i} * {j} = {sum}", i, j, sum);
                }
                Console.WriteLine(new String('-', 10));
            }

        }
        public static void ExampleRandom()
        {

            Random random = new Random();
            int randomNumber = random.Next(9999999, 99999999);
            Console.Write("Sizin daxil etmeli oldugunuz kod:");
            Console.WriteLine(randomNumber);
            for (int i = 3; i >= 0; i--)
            {
                if (i > 0)
                {
                    int enter = Convert.ToInt32(Console.ReadLine());
                    if (enter == randomNumber) { Console.WriteLine("Dogru daxil etdiniz"); break; }
                    else if (enter != randomNumber)
                    {
                        Console.WriteLine("Dogru daxil etmediniz qalan haqqiniz :" + (i - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Deneme haqqiniz bitdi");
                    Thread.Sleep(10000);
                }
            }
        }
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
        public static void ExampleArrayMaxMin(int[] arr)
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
        public static void ExampleOddOrEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) { Console.WriteLine("Ədəd cütdür " + arr[i]); }
                else { Console.WriteLine("Ədəd təkdir " + arr[i]); }
            }
        }

    }
}
