internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

       
        }

         static void Menu(){

            Console.Clear();
            Console.WriteLine("Tempo+S = Segundos");
            Console.WriteLine("Tempo+M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo quer contar?");

            string contagem = Console.ReadLine().ToLower();

            char tipo = char.Parse(contagem.Substring(contagem.Length - 1, 1));

            int tempo = int.Parse(contagem.Substring(0, contagem.Length - 1));

            int multiplicador = 1;

            if(tipo == 'm'){
                multiplicador = 60;
            }
            if(tempo == 0){
                System.Environment.Exit(0);
    
                } 
                PreStart(tempo * multiplicador);
            }


            static void PreStart(int tempo){
            
                Console.Clear();
                Console.WriteLine("Preparar...");
                Thread.Sleep(1000);
                Console.WriteLine("Apontar...");
                Thread.Sleep(1000);
                Console.WriteLine("Fogo...");
                Thread.Sleep(1000);

                Start(tempo);
            }


            static void Start(int tempo){

            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro Finalizado!!!");
            Thread.Sleep(2500);
            Menu();

        }
}