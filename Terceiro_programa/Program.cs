using System.Text.RegularExpressions;

namespace Terceiro_programa
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
            Console.Write($"O maior número é {Math.Max(numero1, numero2)}");
        }
    }
}
    
