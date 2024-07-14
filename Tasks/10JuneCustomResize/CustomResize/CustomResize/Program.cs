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
   Step-5 : Extension Method
    */
namespace CustomResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3};
            ////string[] arr2 = { "a", "b", "c" };
            ////Array.Resize(ref arr, 5);
            ////Console.WriteLine(arr.Length);

            //int[] resizedArray = arr.CResize
            ////CReadArray(CResize(arr, 2));
            ////CReadArray(CResize(arr2, "h"));

            int[] arr = { 1, 2, 3 };
            ArrayExtensions.CReadArray(arr);

            
            int[] resizedArray1 = arr.CResize(4);
            ArrayExtensions.CReadArray(resizedArray1);

            
            int[] resizedArray2 = arr.CResize(5, 6, 7);
            ArrayExtensions.CReadArray(resizedArray2);
        }



     
    }
   
}
