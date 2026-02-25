namespace E6
{
    internal class Program


    {
        public class Logger
        {
            public void LogtoConsole(string mensagem)
            {
                Console.WriteLine(mensagem);
            }
            public void LogToFile(string mensagem)
            {
                Console.WriteLine($"Salvando Mensagem {mensagem}...");
            }
            public void LogToDatabase(string mensagem)
            {
                Console.WriteLine($"Subindo log no SQL: {mensagem}");
            }


            static void Main(string[] args)
            {
                Logger novoLogger = new Logger();

                Action<string> logMulticast = novoLogger.LogtoConsole;
                logMulticast += novoLogger.LogToFile;
                logMulticast += novoLogger.LogToDatabase;

                Console.WriteLine("Para registrar um Log, informe a mensagem de erro: ");
                string mensagemErro = Console.ReadLine() ?? "Mensagem vazia";

                logMulticast(mensagemErro);
                Console.ReadKey();
            }
        }
    }
}
