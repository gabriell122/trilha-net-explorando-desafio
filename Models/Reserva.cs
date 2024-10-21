namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool teste = hospedes.Count() <= Suite.Capacidade;
            if (teste)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("número de hóspedes maior que a quantidade hóspedes suportada pela suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor = valor * 9 / 10;
            }

            return valor;
        }
    }
}