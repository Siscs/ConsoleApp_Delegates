using System;

namespace NetCoreConsole
{
    public class Jogador : IObserver
    {
        public string Nome { get; private set; }
        public Jogador(string nome) => Nome = nome; // Constructor
        
        public void Subscriber(ISubject rodadaDeBingo)
        {
            if(rodadaDeBingo != null)
                rodadaDeBingo.OnOcorreuSorteio += NotificarJogador;
        }

        public void UnSubscriber(ISubject rodadaDeBingo)
        {
            if(rodadaDeBingo != null)
                rodadaDeBingo.OnOcorreuSorteio -= NotificarJogador;
        }

        public void NotificarJogador(ISubject rodadaDeBingo, int numeroSorteado)
        {
            Console.WriteLine($"Notificando o usuário {this.Nome} que houve sorteio na rodada {( rodadaDeBingo as RodadaDeBingo )?.Codigo }");
            Console.WriteLine($"Numero sorteado: {numeroSorteado}");
        }
    }

}