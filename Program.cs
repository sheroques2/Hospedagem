using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria algumas suítes
        Suite suiteLuxo = new Suite("Luxo", 200.0m);
        Suite suiteStandard = new Suite("Standard", 100.0m);

        // Cria alguns hóspedes
        Pessoa pessoa1 = new Pessoa("João Silva", "12345678900");
        Pessoa pessoa2 = new Pessoa("Maria Oliveira", "98765432100");

        // Cria reservas
        Reserva reserva1 = new Reserva(pessoa1, suiteLuxo, new DateTime(2024, 9, 1), new DateTime(2024, 9, 15));
        Reserva reserva2 = new Reserva(pessoa2, suiteStandard, new DateTime(2024, 9, 10), new DateTime(2024, 9, 12));

        // Exibe informações das reservas
        Console.WriteLine(reserva1);
        Console.WriteLine(reserva2);
    }
}
