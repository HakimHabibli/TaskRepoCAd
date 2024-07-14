using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VCardProject.Models;
#region Step's
/*
1-Api almaq ve Deserialize etmek 
2-GenerateVCardString Methodunu yazmaq
3-Api'dan gelen proplarin alt proplarini əl çatan etmek
4-Api Aldigim datalari Save etmək 
5-User nece eded VCard yaaratmag isteyirse Consoldan daxil etmesi
6-Isminin benzersiz olmagi ucun Id propertisi elave etmek (Sebeb eger iki dene eyni adda vcf fayli varsa avtomatik biri silinir)
*/
#endregion
namespace VCardGenerator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var FilePath = "C:\\Users\\77upt\\Desktop\\VCard\\VCF\\";//File save location
            try
            {
                Console.WriteLine("How many VCards do you want to create?");
                int num = Int32.Parse(Console.ReadLine());
                var response = await client.GetAsync($"https://randomuser.me/api/?results={num}");
                response.EnsureSuccessStatusCode();// Status code received from the API
                string responseBody = await response.Content.ReadAsStringAsync();
             

                var jsonData = JsonConvert.DeserializeObject<RandomUserApiResponse>(responseBody);

                foreach (var vcard in jsonData.Results)
                {
                    string vCardString = vcard.GenerateVCardString();
                    Console.WriteLine(vCardString);
                    VCard.SaveMethod
                        (
                        vCardString , 
                        $"{vcard.Id.Value}{vcard.FullName.First}{vcard.FullName.Last}", 
                        FilePath
                        );
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


