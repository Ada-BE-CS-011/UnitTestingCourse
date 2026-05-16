namespace UnitTestsFundamentals
{
    public class CaixaEletronico
    {
        private static readonly int[] NotasDisponiveis = [200, 100, 50, 20, 10, 5, 2];

        public Dictionary<int, int> Saque(int valor)        
        {
            ValidarValorSaque(valor);

            var resultado = new Dictionary<int, int>();
            var valorRestante = valor;

            foreach (var nota in NotasDisponiveis)
            {
                var quantidadeNotas = valorRestante / nota;
                valorRestante %= nota;

                (valorRestante, quantidadeNotas) = AjustarEstorno(valorRestante, quantidadeNotas, nota);

                resultado[nota] = quantidadeNotas;
            }

            return resultado;
        }

        private static void ValidarValorSaque(int valor)
        {
            if (valor <= 1 || valor == 3)
                throw new SaqueException("Saque Impossível");
        }

        private static (int valorRestante, int quantidadeNotas) AjustarEstorno(int valor, int qtdNotas, int valorNota)
        {
            if ((valor == 1 || valor == 3) && qtdNotas > 0)
                return (valor + valorNota, qtdNotas - 1);

            return (valor, qtdNotas);
        }
    }


    public class DomainException : Exception
    {
        public DomainException()
        {

        }

        public DomainException(string? message) : base(message)
        {
        }
    }

    public class SaqueException : DomainException
    {
        public SaqueException()
        {

        }

        public SaqueException(string? message) : base(message)
        {
        }
    }
}