class Program{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu(){
        Console.Clear();

        Console.WriteLine("Opcões disponíveis");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("0 - Encerrar");

        Console.WriteLine("-----------------------------");

        Console.WriteLine("Digite uma opção:");
        short res = short.Parse(Console.ReadLine());

        switch(res){
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 0: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    static void Soma() {

        Console.Clear();

        Console.WriteLine("Digite o primeiro valor:");
        double primeiroValor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double segundoValor = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = primeiroValor + segundoValor;

        Console.WriteLine($"O resultado da sua soma é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao(){
        Console.Clear();

        Console.WriteLine("Digite o Primeiro valor:");
        double primeiroValor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double segundoValor = double.Parse(Console.ReadLine());

        Console.WriteLine("");


        double resultado = primeiroValor - segundoValor;

        Console.WriteLine($"O resultado da subtração é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao(){
        Console.Clear();

        Console.WriteLine("Digite o Primeiro valor:");
        double primeiroValor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double segundoValor = double.Parse(Console.ReadLine());

        Console.WriteLine("");


        double resultado = primeiroValor * segundoValor;

        Console.WriteLine($"O resultado da sua multiplicação é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao(){
        Console.Clear();

        Console.WriteLine("Digite o Primeiro valor:");
        double primeiroValor = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double segundoValor = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = primeiroValor / segundoValor;

        Console.WriteLine($"O resultado da sua divisão é {resultado}");
        Console.ReadKey();
        Menu();
    }

    }
