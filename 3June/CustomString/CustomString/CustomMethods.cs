namespace CustomString
{
    internal class CustomMethods
    {
        #region CustomUpperCase

        public static void CustomUpperCase(string str)
        {
            string newstr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                char ascii = str[i];
                if (96 < ascii && ascii < 122)
                {
                    ascii =(char)(ascii- 32);
                }
                 newstr = (newstr + ascii);
            }
            Console.WriteLine(newstr);
        }
        #endregion
        #region CustomChageSymb

        public static void CustomChangeTheSymb(string str,char oldSymb,char newSymb) 
        {
            string newstr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == oldSymb) {  newstr+= newSymb; }
                else { newstr += str[i]; }
            }
            Console.WriteLine(newstr);
        }
        #endregion
        #region ConvertToCapital
        public static void ConvertToCapitalLetter(string str) 
        {
            string newstr = string.Empty;
            char ascii = str[0];
            if (ascii > 96 && ascii < 122) { ascii = (char)(ascii - 32); }
            newstr += ascii;
            for (int i = 1; i < str.Length; i++)
            {
                newstr += str[i];
            }
            Console.WriteLine(newstr);
        }

        #endregion

    }
}