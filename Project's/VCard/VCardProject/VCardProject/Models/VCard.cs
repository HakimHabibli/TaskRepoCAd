using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VCardProject.Models
{
    public class RandomUserApiResponse
    {
        public VCard[] Results { get; set; }//The Boss Prop :)
    }
    public class Name 
    {
        [JsonProperty("first")]
        public string First{ get; set; }
        [JsonProperty("last")]// We annotate fields according to parameters coming from the API
        public string Last { get; set; }
    }
    public class Id
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class VCard
    {
        public Id Id { get; set; }
        [JsonProperty("name")]
        public Name FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public VCard(string firstname, string lastname, string email, string phone, string city, string country)
        {
            FullName = new Name
            {
                First = firstname, Last = lastname,
            };
            Email = email;
            Phone = phone;
            City = city;
            Country = country;
        }
        /// <summary>
        /// Generates a vCard string using the contact information.
        /// </summary>
        /// <returns>A string in vCard format.</returns>
        public string GenerateVCardString()
        {
            string vCardFormat = $"BEGIN:VCARD\r\n" +
                                 $"VERSION:3.0\r\n" +
                                 $"N:;{FullName.Last};{FullName.First};;;\r\n" +
                                 $"FN:{FullName.First}{FullName.Last}\r\n" +
                                 $"EMAIL;TYPE=INTERNET:{Email}\r\n" +
                                 $"TEL;TYPE=CELL:{Phone}\r\n" +
                                 $"ADR;TYPE=HOME:;;{City};{Country};;;\r\n" +
                                 $"END:VCARD\r\n";

            return vCardFormat;
        }
        /// <summary>
        /// This is the Save method where we specify the file type, name, and the location where it will be saved.
        /// </summary>
        /// <param name="VCardStr">The file type in VCard format</param>
        /// <param name="fileName">The name of the file to be saved</param>
        /// <param name="directory">The directory where the file will be saved</param>
        public static void SaveMethod(string VCardStr, string fileName, string directory)
        {
            var Directory = $@"{directory}"; 
            var Filename = $"{fileName}.vcf";
            var fullPath = Path.Combine(Directory, Filename);
            File.WriteAllText(fullPath, VCardStr);
            Console.WriteLine("Save Successful");
            Console.Write(new string('-', 50));
        }
    }

}
