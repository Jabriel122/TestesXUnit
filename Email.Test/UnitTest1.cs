using System.Globalization;
using ValidadeDeEmail;

namespace Email.Test
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("garibaldo@gmail.com")]
        [InlineData("garibaldo@gmail.com")]
        [InlineData("garibaldo@gmail.com")]
        public void TestandoAVerificacaoDeEmail(string a)
        {

            var verficarEmail = Verificacao.ValidarEmail(a);

            Assert.True(verficarEmail);
 
        }
    }
}