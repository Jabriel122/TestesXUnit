namespace Temperatura.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestarMetodoDeConvertoDeFahrenheit()
        {
            var a = 18;
            var respostaEsperada = 64.400000000000006;

            var convertoDeFahrenheit = Fahrenheit.ConvertorDeFahrenheit(a);

            Assert.Equal(respostaEsperada, convertoDeFahrenheit);
        }
    }
}