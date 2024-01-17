namespace Lesson3Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int number1;
            //int number2;

            //Console.WriteLine("Enter first number:");
            //while (true)
            //{
            //    try
            //    {
            //        number1 = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Please only number");
            //    }
            //}

            //Console.WriteLine("Enter first number:");
            //while (true)
            //{
            //    try
            //    {
            //        number2 = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Please only number");
            //    }
            //}
            //bool last = (number1 % 2 == 0 && number2 % 2 == 0) || (number1 % 2 != 0 && number2 % 2 != 0);


            //Console.WriteLine(last);

            //Console.ReadLine();
            #endregion
            #region Task2
            //Console.WriteLine("Please write first input:");
            //string input1 = Console.ReadLine();
            //Console.WriteLine("Please write second input:");
            //string input2 = Console.ReadLine();
            //bool a = input1.Contains(input2);


            //Console.WriteLine(a);
            //Console.ReadLine();

            #endregion
            #region Task3

            int num1;
            int num2;
            

            Console.WriteLine("Enter first number:");
            while (true)
            {
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please only number");
                }
            }

            Console.WriteLine("Enter second number:");
            while (true)
            {
                try
                {
                    num2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please only number");
                }
            }

            float sum = (float)num1 / num2;

            Console.WriteLine("Result is: " + sum);
            Console.ReadLine();

            #endregion

        }
    }
}
