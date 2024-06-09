//BenchmarkRunner.Run<Program>();
/*
    RoadMap 
   Step-1 : Int tipi üçün CResize methodu
   Step-2 : MethodOverload(Bir reqem daxil etmek ucun) + Garbage Collector 
   Step-3 : Methodu Generic etmek
   Step-4 : Validation
   Step-5 : Extension Method
    */
namespace CustomResize
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Custom olaraq Resize methodunun daha inkişaf edilmiş versiyası 
        /// Arrayı daxil edib əlavə etmək istədiyimiz bir value üçün olan method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">Daxil etdiyimiz array</param>
        /// <param name="arrayValue">Əlavə etmək istədiyimiz dəyər</param>
        /// <returns></returns>
        public static T[] CResize<T>(this T[] array, T arrayValue)
        {
            #region Ilk Hali


            //int arrLength = CTakeALength(array);

            //T[] newArray = new T[1 + arrLength];
            //int newArrayLength = 0;
            //while (newArray.Length > newArrayLength)
            //{
            //    for (int j = 0; j < arrLength; j++)
            //    {
            //        newArray[newArrayLength] = array[j];
            //        newArrayLength++;
            //    }
            //    newArray[newArrayLength] = arrayValue;
            //    newArrayLength++;
            //}
            //array = newArray;
            //return array;
            //try
            //{
            //    array == null;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion

            #region Vali

            if (array == null) { Console.WriteLine("Daxil etdiyiniz array boşdur!"); }
            if (arrayValue == null) { Console.WriteLine("Arraya daxil etmek istediyiniz value null'dir!"); }
            if (array.Length == 0) { Console.WriteLine("Daxil etdiyini array uzunlugu 0 a beraberdir"); }
            #endregion

            
            int arrLength = array.Length;
            T[] newArray = new T[1 + arrLength];
            for (int j = 0; j < arrLength; j++)
            {
                newArray[j] = array[j];
            }
            newArray[arrLength] = arrayValue;
            return newArray;
        }


        /// <summary>
        /// Custom olaraq Resize methodunun daha inkişaf edilmiş versiyası 
        /// Arrayı daxil edib əlavə etmək istədiyimiz value'ları üçün olan method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">Daxil etdiyimiz array</param>
        /// <param name="arrayValue">Əlavə etmək istədiyimiz dəyərlər toplusu</param>
        /// <returns></returns>
        public static T[] CResize<T>(this T[] array, params T[] arrayValue)
        {
            #region FirsTimeTakeALength

            //int arrLength = 0;
            //int paramsLength = 0;
            //while (array.Length > arrLength) 
            //{
            //    arrLength++;
            //}
            //while (paramsLength < numbers.Length )
            //{
            //    paramsLength++;
            //}
            #endregion
            if (array == null) { Console.WriteLine("Daxil etdiyiniz array boşdur!"); }
            if (arrayValue == null) { Console.WriteLine("Arraya daxil etmek istediyiniz value null'dir!"); }
            if (array.Length == 0) { Console.WriteLine("Daxil etdiyini array uzunlugu 0 a beraberdir"); }



            int arrLength = array.Length;
            int paramsLength = arrayValue.Length;
            T[] newArray = new T[paramsLength + arrLength];
            for (int j = 0; j < arrLength; j++)
            {
                newArray[j] = array[j];
            }
            for (int h = 0; h < paramsLength; h++)
            {
                newArray[arrLength + h] = arrayValue[h];
            }
            GC.Collect();
            return newArray;
           
        }



        public static void CReadArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }

        }



        public static int CTakeALength<T>(T[] arr)
        {
            int count = 0;
            while (arr.Length > count)
            {
                count++;
            }
            return count;
        }



        public static void CResizeArrayValidation<T>(T[] arr, T[] arrayValue)
        {
            if (arr == null) { Console.WriteLine("Daxil etdiyiniz array boşdur!"); return; }
            if (arrayValue == null) { Console.WriteLine("Arraya daxil etmek istediyiniz value null'dir!"); return; }
            if (arr.Length == 0) { Console.WriteLine("Daxil etdiyini array uzunlugu 0 a beraberdir"); return; }

        }
    }
   
}
