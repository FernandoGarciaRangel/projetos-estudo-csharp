internal class Program
{
    private static void Main(string[] args)
    {

        /*
        Maior Número
        Peça ao usuário para inserir dois números. Use if para determinar qual é o maior número e exiba o resultado.
        */
       Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Seja bem vindo ao sistema comparador de números:");
            Console.WriteLine("Porfavor digite o primeiro número");
            double primeiroNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o segundo número:");
            double segundoNumero = double.Parse(Console.ReadLine());

            if(primeiroNumero > segundoNumero){
                Console.WriteLine($"O maior número é: {primeiroNumero}");
            }else if(primeiroNumero < segundoNumero){
                Console.WriteLine($"O maior número é o {segundoNumero}");
            }else{
                Console.WriteLine("Os números são iguais");
            }
            Console.ReadLine();
            Menu();
        }
        
        
}