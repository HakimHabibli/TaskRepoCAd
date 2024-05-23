namespace _2305Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice1();
        }
        static void Practice1() 
        {
            #region  Task1
            Console.WriteLine("Enter a Season name");
            string season = Console.ReadLine().ToLower();
            switch (season) 
            {
                case "winter":
                    Console.WriteLine("Qiş");
                    break;
                case "spring":
                    Console.WriteLine("Yaz");
                    break;
                case "summer":
                    Console.WriteLine("Yay");
                    break;
                case "fall":
                    Console.WriteLine("Payiz");
                    break;
            }
            string rSeason = season switch
            {
                "winter" => "Qiş",
                "spring" => "Yaz",
                "summer" => "Yay",
                "fall" => "Payiz",
                _ => "Olmayan mövsümü daxil etdiniz "
            };
            Console.WriteLine(rSeason);






        


            #endregion
        }
    }
}
