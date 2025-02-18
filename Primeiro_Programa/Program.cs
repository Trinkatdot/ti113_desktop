namespace Primeiro_Programa
{
    using System;

    class Program
    {
        static void Main()
        {
            // Leitura das notas
            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            // Cálculo da média
            double media = (nota1 + nota2) / 2;

            // Exibição do resultado com base na média
            Console.WriteLine($"Média: {media:F2}");

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }

}
