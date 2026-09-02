using JornadaMilhasV1.Modelos;

namespace JornadaMilha.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaValida()
        {
            //cenário - arrange
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024,2,1), new DateTime(2024,2,5));
            double preco = 100.00;

            var validacao = true;

            //ação - action
            OfertaViagem oferta = new(rota, periodo, preco);
            
            //validação - assert
            Assert.Equal(validacao, oferta.EhValido);
        }

        [Fact]
        public void TestandoOfertaComRotaNula()
        {
            //cenário - arrange
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 2, 5));
            double preco = 100.00;

            //ação - action
            OfertaViagem oferta = new(rota, periodo, preco);
            var mensagem = "A oferta de viagem não possui rota ou período válidos.";

            //validação - assert
            Assert.Contains(mensagem, oferta.Erros.Sumario);
            Assert.False(oferta.EhValido);
        }
    }
}