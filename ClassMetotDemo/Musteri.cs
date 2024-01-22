using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string Isım { get; set; }
        public int Yas { get; set; }
        public string DogumYeri { get; set; }
        public double Bakiye { get; set; }
        public string Email { get; set; }

        public Musteri(int ıd, string isim, int yas, string dogumYeri, double bakiye, string email)
        {
            Id = ıd;
            Isım = isim;
            Yas = yas;
            DogumYeri = dogumYeri;
            Bakiye = bakiye;
            Email = email;
        }
    }
}
