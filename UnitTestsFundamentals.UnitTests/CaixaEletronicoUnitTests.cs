using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsFundamentals.UnitTests
{
    public class CaixaEletronicoUnitTests
    {
        [Theory]
        [ClassData(typeof(SaqueTestData))]
        public void SaqueValido(int valor, Dictionary<int, int> expected)
        {
            var sut = new CaixaEletronico();
            var actual = sut.Saque(valor);

            Assert.Equal(actual, expected);
        }



        //public void SaqueImpossivel(int valor)
        //{
        //    var sut = new CaixaEletronico();

        //    Action metodo = () => sut.Saque(valor);

        //    //var actual = Assert.Throws<SaqueException>(metodo);
        //    var actual = Assert.ThrowsAny<Exception>(metodo);

        //    Assert.IsType(typeof(SaqueException), actual);
        //    Assert.IsAssignableFrom<DomainException>(actual);
        //    Assert.Contains(actual.Message, "Saque Impossível");
        //}
    }
}
