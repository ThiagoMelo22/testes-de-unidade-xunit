using JornadaMilhasV1.Modelos;

namespace JornadaMilha.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaValida()
        {
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024,2,1), new DateTime(2024,2,5));
            double preco = 100.00;

            var validacao = true;

            OfertaViagem oferta = new(rota, periodo, preco);
            
            Assert.Equal(validacao, oferta.EhValido);
        }
    }
}