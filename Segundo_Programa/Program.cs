namespace Segundo_Programa
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("informe um numero de 1 a 7 para exibir o Dia da semana");
            string opcao = Console.ReadLine()!;

            switch(opcao) {
                case "1":
                    Console.WriteLine("domingo");
                    break;
                     case "2":
                    Console.WriteLine("Segunda-feira");
                    break;
                     case "3":
                    Console.WriteLine("terça-feira");
                    break;
                     case "4":
                    Console.WriteLine("quinta-feira");
                    break;
                     case "5":
                    Console.WriteLine("quarta-feira");
                    break;
                     case "6":
                    Console.WriteLine("sexta-feira");
                    break;
                     case "7":
                    Console.WriteLine("sabado");
                    break;
                    default:
                    Console.WriteLine("Dia Invalido");
                    break;
            }
        }
    }
}