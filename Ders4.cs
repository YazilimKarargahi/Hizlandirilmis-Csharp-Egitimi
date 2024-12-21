using System;


namespace CsharpUserInput
{
    internal class Program
    {
        public static void Main()
        {

            string name = "";

            Console.Write("Adınızı giriniz : ");






            name = Console.ReadLine();

            Console.WriteLine("Adınız : " + name);



            int age;


            Console.Write("Yasinizi giriniz : ");

            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Yaşınız: " + age);

            bool isValid;

            Console.Write("18 yasindan buyuk musunuz  : ");

            isValid = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(isValid);





           

            

            Console.ReadLine();

        }
    }
}
