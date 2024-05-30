
namespace Example30May
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 0, 2, 3, 5, -45, 556, 687, -12442 };

            //Task1.ExampleDigitsofNumber(21);
            //ExampleSquare(6);
            //ExampleTriangle(6);
            //ExampleMultiplication();
            ExampleRandom();
        }

        static void ExampleSquare(int num) 
        {
            for (int i = 0; i < num; i++)
            {
                    Console.WriteLine(new string ('x',num));
            }
        }
        static void ExampleTriangle(int num) 
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(new string('x',i));
            }
        }

        static void ExampleMultiplication() 
        {
            int sum = 1;
            for (int i = 1; i < 10; i++) 
            {
                for (int j = 1; j < 10; j++)
                {
                    sum=i*j;
                    Console.WriteLine($"{i} * {j} = {sum}",i,j,sum);
                }
                Console.WriteLine(new String('-',10));
            }

        }
        static void ExampleRandom() 
        {

            Random random = new Random();
            int randomNumber = random.Next(9999999,99999999);
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
                        Console.WriteLine("Dogru daxil etmediniz qalan haqqiniz :" + (i-1));
                    }
                }
                else
                {
                    Console.WriteLine("Deneme haqqiniz bitdi");
                    Thread.Sleep(10000);
                }
            }

        }
        static void ExampleForeach(int[] arr) 
        {
            int count =0;
            foreach (int item in arr)
            {
                if (item % 2 == 0 || item % 3 == 0) 
                {
                        count++;
                }

            }
        
        }





    }
}
