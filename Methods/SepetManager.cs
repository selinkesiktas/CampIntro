using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + product.Adi, product.Fiyati, product.Aciklama, product.stokAdedi);
        }


        public void Add2(string productAdi, string productaciklama, double productfiyat, int productstokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + productAdi);
        }

    }
}
