using System;

namespace POOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            celular A = new celular();

            Console.WriteLine(A.cor);
            Console.WriteLine(A.modelo);
            Console.WriteLine(A.tamanho);

            Console.WriteLine("Deseja ligar este aparelho? s/n");
            string ligar = Console.ReadLine().ToLower();

            switch (ligar)
            {
                case "s":
                A.ligado = true;
                do
                {
                    
                Console.WriteLine($@"
|-----------------------|
|        {A.modelo}        |
|-----------------------|
|                       |
|                       |
|                       |
|                       |
|  1- Realizar ligação  |
|   2-Enviar mensagem   |
|      0-Desligar       |
|                       |
|                       |
|                       |
|                       |
|_______________________|
|_______________________|
                ");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine(A.ligar());
                }else if (opcao == 2)
                {
                    Console.WriteLine(A.enviar());
                    
                }else if (opcao == 0)
                {
                    Console.WriteLine("Desligado");
                    A.ligado = false;
                }
                } while (A.ligado == true);
                break;
                case "n":
                Console.WriteLine("Celular não foi ligado, boa escolha.");
                break;
                default:
                    break;
            }
            
        }
    }
}
