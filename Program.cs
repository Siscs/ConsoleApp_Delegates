using System;

namespace NetCoreConsole
{   
    public class Program
    {
        public delegate void MostrarAno(int valor);

        public delegate string DelegatePessoa(string valor);

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" **** TESTES ****");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("1 - DelegadoSimples1..................");
            Console.WriteLine("2 - DelegadoSimples2..................");
            Console.WriteLine("3 - Testar Eventos....................");
            Console.WriteLine("4 - Testar Delegate Action (Carro)....");
            Console.WriteLine("5 - Testar padrão Observer (Bingo)....");
            Console.WriteLine(" ");
            Console.Write("Digite sua opçao: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DelegadoSimples1();
                    break;
                case "2":
                    DelegadoSimples2();
                    break;
                case "3":
                    new Eventos().ExecutarEventos();
                    break;
                case "4":
                    new DelegateCarro().IniciarCarro();
                    break;
                case "5":
                    new PadraoObserver();
                    break;
                default:
                    break;
            }

            Environment.Exit(0);

        }

        private static void DelegadoSimples1()
        {
            Carro carro = new Carro();
            Moto moto = new Moto();

            MostrarAno mostrarAno = new MostrarAno(carro.AnoCarro);

            mostrarAno(2011);

            mostrarAno = new MostrarAno(moto.AnoMoto);

            mostrarAno(2014);
        }

        private static void DelegadoSimples2()
        {
            PessoaFisica pf =new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();

            DelegatePessoa delegatePessoa = new DelegatePessoa(pf.MostrarSimples);

            delegatePessoa.Invoke("Cesar Silva");

            delegatePessoa = new DelegatePessoa(pj.MostrarNomeCompleto);

            delegatePessoa.Invoke("Cesar Silva PJ");

        }

    }

    public class Carro
    {
        public Carro() {}

        public void AnoCarro(int ano)
        {
            Console.WriteLine($"Ano do Carro: {ano}" );
        }
    }

    public class Moto
    {
        public Moto() {}

        public void AnoMoto(int ano)
        {
            Console.WriteLine($"Ano da Moto: {ano}" );
        }
    }


}
