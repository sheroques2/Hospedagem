using System;

public class Reserva
{
    public Pessoa Hóspede { get; set; }
    public Suite Suite { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }

    public Reserva(Pessoa hóspede, Suite suite, DateTime dataEntrada, DateTime dataSaida)
    {
        Hóspede = hóspede;
        Suite = suite;
        DataEntrada = dataEntrada;
        DataSaida = dataSaida;
    }

    public int QuantidadeHospedes()
    {
        // Se houver necessidade de vários hóspedes, isso pode ser expandido.
        return 1;
    }

    public decimal ValorTotal()
    {
        int diasEstadia = (DataSaida - DataEntrada).Days;

        if (diasEstadia <= 0)
        {
            throw new ArgumentException("Data de saída deve ser depois da data de entrada.");
        }

        decimal valorTotal = diasEstadia * Suite.ValorDiaria;

        if (diasEstadia > 10)
        {
            valorTotal *= 0.90m; // Aplica 10% de desconto
        }

        return valorTotal;
    }

    public override string ToString()
    {
        return $"Hóspede: {Hóspede.Nome}, Tipo de Suíte: {Suite.Tipo}, " +
               $"Data de Entrada: {DataEntrada.ToShortDateString()}, Data de Saída: {DataSaida.ToShortDateString()}, " +
               $"Quantidade de Hóspedes: {QuantidadeHospedes()}, Valor Total: {ValorTotal():C}";
    }
}
