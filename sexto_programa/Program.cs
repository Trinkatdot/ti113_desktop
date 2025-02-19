namespace sexto_programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double valorhora;
            short quantHora;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine()!;

            Console.Write("Digite o numero de horas trabalhadas: ");
            quantHora = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o valor por hora: ");
            quantHora = Convert.ToDouble(Console.ReadLine());

            double total = valorhora * quantHora;

            Console.WriteLine($@ O valor do {nome} é R$ {total:f2}");

        }
    }
}
