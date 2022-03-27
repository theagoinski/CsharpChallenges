using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n < 1000 && n > 2)
            {
              for(int i = 1; i < 11; i++)
              {
                Console.WriteLine(string.Format($"{i} x {n} = {i * n}")); //escreva o seu código nos espaços em branco
              }
            }
        }
    }
}