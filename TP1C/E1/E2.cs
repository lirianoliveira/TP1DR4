using System;

public class Class1
{
	public Class1()
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

            Action<string> boasVindas;

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

            boasVindas(nome);

            static void Potugues(string nome)
            {
                console.WriteLine($"\nBem-vindo, {nome}!");

            }
            static void Ingles(string nome)
        console.WriteLine($"\n Welcome, {nome}!");

            static void Espanhol(string nome)
            {
                Console.WriteLine("\n Bienvenido, {nome}!");
            }




        }


    }
}
