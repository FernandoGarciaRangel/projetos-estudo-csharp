internal class Program
{
    private static void Main(string[] args)
    {

        /*
       Validação de Idade
        Peça ao usuário a idade dele. Se a idade for maior ou igual a 18, exiba "Você é maior de idade". Caso contrário, exiba "Você é menor de idade".
        */
       Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Seja Bem vindo ao sistema de validação de idade");
            Console.WriteLine("Por favor,digite a idade a ser verificada");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18){
                Console.WriteLine("Você é menor de Idade. Vai estudar!");
            }else if(idade >= 18){
                Console.WriteLine("Você é maior de idade. Já tem uns boletos para pagar!");
            }else{
                Console.WriteLine("Idade invalida");
            }
            Console.ReadLine();
            Menu();
        }
}