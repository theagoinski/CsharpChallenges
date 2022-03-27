using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            
            double media =  (2*A + 3*B + 5*C)/10;
            double decimalValue = Math.Round(media, 1);


            Console.WriteLine($"MEDIA = {decimalValue}");
            Console.ReadKey();
        }
    }
}