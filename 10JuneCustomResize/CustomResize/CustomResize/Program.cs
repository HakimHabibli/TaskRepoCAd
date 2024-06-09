using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography;

//BenchmarkRunner.Run<Program>();
/*
    RoadMap 
   Step-1 : Int tipi üçün CResize methodu
   Step-2 : MethodOverload(Bir reqem daxil etmek ucun) + Garbage Collector 
   Step-3 : Methodu Generic etmek
   Step-4 : Validation
    */
namespace CustomResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3};
            string[] arr2 = { "a", "b", "c" };
            //Array.Resize(ref arr, 5);
            //Console.WriteLine(arr.Length);

            CReadArray(CResize(arr,1,2,3,4,5));
            //CReadArray(CResize(arr, 2));
            //CReadArray(CResize(arr2, "h"));
        }
        static T[] CResize<T>(T[] array, T arrayValue)
        {
            //try
            //{
            //    array == null;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            if (array == null) { Console.WriteLine("Daxil etdiyiniz array boşdur!"); }
            if (arrayValue == null) { Console.WriteLine("Arraya daxil etmek istediyiniz value null'dir!"); }
            if (array.Length == 0) { Console.WriteLine("Daxil etdiyini array uzunlugu 0 a beraberdir"); }
            int arrLength = CTakeALength(array);

            T[] newArray = new T[1 + arrLength];
            int newArrayLength = 0;
            while (newArray.Length > newArrayLength)
            {
                for (int j = 0; j < arrLength; j++)
                {
                    newArray[newArrayLength] = array[j];
                    newArrayLength++;
                }
                newArray[newArrayLength] = arrayValue;
                newArrayLength++;
            }
            array = newArray;
            return array;

        }
        static T[] CResize<T>(T[] array, params T[] arrayValue)
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
            
            int arrLength = CTakeALength(array);
            int paramsLength = CTakeALength(arrayValue);

            T[] newArray = new T[paramsLength + arrLength];
            int newArrayLength = 0;
            while (newArray.Length > newArrayLength)
            {
                for (int j = 0; j < arrLength; j++)
                {
                    newArray[newArrayLength] = array[j];
                    newArrayLength++;
                }
                for (int h = 0; h < paramsLength; h++)
                {
                    newArray[newArrayLength] = arrayValue[h];
                    newArrayLength++;
                }
            }

            array = newArray;
            GC.Collect();
            return array;
        }

        static void CReadArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }
            
        }
        static int CTakeALength<T>(T[] arr)
        {
            int count = 0;
            while (arr.Length > count)
            {
                count++;
            }
            return count;
        }
        static void CResizeArrayValidation<T>(T[] arr, T[] arrayValue) 
        {
            if (arr == null) { Console.WriteLine("Daxil etdiyiniz array boşdur!"); return; }
            if (arrayValue == null) { Console.WriteLine("Arraya daxil etmek istediyiniz value null'dir!"); return; }
            if (arr.Length == 0) { Console.WriteLine("Daxil etdiyini array uzunlugu 0 a beraberdir"); return; }
            
        }
    }
   
}
