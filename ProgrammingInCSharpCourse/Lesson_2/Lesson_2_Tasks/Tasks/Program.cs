using System;

namespace Lesson_2nd_toDos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Task1
            //char letter1;
            //char letter2;
            //char letter3;

            //Console.WriteLine("Ilk herfi daxil edin:");

            //while (true)
            //{
            //    try
            //    {
            //        letter1 = char.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Ancaq tek herf daxil edin");
            //    }
            //}

            //Console.WriteLine("Ikinci herfi daxil edin:");

            //while (true)
            //{
            //    try
            //    {
            //        letter2 = char.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Ancaq tek herf daxil edin");
            //    }
            //}

            //Console.WriteLine("Ucuncu herfi daxil edin:");

            //while (true)
            //{
            //    try
            //    {
            //        letter3 = char.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Ancaq tek herf daxil edin");
            //    }
            //}


            //string lastletter = letter3.ToString() + letter2 + letter1;

            //Console.WriteLine("Butun herflerin birlesmesi budur: " + lastletter);

            //Console.ReadLine();
            #endregion

            #region //Task2

            string name;
            string surname;

            Console.WriteLine("Zehmet olmasa adinizi daxil edin:");
            name = Console.ReadLine();

            Console.WriteLine("Zehmet olmasa soyadinizi daxil edin:");
            surname = Console.ReadLine();

            string nameSurname = name + " " + surname;

            Console.WriteLine("Adiniz ve soyadiniz: " + nameSurname.ToUpper());

            Console.ReadLine();

            #endregion

        }

    }
}