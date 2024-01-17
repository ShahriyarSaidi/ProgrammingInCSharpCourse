namespace SecondLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //integral numeric types

            byte var1 = 45;

            byte var2 = 56; //byte.Parse(Console.ReadLine());

            int sum = var1 + var2;
            Console.WriteLine(sum);

            int a = int.MaxValue;

            bool @bool = (5 < 6) && (7 > 5);
            Console.WriteLine(@bool);

            char d = 'A';
            char e = 'B';
            var f = char.IsLetter(d);
            var g = char.IsNumber(e);

            string abc= "jhjkhjkhjhjkhjkhjk ";
            Console.WriteLine(abc.Trim());



            Console.WriteLine("Char f budur:" + f);
            Console.WriteLine("Char e budur:" + g);


            Console.WriteLine(a);
            Console.ReadLine();

            
     
        }
        
    }
}
