namespace Quinto_Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            Console.WriteLine("Digite o 1° Número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 2° Número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 3° Número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int maior = numeros.Max();
            Console.Write($"O maior número é {maior}");
            int menor = numeros.Min();
            Console.Write($"O menor número é {menor}");
        }
    }
}
