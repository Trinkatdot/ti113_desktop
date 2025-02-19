namespace Quarto_programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° Número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 2° Número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 3° Número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int[] numeros = new int[3];
            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;

            int maior = numeros.Max();
            Console.Write($"O maior número é {maior}");
        }
    }
}
