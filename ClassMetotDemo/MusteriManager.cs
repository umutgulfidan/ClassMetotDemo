using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        private List<Musteri> Musteriler;

        public MusteriManager() {
            Musteriler = new List<Musteri>();
        }
        public void Add(Musteri musteri)
        {
            Musteriler.Add(musteri);
        }
        public void Remove(Musteri musteri)
        {
            Musteriler.Remove(musteri);
        }
        public void Print()
        {
            foreach (Musteri m in Musteriler)
            {
                Console.WriteLine(m.Id+": "+m.Isım);
            }
        }
        public List<Musteri> GetAll()
        {
            return Musteriler;
        }
        public int Count()
        {
            return Musteriler.Count;
        }

    }
}
