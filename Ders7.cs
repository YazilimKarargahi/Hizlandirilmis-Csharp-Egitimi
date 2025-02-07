using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// ARTTIRMA AZALTMA OPERATORLERI

            ////  ++ , -- 

            //////++
            ////int total_students = 5;

            ////Console.WriteLine("Toplam ogrenci sayisi : " + total_students);


            ////total_students = ++total_students;


            ////Console.WriteLine("Simdi Toplam ogrenci sayisi : " + total_students);

            //// --
            //int total_students = 5;

            //Console.WriteLine("Toplam ogrenci sayisi : " + total_students);


            //--total_students;

            //Console.WriteLine("Simdi Toplam ogrenci sayisi : " + total_students);






            int a = 5;
            int b = ++a; // Prefix artırma: önce a artırılır, sonra yeni değeri b'ye atanır.

            Console.WriteLine("\nPrefix Kullanımı:");
            Console.WriteLine($"a: {a}"); // 6
          //  Console.WriteLine("a" + a); //aynı kullanım


            Console.WriteLine($"b: {b}"); // 6 (önce artırılır, sonra atanır)



            int c= 5;
            int d = c++; // Postfix artırma: önce atama yapılır , sonra c arttırılır.

            Console.WriteLine("\nPostfix Kullanımı:");
            Console.WriteLine($"c: {c}"); // arttirilmis deger doner 6

            Console.WriteLine($"d: {d}"); // var olan deger atamasi yapilir. 5






            Console.ReadLine();


        }
    }
}
