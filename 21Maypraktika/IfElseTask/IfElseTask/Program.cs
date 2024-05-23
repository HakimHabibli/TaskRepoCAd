namespace IfElseTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElse();
            IfElse2();
            IfElse3();
        }
        public static void IfElse() 
        {
            int Number;
            Number = 0;
            if (Number % 2 == 0)
            {
                Console.WriteLine("Eded cutdur");
            }
            else { Console.WriteLine("Eded tekdir"); }
        }
        public static void IfElse2() 
        {
            int Number;
            Number = -2;
            if (Number > 0) 
            {
                Console.WriteLine("Eded musbetdir");

            }
            else if (Number < 0) 
            {
                Console.WriteLine("Eded menfidir");
            }
            else
            {
                Console.WriteLine("Eded sifirdir");
            }
        }
        public static void IfElse3()
        {
            int StudentGpa;//variable declare etmek
            StudentGpa = 91;//Bir deyer menimsetmek
            if (StudentGpa > 90) { Console.WriteLine("Telebe Elacidir"); }
            else if (StudentGpa < 90 && StudentGpa > 51) { Console.WriteLine("Telebe Elaci deyil"); }
            else { Console.WriteLine("Telebe kesilib"); }

        }

    }
}
