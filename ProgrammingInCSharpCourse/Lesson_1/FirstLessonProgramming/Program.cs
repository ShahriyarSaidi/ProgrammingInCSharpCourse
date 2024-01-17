namespace FirstLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //CodeHere
            int a;
            int b;
            int c;
            Console.WriteLine("Enter first number:");

            while (true)
            {
                try {
                    a = int.Parse(Console.ReadLine());
                    break;
                }catch (Exception ) {

                    Console.WriteLine("Only number: ");
                }
                
            }

            Console.WriteLine("Enter first number:");

            while (true)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Only number: ");
                }
            }
            c = Sum(a, b);
            Console.WriteLine("Cem budur: " + c);
            Console.ReadLine();
        }



        public static int Sum(int a, int b)
        {
            return a + b;
            #endregion
        }
    }
}
