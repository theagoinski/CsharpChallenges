using System; 
 
class DIO{
 
    static void Main(string[] args) 
    {
		string[] input;

        input = Console.ReadLine().Split(' ');
        
        int cod1 = int.Parse(input[0]); // primeiro input é o código do produto.
        int n1 = int.Parse(input[1]); // segundo input do usuário é a quantidade de produtos.
        double valor1 = double.Parse(input[2]); // terceiro input é o valor individual do produto passado no caixa.
        //Escreva sua lógica nos espaços em branco
        input = Console.ReadLine().Split(' '); 

        int cod2 = int.Parse(input[0]);
	    int n2  = int.Parse(input[1]);
        double valor2 = double.Parse(input[2]);

        double total = (valor1*n1) + (valor2*n2);
        
        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
    }

}