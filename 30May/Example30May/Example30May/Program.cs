namespace Example30May
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 2, 3 ,5,-45,556,687,-12442};
            //ExampleArrayMaxMin(array);
            


        }
     
        static void ExampleArrayMaxMin(int[] arr) 
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) {  max = arr[i];}
                if (arr[i] < min) { min = arr[i]; }
            }
            Console.WriteLine("Maks" + max);
            Console.WriteLine("Min" + min);
        }

        static void ExampleDigitsofNumber(int num)
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
    }
}
