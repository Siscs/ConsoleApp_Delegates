namespace NetCoreConsole
{
    public interface ISubject 
    {
        event NotificarSorteio OnOcorreuSorteio;
        void SortearNumero();
    }

}