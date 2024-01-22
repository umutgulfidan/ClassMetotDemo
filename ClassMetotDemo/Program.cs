using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri = new Musteri(1, "Deneme", 25, "Ankara", 0, "deneme@gmail.com");
            musteriManager.Add(musteri);
            musteriManager.Add(new Musteri(2,"Deneme2",22,"İzmir",1000,"deneme2@gmail.com"));
            musteriManager.Print();
            musteriManager.Remove(musteri);
            musteriManager.Print();
            Console.WriteLine(musteriManager.Count());
            Console.ReadLine();
        }
    }
}
