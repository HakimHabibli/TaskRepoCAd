namespace ArrayFunction
{
	internal class Program : ProgramBase
	{
		static void Main(string[] args)
		{
			int[] numbers = { 5,25,30 };
			cAvarage(numbers);
		}
		static void CSort(int[] num)
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
		static void cSimpleOrComplex(int[] num)
		{
			int[] simpleNum;
			int[] complexNum;
			int j = 0;
			int c = 0;
			for (int i = 0; i < num.Length; i++)
			{
				if ()
				{

				}
				else
				{

				}
			}
		}
	}
}
