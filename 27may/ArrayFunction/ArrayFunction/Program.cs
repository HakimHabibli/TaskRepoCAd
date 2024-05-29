namespace ArrayFunction
{
	internal class Program 
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1,1};
            cSimpleOrComplex(numbers);



            //Console.WriteLine("Zehmet olmasa eded daxil edin");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Simple(n);
        }

        #region SimpleOrComplex

        static void cSimpleOrComplex(int[] num)
        {
            int[] simpleNum = new int[0];
            int[] complexNum = new int[0];
            int time = 2;
            int count = 2;
            for (int i = 0; i < num.Length; i++)
            {
                
                if (num[i] % time != 0)
                {
                    Array.Resize(ref simpleNum, simpleNum.Length + 1);
                    simpleNum[simpleNum.Length - 1] = num[i];
                }
                else
                {
                    Array.Resize(ref complexNum, complexNum.Length + 1);
                    complexNum[complexNum.Length - 1] = num[i];
                }
            }
            for (int j = 0; j < simpleNum.Length; j++)
            {
                Console.WriteLine("Simple Number in Your Array : {0}",simpleNum[j]);

            }
            for (int j = 0; j < complexNum.Length; j++)
            {
                Console.WriteLine("Complex Number in Your Array : {0}", complexNum[j]);

            }
            //string.Join Chatgpt tapdim
            //Console.WriteLine("Simple Array: {0}", string.Join(", ", simpleNum));
            //Console.WriteLine("Complex Array: {0}", string.Join(", ", complexNum));
        }
        static void Simple(int num)
        {
            int time = 2;
            int count = 2;
            while (num / 2 + 1 != time)
            {
                if (num % time == 0)
                {
                    time++;
                    count++;

                }
                else
                {
                    time++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("number is simple");
            }
            else
            {
                Console.WriteLine("number is complex");
            }
        }
        #endregion



        #region Sorting

        static void cSort(int[] num)
		{
			int min;
			min = num[0];
			for (int i = 0; i < num.Length; i++)
			{
				for (int j = 0; j < num.Length; j++)
				{
					int[] numberArray = new int[i];
					if (min > num[j]) min = num[j];
					Console.WriteLine(min);
				}
			}
		}
        #endregion



        #region FindMinumumIndexNumber

        static void cMinumumIndex(int[] num)
		{
			int min;
			min = num[0];
			for (int i = 0; i < num.Length; i++)
			{

				if (min > num[i]) min = num[i];

			}
			int index = Array.IndexOf(num, min);
            Console.WriteLine("en kicik index" + index);
            Console.WriteLine("En kicik eded" + min);

		}
        #endregion




        #region AvarageNumberInArray

        static void cAvarage(int[] num) 
		{
			int sum=0;
			double avarage;
			for (int i = 0; i < num.Length; i++) 
			{
				sum=sum+num[i];
			
			}
			avarage=sum/num.Length;
			Console.WriteLine(avarage);
		}
        #endregion





    }
}
