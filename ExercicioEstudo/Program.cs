internal class Program
{
    private static void Main(string[] args)
    {

        /*
        Par ou Ímpar
        Peça ao usuário para inserir um número inteiro e use uma condicional if para verificar se o número é par ou ímpar. Exiba o resultado no console.
        */
       Menu();
        }

         static void Menu(){
            Console.Clear();

            Console.WriteLine("Verificador de ímpar ou par");
            Console.WriteLine("Digite 0 para encerrar ou número a ser verificado->");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Environment.Exit(0);
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("Seu número é par");
            }
            else
            {
                Console.WriteLine("Seu número é ímpar");
            }
            Console.ReadLine();
            Menu();
    }
}