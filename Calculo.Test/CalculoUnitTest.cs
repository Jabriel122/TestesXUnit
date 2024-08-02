using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculo.Test
{
    public class CalculoUnitTest
    {

        //AAA : Act, Arrange, Assert
        //AAA : Agir, Organizar e Assertir

        [Fact]
        public void TestarMetodoSomar()
        {
            //Arrange : Organizar
            var x1 = 4.1;
            var x2 = 5.9;
            var valorEsperado = 10;

            //Act : Agir
            var soma = Calculo.Somar(x1, x2);



            //Assert : Provar
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void TestarMetodoSubtrair()
        {
            //Arrange : Organizar
            var x1 = 20;
            var x2 = 10;
            var valorEsperado = 10;

            //Act : Agir
            var subtrair = Calculo.Subtrair(x1, x2);

            //Assert : Provar
            Assert.Equal(valorEsperado, subtrair);
        }

        [Fact]
        public void TestarMetodoDivisao()
        {
            //Arrange : Organizar
            var x1 = 36;
            var x2 = 3;
            var valorEsperado = 12;
            //Act : Agir
            var divisao = Calculo.Divisao(x1, x2);
            //Assert : Provar
            Assert.Equal(valorEsperado, divisao);
        }

        [Fact]
        public void TestarMetodoMultiplicacao()
        {
            //Arrange : Organizar
            var x1 = 3;
            var x2 = 9;
            var valorEsperado = 27;
            //Act : Agir
            var multpilcacao = Calculo.Multiplicacao(x1, x2);
            //Assert : Provar
            Assert.Equal(valorEsperado, multpilcacao);
        }

        

    }
}
