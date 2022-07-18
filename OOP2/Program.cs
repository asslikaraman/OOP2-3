using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.Adi = "Aslı";
            gercekMusteri.Soyadi = "Karaman";
            gercekMusteri.MusteriNo = "1224";
            gercekMusteri.TcNo = "835782975";


            TuzelMusteri tuzelMusteri=new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "1225";
            tuzelMusteri.VergiNo = "345";
            tuzelMusteri.SirketAdi = "Holding";


            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(gercekMusteri);
            customerManager1.Add(tuzelMusteri);
            customerManager1.Add(musteri1);
            customerManager1.Add(musteri2);
        }
    }
}
