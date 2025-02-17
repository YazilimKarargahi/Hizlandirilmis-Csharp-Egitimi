using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ders8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MANTIKSAL OPERATORLER

            // ! , || , && 


            // ! 

            // true  false
            //   1     0

            // !1 = 0 YANİ !true = false
            // !0 = 1 YANİ !false = true





            //  Console.WriteLine(!is_checked);






            //   && AND
            //   
            //   0 && 0 = 0
            //   1 && 0 = 0
            //   0 && 1 = 0
            //   1 && 1 = 1





            //  Console.WriteLine(is_checked && is_valid);






            // || OR 
            //
            // 0 || 0 = 0
            // 1 || 0 = 1
            // 0 || 1 = 1
            // 1 || 1 = 1



            bool is_checked = true;


            bool is_valid = true;



            Console.WriteLine(is_checked || is_valid);







            Console.ReadLine();

        }
    }
}
