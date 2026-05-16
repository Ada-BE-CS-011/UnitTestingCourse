namespace UnitTestsFundamentals.UnitTests
{
    public class CaixaEletronicoUnitTests
    {
        [Theory]
        [ClassData(typeof(CaixaEletronicoTestData))]
        public void SaqueValido(int valor, Dictionary<int, int> expected)
        {
            var sut = new CaixaEletronico();
            var actual = sut.Saque(valor);

            Assert.Equal(actual, expected);
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void SaqueImpossivel(int valor)
        {
            var sut = new CaixaEletronico();

            Action metodo = () => sut.Saque(valor);
            var actual = Assert.ThrowsAny<Exception>(metodo);

            Assert.IsType(typeof(SaqueException), actual);
            Assert.IsAssignableFrom<DomainException>(actual);
            Assert.Contains(actual.Message, "Saque Impossível");
        }
    }
}
