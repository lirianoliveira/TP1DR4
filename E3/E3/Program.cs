namespace E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> calcular = (b, h) => b * h;

            Console.WriteLine("Calcular área de um retângulo");

            Console.WriteLine("Informe a largua do retângulo:");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
           
            double resultado = calcular(largura, altura);

            Console.WriteLine($"A área do retângulo é: {resultado:F2}");

            Console.ReadKey();

        }
    }
}
