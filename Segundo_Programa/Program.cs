namespace Segundo_Programa
{
    using System;

    class Program
    {
        static void Main()
        {
            // Solicita ao usuário um número de 1 a 7
            Console.Write("Digite um número de 1 a 7: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Determina o dia da semana correspondente
            string diaSemana = numero switch
            {
                1 => "Domingo",
                2 => "Segunda-feira",
                3 => "Terça-feira",
                4 => "Quarta-feira",
                5 => "Quinta-feira",
                6 => "Sexta-feira",
                7 => "Sábado",
                _ => "Número inválido! Por favor, insira um número entre 1 e 7."
            };

            // Exibe o resultado
            Console.WriteLine(diaSemana);
        }
    }
}