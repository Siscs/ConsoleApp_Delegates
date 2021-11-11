using System;

namespace NetCoreConsole
{
    public delegate void NotificarSorteio(ISubject subject, int numero);

    public class PadraoObserver
    {
        public PadraoObserver()
        {
            var rodada = new RodadaDeBingo($"Rodada {new Random().Next(1,30)}");

            var jogador1 = new Jogador("J1");
            jogador1.Subscriber(rodada);
            var jogador2 = new Jogador("J2");
            jogador2.Subscriber(rodada);
            var jogador3 = new Jogador("J3");
            jogador3.Subscriber(rodada);
            var jogador4 = new Jogador("J4");
            jogador4.Subscriber(rodada);
            var jogador5 = new Jogador("J5");
            jogador5.Subscriber(rodada);

            rodada.SortearNumero();

            jogador3.UnSubscriber(rodada);

            rodada.SortearNumero();

        }
        
    }

}