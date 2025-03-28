using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ders9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ternary - Koşul Operatorü
            //
            // Kosul_ifadesi ? ifade1 : ifade2;

          //  int age = 25;

            string message = "";

            //    message = (age >= 18) ? "Arac surebilirsiniz." : "Arac Suremezsiniz.";


            int number = 0;

            message = (number > 0) ? "Pozitif sayi." : (number < 0 ? "Negatif sayi." : "Sifir sayisi.");

            Console.WriteLine(message);








            Console.ReadLine();






        }
    }
}
