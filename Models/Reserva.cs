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
            // Feito: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Feito: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A capacidade da suíte não permite essa quantidade de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Feito: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            // Feito: Retorna o valor da diária
            decimal valor = DiasReservados*Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados>=10)
            {
                valor *= 0.9M; //Desconto de 10%
            }

            return valor;
        }
    }
}