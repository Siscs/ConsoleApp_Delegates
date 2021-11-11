using System;

namespace NetCoreConsole
{
    public class RodadaDeBingo : ISubject
    {
        public event NotificarSorteio OnOcorreuSorteio;
        public string Codigo { get; private set; }
        public RodadaDeBingo(string codigo) => Codigo = codigo; // Constructor

        public void SortearNumero()
        {
            Console.WriteLine("Iniciando sorteio.....");
            var num = new Random().Next(1,60);

            // OnNotify(this);
            OnOcorreuSorteio?.Invoke(this, num);
        }
    }

}