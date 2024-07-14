namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public static void Example1() 
        {

            //If-else(else-if)
            string UserName = "admin";
            if (UserName == "admin")
            {
            }
            else
            {     
            }



        }
        public static void Example2() 
        {
          
            //Console.WriteLine( Convert.ToByte(num));
            //Console.WriteLine( Convert.ToSByte(num));
            //Console.WriteLine(Convert.ToUInt16(num));
            //Console.WriteLine(Convert.ToInt16(num));
            //Console.WriteLine(Convert.ToInt32(num));
            //Console.WriteLine(Convert.ToUInt32(num));
            //Console.WriteLine(Convert.ToInt64(num));
            //Console.WriteLine(Convert.ToUInt64(num));
            //Console.WriteLine(Convert.ToSingle(num));
            //Console.WriteLine(Convert.ToDecimal(num));
            //Console.WriteLine(Convert.ToDecimal(num));
            //Console.WriteLine(Convert.ToDouble(num));

            string num = Console.ReadLine();

            int notnum = Convert.ToInt32(num);
            
            if (notnum > 100 && notnum < 0)
            {
                Console.WriteLine("Dogru eded daxil olunmuyub");
            }
            else
            {
                Console.WriteLine(num + "Daxil etdiyiniz eded");
            }


        }
        public static void Example3() 
        {
            //Console.Write("");

        }

    }
}
/*
 
 */
