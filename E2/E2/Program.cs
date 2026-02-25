using System;

namespace E2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite sue nome: ");
            string nome = Console.ReadLine() ?? "Usuário";


            Console.WriteLine("1- Potuguês");
            Console.WriteLine("2- Inglês");
            Console.WriteLine("3- Espanhol");
            Console.Write("Selecione um idioma: ");

            string? opcao = Console.ReadLine();

            Action<string> boasVindas = null;

            switch (opcao)
            {

                case "1":
                    boasVindas = Potugues;
                    break;
                case "2":
                    boasVindas = Ingles;
                    break;

                case "3":
                    boasVindas = Espanhol;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            if (boasVindas != null) {
                boasVindas(nome);
                }

            Console.ReadKey(); 


            static void Potugues(string nome)
            {
                Console.WriteLine($"\nBem-vindo, {nome}!");

            }
            static void Ingles(string nome)
            {
                Console.WriteLine($"\n Welcome, {nome}!");
            }

            static void Espanhol(string nome)
            {
                Console.WriteLine("\n Bienvenido, {nome}!");
            }
        }
    }

}



