using Livros;

namespace LivroUnitTest
{
    public class LivroUnitTest2
    {
        [Fact]
        public void TestarMetod()
        {
            //Arrange : Organizar

            var listaDeLivros = new ListaDeLivros();

            var y = "Action";

            var livro = new Livro();

            var name = livro.Nome = "Menino do Pijama Listrado";
            var x = "Action";

            var respostaEsperada = true;


            //Act : Agir
            var adcionarLivro = ListaDeLivros.AdcicionarLivro(x, y);



            //Assert : Provar
            Assert.Equal(adcionarLivro, respostaEsperada);


        }
    }
}