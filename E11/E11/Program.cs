namespace E11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string>  concat = (x, y) => x + y;

            concat += (x, y) => (x + y).ToUpper();
            concat += (x, y) => (x + y).Replace("  ", "  ");

            string Rconcat = concat("Lirian", "Oliveira");

            Console.WriteLine(Rconcat);
        }
    }
}
