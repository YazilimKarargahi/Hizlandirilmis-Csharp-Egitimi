
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler , Veri tipleri


            //veri tipi degisken ismi = 23

            int age = 23;

            Console.WriteLine(age);


















            //tam sayı 
            int num = 100;







            //kesirli sayı
            float rate = 1245.25f;

            Console.WriteLine("Kesirli veri tipi: " + rate);

           



            //büyük kesirli sayı
            double x = 200342432340000.45;

            Console.WriteLine("Buyük Kesirli veri tipi: " + x);


          //double  45 + 33 = 78 -> 80 
          // decimal 45 + 33 = 78

            //decimal, sadece finans ve hesaplama islemleri icin.
            decimal amount = 100.50M;

            Console.WriteLine("Decimal Kesirli veri tipi: " + amount);






            char letter = 'C';

            Console.WriteLine("Karakter veri tipi: " + letter);


            string name = "Adem";

            Console.WriteLine("Benim adım: " + name);







            bool isValid = true;

            //true = 1 , false = 0

            Console.WriteLine("Bool veri tipi: " + isValid);














            // Mevcut tarih ve saat

            DateTime today = DateTime.Now;

            Console.WriteLine("bugün: " + today);


            //sadece tarih.
            DateTime onlyDate = today.Date;

            Console.WriteLine("bugünün tarihi: " + onlyDate);

            //sadece saat 
            TimeSpan onlyTime = today.TimeOfDay;

            Console.WriteLine("bugünün saati: " + onlyTime);






            Console.ReadLine();
        }
    }
}
