using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac.Models;
public enum Hammadde 
{
    Agac,Metal,Plastik
}
public class Muzisyen 
{ 
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public Enstruman Enstruman { get; set; }
}
public interface IEnstruman { }
public abstract class Enstruman:IEnstruman
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Aciklama { get; set; }
    public decimal Qiymet  { get; set; }
    public string UretimYeri { get; set; }
    public Hammadde Hammadde { get; set; }
    public abstract string Sound();
    public virtual string Ses(string name)=>$"{name} Enstruman Default Sound";
}
public class Bateri : Enstruman
{ 
    public string  DeriTipi { get; set; }
    override public string Sound() => "Bateri sound";

}
public class Keman : Enstruman 
{
    public string TelTipi { get; set; }
    public string Arse { get;set; }

    public override string Sound()
    {
        throw new NotImplementedException();
    }
}
public class Gitar : Enstruman
{ 
public bool Akustik { get; set; }

    public override string Sound()
    {
        throw new NotImplementedException();
    }
}
public class Piano : Enstruman
{ 
    public string TelTipi { get; set; }
    public string TusTakimi { get; set; }

    public override string Sound()
    {
        throw new NotImplementedException();
    }
}
