namespace NetCoreConsole
{
    public interface IObserver
    {
        void Subscriber(ISubject subject);
        void UnSubscriber(ISubject subject);
        void NotificarJogador(ISubject subject, int num);
    }

}