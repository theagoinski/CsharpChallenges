using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split(' ');

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            
            r1 = Math.Round(r1, 5);
            r2 = Math.Round(r2, 5);
            
            if (delta >= 0 && a != 0)
            {
              Console.WriteLine($"R1 = {r1}\nR2 = {r2}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

    }

}