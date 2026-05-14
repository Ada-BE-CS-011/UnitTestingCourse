namespace UnitTestsFundamentals
{
    public class CaixaEletronico
    {
        public Dictionary<int, int> Saque(int valor)
        {
            if (valor <= 1 || valor == 3)
                throw new SaqueException("Saque Impossível");

            //450
            int qtdNotas200 = valor / 200;
            valor = valor % 200;
            (valor, qtdNotas200) = Estorno(valor, qtdNotas200, 200);

            int qtdNotas100 = valor / 100;
            valor = valor % 100;
            (valor, qtdNotas100) = Estorno(valor, qtdNotas100, 100);

            int qtdNotas50 = valor / 50;
            valor = valor % 50;
            (valor, qtdNotas50) = Estorno(valor, qtdNotas50, 50);

            int qtdNotas20 = valor / 20;
            valor = valor % 20;
            (valor, qtdNotas20) = Estorno(valor, qtdNotas20, 20);

            int qtdNotas10 = valor / 10;
            valor = valor % 10;
            (valor, qtdNotas10) = Estorno(valor, qtdNotas10, 10);

            int qtdNotas5 = valor / 5;
            valor = valor % 5;
            (valor, qtdNotas5) = Estorno(valor, qtdNotas5, 5);

            int qtdNotas2 = valor / 2;
            valor = valor % 2;
            (valor, qtdNotas2) = Estorno(valor, qtdNotas2, 2);

            return new Dictionary<int, int>
            {
                { 200, qtdNotas200 },
                { 100, qtdNotas100 },
                {  50, qtdNotas50 },
                {  20, qtdNotas20 },
                {  10, qtdNotas10 },
                {   5, qtdNotas5 },
                {   2, qtdNotas2 },
            };
        }

        private (int valor, int qtdNotas200) Estorno(int valor, int qtdNotas, int valorNota)
        {
            if (valor == 1 || valor == 3)
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