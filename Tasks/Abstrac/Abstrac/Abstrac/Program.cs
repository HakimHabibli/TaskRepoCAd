using Abstrac.Helpers;
using Abstrac.Models;
using System.Collections;
using System.Reflection;

namespace Abstrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enstruman enstruman = new Enstruman();
            //enstruman.Marka = "Yamaha";
            //enstruman.Model = "XYS";
            //enstruman.Aciklama = "Yamaha marka enstruman";
            //enstruman.Qiymet = 1500;
            //enstruman.UretimYeri = "Usa";
            //enstruman.Hammadde = Hammadde.Metal;
            Bateri bateri = new Bateri();
            bateri.Marka = "Yamaha";
            bateri.Model = "X-YC-123";
            bateri.Aciklama = "Yamaha Marka Elektro Enstruman";
            bateri.Qiymet = 1500;
            bateri.UretimYeri = "USA";
            bateri.Hammadde = Hammadde.Metal;
            bateri.DeriTipi = "Koyun Derisi";


            Keman keman = new Keman
            {
                Marka = "Yamaha",
                Model = "X-YC-123",
                Aciklama = "Yamaha Marka Elektro Enstruman",
                Qiymet = 1500,
                UretimYeri = "USA",
                Hammadde = Hammadde.Metal,
                TelTipi = "Naylon",
                Arse = "Keman Arşe"
            };

            Gitar gitar = new Gitar
            {
                Marka = "Yamaha",
                Model = "X-YC-123",
                Aciklama = "Yamaha Marka Elektro Enstruman",
                Qiymet = 1500,
                UretimYeri = "USA",
                Hammadde = Hammadde.Metal,
                Akustik = true
            };

            Piano piano = new Piano
            {
                Marka = "Yamaha",
                Model = "X-YC-123",
                Aciklama = "Yamaha Marka Elektro Enstruman",
                Qiymet = 1500,
                UretimYeri = "USA",
                Hammadde = Hammadde.Metal,
                TelTipi = "Naylon",
                TusTakimi = "88 Tuş"
            };
            ArrayList muzikaletleri = new ArrayList();
            //muzikaletleri.Add(bateri);
            //muzikaletleri.Add(piano);
            //muzikaletleri.Add(keman);
            //muzikaletleri.Add(bateri);

            Muzisyen piyanist = new()
            {
                Adi = "Ludwig",
                Soyadi = "van Beethoven",
                Enstruman = new Piano
                {
                    Marka = "Steinway & Sons",
                    Model = "Model D",
                    Aciklama = "Steinway & Sons Model D Concert Grand Piano",
                    Qiymet = 170000,
                    UretimYeri = "Germany",
                    Hammadde = Hammadde.Agac,
                    TelTipi = "Steel",
                    TusTakimi = "88 Keys"
                }
            };

            Muzisyen baterist = new() { Adi = "Hakim", Soyadi = "Habibli", Enstruman = bateri };
            Muzisyen pianst = new() { Adi = "Hakim", Soyadi = "Habibli", Enstruman = piano };
            Muzisyen kemanci = new() { Adi = "Hakim", Soyadi = "Habibli", Enstruman = keman };

            //Helper.WriteConsole(kemanci);



            foreach (var muzisyen in muzikaletleri)
            {
                var muzisyenType = muzisyen.GetType();
                var muzisyenProperties = muzisyenType.GetProperties();
                Console.WriteLine($"{muzisyenType.Name}{new String (' ',20)}");
                foreach (var muzisyenProperty in muzisyenProperties)
                {
                    if (muzisyenProperty.Name == "Enstruman")
                    {
                        var ens = muzisyenProperty.GetValue(muzisyen);
                        Console.WriteLine($"{muzisyenProperty.Name}{new String(' ', 20)}");
                        var enst = ens.GetType().GetMethods().Where(m => m.Name == "Sound" || m.Name == "ses");
                    }
                }
            }


            
        }
    }
}
