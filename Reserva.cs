namespace Hotel_Management_DIO;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
    public Suite Suite{ get; set; }
    public int DiasReservados{ get; set; }

    public Reserva( int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count < Suite.Capacidade)
        {
          Hospedes.AddRange(hospedes);

        }
        else throw new Exception("Erro ao cadastrar hospedes");
    }
    public void CadastrarSuite(Suite suite)
    {
         Suite = suite; 
    }
    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        bool desconto = DiasReservados >= 10;
        var calculo = Suite.ValorDiaria * DiasReservados;
        return desconto ? (calculo - calculo * 0.10M ) : calculo;
    }
}